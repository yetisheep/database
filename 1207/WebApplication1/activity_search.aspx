<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="activity_search.aspx.cs" Inherits="WebApplication1.activity_search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="font-family: 微軟正黑體;">
    <div style="font-size: xx-large; font-family: 微軟正黑體;">
    
        查詢活動資料<br />
        <span class="auto-style1">請輸入主題:</span></div>
        <asp:TextBox ID="tb_topic" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_topic" runat="server" OnClick="btn_topic_Click" Text="搜尋" />
        <br />
        <asp:GridView ID="gv_topic" runat="server">
        </asp:GridView>
        <asp:Label ID="lb" runat="server" Text="lb"></asp:Label>
        <br />
        <br />
        時段選擇:&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddl_period" runat="server">
            <asp:ListItem Value="9:30~11:30"></asp:ListItem>
            <asp:ListItem Value="16:30~18:30"></asp:ListItem>
            <asp:ListItem Value="19:30~21:30"></asp:ListItem>
            <asp:ListItem>13:30~15:30</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_period" runat="server" BackColor="#FFFF66" ForeColor="Black" Height="23px" style="margin-top: 11px" Text="搜尋" Width="66px" OnClick="btn_showactivity_Click" />
        <br />
        <asp:GridView ID="gv_period" runat="server">
        </asp:GridView>
        <br />
        <br />
        主辦人查詢:<br />
        <asp:TextBox ID="tb_host" runat="server" Height="16px" Width="141px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_host" runat="server" OnClick="btn_host_Click" Text="搜尋" />
        <br />
        <asp:GridView ID="gv_host" runat="server">
        </asp:GridView>
        <br />
        <br />
        測試顯示:<br />
        <p>
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
