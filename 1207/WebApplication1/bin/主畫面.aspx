<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="主畫面.aspx.cs" Inherits="WebApplication1.主畫面" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body id="lb_title" style="font-size: xx-large; font-family: 微軟正黑體;">
    <form id="form1" runat="server" style="background-color: #FFFFFF; font-family: 全真海報體; font-size: x-large">
    <div style="text-align:center">
    
        <asp:Label ID="Label1" runat="server" style="font-size: xx-large" Text="圖書館館藏借書系統"></asp:Label>
    
    </div >
        <hr size="5" align="center" noshade width="90%" color="000000">
        <p style="text-align:center">
            功能總覽</p>
        <div style="text-align:center" >
        <asp:Button ID="btn_activity" runat="server" OnClick="btn_activity_Click" style="font-size: large" Text="查詢活動資料" Width="181px" />
        <br />
        <br />
        <asp:Button ID="btn_book" runat="server" OnClick="btn_book_Click" style="font-size: large" Text="管理藏書資料" Width="183px" />
        <br />
        <br />
        <asp:Button ID="btn_record" runat="server" OnClick="btn_record_Click" style="font-size: large" Text="管理借還書記錄" Width="182px" />
        <br />
        <br />
        <asp:Button ID="btn_delay" runat="server" OnClick="btn_delay_Click" style="font-size: large" Text="逾期管理" Width="181px" />
    </div>
            </form>
</body>
</html>
