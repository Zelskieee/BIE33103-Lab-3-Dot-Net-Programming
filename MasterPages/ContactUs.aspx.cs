using System;
using System.Web.UI;

namespace Lab3.MasterPages
{
    public partial class ContactUs : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void submitForm_Click(object sender, EventArgs e)
        {
            // Handle form submission and clearing logic here
            // Clear form fields
            name.Text = string.Empty;
            email.Text = string.Empty;
            message.Text = string.Empty;
        }
    }
}
