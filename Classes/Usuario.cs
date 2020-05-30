using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Processoria.Classes
{
    public class Usuario
    {
        public Int32 IDUsuario { get; set; }
        public Int32 IDUser { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string OAB { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Causa { get; set; }

        private static readonly string strConnection = ConfigurationManager.AppSettings["MysqlConnection"];

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

        public void Salvardados()
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("INSERT INTO tbdadosusuarios (IDUsuario,Nome,Sobrenome,Nascimento,Sexo,Rg,Cpf,OAB,Email,Endereco,Estado,Cep,Cidade,Causa)" +
                        " VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?); ", objcon);

                    objcmd.Parameters.Clear();
                    objcmd.Parameters.Add("@IDUsuario", MySqlDbType.Int32).Value = IDUsuario;
                    objcmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 80).Value = Nome;
                    objcmd.Parameters.Add("@Sobrenome", MySqlDbType.VarChar, 80).Value = Sobrenome;
                    objcmd.Parameters.Add("@Nascimento", MySqlDbType.Date).Value = DataNascimento.Date.ToString("yyyy-MM-dd");
                    objcmd.Parameters.Add("@Sexo", MySqlDbType.VarChar, 15).Value = Sexo;
                    objcmd.Parameters.Add("@Rg", MySqlDbType.VarChar, 15).Value = Rg;
                    objcmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 18).Value = Cpf;
                    objcmd.Parameters.Add("@OAB", MySqlDbType.VarChar, 20).Value = OAB;
                    objcmd.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = Email;
                    objcmd.Parameters.Add("@Endereco", MySqlDbType.VarChar, 180).Value = Endereco;
                    objcmd.Parameters.Add("@Estado", MySqlDbType.VarChar, 2).Value = Estado;
                    objcmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = Cep;
                    objcmd.Parameters.Add("@Cidade", MySqlDbType.VarChar, 60).Value = Cidade;
                    objcmd.Parameters.Add("@Causa", MySqlDbType.VarChar, 30).Value = Causa;


                    objcmd.ExecuteNonQuery();

                    objcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AtualizarDados()
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("UPDATE tbdadosusuarios SET Nome = ?,Sobrenome = ?,Nascimento = ?,Sexo = ?,Rg = ?,Cpf = ?,OAB = ?,Email = ?," +
                                                            "Endereco = ?,Estado = ?,Cep = ?,Cidade = ?,Causa = ? WHERE IDUsuario =" + IDUsuario, objcon);

                    objcmd.Parameters.Clear();
                    objcmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 80).Value = Nome;
                    objcmd.Parameters.Add("@Sobrenome", MySqlDbType.VarChar, 80).Value = Sobrenome;
                    objcmd.Parameters.Add("@Nascimento", MySqlDbType.Date).Value = DataNascimento.Date.ToString("yyyy-MM-dd");
                    objcmd.Parameters.Add("@Sexo", MySqlDbType.VarChar, 15).Value = Sexo;
                    objcmd.Parameters.Add("@Rg", MySqlDbType.VarChar, 15).Value = Rg;
                    objcmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 18).Value = Cpf;
                    objcmd.Parameters.Add("@OAB", MySqlDbType.VarChar, 20).Value = OAB;
                    objcmd.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = Email;
                    objcmd.Parameters.Add("@Endereco", MySqlDbType.VarChar, 180).Value = Endereco;
                    objcmd.Parameters.Add("@Estado", MySqlDbType.VarChar, 2).Value = Estado;
                    objcmd.Parameters.Add("@Cep", MySqlDbType.VarChar, 9).Value = Cep;
                    objcmd.Parameters.Add("@Cidade", MySqlDbType.VarChar, 60).Value = Cidade;
                    objcmd.Parameters.Add("@Causa", MySqlDbType.VarChar, 30).Value = Causa;


                    objcmd.ExecuteNonQuery();

                    objcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable ConsultarCadastro(Int32 IDUSer)
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();
                    MySqlDataAdapter adpprofissional;

                    adpprofissional = new MySqlDataAdapter("SELECT * FROM tbdadosusuarios WHERE IDUsuario = " + IDUSer, objcon);


                    DataTable dtprofissional = new DataTable();

                    adpprofissional.Fill(dtprofissional);

                    if (dtprofissional.Rows.Count > 0)
                    {
                        return dtprofissional;
                    }
                    else return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}