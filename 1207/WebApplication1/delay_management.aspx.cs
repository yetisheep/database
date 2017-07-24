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

namespace WebApplication1
{
    public partial class delay_management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            String strSQL = "select * from BORROW";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;
            //da.Fill(ds);
            da.Fill(ds, "ACTIVITY");
            //da把資料填入ds裡面
            gv_delay.DataSource = ds;  //DataGridview之名稱
            gv_delay.DataBind();


            //得到Data結果集
            //SqlDataReader myDataReader = myCommand.ExecuteReader();
            //lb_show.Text=;
            myConn.Close();
                
        }

        protected void GridView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
          
            
        }

       
           

        
    }
}