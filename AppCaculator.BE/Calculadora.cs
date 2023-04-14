using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCaculator.BE
{
    public class Calculadora
    {
        public int Resultado { get; set; } = 0;
        public int Operador1 { get; set; } = 0;
        public int Operador2 { get; set; } = 0;

        public int Suma() 
        {
            Resultado = Operador1 + Operador2;
            Operador1 = Resultado;
            return Resultado; 
        }
    }
}
