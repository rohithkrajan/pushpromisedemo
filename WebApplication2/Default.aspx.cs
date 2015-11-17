using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.PushPromise("/Images/1.png");
            Response.PushPromise("/Images/2.png");
            Response.PushPromise("/Images/3.png");
            Response.PushPromise("/Images/4.png");
            Response.PushPromise("/Images/5.png");
            //Response.PushPromise("/Images/6.png");
            //Response.PushPromise("/Images/7.png");
            //Response.PushPromise("/Images/8.png");
            //Response.PushPromise("/Images/9.png");
            //Response.PushPromise("/Images/10.png");
        }
    }
}