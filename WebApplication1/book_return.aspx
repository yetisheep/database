<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book_return.aspx.cs" Inherits="WebApplication1.book_return" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: 微軟正黑體; font-size: xx-large;">管理借還書</div>
        <p>
            輸入借書證卡號：<asp:TextBox ID="tb_rid" runat="server"></asp:TextBox>
            <asp:Button ID="btn_idsearch" runat="server" OnClick="btn_idsearch_Click" Text="查詢" />
        </p>
        <asp:GridView ID="gv_rid" runat="server" OnSelectedIndexChanged="gv_rid_SelectedIndexChanged">
        </asp:GridView>
        <br />
        新增借還書紀錄：<br />
        <br />
        </div>
        輸入書本編號<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="tb_record_TextChanged"></asp:TextBox> <br /><br />
        輸入讀者編號<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="tb_record_TextChanged"></asp:TextBox> <br /><br />
        輸入借書日期<asp:TextBox ID="tb_record0" runat="server" OnTextChanged="tb_record_TextChanged"></asp:TextBox><br/><br />
        輸入還書日期<asp:TextBox ID="tb_record2" runat="server" OnTextChanged="tb_record_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lb_add" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="gv_borrow" runat="server" OnSelectedIndexChanged="gv_borrow_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <asp:Button ID="btn_record" runat="server" Height="22px" OnClick="btn_record_Click" Text="送出" />
        <br />
        <br />
        刪除借書紀錄：<br />
        <br />
        輸入書本編號<asp:TextBox ID="tb_delete" runat="server"></asp:TextBox><br /><br />
        輸入讀者編號<asp:TextBox ID="tb_delete0" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lb_delete" runat="server"></asp:Label>
        <asp:GridView ID="gv_deleterecord" runat="server" OnSelectedIndexChanged="gv_deleterecord_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <asp:Button ID="btn_delete" runat="server" OnClick="btn_delete_Click" Text="送出" />
        <br />
        <br />
    </form>
</body>
</html>
