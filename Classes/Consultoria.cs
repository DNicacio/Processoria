using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Procesoria.Classes
{
    public class Consultoria
    {
        public Int32 IDUsuario { get; set; }
        public Int32 IDConsultoria { get; set; }
        public string NomeCliente { get; set; }
        public int Valor { get; set; }
        public DateTime DataAtendimento { get; set; }
        public string Descricao { get; set; }
        public string Causa { get; set; }

        private static readonly string strConnection = ConfigurationManager.AppSettings["MysqlConnection"];

        public void criarConsultoria()
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();

                    MySqlCommand objcmd = new MySqlCommand("INSERT INTO tbconsultorias(IDUsuario,NomeCliente,Valor,DataAtendimento,Descricao,Causa) VALUES" + 
                                                           "(?,?,?,?,?,?)",objcon);
                    objcmd.Parameters.Clear();
                    objcmd.Parameters.Add("@IDUsuario", MySqlDbType.Int32).Value = IDUsuario;
                    objcmd.Parameters.Add("@NomeCliente", MySqlDbType.VarChar, 80).Value = NomeCliente;
                    objcmd.Parameters.Add("@Valor", MySqlDbType.Int32).Value = Valor;
                    objcmd.Parameters.Add("@Data", MySqlDbType.Date).Value = DataAtendimento.Date.ToString("yyyy-MM-dd");
                    objcmd.Parameters.Add("@Descricao", MySqlDbType.LongText).Value = Descricao;
                    objcmd.Parameters.Add("@Causa", MySqlDbType.VarChar,30).Value = Causa;

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
        public static DataTable BindConsultorias(Int32 IDUSer, int tipo)
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();
                    MySqlDataAdapter adpprofissional;
                    if (tipo == 1) //sem ID
                    {
                        adpprofissional = new MySqlDataAdapter("SELECT * FROM tbconsultorias", objcon);
                    }
                    else
                    {
                        adpprofissional = new MySqlDataAdapter("SELECT * FROM tbconsultorias WHERE IDUsuario = " + IDUSer, objcon);

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