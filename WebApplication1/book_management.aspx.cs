using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

using System.Timers;
namespace WebApplication1
{
    public partial class book_management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_bid_Click(object sender, EventArgs e)
        {
            string bid = tb_bid.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string strSQL = "select * from BOOK,BORROW WHERE BOOK.B_id = '" + bid + "'AND  BORROW.B_id = '" + bid + "'";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "BOOK AUTHORS");
            //da把資料填入ds裡面
            gv_bid.DataSource = ds;  //DataGridview之名稱
            gv_bid.DataBind();


            myConn.Close();
        }


        protected void btn_bname_Click(object sender, EventArgs e)
        {
            string bname = tb_bname.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string strSQL = "select * from BOOK,BORROW WHERE BOOK.B_name LIKE'%" + bname + "%' AND BOOK.B_id = BORROW.B_id";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "BOOK AUTHORS");
            //da把資料填入ds裡面
            gv_bname.DataSource = ds;  //DataGridview之名稱
            gv_bname.DataBind();


            myConn.Close();
        }

        protected void btn_pub_Click(object sender, EventArgs e)
        {
            string pub = tb_pub.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string strSQL = "select * from BOOK,BORROW WHERE BOOK.Publisher LIKE'%" + pub + "%' AND BOOK.B_id = BORROW.B_id";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "BOOK AUTHORS");
            //da把資料填入ds裡面
            gv_pub.DataSource = ds;  //DataGridview之名稱
            gv_pub.DataBind();


            myConn.Close();
        }

        protected void btn_addbook_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();


            //string strSQL = "DELETE FROM BORROW WHERE BORROW.B_id = '" + @delete_bid + "' AND BORROW.R_id = '" + @delete_rid + "'";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            //建立sql命令
            SqlCommand myCommand = new SqlCommand("INSERT INTO BOOK(B_id, B_name, publisher) VALUES(@add_bid,@add_bname,@add_pub)", myConn);

            //填入刪除變數
            myCommand.Parameters.AddWithValue("@add_bid",tb_add_bid.Text);
            myCommand.Parameters.AddWithValue("@add_bname",tb_add_bname.Text);
            myCommand.Parameters.AddWithValue("@add_pub", tb_add_pub.Text);

            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "BORROW");
            //da把資料填入ds裡面

            myConn.Close();
        }

   
        protected void btn_edit_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();


            //string strSQL = "DELETE FROM BORROW WHERE BORROW.B_id = '" + @delete_bid + "' AND BORROW.R_id = '" + @delete_rid + "'";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            //建立sql命令
            SqlCommand myCommand = new SqlCommand("UPDATE BOOK SET BOOK.B_name = @edit_bname , BOOK.Publisher = @edit_pub WHERE BOOK.B_id = @edit_bid ", myConn);

            //填入刪除變數
            myCommand.Parameters.AddWithValue("@edit_bid", tb_edit_bid.Text);
            myCommand.Parameters.AddWithValue("@edit_bname", tb_edit_bname.Text);
            myCommand.Parameters.AddWithValue("@edit_pub", tb_edit_pub.Text);

            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "BOOK");
            //da把資料填入ds裡面

            myConn.Close();
        }

        protected void gv_bid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void tb_bid_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb_bname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void gv_bname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gv_pub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void tb_pub_TextChanged(object sender, EventArgs e)
        {

        }


        protected void tb_add_bid_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb_add_bname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb_add_pub_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb_edit_bid_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb_edit_bname_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb_edit_pub_TextChanged(object sender, EventArgs e)
        {

        }
    }
}