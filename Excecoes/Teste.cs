using System;

namespace Excecoes
{
    public class Teste
    {
        static int totalConta = 100;
        public static void sacarDinheiro(int valor) {
            if (valor <= totalConta) {
                Console.Write("Saque feito com sucesso");
            }
            else {
                throw new Exception("Erro: Valor do saque é maior do que o saldo em conta");
            }
        }
    }
}