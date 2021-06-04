<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAdmin.aspx.cs" Inherits="CBQ.AddAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <p>    
        <a href ="Menu.aspx" style="color:red"> <<<:Previous Page</a>
             </p>
        <table class =" table table-responsive">
             <tr>
                <td>
                    Name:
                     <%--<asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>--%>
                    <asp:TextBox ID="txtName" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                </td>
                <td>
                   Surname:
                    <%--<asp:Label ID="lblSurname" runat="server" Text="Label"></asp:Label>--%>
                    <asp:TextBox ID="txtSurname" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                </td>
            </tr>
            
            
            <tr>
                <td>
                    User ID:
                     <asp:Label ID="lblUserID" runat="server" Text=""></asp:Label>
                    <asp:TextBox ID="txtUserID" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                </td>
                <td> 
                    Email:
                    <asp:TextBox ID="txtEmail" runat="server" Class="form-control" readonly="true"></asp:TextBox>
                </td>
            </tr>
            
            <tr>
                <td>
                    Password:
                     <%--<asp:Label ID="lblPassword" runat="server" Text="Label"></asp:Label>--%>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Class="form-control" ></asp:TextBox>
                </td>
                <td> 
                   <asp:DropDownList ID="EmailList" runat="server" class="form-control" OnSelectedIndexChanged="EmailList_SelectedIndexChanged"  >
                        </asp:DropDownList> 
                    </td>
                </tr>
            
           
            
            <tr>
                  <td>     
            <asp:Button ID="Button3" runat="server"  Text="Show"  OnClick="Button3_Click" style="display: inline-block;
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
                <td>     
            <asp:Button ID="Button1" runat="server"  Text="Add User"  OnClick="Button1_Click" style="display: inline-block;
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

        <table class="table table-responsive">
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Candy_s_Beauty_QueensConnectionString %>" SelectCommand="SELECT * FROM [Admin]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" Class="table table-striped table-bordered" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" DataKeyNames="Admin_ID">
                        <Columns>
                            <asp:BoundField DataField="Admin_ID" HeaderText="Admin ID" InsertVisible="False" ReadOnly="True" SortExpression="Admin_ID" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
                            <asp:BoundField DataField="User_Num" HeaderText="User ID" SortExpression="User_Num" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Candy_s_Beauty_QueensConnectionString %>" SelectCommand="SELECT * FROM [Admin_tbl]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
                </td>
                </tr>
                </table>
    </div>
</asp:Content>
