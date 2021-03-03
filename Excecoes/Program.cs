using System;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Teste.sacarDinheiro(10000);
            }
            catch(Exception exception) {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
