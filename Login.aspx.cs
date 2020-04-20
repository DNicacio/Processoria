using Processoria.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Procesoria
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["NomeUsuario"] = null;
            Session["IDUsuario"] = null;

        }

        protected void btnLoginAcessar_Click(object sender, EventArgs e)
        {
            bool resAutencicacao;
            resAutencicacao = Usuario.ValidarLogin(txtLoginUsuario.Value, txtLoginSenha.Value);

            if (resAutencicacao == true)
            {

                Sessao novaSessao = new Sessao();
                novaSessao.CriarSessao(txtLoginUsuario.Value);

                //ABRIR SESSAO
                Session["IDUsuario"] = novaSessao.IDUsuario;
                Session["NomeUsuario"] = novaSessao.NomeUsuario;

                //Response.Redirect("Home.aspx");
                Server.Transfer("Home.aspx");

            }
            else
            {
                txtLoginUsuario.Value = "";
                txtLoginSenha.Value = "";
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "RetornoLogin", "<script type='text/javascript'> alert('Login inválido');</script>");
            }
        }
    }
}