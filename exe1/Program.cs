using System;

namespace exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x = new Pessoa();

            Console.WriteLine("Digite seu nome: ");
            string n1 = Console.ReadLine();
            x.Nome = n1;

            Console.WriteLine("Digite sua idade: ");
            int id1 = int.Parse(Console.ReadLine());
            x.Idade = id1;

            Console.WriteLine("Digite seu nome: ");
            string n2 = Console.ReadLine();
            x.Nome2 = n2;

            Console.WriteLine("Digite sua idade: ");
            int id2 = int.Parse(Console.ReadLine());
            x.Idade2 = id2;

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
