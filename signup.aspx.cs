﻿using System;
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
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Internal;

namespace DatabaseFromApplication.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      
        
        SqlCommand sqlcomm;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

     

        protected void SignUp_Click(object sender, EventArgs e)
        {
            
                SqlConnection sqlconn = new SqlConnection(@"Data source =INGSMISHROL5C ; Database=Registration ; Trusted_Connection=True");
                sqlconn.Open();
                var sqlCommand = new SqlCommand("select * from UserDetails where UserName = '" + UserName.Text + "'", sqlconn);

                SqlDataReader count = sqlCommand.ExecuteReader();
               
            if (count.HasRows)

                { Label1.Text = "<b>" + "User already exists !!";
                sqlconn.Close();
                }
                else {
                sqlconn.Close();
                sqlconn.Open();
                DateTime today = DateTime.Today;

                string CreatedDate = today.ToString();
                
                //string Date = Convert.ToDateTime(CreatedDate.Text).ToString("yyyy-MM-dd");
                String sqlquery = "INSERT INTO UserDetails(FirstName,LastName,UserName,Password,Email,UserRole,CreatedDate) values('"+ FirstName.Text + "','" + LastName.Text  + "','" + UserName.Text + "','" + Password.Text + "','" + Email.Text + "','" + UserRole.SelectedValue + "','" + CreatedDate + "')";
                sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.ExecuteNonQuery();
                sqlconn.Close();
                Label1.Text = "<b>" + "User is successfully created " + " !!"; }
                
            
        }

        
    }
    }
