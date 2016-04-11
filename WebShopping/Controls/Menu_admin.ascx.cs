using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebShopping.Common;

namespace WebShopping.Controls
{
    public partial class Admin_left : System.Web.UI.UserControl
    {
        public string ver = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ver = Tools.GeVer();
            }
        }
    }
}