using System;

namespace cotaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversodemoeda a = new Conversodemoeda();

            Console.WriteLine("Cotação do Dolar: 5,19");
            
            Console.WriteLine("Quantos dolares você vai comprar? ");
            a.Dolar = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Valor a ser pago em Reais: ");
            a.Valor = double.Parse(Console.ReadLine());

            double conta;
            
                conta = a.Valor - 6 % + a.Dolar / 5.19;

                
            

            Console.WriteLine("Dolas comprados $ " +conta);

            Console.ReadKey();
        }
    }
}
