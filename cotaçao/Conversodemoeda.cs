using System;
using System.Collections.Generic;
using System.Text;

namespace cotaçao
{
    class Conversodemoeda
    {
        public double Dolar { get; set; }
        public double Valor { get; set; }

        double z;
        public double Conversao()
        {
            z = 5.19 + Valor / 6;

            return z;
        }
        public void Valorrecebido(double compra)
        {
            compra = z;
        }
    }
}
