using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tepeguvenlık
{
    public partial class serviscek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kisiID = TextBox1.Text.ToString();
            service1 servis = new service1();
            DataTable dt = service1.Kisiara(kisiID);

            DataList1.DataSource = dt;
            DataList1.DataBind();
        }
    }
}