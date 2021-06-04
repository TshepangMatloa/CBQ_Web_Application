using CBQ1.CBQ_DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



namespace CBQ
{
   
    public partial class WebForm1 : System.Web.UI.Page
    {
        private void MessageBox(string msg)
        {
            Label lbl = new Label();
            lbl.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lbl);

        }
        CBQ1.CBQ_Entities cbq = new CBQ1.CBQ_Entities();
        string StrCon = ConfigurationManager.ConnectionStrings["Candy_s_Beauty_QueensConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Text = $"  {Session["Name"].ToString()}";
            txtSurname.Text = $"  {Session["Surname"].ToString()}";
            txtEmail.Text = $"  {Session["Email"].ToString()}";
            txtUserID.Text = $"  {Session["User_ID"].ToString()}";
            txtPassword.Text = $"  {Session["Pass"].ToString()}";
            Session["Admin"] = "Admin";
            txtUsertype.Text = $"  {Session["Admin"].ToString()}";


            //lblName.Text = $"  {Session["Name"].ToString()}";
            //lblSurname.Text = $"  {Session["Surname"].ToString()}";
            //lblEmail.Text = $"  {Session["Email"].ToString()}";
            //lblUserID.Text = $"  {Session["User_ID"].ToString()}";
            //lblPassword.Text = $"  {Session["Pass"].ToString()}";


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(StrCon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO Admin (Email, Password, Name,Surname,User_Type,User_ID) VALUES (@Email, @Password, @Name, @Surname, @User_ID, @User_Type)"
              );
            cmd.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@User_Type", SqlDbType.NVarChar, 50));
            cmd.Parameters.Add(new SqlParameter("@User_ID", SqlDbType.Int));

            cmd.Parameters["@Name"].Value = txtName.Text;
            cmd.Parameters["@Surname"].Value = txtSurname.Text;
            cmd.Parameters["@Email"].Value = txtEmail.Text;
            cmd.Parameters["@Password"].Value = txtPassword.Text;
            cmd.Parameters["@User_Type"].Value = txtUsertype.Text;
            cmd.Parameters["@User_ID"].Value = txtUserID.Text;

            cmd.ExecuteNonQuery();
            //GridView1.DataBind();
            Response.Write("<script>('New Admin Registered'); <script>");
            con.Close();
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
        void UpdateAdmin (string admin)
        {
            try
            {
                SqlConnection con = new SqlConnection(StrCon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE Admin SET Email, Password, Name, Surname, User_ID, User_Type" + admin + "'WHERE Admin_ID='"
                   + "'" , con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>('New Admin Registered'); <script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>('"+ ex.Message +"'); <script>");

            }
        }
    }
}