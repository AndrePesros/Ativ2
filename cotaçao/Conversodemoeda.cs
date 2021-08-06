using System;
using System.Collections.Generic;
using System.Text;

namespace cotaçao
{
    class Conversodemoeda
    {
        public double Cotaçãoção { get; set; }
        public double Dolar { get; set; }
        public double Reais { get; set; }
        
        public double Convercao()
        {
            Reais = ((Dolar * Cotaçãoção) * 0.05) + (Dolar * Cotaçãoção);
            return Reais;
        }

        public override string ToString()
        {
            return $" o valor a ser pago em reias é: {Convercao():F2}";
        }







    }
}
