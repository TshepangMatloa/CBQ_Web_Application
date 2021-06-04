<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Book.aspx.cs" Inherits="CBQ.Book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4">
         
        </div>
        
        <div style= "text-align:center; background-color:white" class="col-md-4" <%--style="background-image:url('TshepangVS/FK login BGpic.png'); width:500px"--%>>
            
           <h2 style="color:darkred">Book your appointment here</h2>
            
            <table class ="table table-responsive " >
               <tr>
                   <td>
                       <asp:Button ID="Button3" runat="server"  Text="Book"  OnClick="Button3_Click" style="display: inline-block;
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

        
    </div>
</asp:Content>
