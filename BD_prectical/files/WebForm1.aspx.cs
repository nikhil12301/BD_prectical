using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_prectical.files
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View2);
        }

        protected void btnpre_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(View1);
        }
    }
}