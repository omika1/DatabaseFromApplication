using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Internal;

namespace DatabaseFromApplication
{   
    public partial class DbCreationForm : System.Web.UI.Page
    {
        SqlCommand sqlcomm;
        SqlDataReader dr;
       
        
        public object DatabaseList1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!this.IsPostBack)
            {

                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                var count = 0;
                sqlconn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT name from sys.databases", sqlconn))
                {
                    DatabaseList.Items.Clear();
                    DatabaseList.DataSource = cmd.ExecuteReader();
                    DatabaseList.DataTextField = "name";
                    DatabaseList.DataValueField = "name";
                    DatabaseList.DataBind();
                }
                string filename = "C:\\Users\\mishro\\source\\repos\\DatabaseFromApplication\\Projects\\Check.sql";
                List<string> line = File.ReadAllLines(filename).ToList();
                line.Remove("USE[" + DatabaseList.Text + "]");

                sqlconn.Close();


            }*/
            string filename = "C:\\Users\\mishro\\source\\repos\\DatabaseFromApplication\\Projects\\Check.sql";
            List<string> line = File.ReadAllLines(filename).ToList();
            line.Remove("USE[" + DatabaseBox1.Text + "]");
        }

       

        public void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                sqlconn.Open();

                String sqlquery = "CREATE Database " + DatabaseBox1.Text;
                //String sqlquery = "CREATE TABLE Table2('"+TextBox1.Text+ "' char(50))";

                sqlcomm = new SqlCommand(sqlquery, sqlconn);

                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();



                Label1.Text = "<b> Database <b>" + DatabaseBox1.Text + "<b> is successfully created!!";
            }
            catch (Exception ex)
            {
                Label1.Text = "<b>" + ex.Message;

            }

        
        
                   
            try
            {
                SqlConnection sqlconn = new SqlConnection(@"Data source =INGSMISHROL5C ; Database='" + DatabaseBox1.Text + "';Trusted_Connection=True");

                sqlconn.Open();
                string filename = "C:\\Users\\mishro\\source\\repos\\DatabaseFromApplication\\Projects\\Check.sql";
                List<string> lines = File.ReadAllLines(filename).ToList();
                
                
                //lines.Add("Test");
                lines.Insert(0, "USE[" + DatabaseBox1.Text + "]");
                //File.WriteAllLines(filename, lines);
                string text = File.ReadAllText(filename);           


                IEnumerable<string> commandStrings = Regex.Split(text, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                Label2.Text = commandStrings.ToString();
                foreach (string commandString in commandStrings)
                {
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(commandString.Trim()))
                        {
                            using (var command = new SqlCommand(commandString, sqlconn))
                            {
                                Label2.Text = commandStrings.ToString();
                                command.ExecuteNonQuery();
                            }
                        }
                        Label2.Text = "<b>" + "[Applications],[Database],[Hosts],[Relationships],[Storage] tables are successfully created in " + DatabaseBox1.Text + " !!";

                    }

                    catch (Exception ex)
                    {
                        Label1.Text = "<b>" + ex.Message;
                    }
                    sqlconn.Close();
                }

                //Label2.Text = "<b>" + TableNameBox.Text + " with " + ColumnName.Text + "<b> is successfully created in " + DatabaseList.Text + " !!";

            }

            catch (Exception ex)
            {
                Label2.Text = "<b>" + ex.Message;
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (CheckBox1.Enabled)
            {
                SqlConnection sqlconn = new SqlConnection(@"Data source =INGSMISHROL5C ; Database=Registration ; Trusted_Connection=True");
                sqlconn.Open();
                //string Date = Convert.ToDateTime(CreatedDate.Text).ToString("yyyy-MM-dd");
                string test = "test";
                String sqlquery = "INSERT INTO UserDetails(FirstName,LastName,UserName,Password,Email,UserRole,CreatedDate) values('" + test + "','" + test + "','" + test + "','" + test + "','" + test + "','" + test + "','" + test + "')";
                sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                Label1.Text = "<b>" + "User is successfully created " + " !!";
            }*/
        }
    }
}