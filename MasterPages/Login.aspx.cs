using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3.MasterPages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblStatus.Visible = false; // Initially hide the status label.
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = TextBox3.Text; // Retrieve the ID entered by the user.
            string pw = TextBox1.Text; // Retrieve the password entered by the user.

            if (id.Equals("admin") && pw.Equals("admin"))
            {
                //Re-direct to another page
                Response.Redirect("default.aspx");
            }
            else
            {
                lblStatus.Visible = true; // Make the label visible.
                lblStatus.Text = "Login unsuccessful!"; // Display a message on the page to indicate login failure.
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Clear the text inside ID and Password TextBoxes.
            TextBox3.Text = string.Empty;
            TextBox1.Text = string.Empty;
            lblStatus.Visible = false; // Hide the status label.
        }
    }
}