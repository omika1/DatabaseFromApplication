<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="DatabaseFromApplication.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 524px;
        }
        .auto-style2 {
            width: 1035px;
        }
        .auto-style3 {
            width: 397px;
        }
        .auto-style4 {
            width: 200px;
        }
        .auto-style5 {
            width: 397px;
            height: 68px;
        }
        .auto-style6 {
            width: 200px;
            height: 68px;
        }
    </style>
</head>
<body style="background:powderblue;">
    <form id="form1" runat="server">
        <div class ="container">
            <table align="center"
                style="width:700px;"height:744px;background:powderblue;">
                <tr>
                    <td class="auto-style1" colspan="2" align="center">
                        <h1 class="auto-style2"> Welcome to Signup Page</h1>

                    </td>
                 </tr>
                   <tr><td class="auto-style1"></td></tr>
              </table>
            <table align ="center">
            <tr>
                
                 <td class="auto-style3">FirstName : </td>
                 <td class="auto-style3"> <asp:TextBox ID="FirstName" runat="server" ></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FirstName" ErrorMessage="FirstName is empty" ForeColor="Red">*</asp:RequiredFieldValidator>
                 </td>
            </tr> 
            <tr>
                
                 <td class="auto-style3">LastName : </td>
                 <td class="auto-style3"> <asp:TextBox ID="LastName" runat="server" ></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="LastName" ErrorMessage="LastName is empty" ForeColor="Red">*</asp:RequiredFieldValidator>
                 </td>
            </tr>
            <tr>
                
                 <td class="auto-style3">UserName : </td>
                 <td class="auto-style4"> <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="UserName" ErrorMessage="UserName is empty" ForeColor="Red">*</asp:RequiredFieldValidator>
                 </td>
            </tr>          
                
            <tr>
                <td class="auto-style3">Password :</td>
                <td class="auto-style4"> <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Password length must be between 7 to 10 characters" ValidationExpression="^[a-zA-Z0-9'@&#.\s]{7,10}$" ControlToValidate="Password" ForeColor="Red">*</asp:RegularExpressionValidator> 
                </td>
            </tr>

            <tr>
                <td class="auto-style3">Email :</td>
                <td class="auto-style4"><asp:TextBox ID="Email" runat="server" ></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email Format" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email" ForeColor="Red">*</asp:RegularExpressionValidator>

                </td>

            </tr>
             <tr>
                
                 <td class="auto-style3">UserRole : </td>
                 <td class="auto-style4"> 
                      <asp:DropDownList ID="UserRole" runat="server" DataValueField="Admin,User" DataTextField="values" Width="165px">
                         <asp:ListItem Selected="True">User</asp:ListItem>
                         <asp:ListItem Value="Admin"></asp:ListItem>
                     </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="UserRole" ErrorMessage="UserRole is empty" ForeColor="Red">*</asp:RequiredFieldValidator>
                 </td>
            </tr> 
             

            <tr><td class="auto-style3"></td></tr>
            <tr><td class="auto-style3"><asp:Button ID="SignUp" runat="server" Text="SignUp" OnClick="SignUp_Click" /></td><td class="auto-style4"></td></tr>
             <tr><td colspan="3" >
                 <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                 <asp:Label ID="Label1" runat="server" ></asp:Label>
             </td></tr>
          </table>
            </div>
        
    </form>
</body>
</html>
