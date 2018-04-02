using System;
using System.IO;
using System.Linq;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Collections.Generic;

namespace Banhuitong.Console.Excel {
    using MyLib.UI;

    public enum CellStyleCustom { Text = 0, Integer = 1, IntMoney = 2, DecimalMoney = 3, Date = 4, DateTime = 5, Percent = 6, Bool = 7 }
    /// <summary>
    /// 用于导出Excel表格的工具类。
    /// </summary>
    public static class ExcelHelper {
        static ICellStyle CellStyleText;
        static ICellStyle CellStyleInteger;
        static ICellStyle CellStyleIntMoney;
        static ICellStyle CellStyleDecimalMoney;
        static ICellStyle CellStyleDate;
        static ICellStyle CellStyleDateTime;
        static ICellStyle CellStylePercent;
        static ICellStyle CellStyleBool;


        /// <summary>
        /// 导出为Excel表格。
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="fileName"></param>
        private static void Export(System.Windows.Forms.IWin32Window parent, MyGridViewBinding binding, string fileName) {
            Commons.NotNull(binding, "binding");
            Commons.NotBlank(fileName, "path");

            // 此处固定导出所有的可见列。
            var exportedColumns = binding.Columns.Cast<MyGridColumn>()
                .Where(col => col.Visible)
                .ToList();

            using (var dlg = new ExportExcelDlg(binding, exportedColumns, fileName)) {
                dlg.DoExport += ExportToExcel;
                dlg.ShowDialog(parent);
            }
        }

        /// <summary>
        /// 从Excel表格导入。
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="fileName"></param>
        public static void Import(System.Windows.Forms.IWin32Window parent, MyGridViewBinding binding, string fileName) {
            Commons.NotNull(binding, "binding");
            Commons.NotBlank(fileName, "path");

            // 此处固定导入所有的可见列。
            var importedColumns = binding.Columns.Cast<MyGridColumn>()
                .Where(col => col.Visible)
                .ToList();

            using (var dlg = new ImportExcelDlg(binding, importedColumns, fileName)) {
                dlg.DoImport += ImportFromExcel;
                dlg.ShowDialog(parent);
            }
        }

        /// <summary>
        /// 创建标题栏样式，居中，粗体。
        /// </summary>
        /// <param name="workBook"></param>
        /// <returns></returns>
        public static ICellStyle CreateTitleStyle(HSSFWorkbook workBook) {
            Commons.NotNull(workBook, "workBook");
            var font = workBook.CreateFont();
            font.IsBold = true;
            var cs = workBook.CreateCellStyle();
            cs.WrapText = false;
            cs.IsLocked = true;
            cs.SetFont(font);
            cs.Alignment = HorizontalAlignment.Center;
            cs.VerticalAlignment = VerticalAlignment.Center;
            cs.BorderTop = BorderStyle.Thin;
            cs.BorderBottom = BorderStyle.Thin;
            cs.BorderLeft = BorderStyle.Thin;
            cs.BorderRight = BorderStyle.Thin;
            return cs;
        }

        /// <summary>
        /// 创建数据样式，居中，正常。
        /// </summary>
        /// <param name="workBook"></param>
        /// <returns></returns>
        public static ICellStyle CreateDataStyle(HSSFWorkbook workBook) {
            Commons.NotNull(workBook, "workBook");
            //var font = workBook.CreateFont();
            //font.IsBold = false;
            var cs = workBook.CreateCellStyle();
            cs.WrapText = false;
            cs.IsLocked = false;
            //cs.SetFont(font);
            cs.Alignment = HorizontalAlignment.Center;
            cs.VerticalAlignment = VerticalAlignment.Center;
            cs.BorderTop = BorderStyle.Thin;
            cs.BorderBottom = BorderStyle.Thin;
            cs.BorderLeft = BorderStyle.Thin;
            cs.BorderRight = BorderStyle.Thin;
            return cs;
        }

        /// <summary>
        /// 创建第二种数据样式，靠右，正常。
        /// </summary>
        /// <param name="workBook"></param>
        /// <returns></returns>
        static ICellStyle CreateDataStyle2(HSSFWorkbook workBook) {
            Commons.NotNull(workBook, "workBook");
            var font = workBook.CreateFont();
            font.IsBold = false;
            var cs = workBook.CreateCellStyle();
            cs.WrapText = false;
            cs.IsLocked = false;
            cs.SetFont(font);
            cs.Alignment = HorizontalAlignment.Right;
            cs.VerticalAlignment = VerticalAlignment.Center;
            cs.BorderTop = BorderStyle.Thin;
            cs.BorderBottom = BorderStyle.Thin;
            cs.BorderLeft = BorderStyle.Thin;
            cs.BorderRight = BorderStyle.Thin;
            return cs;
        }

        public static void CreateStyles(HSSFWorkbook workBook) {
            var baseStyle = CreateDataStyle(workBook);

            CellStyleText = workBook.CreateCellStyle();
            CellStyleText.CloneStyleFrom(baseStyle);

            CellStyleInteger = workBook.CreateCellStyle();
            CellStyleInteger.CloneStyleFrom(baseStyle);
            CellStyleInteger.DataFormat = workBook.CreateDataFormat().GetFormat("0");
            CellStyleInteger.Alignment = HorizontalAlignment.Right;

            CellStyleIntMoney = workBook.CreateCellStyle();
            CellStyleIntMoney.CloneStyleFrom(baseStyle);
            CellStyleIntMoney.DataFormat = workBook.CreateDataFormat().GetFormat("#,##0");
            CellStyleIntMoney.Alignment = HorizontalAlignment.Right;

            CellStyleDecimalMoney = workBook.CreateCellStyle();
            CellStyleDecimalMoney.CloneStyleFrom(baseStyle);
            CellStyleDecimalMoney.DataFormat = workBook.CreateDataFormat().GetFormat("#,##0.00");
            CellStyleDecimalMoney.Alignment = HorizontalAlignment.Right;

            CellStyleDate = workBook.CreateCellStyle();
            CellStyleDate.CloneStyleFrom(baseStyle);
            CellStyleDate.DataFormat = workBook.CreateDataFormat().GetFormat("yyyy/MM/dd");

            CellStyleDateTime = workBook.CreateCellStyle();
            CellStyleDateTime.CloneStyleFrom(baseStyle);
            CellStyleDateTime.DataFormat = workBook.CreateDataFormat().GetFormat("yyyy/MM/dd HH:mm:ss");

            CellStylePercent = workBook.CreateCellStyle();
            CellStylePercent.CloneStyleFrom(baseStyle);
            CellStylePercent.DataFormat = workBook.CreateDataFormat().GetFormat("0.00%");
            CellStylePercent.Alignment = HorizontalAlignment.Right;

            CellStyleBool = workBook.CreateCellStyle();
            CellStyleBool.CloneStyleFrom(baseStyle);
        }

        static void ExportToExcel(object sender, ExportExcelEventArgs e) {
            var workBook = new HSSFWorkbook();
            CreateStyles(workBook);
            var sheet = workBook.CreateSheet("exported-data");

            if (e.Cannelled) { return; }

            var titleStyle1 = CreateTitleStyle(workBook);



            // 创建空白行
            sheet.CreateRow(0);

            if (e.Cannelled) { return; }

            // 创建标题行。
            var titleRow = sheet.CreateRow(1);
            for (var i = 0; i < e.Columns.Count; ++i) {
                if (e.Cannelled) { return; }

                var colIndex = i + 1; // Excel表格中的列序号。
                var col = e.Columns[i];

                var cell = titleRow.CreateCell(colIndex);
                cell.SetCellValue(col.Title);
                cell.CellStyle = titleStyle1;
                sheet.SetColumnWidth(colIndex, col.Width * 50 /* 1/5 of character width */);
            }

            var total = e.Binding.DataTable.Count;
            for (int j = 0; j < total; ++j) {
                if (e.Cannelled) { return; }

                var rowIndex = j + 2; // Excel表格中的行序号。
                var dataRow = sheet.CreateRow(rowIndex);
                for (int i = 0; i < e.Columns.Count; ++i) {
                    if (e.Cannelled) { return; }

                    var colIndex = i + 1; // Excel表格中的列序号。
                    var col = e.Columns[i];

                    var cell = dataRow.CreateCell(colIndex);

                    var value = e.Binding.GetCellValue(j, col.DataKey);
                    if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                        continue;
                    switch (col.Type) {
                        case MyGridColumnType.Boolean:
                            SetCellStyle(CellStyleCustom.Bool, cell);
                            cell.SetCellValue(value + "");
                            break;
                        case MyGridColumnType.Date:
                            SetCellStyle(CellStyleCustom.Date, cell);
                            cell.SetCellValue(Convert.ToDateTime(value));
                            break;
                        case MyGridColumnType.DateTime:
                            SetCellStyle(CellStyleCustom.DateTime, cell);
                            cell.SetCellValue(Convert.ToDateTime(value));
                            break;
                        case MyGridColumnType.Money:
                            SetCellStyle(CellStyleCustom.DecimalMoney, cell);
                            cell.SetCellValue(Convert.ToDouble(value));
                            break;
                        case MyGridColumnType.IntMoney:
                            SetCellStyle(CellStyleCustom.IntMoney, cell);
                            cell.SetCellValue(Convert.ToInt64(value));
                            break;
                        case MyGridColumnType.Percent:
                            SetCellStyle(CellStyleCustom.Percent, cell);
                            cell.SetCellValue(Convert.ToDouble(value));
                            break;
                        case MyGridColumnType.Number:
                            SetCellStyle(CellStyleCustom.Integer, cell);
                            cell.SetCellValue(Convert.ToInt64(value));
                            break;
                        default:
                            SetCellStyle(CellStyleCustom.Text, cell);
                            cell.SetCellValue(Convert.ToString(value));
                            break;
                    }
                }

                e.UpdateProgress(j + 1);
            }

            if (e.Cannelled) { return; }

            SaveExcel(workBook, e.FileName, new Action(() => {
                e.UpdateProgress(total, "保存文件...");
            }));

            e.UpdateProgress(total, "已保存");
        } // end of Export.

        static void SaveExcel(HSSFWorkbook workBook, string fileName, Action action) {
            using (var fs = File.OpenWrite(fileName)) {
                if (action != null) {
                    action();
                }
                workBook.Write(fs);
            }
        }

        static void ImportFromExcel(object sender, ImportExcelEventArgs e) {
            throw new NotImplementedException();
        } // end of Import.


        public static void ExportExcel(MyGridViewBinding binding) {
            // 创建保存文件的对话框，获取文件名。
            var dlg = new System.Windows.Forms.SaveFileDialog();
            dlg.Title = Properties.Resources.Excel_SaveFile;
            dlg.Filter = Properties.Resources.Excel_SaveFile_Filter;
            dlg.AddExtension = true;
            dlg.AutoUpgradeEnabled = true;
            dlg.CheckPathExists = true;
            dlg.CreatePrompt = false;
            dlg.DefaultExt = "xls";
            dlg.DereferenceLinks = true;
            dlg.OverwritePrompt = true;
            dlg.SupportMultiDottedExtensions = true;
            if (dlg.ShowDialog(null) == System.Windows.Forms.DialogResult.OK) {
                // 调用Excel导出。
                Export(null, binding, dlg.FileName);
            }
        }

        public static void SetCellStyle(CellStyleCustom style, ICell cell) {
            switch (style) {
                case CellStyleCustom.Integer:
                    cell.CellStyle = CellStyleInteger;
                    cell.SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                    break;
                case CellStyleCustom.IntMoney:
                    cell.CellStyle = CellStyleIntMoney;
                    cell.SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                    break;
                case CellStyleCustom.DecimalMoney:
                    cell.CellStyle = CellStyleDecimalMoney;
                    cell.SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                    break;
                case CellStyleCustom.Date:
                    cell.CellStyle = CellStyleDate;
                    cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                    break;
                case CellStyleCustom.DateTime:
                    cell.CellStyle = CellStyleDateTime;
                    cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                    break;
                case CellStyleCustom.Percent:
                    cell.CellStyle = CellStylePercent;
                    cell.SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                    break;
                case CellStyleCustom.Text:
                    cell.CellStyle = CellStyleText;
                    cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                    break;
                case CellStyleCustom.Bool:
                    cell.CellStyle = CellStyleBool;
                    cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                    break;
            }
        }

    } // end of ExcelHelper.
}
