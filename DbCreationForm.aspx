﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DbCreationForm.aspx.cs" Inherits="DatabaseFromApplication.DbCreationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    
    
    <meta name="viewport" content="width=device-width" />
    <title>Signup</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Bootstrap Elegant Sign Up Form</title>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Roboto:400,700">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <style>
        body {
            color: #999;
            background: #fafafa;
            font-family: 'Roboto', sans-serif;
        }

        .form-control {
            min-height: 41px;
            box-shadow: none;
            border-color: #e6e6e6;
        }

            .form-control:focus {
                border-color: #00c1c0;
            }

        .form-control, .btn {
            border-radius: 3px;
        }

        .signup-form {
            width: 425px;
            margin: 0 auto;
            padding: 30px 0;
        }

            .signup-form h2 {
                color: #333;
                font-weight: bold;
                margin: 0 0 25px;
            }

            .signup-form form {
                margin-bottom: 15px;
                background: #fff;
                border: 1px solid #f4f4f4;
                box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3);
                padding: 40px 50px;
            }

            .signup-form .form-group {
                margin-bottom: 20px;
            }

            .signup-form label {
                font-weight: normal;
                font-size: 14px;
            }

            .signup-form input[type="checkbox"] {
                position: relative;
                top: 1px;
            }

            .signup-form .btn, .signup-form .btn:active {
                font-size: 16px;
                font-weight: bold;
                background: #00c1c0 !important;
                border: none;
                min-width: 140px;
            }

                .signup-form .btn:hover, .signup-form .btn:focus {
                    background: #00b3b3 !important;
                }

            .signup-form a {
                color: #00c1c0;
                text-decoration: none;
            }

                .signup-form a:hover {
                    text-decoration: underline;
                }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center"
                style="width:700px;"height:744px;">
                <tr>
                    <td class="auto-style1" colspan="2" align="center">
                        <h1 class="auto-style2"> Project Creation Page</h1>

                    </td>
                 </tr>
                   <tr><td class="auto-style1"></td></tr>
                <tr></tr>
              </table>
            <table align="center">
                <tr>
                  <td> Enter the Project name to be created :</td><td> <asp:TextBox ID="DatabaseBox1" runat="server" ></asp:TextBox></td>
                    
                 </tr>
                <tr>
                  <td> Insert Data into Table :</td>
                  <td> <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" ></asp:CheckBox></td>
               
                </tr>
                <tr>  
                    
                    <td align ="center"><asp:Button ID="Button1" runat="server" Text="Create Database" OnClick="Button1_Click"></asp:Button></td>
               
                </tr>
                <tr ><td > <asp:Label ID="Label1" runat="server" ></asp:Label></td></tr> 
                <tr><td><asp:Label ID="Label2" runat="server" ></asp:Label></td></tr>
               
            
            </table>
        </div>
       
    </form>
</body>
</html>
