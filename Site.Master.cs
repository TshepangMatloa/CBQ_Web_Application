using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBQ
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals("home"))
                {
                    LinkButton1.Visible = true; //Admin login
                    LinkButton2.Visible = true; //About
                    LinkButton3.Visible = true; //Contact
                    LinkButton4.Visible = false; //Logout button
                    Button1.Visible = true; //Login button
                    Button2.Visible = true; //Sign in
                    LnkBtnHome.Visible = true; //Home

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; //Admin login
                    LinkButton2.Visible = true; //About
                    LinkButton3.Visible = true; //Contact
                    LinkButton4.Visible = true; //Logout button
                    Button1.Visible = false; //Login button
                    Button2.Visible = false; //Sign in
                    LnkBtnHome.Visible = false; //Home
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; //Admin login
                    LinkButton2.Visible = false; //About
                    LinkButton3.Visible = false; //Contact
                    LinkButton4.Visible = true; //Logout button
                    Button1.Visible = false; //Login button
                    Button2.Visible = false; //Sign in
                    LnkBtnHome.Visible = false; //Home
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>('" + ex.Message + "'); <script>");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
       
       

        

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Session["NameAndSurname"] = "";
            Session["User_ID"] = "";
            Session["User_Type"] = "";
            Session["role"] = "";

            LinkButton2.Visible = true; //About
            LinkButton3.Visible = true; //Contact
            LinkButton4.Visible = false; //Logout button
            Button1.Visible = true; //Login button
            Button2.Visible = true; //Sign in

            Response.Redirect("Default.aspx");

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Admin.aspx");
        }

        protected void LnkBtnHome_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}