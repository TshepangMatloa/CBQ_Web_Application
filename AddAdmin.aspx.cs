using CBQ1;
using CBQ1.CBQ_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CBQ
{
    public partial class AddAdmin : System.Web.UI.Page
    {
        //string str = "Data Source=.;uid=sa;pwd=Xrrce@1997;database=Candy's-Beauty-Queens";
        CBQ1.CBQ_Entities cbq = new CBQ1.CBQ_Entities();
        
        string StrCon = ConfigurationManager.ConnectionStrings["Candy_s_Beauty_QueensConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();

            //Session["Admin"] = "Admin";
            //txtUsertype.Text = $"  {Session["Admin"].ToString()}";

            if (!Page.IsPostBack)
            {
                FillEmpDropdownList();
                txtPassword.Attributes["value"] = txtPassword.Text;
            }
        }
        protected void FillEmpDropdownList()
        {
            Register_loginTableAdapter User = new Register_loginTableAdapter();
            DataTable DTdistr = User.GetDataRegister_Login();

            try
            {
                EmailList.DataSource = DTdistr;
                //EmailList.DataBind();
                EmailList.DataValueField = "User_ID";
                EmailList.DataTextField = "Email".ToString();
                EmailList.DataBind();
                EmailList.Items.Insert(0, "--Select Email--");


            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Error occured : " + ex.Message.ToString() + "');", true);
            }
            finally
            {
                DTdistr.Dispose();
                DTdistr.Clear();

            }
        }
        protected void EmailList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    try
            //    {
            //        int User_ID = Convert.ToInt32(EmailList.SelectedValue);
            //        BindEmpGrid(User_ID);
            //    }
            //    catch (Exception ex)
            //    {
            //        ScriptManager.RegisterStartupScript(this, this.GetType(), "Message", "alert('Error occured : " + ex.Message.ToString() + "');", true);
            //    }

            //}
            //private void BindEmpGrid(Int32 User_ID)
            //{

        }
        protected void Button3_Click(object sender, EventArgs e)
        {

            GetUserByID();

            //Register_loginTableAdapter User = new Register_loginTableAdapter();
            //int checkLogin = int.Parse(User.ScalarQueryEmail(EmailList.SelectedItem.Text).ToString());

            //if (checkLogin == 1)
            //{
            //    DataTable DTdistr = User.GetDataByEmail(EmailList.SelectedItem.Text);



        }





        void GetUserByID()
        {
            Register_loginTableAdapter User = new Register_loginTableAdapter();
            DataTable DTdistr = User.GetDataByEmail(EmailList.SelectedItem.Text);
            foreach (DataRow data in DTdistr.Rows)
            {
                Session["User_ID"] = data["User_ID"].ToString();
                Session["Name"] = data["First_Name"].ToString();
                Session["Surname"] = data["Last_Name"].ToString();
                Session["Pass"] = data["Password"].ToString();
                Session["Email"] = data["Email"].ToString();

            }

            txtUserID.Text = Session["User_ID"].ToString();
            txtName.Text = Session["Name"].ToString();
            txtSurname.Text = Session["Surname"].ToString();
            txtPassword.Text = Session["Pass"].ToString();
            txtEmail.Text = Session["Email"].ToString();


            try
            {

                SqlConnection con = new SqlConnection(StrCon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * From Register_login Where User_ID='" + txtUserID.Text  + "' First_Name ='"  + txtName.Text  + "' " +
                    "Last_Name ='" + txtSurname.Text +  "' Email ='"  + txtEmail.Text  +  "'" , con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text = dr.GetValue(1).ToString();
                        txtSurname.Text = dr.GetValue(2).ToString();
                        txtEmail.Text = dr.GetValue(3).ToString();
                        txtUserID.Text = dr.GetValue(0).ToString();
                        txtPassword.Text = dr.GetValue(5).ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>('" + ex.Message + "'); <script>");

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Admin_tblTableAdapter CheckEmail = new Admin_tblTableAdapter();
            int Avail1 = int.Parse(CheckEmail.ScalarQueryEmail(txtEmail.Text.Trim()).ToString());
            if (Avail1 == 1)
            {
                Response.Write("<script>('Email already exist, enter new Email'); <script>");
                return;
            }

            int UserID = int.Parse(txtUserID.Text);

            Admin_tbl user = new Admin_tbl
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                User_Num = UserID,
                Password = txtPassword.Text,
                Email = txtEmail.Text
            };

            cbq.Admin_tbl.Add(user);
            cbq.SaveChanges();
            GridView1.DataBind();
            Response.Write("<script>('New Admin Registered'); <script>");
            CleartextBoxes(this);


            //int UserID = int.Parse(txtUserID.Text);

            //Admin user = new Admin();
            //user.Name = txtName.Text;
            //user.Surname = txtSurname.Text;
            //user.User_ID = UserID;
            //user.Password = txtPassword.Text;
            //user.User_Type = txtUsertype.Text;
            //user.Email = txtEmail.Text;

            //cbq.Admins.Add(user);
            //GridView1.DataBind();


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

        void InsertIntoAdmin()
        {

            //DataTable DTdistr = User.GetDataByEmail(EmailList.SelectedItem.Text);
            //foreach (DataRow data in DTdistr.Rows)
            //{
            //    Session["User_ID"] = data["User_ID"].ToString();
            //    Session["Name"] = data["First_Name"].ToString();
            //    Session["Surname"] = data["Last_Name"].ToString();
            //    Session["Pass"] = data["Password"].ToString();
            //    Session["Email"] = data["Email"].ToString();

            //}

            //txtUserID.Text = Session["User_ID"].ToString();
            //txtName.Text = Session["Name"].ToString();
            //txtSurname.Text = Session["Surname"].ToString();
            //txtEmail.Text = Session["Email"].ToString();
            //txtPassword.Text = Session["Pass"].ToString();
            //try
            //{
              
            //}
            //catch (Exception ex)
            //{
            //    Response.Write("<script>('" + ex.Message + "'); <script>");

            //}
        }
    }
}

