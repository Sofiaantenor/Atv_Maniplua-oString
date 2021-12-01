using System;

namespace ManipulacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string frutas = " Maçã, Uva, Banana, Abacaxi, Pera, Mamão";
            
            Console.WriteLine(" ");
            Console.WriteLine("                                                 MÉTODO SPLIT                                 ");
            Console.WriteLine(" ");
            Console.WriteLine($"Lista de frutas antes da separação com a utilização do Método Split: {frutas}");
            Console.WriteLine(" ");
            string[] listaFrutas = frutas.Split(',');
            foreach (string fruta in listaFrutas)
            {
                Console.WriteLine($"Lista de frutas depois da separação com a utilização do Método Split: {fruta}");
            }

             Console.WriteLine(" ");
             Console.WriteLine("                                                  MÉTODO JOIN                                    ");
             Console.WriteLine(" ");

            string frutas_ = "Maça; Uva; Banana; Abacaxi; Pera; Mamão";
            Console.WriteLine($"Lista antes da junção com a utilização do Método Split junto ao Método Join: {frutas_}");
            string[] listaFrutas_ = frutas_.Split(';');
            string frutasJuntadas_ = String.Join('|', listaFrutas_);
            Console.WriteLine(" ");
            Console.WriteLine($"Lista depois da junção com a utilização do Método Split junto ao Método Join: {frutasJuntadas_}");
            Console.WriteLine(" ");
            
        }
    }
}
