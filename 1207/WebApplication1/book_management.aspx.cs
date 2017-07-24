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
    public partial class book_return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_idsearch_Click(object sender, EventArgs e)
        {
            string ridin = tb_rid.Text.ToString();
            //lb.Text = topicin;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string strSQL = "select * from READER , BORROW WHERE READER.R_id = '" + ridin + "' AND READER.R_id = BORROW.R_id  ";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "ACTIVITY");
            //da把資料填入ds裡面
            gv_rid.DataSource = ds;  //DataGridview之名稱
            gv_rid.DataBind();


            myConn.Close();
        }

        protected void gv_rid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void tb_record_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn_record_Click(object sender, EventArgs e)
        {
            string recordin1 = tb_record.Text.ToString();
            string recordin2 = tb_record0.Text.ToString();
            string recordin3 = tb_record1.Text.ToString();
            string recordin4 = tb_record2.Text.ToString();
            //lb.Text = topicin;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            //當recordin4沒有輸入值的時候 日期自動變為1900-01-01
            //資料類型問題？？
            if (recordin4 == "")
            {
                recordin4 = "NULL";
            }

            //建立sql命令
            string strSQL = "INSERT INTO BORROW(B_id,R_id,B_date,R_date) VALUES ('" + recordin1 +"','"+ recordin2 + "','" + recordin3 +"','" + recordin4 + "')";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "ACTIVITY");
            //da把資料填入ds裡面
           
            myConn.Close();
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            //string delete_bid = tb_delete.Text.ToString();
            //string delete_rid = tb_delete0.Text.ToString();
                       
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

          
            //string strSQL = "DELETE FROM BORROW WHERE BORROW.B_id = '" + @delete_bid + "' AND BORROW.R_id = '" + @delete_rid + "'";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            //建立sql命令
            SqlCommand myCommand = new SqlCommand("DELETE FROM BORROW WHERE BORROW.B_id = @delete_bid AND BORROW.R_id = @delete_rid", myConn);
            
            //填入刪除變數
            myCommand.Parameters.AddWithValue("@delete_bid", tb_delete.Text);
            myCommand.Parameters.AddWithValue("@delete_rid", tb_delete0.Text);

            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "ACTIVITY");
            //da把資料填入ds裡面

            myConn.Close();

        }

      
    }
}