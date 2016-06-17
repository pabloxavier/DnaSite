using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DNAMais.Domain;
using DNAMais.Domain.Services;

namespace DNAMais_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            BackOfficeUserService teste = new BackOfficeUserService();

            Console.Write("Teste: " + teste.GetById(1));
            Console.ReadKey();

            //BackOfficeUser user = new BackOfficeUser();

            //Console.WriteLine("ID: {0}", user.Id);
            //Console.WriteLine("Nome: {0}", user.Name);
            //Console.ReadKey();
        }
    }
}
