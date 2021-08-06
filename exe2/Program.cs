using System;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x = new Funcionario();

            Console.WriteLine("Digite seu Nome: ");
            string n1 = Console.ReadLine();
            x.Nome = n1;
            Console.WriteLine("Digite seu Salario: ");
            double sl1 = double.Parse(Console.ReadLine());
            x.Salario = sl1;
            Console.WriteLine("Digite seu Nome: ");
            string n2 = Console.ReadLine();
            x.Nome2 = n2;
            Console.WriteLine("Digite seu Salario: ");
            double sl2 = double.Parse(Console.ReadLine());
            x.Salario2 = sl2;

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
