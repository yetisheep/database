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
            string strSQL = "select READER.R_id AS '讀者編號', R_name AS '讀者姓名' ,Birth AS '生日' ,Age AS '年齡', Phone AS '電話' , BORROW.B_id AS '書號', B_date AS '借閱日期', R_date AS '還書日期'  from READER , BORROW WHERE READER.R_id = '" + ridin + "' AND READER.R_id = BORROW.R_id  ";
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
            string recordin1 = TextBox1.Text;
            string recordin2 = TextBox2.Text;
            string recordin3 = tb_record0.Text;
            string recordin4 = tb_record2.Text;
          
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            //當recordin4沒有輸入值的時候 日期自動變為1900-01-01
            //資料類型問題？？
            /*if (recordin4 == "")
            {
                recordin4 = "null";
            }*/

            //建立sql命令
            string strSQL = "INSERT INTO BORROW(B_id,R_id,B_date,R_date) VALUES ('" + recordin1 +"','"+ recordin2 + "','" + recordin3 + "' , '" + recordin4 + "')";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            
        
            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;
            
            da.Fill(ds, "BORROW");
            //da把資料填入ds裡面

      
            //建立sql命令
            strSQL = "select B_id AS '書號' ,R_id AS '讀者編號'	,B_date AS '借閱日期',R_date AS '還書日期'  from BORROW";
            
            myConn = new SqlConnection(strConn);

            myCommand = new SqlCommand(strSQL, myConn);




            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "BORROW");
            //da把資料填入ds裡面

            gv_borrow.DataSource = ds;  //DataGridview之名稱
            gv_borrow.DataBind();

            lb_add.Text = "新增成功！";

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

            da.Fill(ds, "BORROW");
            //da把資料填入ds裡面

            //建立sql命令
            string strSQL = "select B_id AS '書號' ,R_id AS '讀者編號'	,B_date AS '借閱日期',R_date AS '還書日期'  from BORROW";

            myConn = new SqlConnection(strConn);

            myCommand = new SqlCommand(strSQL, myConn);




            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "BORROW");
            //da把資料填入ds裡面

            gv_deleterecord.DataSource = ds;  //DataGridview之名稱
            gv_deleterecord.DataBind();
            //gv_deleterecord
            lb_delete.Text = "刪除成功！";
            myConn.Close();

        }

        protected void gv_borrow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gv_deleterecord_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}