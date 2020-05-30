using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Procesoria.Classes
{
    public class Processo
    {
        public Int32 IDUsuario { get; set; }
        public Int32 IDProcesso { get; set; }
        public string NomeCliente { get; set; }
        public string Telefone { get; set; }
        public DateTime Data { get; set; }
        public Int32 Valor { get; set; }
        public string NomeAdvogado { get; set; }
        public string OAB { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Descricao { get; set; }
        public string Causa { get; set; }


        private static readonly string strConnection = ConfigurationManager.AppSettings["MysqlConnection"];

        public void criarProcesso()
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("INSERT INTO tbprocessos (IDUsuario,NomeCliente,Telefone,DataProcesso,Valor,NomeAdvogado,OAB,Email,Endereco,Estado,Cep,Cidade,Descricao,Causa)"+
                        " VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?); ",objcon);

                    objcmd.Parameters.Clear();
                    objcmd.Parameters.Add("@IDUsuario", MySqlDbType.Int32).Value = IDUsuario;
                    objcmd.Parameters.Add("@NomeCliente", MySqlDbType.VarChar, 80).Value = NomeCliente;
                    objcmd.Parameters.Add("@Telefone", MySqlDbType.VarChar, 14).Value = Telefone;
                    objcmd.Parameters.Add("@Data", MySqlDbType.Date).Value = Data.Date.ToString("yyyy-MM-dd");
                    objcmd.Parameters.Add("@Valor", MySqlDbType.Int32).Value = Valor;
                    objcmd.Parameters.Add("@NomeAdvogado", MySqlDbType.VarChar, 80).Value = NomeAdvogado;
                    objcmd.Parameters.Add("@OAB", MySqlDbType.VarChar, 20).Value = OAB;
                    objcmd.Parameters.Add("@Email", MySqlDbType.VarChar, 100).Value = Email;
                    objcmd.Parameters.Add("@Endereco", MySqlDbType.VarChar, 180).Value = Endereco;
                    objcmd.Parameters.Add("@Estado", MySqlDbType.VarChar,2).Value = Estado;
                    objcmd.Parameters.Add("@CEP", MySqlDbType.VarChar, 9).Value = CEP;
                    objcmd.Parameters.Add("@Cidade", MySqlDbType.VarChar, 60).Value = Cidade;
                    objcmd.Parameters.Add("@Descricao", MySqlDbType.LongText).Value = Descricao;
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
        public static void ExcluirProcesso(Int32 IDP)
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("DELETE FROM tbprocessos WHERE IDProcesso = " + IDP, objcon);

                    objcmd.ExecuteNonQuery();

                    objcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IDUSer">ID Session</param>
        /// <param name="tipo">1 = sem ID(todos)</param>
        /// <returns></returns>
        public static DataTable BindProcessos(Int32 IDUSer, int tipo)
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();
                    MySqlDataAdapter adpprofissional;
                    if (tipo == 1) //sem ID
                    {
                        adpprofissional = new MySqlDataAdapter("SELECT * FROM tbprocessos", objcon);
                    }
                    else
                    {
                        adpprofissional = new MySqlDataAdapter("SELECT * FROM tbprocessos WHERE IDUsuario = " + IDUSer, objcon);

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