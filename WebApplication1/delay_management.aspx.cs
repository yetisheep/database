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
            String strSQL = "select BORROW.R_id,R_name,Phone,P_name,P_phone,B_name,BORROW.B_id,B_date,R_date,DATEDIFF(day,B_date,GETDATE()-30) AS DELAY_DATED from BORROW,BOOK ,READER LEFT JOIN PARENT ON PARENT.R_id=READER.R_id WHERE (DATEDIFF(day,B_date,GETDATE()))>30 AND BORROW.B_id=BOOK.B_id AND BORROW.R_id = READER.R_id  AND R_date IS NULL ;";
            //"Data Source=163.14.67.18;Database=3B15;Initial Catalog=3B15;Persist Security Info=True;User ID=3B15;Password=3B15";
            string strConn = "Data Source=163.14.67.18;Database=3B14;Initial Catalog=3B14;Persist Security Info=True;User ID=3B14;Password=3B14;";
            SqlConnection myConn = new SqlConnection(strConn);

            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            myConn.Open();

            //建立SQL命令對象
            da.SelectCommand = myCommand;
            //da.Fill(ds);
            da.Fill(ds, "BORROW");
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

        protected void GridView1_SelectedIndexChanged1(object sender, System.EventArgs e)
        {
        }

       
           

        
    }
}