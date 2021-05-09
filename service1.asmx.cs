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
    /// Summary description for service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class service1 : System.Web.Services.WebService
    {
        internal static DataTable Kisiara(string kisiID)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public DataTable KisiAra(string kisiID)
        {
            string query = String.Format("SELECT Adi, Soyadi, dogumtarihi, sehir FROM kisibilgileri WHERE" +
              " kisiID = '{0}'", kisiID);
            return SorguCalistir(query);
        }

        public DataTable SorguCalistir(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=.SQLEXPRESS;Initial Catalog=WebServis;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            DataSet dt = new DataSet();
            da.Fill(dt);
            DataTable datat = new DataTable();
            DataRow dr;

            datat.Columns.Add(new System.Data.DataColumn("Column1", typeof(String)));
            datat.Columns.Add(new System.Data.DataColumn("Column2", typeof(String)));
            datat.Columns.Add(new System.Data.DataColumn("Column3", typeof(String)));
            datat.Columns.Add(new System.Data.DataColumn("Column4", typeof(String)));

            return datat;
        }
    }
}
