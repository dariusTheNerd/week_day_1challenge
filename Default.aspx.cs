using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //highlighting  tge cirrect link on the masterpage
        //find the control and hold the results in the htmlcontrol object
        HtmlControl ctrl = (HtmlControl)Master.FindControl("lihome");

        //as long as the item is located  add the class attribute and assign it (in the scase we assined)

        if (ctrl != null)
        {
            ctrl.Attributes["class"] = "selected-item";
        }
    }
}