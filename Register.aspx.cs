using CBQ1;
using CBQ1.CBQ_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBQ
{
    public partial class Register : System.Web.UI.Page
    {
        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);

        }
        CBQ1.CBQ_Entities cbq = new CBQ1.CBQ_Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                txtpassword.Attributes["value"] = txtpassword.Text;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Register_loginTableAdapter CheckEmail = new Register_loginTableAdapter();

            if (txtpassword.Text == "")
            {
                MessageBox("Enter Password");
                return;
            }

            

            if (txtfirstname.Text == "")
            {
                MessageBox("Enter first name");
                return;
            }

            if (txtlastname.Text == "")
            {
                MessageBox("Enter last name");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox("Enter Email");
                return;
            }

            


            int Avail1 = int.Parse(CheckEmail.ScalarQueryEmail(txtEmail.Text.Trim()).ToString());
            if (Avail1 == 1)
            {
                MessageBox("Email already exist, try another email");
                return;
            }


            Register_login LN = new Register_login();

            int phone = int.Parse(txtMobileNum.Text);

            LN.First_Name = txtfirstname.Text;
            LN.Last_Name = txtlastname.Text;
            LN.Password = txtpassword.Text;
            LN.Email = txtEmail.Text;
            LN.Mobile_Number = phone;
            //LN.User_Type = DDUserType.SelectedItem.ToString();
            LN.Date = DateTime.Parse(DateTime.Now.ToString());

            cbq.Register_login.Add(LN);
            cbq.SaveChanges();
            MessageBox("Registered");
            CleartextBoxes(this);
            Response.Redirect("Login.aspx");
        }
        public void CleartextBoxes(Control parent)
        {

            foreach (Control c in parent.Controls)
            {
                if ((c.GetType() == typeof(TextBox)))
                {

                    ((TextBox)(c)).Text = "";
                }

                if (c.HasControls())
                {
                    CleartextBoxes(c);
                }
            }

        }

        
    }
    }
