using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBQ
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnAppointment_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewClientsAppointment.aspx");
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAdmin.aspx");
        }

        protected void btnViewUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }
    }
}