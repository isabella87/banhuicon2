using System;
using System.IO;
using System.Linq;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Banhuitong.Console.Excel {
    using MyLib.UI;

    /// <summary>
    /// 用于导出Excel表格的工具类。
    /// </summary>
    public static class ExcelHelper {
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
        static ICellStyle CreateTitleStyle(HSSFWorkbook workBook) {
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
        static ICellStyle CreateDataStyle(HSSFWorkbook workBook) {
            Commons.NotNull(workBook, "workBook");
            var font = workBook.CreateFont();
            font.IsBold = false;
            var cs = workBook.CreateCellStyle();
            cs.WrapText = false;
            cs.IsLocked = false;
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

        static void ExportToExcel(object sender, ExportExcelEventArgs e) {
            var workBook = new HSSFWorkbook();
            var sheet = workBook.CreateSheet("exported-data");

            if (e.Cannelled) { return; }

            var titleStyle1 = CreateTitleStyle(workBook);

            var dataStyle = CreateDataStyle(workBook);
            var dataStyle1 = workBook.CreateCellStyle(); // 文本。
            dataStyle1.CloneStyleFrom(dataStyle);

            var dataStyle2 = workBook.CreateCellStyle(); // 整数。
            dataStyle2.CloneStyleFrom(dataStyle);
            dataStyle2.DataFormat = workBook.CreateDataFormat().GetFormat("0");
            dataStyle2.Alignment = HorizontalAlignment.Right;

            var dataStyle3 = workBook.CreateCellStyle(); // 整数金额。
            dataStyle3.CloneStyleFrom(dataStyle);
            dataStyle3.DataFormat = workBook.CreateDataFormat().GetFormat("#,##0");
            dataStyle3.Alignment = HorizontalAlignment.Right;

            var dataStyle4 = workBook.CreateCellStyle(); // 金额。
            dataStyle4.CloneStyleFrom(dataStyle);
            dataStyle4.DataFormat = workBook.CreateDataFormat().GetFormat("#,##0.00");
            dataStyle4.Alignment = HorizontalAlignment.Right;

            var dataStyle5 = workBook.CreateCellStyle(); // 日期。
            dataStyle5.CloneStyleFrom(dataStyle);
            dataStyle5.DataFormat = workBook.CreateDataFormat().GetFormat("yyyy/MM/dd");

            var dataStyle6 = workBook.CreateCellStyle(); // 日期时间。
            dataStyle6.CloneStyleFrom(dataStyle);
            dataStyle6.DataFormat = workBook.CreateDataFormat().GetFormat("yyyy/MM/dd HH:mm:ss");

            var dataStyle7 = workBook.CreateCellStyle(); // 百分比
            dataStyle7.CloneStyleFrom(dataStyle);
            dataStyle7.DataFormat = workBook.CreateDataFormat().GetFormat("0.00%");

            var dataStyle8 = workBook.CreateCellStyle(); // 是否。
            dataStyle8.CloneStyleFrom(dataStyle);

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
                            cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                            cell.SetCellValue(value + "");
                            cell.CellStyle = dataStyle8;
                            break;
                        case MyGridColumnType.Date:
                            cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                            cell.SetCellValue(Convert.ToDateTime(value));
                            cell.CellStyle = dataStyle5;
                            break;
                        case MyGridColumnType.DateTime:
                            cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                            cell.SetCellValue(Convert.ToDateTime(value));
                            cell.CellStyle = dataStyle6;
                            break;
                        case MyGridColumnType.Money:
                            cell.SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                            cell.SetCellValue(Convert.ToDouble(value));
                            cell.CellStyle = dataStyle4;
                            break;
                        case MyGridColumnType.IntMoney:
                            cell.SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                            cell.SetCellValue(Convert.ToInt64(value));
                            cell.CellStyle = dataStyle3;
                            break;
                        case MyGridColumnType.Percent:
                            cell.SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                            cell.SetCellValue(Convert.ToDouble(value));
                            cell.CellStyle = dataStyle7;
                            break;
                        case MyGridColumnType.Number:
                            cell.SetCellType(NPOI.SS.UserModel.CellType.Numeric);
                            cell.SetCellValue(Convert.ToInt64(value));
                            cell.CellStyle = dataStyle2;
                            break;
                        default:
                            cell.SetCellType(NPOI.SS.UserModel.CellType.String);
                            cell.SetCellValue(Convert.ToString(value));
                            cell.CellStyle = dataStyle1;
                            break;
                    }
                }

                e.UpdateProgress(j + 1);
            }

            if (e.Cannelled) { return; }

            using (var fs = File.OpenWrite(e.FileName)) {
                e.UpdateProgress(total, "保存文件...");
                workBook.Write(fs);
            }

            e.UpdateProgress(total, "已保存");
        } // end of Export.

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
    } // end of ExcelHelper.
}
