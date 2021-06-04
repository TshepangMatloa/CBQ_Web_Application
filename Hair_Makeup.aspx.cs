using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using CBQ1;

namespace CBQ
{
    public partial class Hair_Makeup : System.Web.UI.Page
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
            //lblUser.Text = $":)  {Session["NameAndSurname"].ToString()}";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible = true;
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextB1.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void BtnBook_Click(object sender, EventArgs e)
        {
            string Hair = string.Empty;
            string makeup = string.Empty;

            if (RadioButton1.Checked)
            {
                Hair = "Micro Braids(Long)";
            }
            else if (RadioButton2.Checked)
            {
                Hair = "Micro braids(short)";
            }
            else if (RadioButton3.Checked)
            {
                Hair = "Box braids(Long)";
            }
            else if (RadioButton4.Checked)
            {
                Hair = "Box braids(short)";
            }
            else if (RadioButton5.Checked)
            {
                Hair = "Passion Twist(Long)";
            }
            else if (RadioButton6.Checked)
            {
                Hair = "Passion Twist(short)";
            }
            else if (RadioButton7.Checked)
            {
                Hair = "Butterfly Locs(Long)";
            }
            else if (RadioButton8.Checked)
            {
                Hair = "Butterfly Locs(short)";
            }
            else if (RadioButton9.Checked)
            {
                Hair = "Blended Braids(Long)";
            }
            else if (RadioButton10.Checked)
            {
                Hair = "Blended Braids(short)";
            }
            else if (RadioButton11.Checked)
            {
                Hair = "Senegalese Twist(Long)";
            }
            else if (RadioButton12.Checked)
            {
                Hair = "Senegalese Twist(short)";
            }

            if (RadioButton13.Checked)
            {
                makeup = "Bridal package(2 days)";
            }
            else if (RadioButton14.Checked)
            {
                makeup = "Bridal package(With lashes)";
            }
            else if (RadioButton15.Checked)
            {
                makeup = " Bridesmaids";
            }
            else if (RadioButton16.Checked)
            {
                makeup = " Bridesmaids(With lashes)";
            }
            else if (RadioButton17.Checked)
            {
                makeup = "Special occasion";
            }
            else if (RadioButton18.Checked)
            {
                makeup = "Special occasion(With lashes)";
            }
            else if (RadioButton19.Checked)
            {
                makeup = "Natural";
            }
            else if (RadioButton20.Checked)
            {
                makeup = "Natural(With lashes)";
            }
            DateTime date = Convert.ToDateTime(TextB1.Text); date = date.AddDays(0);

            

            Booking book = new Booking();
            
            book.Type_Of_Hairstyle = Hair;
            book.Type_Of_Makeup = makeup;
            book.Date_Of_Appointment = date;
            book.User_ID = int.Parse(Session["User_ID"].ToString());

            cbq.Bookings.Add(book);
            cbq.SaveChanges();
          
            //MessageBox("Thank you for visiting Candy's Beauty Queens");
            CleartextBoxes(this);
            Response.Write("<script>('Thank you for visiting Candy's Beauty Queens'); <script>");

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


        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}