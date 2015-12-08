using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnleashedBlog.Views.Shared
{
    public partial class ContactForm : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Page.Controls.Add(Page.LoadControl("/UnleashedBlog/Views/Shared/ContactForm.ascx"));
        }

        public void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}