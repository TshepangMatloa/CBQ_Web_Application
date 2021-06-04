<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login_Admin.aspx.cs" Inherits="CBQ.Login_Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row" >

    <div class="col-md-4">
         
        </div>
        
        <div class="col-md-4" >
           <h2 style="color:darkred">Login</h2>
            
             <table class =" table table-responsive">
               <tr>
                   <td>
<b style="color:darkred; height:100px; width:100px">Email:</b> 
                   </td>
                   <td>
                       <asp:TextBox ID="txtEmail" CSSClass ="form-control"  runat="server"></asp:TextBox>
                   </td>
               </tr> 

                <tr>
                   <td>
<b style="color:darkred; height:100px; width:100px">Password:</b>
                   </td>
                   <td>
                       <asp:TextBox ID="txtPass" CSSClass ="form-control"  runat="server" TextMode="Password" ></asp:TextBox>
                   </td>
               </tr> 
                 
                 
                     

                       
    
                       
   <%-- <td>

                       <asp:Button ID="Button4" runat="server"  Text="Cancel" style="display: inline-block;
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
        to(red),
        color-stop(0.03, #72c6e4)
    );
    -moz-border-radius: 0.333em;
    -webkit-border-radius: 0.333em;
    width:210px;
    height:45px" OnClick="Button4_Click" /> 

                       
                   </td>--%>
    
    
    </table> 
            <table class =" table table-responsive">
                <tr>
                    <td></td>

                    
              <td>     
            <asp:Button ID="Button3" runat="server"  Text="Login"  OnClick="Button3_Click" style="display: inline-block;
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
        <div class="col-md-4">
            
        </div>
        </div>
    
</asp:Content>
