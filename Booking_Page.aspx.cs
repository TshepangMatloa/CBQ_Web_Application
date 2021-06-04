using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBQ
{
    public partial class Booking_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Welcome  {Session["NameAndSurname"].ToString()}";
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Hair_Makeup.aspx");
        }
    }
}