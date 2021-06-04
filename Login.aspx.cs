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

    public partial class Login : System.Web.UI.Page
    {
        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);

        }
        Register_loginTableAdapter CBQAdapt = new Register_loginTableAdapter();
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
                    Session["NameAndSurname"] = data["First_Name"].ToString();
                    Session["User_ID"] = data["User_ID"].ToString();
                    Session["Email"] = data["Email"].ToString();
                    Session["role"] = "user";

                }

                if (Session["Email"].ToString() == txtEmail.Text)
                {
                    Response.Redirect("Booking_Page.aspx");

                }
                else
                {
                    Response.Write("<script>('Invalid credentials'); <script>");
                }
            }


        }
    }
}