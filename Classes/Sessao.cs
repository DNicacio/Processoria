using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Processoria.Classes
{
    public class Sessao
    {
        public Int32 IDUsuario { get; set; }
        public string NomeUsuario { get; set; }

        private static readonly string strConnection = ConfigurationManager.AppSettings["MysqlConnection"];

        public void CriarSessao(string Usuario)
        {
            try
            {
                using (MySqlConnection objcon = new MySqlConnection(strConnection))
                {
                    objcon.Open();
                    MySqlCommand objcmd = new MySqlCommand("SELECT my_aspnet_users.id, my_aspnet_users.name FROM my_aspnet_users where my_aspnet_users.name = '" + Usuario +"';", objcon);
                    objcmd.CommandType = CommandType.Text;

                    MySqlDataReader drSessao;
                    drSessao = objcmd.ExecuteReader();

                    drSessao.Read();
                    IDUsuario = drSessao.GetInt32(0);
                    NomeUsuario = drSessao.GetString(1);
                    objcon.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}