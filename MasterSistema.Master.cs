using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Procesoria
{
    public partial class MasterSistema : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["IDUsuario"] != null)
            {
                nomeUsuario.InnerText = Session["NomeUsuario"].ToString();
            }
            else
            {
                Server.Transfer("Login.aspx");
            }

        }

        protected void btnSair_Click(object sender, EventArgs e)
        {
          
        }
    }
}