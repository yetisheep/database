using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
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
    
    public partial class activity_search : System.Web.UI.Page
    {/*
        SqlDataAdapter da = new SqlDataAdapter();       
           //SQL 資料庫的連接與執行命令
            DataSet ds = new DataSet();


        string strConn = "server=163.14.67.18\SQLEXPRESS,1433;database=databaseName;User ID=3B14;Password=3B14;Trusted_Connection=True;";


        //建立連接
        SqlConnection myConn = new SqlConnection(strConn);
           // SqlConnection Conn = new SqlConnection("Data Source=163.14.67.18\SQLEXPRESS,1433;"+             
                      //                             " Initial Catalog=組別之TABLE;                   Persist Security Info=True;                   User ID=帳號;Password=密碼");
            //SqlCommand cmd = new SqlCommand(                    "SELECT * FROM [Reader] ORDER BY r_id DESC",                     Conn);             
            //宣告對SQL執行的語法
            //myConn.Open();
            //da.SelectCommand = cmd;   
            //da把資料填入ds裡面   da.Fill(ds, "Reader");            
            //DataGridview之名稱 GridView1.DataSource = ds;  
            //GridView1.DataBind();
            */
        string topicin;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            String strSQL = "select * from BORROW";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            using (SqlConnection myConn = new SqlConnection(strConn))
            {
                using (SqlCommand myCommand = new SqlCommand(strSQL, myConn))
                {

                    myConn.Open();

                    //建立SQL命令對象
                    da.SelectCommand = myCommand;
                    //da.Fill(ds);
                    da.Fill(ds, "ACTIVITY");             
                    //da把資料填入ds裡面
                    GridView1.DataSource = ds;  //DataGridview之名稱
                    GridView1.DataBind();


                    //得到Data結果集
                    //SqlDataReader myDataReader = myCommand.ExecuteReader();
                    //lb_show.Text=;
                    myConn.Close();
                }
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btn_showactivity_Click(object sender, EventArgs e)
        {
            string period = ddl_period.Text;

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            String strSQL = "select * from ACTIVITY WHERE Period LIKE'%" + period + "%'";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);

            lb.Text = period;
            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;

            da.Fill(ds, "ACTIVITY");
            //da把資料填入ds裡面
            gv_period.DataSource = ds;  //DataGridview之名稱
            gv_period.DataBind();


            myConn.Close();
        }

        protected void btn_topic_Click(object sender, System.EventArgs e)
        {
            topicin = tb_topic.Text.ToString();
            //lb.Text = topicin;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string strSQL = "select * from ACTIVITY WHERE Topic LIKE'%" + topicin + "%'";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);
            
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);
                

                    myConn.Open();

                    //建立SQL命令對象
                    da.SelectCommand = myCommand;
                    
                    da.Fill(ds, "ACTIVITY");
                        //da把資料填入ds裡面
                   gv_topic.DataSource = ds;  //DataGridview之名稱
                   gv_topic.DataBind();
                    
                    
                    myConn.Close();

                
            }
        

        protected void btn_host_Click(object sender, System.EventArgs e)
        {   String host=tb_host.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            String strSQL = "SELECT * from ACTIVITY,READER WHERE READER.R_id=ACTIVITY.R_id AND READER.R_name LIKE'%" + host+"%'; " ;
            //LIKE '%"+topic+"%' 
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            using (SqlConnection myConn = new SqlConnection(strConn))
            {
                using (SqlCommand myCommand = new SqlCommand(strSQL, myConn))
                {

                    myConn.Open();

                    //建立SQL命令對象
                    da.SelectCommand = myCommand;
                    da.Fill(ds, "ACTIVITY");
                        //da把資料填入ds裡面
                        gv_host.DataSource = ds;  //DataGridview之名稱
                        gv_host.DataBind();
                   



                    //得到Data結果集
                    //SqlDataReader myDataReader = myCommand.ExecuteReader();
                    //lb_show.Text=;
                    myConn.Close();

                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

    }
}