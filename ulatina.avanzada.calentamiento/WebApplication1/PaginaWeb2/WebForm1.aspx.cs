using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CLDFechadeentrada_SelectionChanged(object sender, EventArgs e)
        {

            LBLBFechaseleccionada.Text = CLDFechadeentrada.SelectedDate.ToShortDateString();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}