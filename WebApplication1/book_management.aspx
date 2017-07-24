<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book_management.aspx.cs" Inherits="WebApplication1.book_management" %>

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
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1" style="font-family: 微軟正黑體">
    
        管理藏書記錄<br />
        <asp:Label ID="Label4" runat="server" Font-Size="16pt" Text="* 藏書查詢 *"></asp:Label><br />
        <asp:Label ID="Label1" runat="server" Font-Size="16pt" Text="請輸入書號"></asp:Label>
&nbsp;
        <span class="auto-style2">&nbsp;<asp:TextBox ID="tb_bid" runat="server" OnTextChanged="tb_bid_TextChanged" style="height: 19px"></asp:TextBox>
&nbsp;<asp:Button ID="btn_bid" runat="server" Text="搜尋" OnClick="btn_bid_Click" />
        <asp:GridView ID="gv_bid" runat="server" Font-Size="16pt" OnSelectedIndexChanged="gv_bid_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="16pt" Text="請輸入書名"></asp:Label>
        <asp:TextBox ID="tb_bname" runat="server" OnTextChanged="tb_bname_TextChanged"></asp:TextBox>
&nbsp;
        <asp:Button ID="btn_bname" runat="server" Text="搜尋" OnClick="btn_bname_Click" />
        <asp:GridView ID="gv_bname" runat="server" Font-Size="16pt" OnSelectedIndexChanged="gv_bname_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Size="16pt" Text="請輸入出版社"></asp:Label> 
        <asp:TextBox ID="tb_pub" runat="server" OnTextChanged="tb_pub_TextChanged"></asp:TextBox>
&nbsp;
        <asp:Button ID="btn_pub" runat="server" Text="搜尋" OnClick="btn_pub_Click" />
        <br />
        <asp:GridView ID="gv_pub" runat="server" Font-Size="16pt" OnSelectedIndexChanged="gv_pub_SelectedIndexChanged">
        </asp:GridView>
        <br />
        
        <asp:Label ID="Label5" runat="server" Font-Size="16pt" Text="* 新增藏書 *"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Font-Size="16pt" Text="輸入書號"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_add_bid" runat="server" OnTextChanged="tb_add_bid_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Font-Size="16pt" Text="輸入書名"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_add_bname" runat="server" OnTextChanged="tb_add_bname_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Font-Size="16pt" Text="輸入出版社"></asp:Label>
&nbsp;
&nbsp;
        <asp:TextBox ID="tb_add_pub" runat="server" OnTextChanged="tb_add_pub_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="btn_addbook" runat="server" Text="新增" OnClick="btn_addbook_Click" />
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Font-Size="16pt" Text="* 編輯藏書 *"></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server" Font-Size="16pt" Text="輸入書號"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_edit_bid" runat="server" OnTextChanged="tb_edit_bid_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label11" runat="server" Font-Size="16pt" Text="輸入書名"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_edit_bname" runat="server" OnTextChanged="tb_edit_bname_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label12" runat="server" Font-Size="16pt" Text="輸入出版社"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_edit_pub" runat="server" OnTextChanged="tb_edit_pub_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="btn_edit" runat="server" Text="編輯" OnClick="btn_edit_Click" />
        <br />
        
        </span>
    
    </div>
    </form>
</body>
</html>

