using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Procesoria.Classes
{
    public class Clientes
    {
        public Int32 IDUsuario { get; set; }
        public Int32 IDCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }

        private static readonly string strConnection = ConfigurationManager.AppSettings["MysqlConnection"];
        public void criarCliente()
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("INSERT INTO tbclientes(IDUsuario,Nome,Sobrenome,Nascimento,Sexo,Rg,Cpf,Telefone,Email,Endereco,Estado,Cep,Cidade)" +
                        " VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?); ", objcon);

                    objcmd.Parameters.Clear();
                    objcmd.Parameters.Add("@IDUsuario", MySqlDbType.Int32).Value = IDUsuario;
                    objcmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 80).Value = Nome;
                    objcmd.Parameters.Add("@Sobrenome", MySqlDbType.VarChar, 80).Value = Sobrenome;
                    objcmd.Parameters.Add("@Data", MySqlDbType.Date).Value = Nascimento.Date.ToString("yyyy-MM-dd");
                    objcmd.Parameters.Add("@Sexo", MySqlDbType.VarChar, 15).Value = Sexo;
                    objcmd.Parameters.Add("@Rg", MySqlDbType.VarChar, 15).Value = Rg;
                    objcmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 18).Value = Cpf;
                    objcmd.Parameters.Add("@Telefone", MySqlDbType.VarChar, 14).Value = Telefone;
                    objcmd.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = Email;
                    objcmd.Parameters.Add("@Endereco", MySqlDbType.VarChar, 180).Value = Endereco;
                    objcmd.Parameters.Add("@Estado", MySqlDbType.VarChar, 2).Value = Estado;
                    objcmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = CEP;
                    objcmd.Parameters.Add("@Cidade", MySqlDbType.VarChar, 60).Value = Cidade;

                    objcmd.ExecuteNonQuery();

                    objcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataTable BindClientes(Int32 IDUSer, int tipo)
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();
                    MySqlDataAdapter adpprofissional;
                    if (tipo == 1) //sem ID
                    {
                        adpprofissional = new MySqlDataAdapter("SELECT * FROM tbclientes", objcon);
                    }
                    else
                    {
                        adpprofissional = new MySqlDataAdapter("SELECT * FROM tbclientes WHERE IDUsuario = " + IDUSer, objcon);

                    }
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