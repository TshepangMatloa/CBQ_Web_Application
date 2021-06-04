<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CBQ.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


                        
     <div class="row">
         <div class="col-md-4"></div>
        <div class="col-md-4">
            
         
        
            
            
             <table class ="table table-responsive " >

               <tr>
                   <td>
                       <asp:Button ID="btnAppointment" runat="server" Text="View Clients Appointment" width="156px"  OnClick="btnAppointment_Click" style="display: inline-block;
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
        to(blue),
        color-stop(0.03, #72c6e4)
    );
    -moz-border-radius: 0.333em;
    -webkit-border-radius: 0.333em;
    width:210px;
    height:45px"/>
                   </td>
                   <td>
                      
                   </td>
                   </tr>
                 <tr>
                    <td>
                       <asp:Button ID="btnAddUser" runat="server" Text="Add New Admin" Width="156px"  OnClick="btnAddUser_Click" style="display: inline-block;
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
        to(blue),
        color-stop(0.03, #72c6e4)
    );
    -moz-border-radius: 0.333em;
    -webkit-border-radius: 0.333em;
    width:210px;
    height:45px"/>
                   </td>
                    <td>
                       <asp:Button ID="btnViewUsers" runat="server" Text="View Users" Width="156px"  OnClick="btnViewUsers_Click" style="display: inline-block;
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
        to(blue),
        color-stop(0.03, #72c6e4)
    );
    -moz-border-radius: 0.333em;
    -webkit-border-radius: 0.333em;
    width:210px;
    height:45px"/>
                   </td>
                   </tr>

                   </table>
            </div>
         <div class="col-md-4"></div>
         </div>
</asp:Content>
