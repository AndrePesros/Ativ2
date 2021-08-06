using System;
using System.Collections.Generic;
using System.Text;

namespace exe2
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Nome2 { get; set; }
        public double Salario { get; set; }
        public double Salario2 { get; set; }

        double media;
        public double Media()
        {
            media = (Salario + Salario2) / 2;
            return media;
        }
        public override string ToString()
        {
            return $"Salario Médio é de: {Media():F2}";
        }
    }
}
