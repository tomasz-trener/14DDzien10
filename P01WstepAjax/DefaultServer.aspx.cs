using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01WstepAjax
{
    public partial class DefaultServer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int liczba1 = Convert.ToInt32(Request["liczba1"]);

            int liczba2 = Convert.ToInt32(Request["liczba2"]);

            int wynik = liczba1 + liczba2;

            Response.Write(wynik);

            // Response.Write("ala ma kota");
        }
    }
}