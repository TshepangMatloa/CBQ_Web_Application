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
    public partial class ViewUser : System.Web.UI.Page
    {
        Register_loginTableAdapter user = new Register_loginTableAdapter();
        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable filetb = user.GetDataRegister_Login();
            GridView1.DataSource = filetb;
            GridView1.DataBind();

            //if (!IsPostBack)
            //{
            //    GridView2.Visible = false;


            //}

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
           
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            int countemail = int.Parse(user.ScalarQueryEmail(txtSearch.Text).ToString());

            if (countemail == 0)
            {
                MessageBox("Not found");
            }
            else
            {
                DataTable UserDV = user.GetDataByEmail(txtSearch.Text);
                GridView1.DataSource = UserDV;
                GridView1.DataBind();
            }

            if (txtSearch.Text == "")
            {
                MessageBox("Required to write something");
            }


            //if (GridView1.Visible == true)
            //{
            //    GridView1.Visible = false;
            //    GridView2.Visible = true;
            //}
            //else
            //{
            //    GridView1.Visible = true;
            //    GridView2.Visible = false;
            //}
        }
    }
}