using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace TokopediaMain.Util
{
    public static class PageUtililty
    {
        public static void ErrorMessage(Control control, string errorMessage){
            System.Web.UI.ScriptManager.RegisterClientScriptBlock(control, control.GetType(),"alertMessage", "alert('" + errorMessage + "')", true);
        }
    }
}