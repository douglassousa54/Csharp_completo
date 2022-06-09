using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MySql.Data;


namespace ConsoleApplication9
{
    class Dao
    {
        private MySqlConnection conexao;
        private MySqlDataReader rdr;
        private MySqlCommand cmd;

        public Dao()
        {
            conexao = new MySqlConnection("server=localhost;database=phpmysql;uid=root;password");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Algo deu errado");
            }
        }
        public bool verificarUsuario(Pessoa p)
        {

            string sql = "select * from login where usuario='" + p.Usuario + "'and senha='" + p.Senha + "'";
            cmd = new MySqlCommand(sql, conexao);
            rdr = cmd.ExecuteReader();
            rdr.Read();
            return rdr.HasRows;
        }
    }
}

    
