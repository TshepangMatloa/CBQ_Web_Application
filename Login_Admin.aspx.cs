using CBQ1.CBQ_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBQ
{
    public partial class Login_Admin : System.Web.UI.Page
    {
        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);

        }
        Admin_tblTableAdapter CBQAdapt = new Admin_tblTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                txtPass.Attributes["value"] = txtPass.Text;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Button click';</script>");
            int checkLogin = int.Parse(CBQAdapt.Login_ScalarQuery(txtEmail.Text, txtPass.Text).ToString());

            if (checkLogin == 1)
            {
                DataTable device = CBQAdapt.GetDataByEmail(txtEmail.Text);

                foreach (DataRow data in device.Rows)
                {
                   
                    Session["NameAndSurname"] = data["Name"].ToString();
                    Session["User_ID"] = data["User_Num"].ToString();
                    Session["Email"] = data["Email"].ToString();
                    Session["role"] = "admin";
                }

                if (Session["Email"].ToString() == txtEmail.Text)
                {
                    Response.Write("<script>('Logging in'); <script>");
                    Response.Redirect("Menu.aspx");

                }
                else
                {
                    Response.Write("<script>('Invalid credentials'); <script>");
                }


            }
            else
            {
                Response.Write("<script>('Invalid credentials'); <script>");
            }
            
        }

    }
}
