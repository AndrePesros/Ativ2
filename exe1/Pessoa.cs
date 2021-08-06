using System;
using System.Collections.Generic;
using System.Text;

namespace exe1
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Nome2 { get; set; }
        public int Idade { get; set; }
        public int Idade2 { get; set; }

        public string Velho()
        {
            if (Idade > Idade2)
            {
                return Nome;
            }
            else
            {
                return Nome2;
            }
        }
        public override string ToString()
        {
            return $"A pessoa mais velha é: {Velho():F2}";
        }

    }
}
