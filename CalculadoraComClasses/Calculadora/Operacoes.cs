using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
     class Operacoes
    {
        public double a, b;

        public double Adicao()
        {
            return a + b;
        }

        public double Subtracao()
        {
            return a - b;
        }

        public double Mult()
        {
            return a * b;
        }

        public double Div()
        {
            return a / b;
        }
        
        public double Raiz()
        {
            return Math.Sqrt(a);
        }
        public double Porcentagem()
        {
            return (a/100)*b;
        }
        public double Exponencial()
        {
            return Math.Pow(a,b);
        }





    }
}
