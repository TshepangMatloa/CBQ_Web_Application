<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hair_Makeup.aspx.cs" Inherits="CBQ.Hair_Makeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        
         
        <div  style="background-color:white">

            <b><asp:Label ID="lblUser" runat="server" Text="Label" Style="color:maroon; width:100px"></asp:Label></b>

            <h2 style="color:black">Choose date of appointment: </h2>
                       
                       <asp:TextBox ID="TextB1" runat="server" Width="350px"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="17px"
            ImageUrl="~/Hairstyles/calender.png" onclick="ImageButton1_Click" Width="28px" />
<asp:Calendar ID="Calendar1" runat="server"
            onselectionchanged="Calendar1_SelectionChanged" Visible="False">

        </asp:Calendar>

           <h2 style="color:black">Choose Hairstyle</h2>
            <table class ="table table-responsive " >
               <tr>
                   <td>
                        <asp:Image runat="server" ImageURL="Hairstyles/Micro braids Long.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                       <asp:RadioButton ID="RadioButton1" GroupName="Hair" runat="server" Text="Micro braids(Long): R400"/>
                      
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Micro braids Short.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                       <asp:RadioButton ID="RadioButton2" GroupName="Hair" runat="server" Text="Micro braids(Short): R300"/>
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Box braidd Long.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton3" GroupName="Hair" runat="server" Text="Box braids(Long): R400"/>
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Box braids Short.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton4" GroupName="Hair" runat="server" Text="Box braids(Short): R300"/>
                       </td>
                </tr>

                <tr>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Passion twist long.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton5" GroupName="Hair" runat="server" Text="Passion Twist(Long): R400"/>
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Passion twist short.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton6" GroupName="Hair" runat="server" Text="Passion Twist(Short): R300"/>
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Butterfly locs long.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton7" GroupName="Hair" runat="server" Text="Butterfly Locs(Long): R400"/>
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Butterfly locs short.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton8" GroupName="Hair" runat="server" Text="Butterfly Locs(Short): R300"/>
                       </td>
                </tr>


                <tr>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Blended L.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton9" GroupName="Hair" runat="server" Text="Blended Braids(Long): R400"/>
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Blended S.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton10" GroupName="Hair" runat="server" Text="Blended Braids(Short): R300"/>
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Senegalas L.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton11" GroupName="Hair" runat="server" Text="Senegalese Twist(Long): R400"/>
                       </td>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Senegalas S.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton12" GroupName="Hair" runat="server" Text="Senegalese Twist(Short): R300"/>
                       </td>
                </tr>

                <tr>
                   <td>
                        <asp:CheckBox ID="CheckBox13" runat="server" Text="Hairpiece extension: R60"/>
                       </td>
                   
                   
                </tr>
                </table>
             </div>

            <div style="background-color:white" <%--class="col-md-4"--%>>

            <h2 style="color:black">Choose Makeup</h2>
            <table class ="table table-responsive " >
                <tr>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Bride.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton13" runat="server" GroupName="Makeup" Text="Bridal package(2 days): R400"/><br />
                       <asp:RadioButton ID="RadioButton14" runat="server" GroupName="Makeup" Text="Bridal package (With lashes): R420"/>
                       </td>
                   
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Bridesmaid.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton15" GroupName="Makeup" runat="server" Text="Bridesmaids: R200"/><br />
                       <asp:RadioButton ID="RadioButton16" GroupName="Makeup" runat="server" Text="Bridesmaids (With lashes): R220"/>
                       </td>
                   
                </tr>

            <tr>
                   <td>
                       <asp:Image runat="server" ImageURL="Hairstyles/Special ocassion.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton17" GroupName="Makeup" runat="server" Text="Special occasion: R200"/> <br />
                       <asp:RadioButton ID="RadioButton18" GroupName="Makeup" runat="server" Text="Special occasion (With lashes): R220"/>
                       </td>
                   
                   <td >
                       <asp:Image runat="server" ImageURL="Hairstyles/Natural.jpg" style="width:270px; height:230px"></asp:Image> <br><br />
                        <asp:RadioButton ID="RadioButton19" GroupName="Makeup" runat="server" Text="Natural: R150"/> <br />
                       <asp:RadioButton ID="RadioButton20" GroupName="Makeup" runat="server" Text="Natural (With lashes): R170"/>
                       </td>
                   
                </tr>
                </table>
                
            </div>

        <div > 
            
           
            <table class =" table table-responsive">
                <tr>
                <td>
                       <asp:Button ID="BtnBook" runat="server"  Text="Book" OnClick="BtnBook_Click" style="display: inline-block;
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
    width:210px;
    height:45px"/>
                       </td>
    <td>

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

                       
                   </td>
                </tr>
           </table>
            </div>
        </div>
</asp:Content>
