using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopping.BaseUI
{
    public class BasePage : System.Web.UI.Page
    {

        protected override void OnInit(EventArgs e)
        {
            var loginer = Session["staffer"];
            if (loginer == null)
            {
                Response.Redirect("../StaffPage/Login.aspx");
            }

            base.OnInit(e);
        }
    }
}