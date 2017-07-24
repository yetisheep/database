<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delay_management.aspx.cs" Inherits="WebApplication1.delay_management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: 微軟正黑體">
    
        <asp:Label ID="lb_delaymanagement" runat="server" style="font-size: x-large" Text="逾期管理"></asp:Label>
        <br />
    
    </div>
        <asp:GridView ID="gv_delay" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
