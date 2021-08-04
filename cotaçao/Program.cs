using System;

namespace cotaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversodemoeda a = new Conversodemoeda();

            Console.WriteLine("Qual a cotação do Dolar: 5,19");
            
            Console.WriteLine("Quantos dolares você vai comprar? " +a.Valor );
            a.Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em Reais: " );
            
        }
    }
}
