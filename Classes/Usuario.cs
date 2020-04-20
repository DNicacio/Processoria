using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Processoria.Classes
{
    public class Usuario
    {
        public static bool ValidarLogin(string usuario, string dado)
        {
            if (Membership.ValidateUser(usuario, dado) == true)
            {
                return true;
            }
            else return false;
        }
        public static MembershipCreateStatus CriarAcesso(string usuario, string senha, string email)
        {
            try
            {
                MembershipUser novoUsuario = Membership.CreateUser(usuario, senha, email);
                return MembershipCreateStatus.Success;
            }
            catch (MembershipCreateUserException e)
            {
                return e.StatusCode;
            }
        }
    }
}