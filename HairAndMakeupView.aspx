<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HairAndMakeupView.aspx.cs" Inherits="CBQ.HairAndMakeupView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <table class="table table-responsive">
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Candy_s_Beauty_QueensConnectionString %>" SelectCommand="SELECT * FROM [Admin]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" Class="table table-striped table-bordered" AutoGenerateColumns="False" DataSourceID="SqlDataSource4" DataKeyNames="Admin_ID">
                        <Columns>
                            <asp:BoundField DataField="Admin_ID" HeaderText="Admin ID" InsertVisible="False" ReadOnly="True" SortExpression="Admin_ID" />
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                            <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
                            <asp:BoundField DataField="User_Num" HeaderText="User ID" SortExpression="User_Num" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:Candy_s_Beauty_QueensConnectionString %>" SelectCommand="SELECT * FROM [Admin_tbl]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
                </td>
                </tr>
                </table>
    </div>
</asp:Content>
