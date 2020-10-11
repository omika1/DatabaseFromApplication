<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DbCreationForm.aspx.cs" Inherits="DatabaseFromApplication.DbCreationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 79px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center> 
                <h1>Welcome to Database Creation Page   </h1>
                </hr>
                   Enter the database name to be created : <asp:TextBox ID="DatabaseBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </br>   </br> 
                <asp:Button ID="Button1" runat="server" Text="Create Database" OnClick="Button1_Click"></asp:Button>
                    </br></br>
                    <asp:Label ID="Label1" runat="server" ></asp:Label>
                </hr>
                </br>   </br> 
                </br>   
                <br />
                Select name of Database you want to create table in&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; 
                <asp:DropDownList ID="DatabaseList" runat="server" OnSelectedIndexChanged="DatabaseList_SelectedIndexChanged"></asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </br>   </br>
                Enter the name of table you want to create&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TableNameBox" runat="server"></asp:TextBox>
                </br>   </br>  
                
                Enter the column names&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="ColumnName" runat="server"></asp:TextBox>
                </br>   </br>
                </br>   </br>
              
                <asp:Button ID="Button2" runat="server" Text="Create Table" OnClick="Button2_Click"></asp:Button>
                </br></br>
                <asp:Label ID="Label2" runat="server" ></asp:Label>
            </center>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
