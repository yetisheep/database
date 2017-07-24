using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class 主畫面 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btn_delay_Click(object sender, EventArgs e)
        {
            Server.Transfer("delay_management.aspx");
        }

        protected void btn_record_Click(object sender, EventArgs e)
        {
            Server.Transfer("book_return.aspx");
        }

        protected void btn_book_Click(object sender, EventArgs e)
        {
            Server.Transfer("book_management.aspx");
        }

        protected void btn_activity_Click(object sender, EventArgs e)
        {
            Server.Transfer("activity_search.aspx");
        }
    }
}