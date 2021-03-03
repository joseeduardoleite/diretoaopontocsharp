using System;

namespace MyDelegates
{
    class Program
    {
        delegate void myDelegate(int x);
        delegate void ExibirNomeComFrase(string nome);

        static myDelegate Delegate;

        static void Main(string[] args)
        {
            Delegate = TesteDividir;
            Delegate(10);

            Delegate = TesteSomar;
            Delegate(8);

            myDelegate delegateParameter;
            delegateParameter = TesteSomar;

            // ExibirNomeAndOther("Eduardo", 2, delegateParameter);
            // ExibirNomeAndOther("Eduardo", 2, (int x) => {
            //     Console.WriteLine("Function");
            // });
            ExibirNomeAndOther("Eduardo", (string x) => {
                Console.WriteLine(x + " Bichao");
            });
            
        }

        static void TesteDividir(int x) {
            Console.WriteLine(x + " / por 2:");
            Console.WriteLine(x / 2);
        }

        static void TesteSomar(int soma) {
            Console.WriteLine(soma + " + 2:");
            Console.WriteLine(soma + 2);
        }

        // static void ExibirNomeAndOther(string nome, int numero, myDelegate callback) {
        //     Console.WriteLine(nome);
        //     callback(numero);
        // }
        static void ExibirNomeAndOther(string nome, ExibirNomeComFrase callback) {
            Console.WriteLine(nome);
            callback(nome);
        }
    }
}
