using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dao dao = new Dao();
            Pessoa p = new Pessoa();
            var rdr = dao.listaUsuario();
            while (rdr.Read())
            {
                Console.WriteLine("id:{0}", rdr["id"]);
                Console.WriteLine("Usuario:{0}", rdr["usuario"]);
                Console.WriteLine("Senha:{0}", rdr["senha"]);
            }
            p.cadastrar();
            dao.insertUsuario(p);
            if (dao.verificarUsuario(p))
            {
                Console.WriteLine("Usuario existe no banco");

            } else
            {
                Console.WriteLine("Usuario ou senha invalida");
            }
            Console.ReadKey();
        }
    }
}
