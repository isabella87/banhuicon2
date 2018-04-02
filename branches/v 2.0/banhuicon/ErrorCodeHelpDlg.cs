using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Banhuitong.Console.Excel {
    public partial class ErrorCodeHelp : Form {
        private static readonly String javaScript;

        static ErrorCodeHelp() {
            javaScript = @"
<script language='JavaScript'>
var scrollToItem=function(item){
var range=window.document.body.createTextRange();
if(range.findText(item)){
    range.select();
  }else{
    alert('查找不到 '+item+' !');
  }
}
</script>
";
        }

        public ErrorCodeHelp() {
            InitializeComponent();
        }

        private void ErrorCodeHelpDlg_Load(object sender, EventArgs e) {
            webBrowser1.DocumentText = string.Format(@"<html>
<head>
{0}
<meta http-equiv=Content-Type content='text/html; charset=gb2312'>
<meta name=Generator content='Microsoft Word 14 (filtered)'>
<style>
<!--
 /* Font Definitions */
 @font-face
	{{font-family:宋体;
	panose-1:2 1 6 0 3 1 1 1 1 1;}}
@font-face
	{{font-family:宋体;
	panose-1:2 1 6 0 3 1 1 1 1 1;}}
@font-face
	{{font-family:Calibri;
	panose-1:2 15 5 2 2 2 4 3 2 4;}}
@font-face
	{{font-family:'\@宋体';
	panose-1:2 1 6 0 3 1 1 1 1 1;}}
@font-face
	{{font-family:微软雅黑;
	panose-1:2 11 5 3 2 2 4 2 2 4;}}
@font-face
	{{font-family:'\@微软雅黑';
	panose-1:2 11 5 3 2 2 4 2 2 4;}}
 /* Style Definitions */
 p.MsoNormal, li.MsoNormal, div.MsoNormal
	{{margin:0cm;
	margin-bottom:.0001pt;
	text-align:justify;
	text-justify:inter-ideograph;
	font-size:10.5pt;
	font-family:'Calibri','sans-serif';}}
p.MsoHeader, li.MsoHeader, div.MsoHeader
	{{mso-style-link:'页眉 Char';
	margin:0cm;
	margin-bottom:.0001pt;
	text-align:center;
	layout-grid-mode:char;
	border:none;
	padding:0cm;
	font-size:9.0pt;
	font-family:'Calibri','sans-serif';}}
p.MsoFooter, li.MsoFooter, div.MsoFooter
	{{mso-style-link:'页脚 Char';
	margin:0cm;
	margin-bottom:.0001pt;
	layout-grid-mode:char;
	font-size:9.0pt;
	font-family:'Calibri','sans-serif';}}
span.Char
	{{mso-style-name:'页眉 Char';
	mso-style-link:页眉;}}
span.Char0
	{{mso-style-name:'页脚 Char';
	mso-style-link:页脚;}}
.MsoChpDefault
	{{font-family:'Calibri','sans-serif';}}
 /* Page Definitions */
 @page WordSection1
	{{size:595.3pt 841.9pt;
	margin:72.0pt 90.0pt 72.0pt 90.0pt;
	layout-grid:15.6pt;}}
div.WordSection1
	{{page:WordSection1;}}
-->
</style>

</head>

<body lang=ZH-CN style='text-justify-trim:punctuation'>

<div class=WordSection1 style='layout-grid:15.6pt'>

<table class=MsoNormalTable border=0 cellspacing=0 cellpadding=0 width=1101
 style='width:826.0pt;margin-left:4.65pt;border-collapse:collapse'>
 <tr style='height:27.0pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;background:
  #E7E6E6;padding:0cm 5.4pt 0cm 5.4pt;height:27.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><b><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>响应码</span></b></p>
  </td>
  <td width=269 style='width:202.0pt;border:solid windowtext 1.0pt;border-left:
  none;background:#E7E6E6;padding:0cm 5.4pt 0cm 5.4pt;height:27.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><b><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>响应描述</span></b></p>
  </td>
  <td width=161 style='width:121.0pt;border:solid windowtext 1.0pt;border-left:
  none;background:#E7E6E6;padding:0cm 5.4pt 0cm 5.4pt;height:27.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><b><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>应用场景</span></b></p>
  </td>
  <td width=583 style='width:437.0pt;border:solid windowtext 1.0pt;border-left:
  none;background:#E7E6E6;padding:0cm 5.4pt 0cm 5.4pt;height:27.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><b><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>处理方式</span></b></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA100146</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>证件号码长度非法</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>请贵司技术排查报文中的证件号码长度是否正确，是否为<span
  lang=EN-US>18</span>位身份证号</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA100914</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>请输入中文姓名</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>请贵司技术排查报文中的姓名是否带有特殊字符</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA101068</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>客户已申领过该理财卡产品</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该用户的身份证已经开通过存管电子账户，可用“按证件号查询电子账号”的接口去进行反查相关信息</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA101142</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>未成年（<span
  lang=EN-US>18</span>岁）控制</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>未满<span lang=EN-US>18</span>岁用户无法开通存管电子账户</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA110150</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>该手机已申领过电子账号</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该用户的手机号已经开通过存管电子账户，可用“按手机号查询电子账号信息”的接口去进行反查相关信息</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=4 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CE999001</span></p>
  </td>
  <td width=269 rowspan=4 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>功能受限，交易失败</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该银行卡不支持开通存管电子账户，让用户换一张银行卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该银行卡不支持绑定存管电子账户，让用户换一张银行卡</span></p>
  </td>
 </tr>
 <tr style='height:60.0pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:60.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:60.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>1.</span><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>超过快捷充值单次不超过<span
  lang=EN-US>10W</span>元的限制，若客户需充值资金较大，请引导客户通过线下充值；<span lang=EN-US><br>
  2.</span>充值次数超限（<span lang=EN-US>10</span>次），若客户需充值资金较大，请引导客户通过线下充值；<span
  lang=EN-US><br>
  3.</span>该银行卡不支持快捷充值，建议用户通过线下充值，或换一张银行卡；</span></p>
  </td>
 </tr>
 <tr style='height:39.95pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=left style='text-align:left'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>1.</span><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>由于客户之前有做过异常操作而进入银行提现黑名单，需要用户提供相关申请材料进行黑名单的解除<span
  lang=EN-US><br>
  2</span>、用户提现的次数达到每日<span lang=EN-US>10</span>次上限，让用户次日再提现，若金额较大的用户请引导通过人行通道提现</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=3 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CI61</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>请联系发卡行</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>输入的卡号无效，请确认后输入，请让用户确认所输入的银行卡号是否正确</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>输入的卡号无效，请确认后输入，请让用户确认所输入的银行卡号是否正确</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>无效卡号</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>请让用户确认所输入的银行卡号是否正确，若正确请让用户提供银行卡正面的照片进行核实</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CI62</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>请联系发卡行</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=2 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该银行卡不支持绑定存管电子账户，让用户换一张银行卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=3 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CI66</span></p>
  </td>
  <td width=269 rowspan=3 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>核验身份信息失败，请联系发卡行</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=3 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户银行卡在发卡行的系统中缺少相关信息，需要用户去发卡行核实是否信息都完整</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=3 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CI77</span></p>
  </td>
  <td width=269 rowspan=3 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行卡未开通认证支付</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需要在银联在线（<span lang=EN-US>www.chinapay.com</span>）上开通认证支付功能，认证路径：个人管理<span
  lang=EN-US>-&gt;</span>实名认证<span lang=EN-US>-&gt;</span>绑定卡信息<span
  lang=EN-US>-&gt;</span>卡绑定</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需要在银联在线（<span lang=EN-US>www.chinapay.com</span>）上开通认证支付功能，认证路径：个人管理<span
  lang=EN-US>-&gt;</span>实名认证<span lang=EN-US>-&gt;</span>绑定卡信息<span
  lang=EN-US>-&gt;</span>卡绑定</span></p>
  </td>
 </tr>
 <tr style='height:60.0pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:60.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:60.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>1.</span><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开通银联在线（<span
  lang=EN-US>www.chinapay.com</span>）上开通认证支付功能，认证路径：个人管理<span lang=EN-US>-&gt;</span>实名认证<span
  lang=EN-US>-&gt;</span>绑定卡信息<span lang=EN-US>-&gt;</span>卡绑定；<span
  lang=EN-US><br>
  2.</span>让用户通过人行通道进行提现，人行通道请保证用户输入的联行号是正确的，联行号查询可参考<span lang=EN-US>&lt;www.lianhanghao.com&gt;</span>；<span
  lang=EN-US><br>
  3.</span>让用户申请线下强制换绑卡；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP0015</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值连续<span
  lang=EN-US>6</span>次都失败</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=2 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>一般来说是因为实名认证失败<span lang=EN-US>6</span>次造成的，让用户隔天再试试，比较稳妥的办法就是让用户去发卡行柜面重置银行卡密码；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP0016</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>身份证格式错误</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>请贵司技术排查报文中的证件号码是否正确；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP9904</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易失败</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=2 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该报错具体为无效的卡号，请确认用户输入的银行卡号是否正确，或该银行卡是否处于非正常状态（挂失，冻结，已销户等）</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=3 style='width:66.0pt;border-top:none;border-left:solid windowtext 1.0pt;
  border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP9915</span></p>
  </td>
  <td width=269 rowspan=3 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>超出最大输入密码次数<span
  lang=EN-US>,</span>请联系发卡行</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=3 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户银行卡密码输错太多次，银行卡被发卡行冻结，需要用户去发卡行柜面进行解冻</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=3 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP9920</span></p>
  </td>
  <td width=269 rowspan=3 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行卡与证件信息不符或银行预留手机号不符</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=3 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>由于实名认证是将用户的信息送到发卡行做校验的，认证的结果也是发卡行校验后返回的，若是开户和绑卡一般来说是因为证件的有效期问题或其他证件信息不符的问题导致的，充值问题则一般为银行预留手机号的问题，如果确认无误的话需要让客户去发卡行柜面核实为什么在银联在线上的实名认证会报信息不符的错误</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=3 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP9999</span></p>
  </td>
  <td width=269 rowspan=3 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>认证失败<span
  lang=EN-US>,</span>请稍后重试</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=3 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该报错为网络超时的原因导致，让用户稍后再试试看</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=3 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CT9903</span></p>
  </td>
  <td width=269 rowspan=3 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易超时</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=3 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该报错为网络超时的原因导致，让用户稍后再试试看</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border:solid windowtext 1.0pt;
  border-top:none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX110003</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>请求参数长度超长</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=2 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>请贵司技术人员确认请求参数中各个字段的内容是否符合接口文档的字段要求</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA101131</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>电子账号已与该卡号绑定</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>绑卡</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>电子账号已与该银行卡绑定，请贵司通过绑定卡关系查询接口去确认绑定卡信息</span></p>
  </td>
 </tr>
 <tr style='height:99.0pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:99.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP012001</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:99.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>查开户方原因</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:99.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:99.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>（<span lang=EN-US>1</span>）请咨询客户是否有签约我行个贷产品，如有签约，请客户自行登录其网上银行选择个人贷款菜单＝》借贷通＝》消费顺序维护，修改为“优先使用存款”或者“只使用存款”<span
  lang=EN-US><br>
  </span>（<span lang=EN-US>2</span>）客户卡未在柜面开通高级版电子银行业务<span lang=EN-US><br>
  </span>（<span lang=EN-US>3</span>）查询账户基本信息出错<span lang=EN-US><br>
  </span>（<span lang=EN-US>4</span>）卡已过期， 此卡应该属于理财卡，理财卡是有有效期的。<span lang=EN-US><br>
  </span>（<span lang=EN-US>5</span>）交易金额超出通道的限额，请引导客户使用线下充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP512051</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>余额不足</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>请客户确认银行卡余额是否足够</span></p>
  </td>
 </tr>
 <tr style='height:33.0pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP612061</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>超出提款限额</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>超出银行卡每日网银的交易限额，例如用户网银每日只能交易<span
  lang=EN-US>1w</span>元，用户充值<span lang=EN-US>1w</span>以上就会报这个错，需要让用户去发卡行提高网银每日交易限额，或引导用户通过线下转账进行充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CPPS20PS</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>户名不符</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>身份验证不通过，应是持卡人身份信息与银行预留不一致，一般是姓名、证件号码等，需要让用户去发卡行柜面核实</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP412041</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>挂失卡</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户银行卡属于挂失状态，需要用户去发卡行柜面核实</span></p>
  </td>
 </tr>
 <tr style='height:33.0pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP452000</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>处理完成或接收成功</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>由于网络波动导致数据传输没有得到及时的响应，需要具体情况具体分析。<span
  lang=EN-US>1.</span>扣款了没到账则属于单边账；<span lang=EN-US>2.</span>扣款并到账了属于正常的交易；<span
  lang=EN-US>3.</span>未扣款则表示该交易未成功；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP942094</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>重复业务</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>一般是因为短时间内重复提交导致，若银行卡扣款了电子账户未到账则需要调账</span></p>
  </td>
 </tr>
 <tr style='height:33.0pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CI78</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>发卡行交易权限控制，咨询您的发卡行</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户绑定的是银行二类卡，提现超过一万会报错，会扣款没到账，掉单处理，以先建议问发卡行是否能换成<span
  lang=EN-US>1</span>类卡，若不行 需要联系江西银行进行换绑卡<span lang=EN-US> </span></span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>G3UPC001</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>联行号问题</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>联行号为空，大额提现报文中未输入联行号，联行号查询可参考<span
  lang=EN-US>&lt;www.lianhanghao.com&gt;</span>；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CI73</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>支付卡已超过有效期</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>可让客户通过人行通道提现，但是建议客户通过线下换绑卡；</span></p>
  </td>
 </tr>
 <tr style='height:49.5pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:49.5pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CI38</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:49.5pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>风险受限</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:49.5pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:49.5pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>目前这种风险受限的情况风险部只接受持卡人主动电话<span
  lang=EN-US>95516</span>咨询。建议让持卡人致电<span lang=EN-US>95516</span>人工服务转风险岗，报上卡号，交易时间，以及<span
  lang=EN-US>2020023</span>报错码，失败原因是风险受限。让他们协助查询确认，如确认无误就会帮持卡人取消风险受限了；</span></p>
  </td>
 </tr>
 <tr style='height:33.0pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA57</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>账户已冻结</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>因为提现卡与绑定卡不一致所造成的，需要平台技术人员发起一起绑定卡关系查询的交易，确认电子账户绑定的银行卡是否与提现的银行卡一致；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>G3UPD001</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>户名账号或者收款行错</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>大额提现输入错误的联行号导致的报错</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900019</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>未能根据<span
  lang=EN-US>accountID</span>获取到手机号</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需提供充值的报文给即信处理</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA75</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>单日密码输错超出限制</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>重置电子账户交易密码即可</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP9910</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>未开通此功能</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>一般来说是因为用户没有开通网银或银联无卡支付功能导致的</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>CA40</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>不支持的功能</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>红包发放</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>一般来说是因为账号填错或合作单位编号填错导致的</span></p>
  </td>
 </tr>
 <tr style='height:33.0pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T515</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>处理完成或接收成功</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:33.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>由于网络波动导致数据传输没有得到及时的响应，需要具体情况具体分析。<span
  lang=EN-US>1.</span>扣款了没到账则属于单边账；<span lang=EN-US>2.</span>扣款并到账了属于正常的交易；<span
  lang=EN-US>3.</span>未扣款则表示该交易未成功；</span></p>
  </td>
 </tr>
 <tr style='height:39.95pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5E00000</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>处理中</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>由于网络波动导致数据传输没有得到及时的响应，需要具体情况具体分析。<span
  lang=EN-US>1.</span>扣款了没到账则属于单边账；<span lang=EN-US>2.</span>扣款并到账了属于正常的交易；<span
  lang=EN-US>3.</span>未扣款则表示该交易未成功；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EB0001</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>未找到匹配支付渠道路由</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该银行暂不支持快捷充值</span></p>
  </td>
 </tr>
 <tr style='height:99.0pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:99.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0003</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:99.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>查开户方原因</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:99.0pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:99.0pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>（<span lang=EN-US>1</span>）请咨询客户是否有签约我行个贷产品，如有签约，请客户自行登录其网上银行选择个人贷款菜单＝》借贷通＝》消费顺序维护，修改为“优先使用存款”或者“只使用存款”<span
  lang=EN-US><br>
  </span>（<span lang=EN-US>2</span>）客户卡未在柜面开通高级版电子银行业务<span lang=EN-US><br>
  </span>（<span lang=EN-US>3</span>）查询账户基本信息出错<span lang=EN-US><br>
  </span>（<span lang=EN-US>4</span>）卡已过期， 此卡应该属于理财卡，理财卡是有有效期的。<span lang=EN-US><br>
  </span>（<span lang=EN-US>5</span>）交易金额超出通道的限额，请引导客户使用线下充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0004</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行卡号无效</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需确认输入的银行卡号是否正确</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0007</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行账户余额不足</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需确认银行卡余额是否足够</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0008</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行卡已挂失</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需联系发卡行确认卡片状态是否正常</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0009</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行账户不存在</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需确认输入的银行卡号是否正确</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0018</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行卡未开通银联在线支付</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需要在银联在线（<span lang=EN-US>www.chinapay.com</span>）上开通认证支付功能，认证路径：个人管理<span
  lang=EN-US>-&gt;</span>实名认证<span lang=EN-US>-&gt;</span>绑定卡信息<span
  lang=EN-US>-&gt;</span>卡绑定</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0019</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行卡已被锁定</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需联系发卡行确认卡片状态是否正常</span></p>
  </td>
 </tr>
 <tr style='height:39.95pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0022</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易失败，风险受限</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>目前这种风险受限的情况风险部只接受持卡人主动电话<span
  lang=EN-US>95516</span>咨询。建议让持卡人致电<span lang=EN-US>95516</span>人工服务转风险岗，报上卡号，交易时间，以及<span
  lang=EN-US>2020023</span>报错码，失败原因是风险受限。让他们协助查询确认，如确认无误就会帮持卡人取消风险受限了；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0031</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>证件类型与卡号不符</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需确定银行卡开户证件是否与充值报文中的证件号一致</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EX0032</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>证件号错误，请核实</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需确定银行卡开户证件是否与充值报文中的证件号一致</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5ER1001</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>该银行卡<span
  lang=EN-US>bin</span>不支持</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该银行卡卡<span lang=EN-US>bin</span>不支持快捷充值，需让用户换张银行卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5ER9999</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行认证系统异常</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该报错为网络超时的原因导致，让用户稍后再试试看</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA110358</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>查到的签约记录为非无密债权转让类型</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>签约</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>自动投标或自动债权签约未成功，重新签约即可</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border-top:none;border-left:solid windowtext 1.0pt;
  border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA100152</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>证件类型不正确</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>密码设置</span></p>
  </td>
  <td width=583 rowspan=2 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需提供报文检查所送证件类型是否正确</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>密码重置</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900064</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>该账户冻结操作未完成或失败</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>解冻</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需联系即信处理</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border-top:none;border-left:solid windowtext 1.0pt;
  border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>510000</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行系统返回异常，大量报错的话需联系即信排查</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易类接口</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>处理超时，交易可能成功也可能失败，需通过接口确认下该笔交易是否成功。</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>查询类接口</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>网络原因，查询超时，稍后再试</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900101</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>账户不存在</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>查询</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需联系即信处理</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CP9916</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易超时<span
  lang=EN-US>,</span>请重试</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>服务器网络不稳定，稍后再试</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA101101</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>签约流水号已存在</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>签约</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>重复签约，可能是用户短时间连续点击两次造成的报错，实际签约已成功</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border-top:none;border-left:solid windowtext 1.0pt;
  border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900014</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易重复<span
  lang=EN-US>,</span>请保证<span lang=EN-US>instCode,txDate,txTime,seqNo</span>唯一</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 rowspan=2 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>1.</span><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>每笔交易需保证<span
  lang=EN-US>instCode,txDate,txTime,seqNo</span>的唯一性，重复会报错。<span lang=EN-US>2.</span>相同的交易请求多次，可以通过日志查看</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900658</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>债权状态不能进行还款交易</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>还款</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该债权还在处理中状态 ，当前无法进行还款</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900148</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>投标信息状态不可进行债权转移</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>债转</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>债权已结清，无法进行债转</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border-top:none;border-left:solid windowtext 1.0pt;
  border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900650</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>前导业务授权码或手机验证码错误</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=2 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>1.</span><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>确保在<span lang=EN-US>1</span>分钟有效期内正确输入验证码。<span
  lang=EN-US>2.</span>获取验证码的手机号需与电子账户绑定手机号相同；<span lang=EN-US>3.</span>批量报错的话需联系即信处理</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900024</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>电子账号已设置过密码</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>密码设置</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>通过密码设置查询确认电子账号是否有成功设置过交易密码或者重置密码</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA100911</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>卡片已注销</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>余额查询</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户已经销户</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900136</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>原记录签约失败</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>投标</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>1.</span><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>签约失败。<span
  lang=EN-US>2.</span>若银行的状态为签约成功，则需要平台手动发起签约查询同步银行数据后再发起投标</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900062</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>转让债权超过现拥有的债权金额</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>债转</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>债权转让金额不足</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>US111119</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>此渠道不支持该行认证</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>不支持该银行卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>CA101135</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>存在本息未返还的第三方理财产品的记录</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>解绑</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>有债权不能解绑银行卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 rowspan=2 style='width:66.0pt;border-top:none;border-left:solid windowtext 1.0pt;
  border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>JX900015</span></p>
  </td>
  <td width=269 rowspan=2 style='width:202.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>FES</span><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>系统验签失败</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 rowspan=2 style='width:437.0pt;border-top:none;border-left:
  none;border-bottom:solid black 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>核实下请求报文内有没有字段送错不合规，如字段内带空格或者不支持的符号</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>US050034</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>渠道暂不支持</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>该银行卡不支持</span></p>
  </td>
 </tr>
 <tr style='height:39.95pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>T5EX0011</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行交易超过限额</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:39.95pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>超出银行卡每日网银的交易限额，例如用户网银每日只能交易<span
  lang=EN-US>1w</span>元，用户充值<span lang=EN-US>1w</span>以上就会报这个错，需要让用户去发卡行提高网银每日交易限额，或引导用户通过线下转账进行充值</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>T5E70006</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>单笔金额超限，拒绝交易</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>单笔交易金额超过通道限额</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>T5EX0065</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>该银行卡<span
  lang=EN-US>24</span>小时内余额不足次数过多</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>余额不足的情况下连续充值两次后，第三次会报改错</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>T5EX0042</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>银行账户扣款失败</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>可让用户过段时间再次发起交易，一般为通道与发卡行间的连接超时导致</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>T5EX0064</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>该卡当日失败次数超过阈值</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>渠道针对单日失败超过一定笔数的卡，后续交易会直接拒绝，失败次数两次后第三次会报改错</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>CE999039</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>验证码状态异常</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>第二次充值仍然使用了第一次充值的验证码，客户需要重新申请验证码。</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>CE999042</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>验证码不正确</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户短信验证码输入错误</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>CA110559</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>请输入长度为<span
  lang=EN-US>40</span>位的标的编号</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>标的登记</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需联系即信确认是否长标标志打开</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>T5EP0002</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易失败</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>客户银行卡非借记卡</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>CT250103</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>流水号信息不存在</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>输入交易密码页面停留超过<span lang=EN-US>15</span>分钟，订单超时。</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>N301R005</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现金额超限</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>提现</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>超级网银通道提现单笔金额不超过<span lang=EN-US>5</span>万。</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>CA110130</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>该第三方平台编号已关联</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>开户</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>USNO</span><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>字段送空即可</span></p>
  </td>
 </tr>
 <tr style='height:38.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:38.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>TBEE2008</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:38.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易正在处理中</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:38.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:38.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>由于网络波动导致数据传输没有得到及时的响应，需要具体情况具体分析。<span
  lang=EN-US>1.</span>扣款了没到账则属于单边账；<span lang=EN-US>2.</span>扣款并到账了属于正常的交易；<span
  lang=EN-US>3.</span>未扣款则表示该交易未成功；</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>TBEE1108</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>您输入的证件号、姓名或手机号有误</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>需用户核对信息是否正确</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>TBEE4020</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>卡内可用余额不足，请换其他卡支付</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户银行卡余额不足</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>TBEE6001</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>卡余额不足</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户银行卡余额不足</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>TBEEEE51</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>卡余额不足，请换卡交易</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>用户银行卡余额不足</span></p>
  </td>
 </tr>
 <tr style='height:20.1pt'>
  <td width=88 style='width:66.0pt;border:solid windowtext 1.0pt;border-top:
  none;padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span lang=EN-US
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif';color:black'>TBEE9997</span></p>
  </td>
  <td width=269 style='width:202.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>交易失败<span
  lang=EN-US>,</span>该卡已交易<span lang=EN-US>5</span>笔超出单日限额</span></p>
  </td>
  <td width=161 style='width:121.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=center style='text-align:center'><span
  style='font-size:10.0pt;font-family:'微软雅黑','sans-serif''>充值</span></p>
  </td>
  <td width=583 style='width:437.0pt;border-top:none;border-left:none;
  border-bottom:solid windowtext 1.0pt;border-right:solid windowtext 1.0pt;
  padding:0cm 5.4pt 0cm 5.4pt;height:20.1pt'>
  <p class=MsoNormal align=left style='text-align:left'><span style='font-size:
  10.0pt;font-family:'微软雅黑','sans-serif''>让用户隔天再试试</span></p>
  </td>
 </tr>
</table>

<p class=MsoNormal><span lang=EN-US>&nbsp;</span></p>

</div>

</body>

</html>
", javaScript);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(tbKey.Text)) {
                Commons.ShowInfoBox(this, "搜索内容不能为空");
                return;
            }
            webBrowser1.Document.InvokeScript("scrollToItem", new string[] { tbKey.Text });

        }

    }

}
