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
            p.cadastrar();
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
