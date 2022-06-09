using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Pessoa

    {
        private int id;
        private string senha;
        private string usuario;

        public int Id
        {
            get
            {
                return id;
            }

         }

        public string Senha
        {
            get
            {
                return senha;
            }

        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

        }
        public void cadastrar()
        {
            Console.WriteLine("Digite o nome do usuario:");
            this.usuario = Console.ReadLine();
            Console.WriteLine("Digite a senha do usuario");
            this.senha = Console.ReadLine();
        }
    }
}
