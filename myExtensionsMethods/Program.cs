using System;
using extensionsMethods;

namespace myExtensionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Eduardo";
            int x = 5;
            
            Console.WriteLine(maisSon(nome));

            Console.WriteLine(nome.Legal());

            nome.Printar();

            Console.WriteLine(x.Dobro());
            Console.WriteLine(10.Dobro());
        }

        static string maisSon(string nome) {
            return nome + " Legal";
        }
    }
}
