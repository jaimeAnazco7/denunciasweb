using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace denunciasWeb
{
    public  static class MessageBox
    {

        public static void Show(this Page Page, String Message)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(),
               "MessageBox",
               "<script language='javascript'>alert('" + Message + "');  window.location = 'DefaultCI.aspx';</script>"
            );
        }
    }
}