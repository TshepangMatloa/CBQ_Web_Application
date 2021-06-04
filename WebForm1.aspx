<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CBQ.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <table class =" table table-responsive">
            <tr>
                <td>
                    Name:
                </td>
                <td>
                    <%--<asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>--%>
                    <asp:TextBox ID="txtName" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Surname:
                </td>
                <td> 
                    <%--<asp:Label ID="lblSurname" runat="server" Text="Label"></asp:Label>--%>
                    <asp:TextBox ID="txtSurname" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>

                <td>Email:</td>
                
         
                <td> 
                    <%--<asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>--%>
                   <asp:TextBox ID="txtEmail" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                      </td>
                </tr>
            <tr>
                <td>
                    User ID:
                </td>
                <td> 
                    <%--<asp:Label ID="lblUserID" runat="server" Text="Label"></asp:Label>--%>
                    <asp:TextBox ID="txtUserID" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    User type:
                </td>
                <td> 
                    <asp:TextBox ID="txtUsertype" CSSClass ="form-control"  runat="server" readonly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td> 
                    <%--<asp:Label ID="lblPassword" runat="server" Text="Label"></asp:Label>--%>
                    <asp:TextBox ID="txtPassword" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                  <td>     
            <asp:Button ID="Button3" runat="server"  Text="Add"  OnClick="Button3_Click" style="display: inline-block;
    border: 1px solid;
    border-color: #50a3c8 #297cb4 #083f6f;
    background: #0c5fa5 url(../images/old-browsers-bg/button-element-bg.png) repeat-x left top;
    
    background-size: 100% 100%;
    background: -moz-linear-gradient(
        top,
        white,
        #72c6e4 4%,
        #0c5fa5
    );
    background: -webkit-gradient(
        linear,
        left top, left bottom,
        from(white),
        to(green),
        color-stop(0.03, #72c6e4)
    );
    -moz-border-radius: 0.333em;
    -webkit-border-radius: 0.333em;
   width:100%;
    height:40px"/>
    </td>  
                
            </tr>
        </table>
    </div>
</asp:Content>
