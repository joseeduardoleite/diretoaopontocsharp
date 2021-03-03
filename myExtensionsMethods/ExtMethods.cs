using System;

namespace extensionsMethods
{
    public static class ExtMethods
    {
        public static string Legal(this string texto) {
            return texto + " Legal";
        }

        public static void Printar(this string texto) {
            Console.WriteLine(texto);
        }

        public static int Dobro(this int numero) {
            return numero * 2;
        }
    }
}