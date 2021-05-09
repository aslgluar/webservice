using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace tepeguvenlık
{
    /// <summary>
    /// Summary description for servis
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class servis : System.Web.Services.WebService
    {

      

        [WebMethod]
        public DataSet KisiGetir(string kisiID)
        {

            string query = String.Format("SELECT Adi, Soyadi, dogumtarihi, sehir FROM kisibilgileri WHERE" +
                " kisiID = '{0}'",kisiID);
            return SorguCalistir(query);
        }

        public DataSet SorguCalistir(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=.SQLEXPRESS;Initial Catalog=WebServis;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }
    }
}
