using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var name = Request.QueryString["name"];
            var family = Request.QueryString["family"];


            using (StreamWriter sw = new StreamWriter(Server.MapPath("~/UsersData/data.txt"), true))
            {
                sw.WriteLine($"{name},{family}");
            }

            Thread.Sleep(3000);

            result.InnerText = "ثبت کاربر با موفقیت انجام شد";
        }
    }
}