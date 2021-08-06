using System;

namespace cotaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversodemoeda a = new Conversodemoeda();

            Console.WriteLine("Diga qual o valor da cotação atual do Dólar: ");
            double x = double.Parse(Console.ReadLine());
            a.Cotaçãoção = x;
            Console.WriteLine("Quantos dólares você vai compra: ");
            double z = double.Parse(Console.ReadLine());
            a.Dolar = z;

            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
