using System;
using System.Data;
using System.Data.SqlClient;
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
            show();
        }

        public void show() {

            Label1.Text = "EXCEPTION ERROR: null";
            try
            {
                System.Data.SqlClient.SqlConnection _SqlConnection = new System.Data.SqlClient.SqlConnection();
                _SqlConnection.ConnectionString = "Server=tcp:emergingserver.database.windows.net,1433;Database=emergingDb;User ID=avneet@emergingserver;Password=Tirlok_0173;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";

                System.Data.SqlClient.SqlCommand _SqlCommand1 = new System.Data.SqlClient.SqlCommand("Select * From customer", _SqlConnection);
                System.Data.SqlClient.SqlDataAdapter _SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
                _SqlDataAdapter.SelectCommand = _SqlCommand1;

                DataTable _DataTable = new DataTable();
                _DataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;


                _SqlDataAdapter.Fill(_DataTable);
                GridView1.DataSource = _DataTable;
                // GridView1.DataSource = _DataTable;
                GridView1.DataBind();
            }
            catch
            {
                Label1.Text = "EXCEPTION ERROR: invalid Id or Id already exsist";
            }




        }
        
        protected void Button1_Update(object sender, EventArgs e)
        {
            try {
                System.Data.SqlClient.SqlConnection _SqlConnection = new System.Data.SqlClient.SqlConnection();
                _SqlConnection.ConnectionString = "Server=tcp:emergingserver.database.windows.net,1433;Database=emergingDb;User ID=avneet@emergingserver;Password=Tirlok_0173;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
                int Id = Convert.ToInt32(TextBox1.Text);
                String student = TextBox2.Text;
                String program = TextBox3.Text;

                System.Data.SqlClient.SqlCommand _SqlCommand1 = new System.Data.SqlClient.SqlCommand("UPDATE customer SET student = @student, program = @program WHERE(Id = @Id)", _SqlConnection);

                System.Data.SqlClient.SqlDataAdapter _SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
                _SqlDataAdapter.SelectCommand = _SqlCommand1;

                DataTable _DataTable = new DataTable();
                _DataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                _SqlCommand1.Parameters.Add(new SqlParameter("Id", Id));
                _SqlCommand1.Parameters.Add(new SqlParameter("student", student));
                _SqlCommand1.Parameters.Add(new SqlParameter("program", program));

                _SqlDataAdapter.Fill(_DataTable);
                GridView1.DataSource = _DataTable;
                GridView1.DataBind();
                show();
            }
            catch
            {
                Label1.Text = "EXCEPTION ERROR: invalid Id or Id already exsist";
            }


        }

        protected void Button1_add(object sender, EventArgs e)
        {
            try {
                System.Data.SqlClient.SqlConnection _SqlConnection = new System.Data.SqlClient.SqlConnection();
                _SqlConnection.ConnectionString = "Server=tcp:emergingserver.database.windows.net,1433;Database=emergingDb;User ID=avneet@emergingserver;Password=Tirlok_0173;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
                int Id = Convert.ToInt32(TextBox1.Text);
                String student = TextBox2.Text;
                String program = TextBox3.Text;

                System.Data.SqlClient.SqlCommand _SqlCommand1 = new System.Data.SqlClient.SqlCommand("INSERT INTO customer (Id,student,program) Values (@Id,@student,@program)", _SqlConnection);

                System.Data.SqlClient.SqlDataAdapter _SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
                _SqlDataAdapter.SelectCommand = _SqlCommand1;

                DataTable _DataTable = new DataTable();
                _DataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                _SqlCommand1.Parameters.Add(new SqlParameter("Id", Id));
                _SqlCommand1.Parameters.Add(new SqlParameter("student", student));
                _SqlCommand1.Parameters.Add(new SqlParameter("program", program));

                _SqlDataAdapter.Fill(_DataTable);
                GridView1.DataSource = _DataTable;
                GridView1.DataBind();
                show();
            }
            catch  {
                Label1.Text = "EXCEPTION ERROR: invalid Id or Id already exsist";
            }

        }

        protected void Button1_delete(object sender, EventArgs e)
        {
            try {

                System.Data.SqlClient.SqlConnection _SqlConnection = new System.Data.SqlClient.SqlConnection();
                _SqlConnection.ConnectionString = "Server=tcp:emergingserver.database.windows.net,1433;Database=emergingDb;User ID=avneet@emergingserver;Password=Tirlok_0173;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
                int Id = Convert.ToInt32(TextBox1.Text);
                String student = TextBox2.Text;
                String program = TextBox3.Text;

                System.Data.SqlClient.SqlCommand _SqlCommand1 = new System.Data.SqlClient.SqlCommand("DELETE FROM customer WHERE Id = @Id", _SqlConnection);

                System.Data.SqlClient.SqlDataAdapter _SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
                _SqlDataAdapter.SelectCommand = _SqlCommand1;

                DataTable _DataTable = new DataTable();
                _DataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                _SqlCommand1.Parameters.Add(new SqlParameter("Id", Id));
                _SqlCommand1.Parameters.Add(new SqlParameter("student", student));
                _SqlCommand1.Parameters.Add(new SqlParameter("program", program));

                _SqlDataAdapter.Fill(_DataTable);
                GridView1.DataSource = _DataTable;
                GridView1.DataBind();


                show();
            }
            catch
            {
                Label1.Text = "EXCEPTION ERROR: invalid Id or Id already exsist";
            }

        }
    }
}