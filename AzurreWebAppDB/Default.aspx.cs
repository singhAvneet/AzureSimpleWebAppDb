using System;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AzurreWebAppDB
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection _SqlConnection = new System.Data.SqlClient.SqlConnection();
            _SqlConnection.ConnectionString = "Server=tcp:emergingserver.database.windows.net,1433;Database=emergingDb;User ID=avneet@emergingserver;Password=Tirlok_0173;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";

            System.Data.SqlClient.SqlCommand _SqlCommand1 = new System.Data.SqlClient.SqlCommand("Select * From customer", _SqlConnection);
            System.Data.SqlClient.SqlDataAdapter _SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            _SqlDataAdapter.SelectCommand = _SqlCommand1;

            DataTable _DataTable = new DataTable();
            _DataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;


            _SqlDataAdapter.Fill(_DataTable);
            GridView1.DataSource= _DataTable;
           // GridView1.DataSource = _DataTable;
            GridView1.DataBind();




            

        }
    }
}