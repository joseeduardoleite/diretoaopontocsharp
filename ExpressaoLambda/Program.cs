using System;

namespace ExpressaoLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> Quadrado = num => num * num;
            Console.WriteLine(Quadrado(10));

            Func<int, int> Cubo = x => x * x * x;
            Console.WriteLine(Cubo(10));

            Func<int, double> Raiz = numero => {
                return Math.Sqrt(numero);
            };
            Console.WriteLine(Raiz(4));

            // Parametros => Implementação
            // () => Implementação
            // num => Implementação
            // (p1, p2, p3) => Implementação
        }

        // static int Quadrado(int num) {
        //     return num * num;
        // }
    }
}
