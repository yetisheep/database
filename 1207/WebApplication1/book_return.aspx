<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book_return.aspx.cs" Inherits="WebApplication1.book_management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1" style="font-family: 微軟正黑體">
    
        管理還書記錄<br />
        <br />
        <span class="auto-style2">借書卡號:<br />
        </span>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <span class="auto-style3">讀者基本資料<br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <span style="font-size: 11.0pt; font-family: &quot;新細明體&quot;,serif; mso-ascii-font-family: &quot;Calibri Light&quot;; mso-ascii-theme-font: major-latin; mso-fareast-theme-font: minor-fareast; mso-hansi-font-family: &quot;Calibri Light&quot;; mso-hansi-theme-font: major-latin; mso-bidi-font-family: &quot;Times New Roman&quot;; mso-bidi-theme-font: minor-bidi; mso-ansi-language: EN-US; mso-fareast-language: ZH-TW; mso-bidi-language: AR-SA">讀者借還書記錄</span></span><br />
        <asp:Label ID="Label2" runat="server" style="font-size: medium" Text="Label"></asp:Label>
    
    </div>
        <asp:Button ID="btn_add" runat="server" Text="新增" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_delete" runat="server" Text="刪除" />
    </form>
</body>
</html>
