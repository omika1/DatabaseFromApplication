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


namespace DatabaseFromApplication
{   
    public partial class DbCreationForm : System.Web.UI.Page
    {
        SqlCommand sqlcomm;
        SqlDataReader dr;
       
        
        public object DatabaseList1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
           
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            var count = 0;
            sqlconn.Open();
           
            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT name from sys.databases", sqlconn))
            {
                using (dr = cmd.ExecuteReader())
                {
                    //DatabaseList.Items.Remove(dr.ToString());
                    while (dr.Read())
                    {
                        DatabaseList.Items.Insert(0,dr[0].ToString());
                        //DatabaseList.AppendDataBoundItems(dr[0].ToString());
                        //DatabaseList.Items.Add(dr[0].ToString());
                        Console.WriteLine(dr[0].ToString());

                    }
                    count++;
                }
            }
            string filename = "C:\\Users\\mishro\\source\\repos\\DatabaseFromApplication\\Projects\\Check.sql";
            List<string> line = File.ReadAllLines(filename).ToList();
            foreach (string lin in line)
            {
                if (lin.Contains("USE"))
                {
                    var val=lin.IndexOf("USE");
                    lin.Remove(val, 6);
                }
            }
            
            //line.RemoveAt(0);            
            File.WriteAllLines(filename, line);
            sqlconn.Close();
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

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

        }

        public void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(@"Data source =INGSMISHROL5C ; Database='" + DatabaseList.Text + "';Trusted_Connection=True");

                sqlconn.Open();
                string filename = "C:\\Users\\mishro\\source\\repos\\DatabaseFromApplication\\Projects\\Check.sql";
                List<string> lines = File.ReadAllLines(filename).ToList();
                
                //lines.Add("Test");
                lines.Insert(0, "USE[" + DatabaseList.Text + "]");
                File.WriteAllLines(filename, lines);
                string text = File.ReadAllText(filename);
                //Label1 = lines;
                //private const string seperator = "[PRIMARY]";
                //foreach (string line in lines) 
                //  { string[] commandStrings = line.Split(seperator); } 

                

                // split script on GO command

                IEnumerable<string> commandStrings = Regex.Split(text, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                Label2.Text = commandStrings.ToString();
                //@"^\s*GO\s*$"
                //@"\bG\S*O\b"
                foreach (string commandString in commandStrings)
                {
                    if (!string.IsNullOrWhiteSpace(commandString.Trim()))
                    {
                        using (var command = new SqlCommand(commandString, sqlconn))
                        {
                            Label2.Text = commandStrings.ToString();
                            command.ExecuteNonQuery();
                        }
                    }
                }
                sqlconn.Close();

                
                //Label1 = text;
                //Console.WriteLine(writer);
                //String sqlquery = "CREATE TABLE" + " " + TableNameBox.Text + "(" + ColumnName.Text + " " + "char(50))";
                //String sqlquery = "CREATE TABLE" + " " + TableNameBox.Text + "(" + ColumnName.Text + ")";
                //String sqlquery = text;

                //SqlCommand sqlcomm2 = new SqlCommand(sqlquery, sqlconn);

                //sqlcomm2.ExecuteNonQuery();
                //sqlconn.Close();
                //List<string> line = File.ReadAllLines(filename).ToList();
                lines.Insert(0," ");
                File.WriteAllLines(filename, lines);

                Label2.Text = "<b>" + TableNameBox.Text + " with " + ColumnName.Text + "<b> is successfully created in " + DatabaseList.Text + " !!";

            }

            catch (Exception ex)
            {
                Label2.Text = "<b>" + ex.Message;
            }
        }

        protected void DatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

    }
}