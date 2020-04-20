using Processoria.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Procesoria
{
    public partial class Registrar : System.Web.UI.Page
    {
        string msgRetornoCadastro = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (msgRetornoCadastro == "Usuário cadastado!")
            {
                Server.Transfer("Login.aspx");
            }
        }
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            MembershipCreateStatus createStatus;
            
            createStatus = Usuario.CriarAcesso(txtCadastrarUsuario.Value, txtCadastrarSenhaConfirmada.Value, txtCadastrarEmailConfirmado.Value);
            switch (createStatus)
            {
                case MembershipCreateStatus.Success:
                    msgRetornoCadastro = "Usuário cadastado!";
                    esvaziaFormulario();
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    msgRetornoCadastro = "Usuário já Cadastado, tente outro nome";
                    esvaziaFormulario();
                    break;
                case MembershipCreateStatus.InvalidPassword:
                    msgRetornoCadastro = "Senha inválida, tente outra senha";
                    esvaziaFormulario();
                    break;
                case MembershipCreateStatus.InvalidUserName:
                    msgRetornoCadastro = "Usuário inválido";
                    esvaziaFormulario();
                    break;
                default:
                    //lblResultado.Text = "Tente novamente";
                    msgRetornoCadastro = "Tente novamente";
                    break;
            }
            //Page.ClientScript.RegisterStartupScript(Page.GetType(), "RetornoLogin", "<script type='text/javascript'>bootbox.alert({'" + msgRetornoCadastro + "'});</script >");
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "RetornoLogin", "<script type='text/javascript'>alert('" + msgRetornoCadastro + "');</script >");

            if(msgRetornoCadastro == "Usuário cadastado!")
            {
                Server.Transfer("Login.aspx");
            }
        }
        void esvaziaFormulario()
        {
            txtCadastrarUsuario.Value = "";
            txtCadastrarEmailConfirmado.Value = "";
            txtCadastrarSenha.Value = "";
            txtCadastrarSenhaConfirmada.Value = "";
        }
    }
}