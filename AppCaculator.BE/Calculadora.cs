using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCaculator.BE
{
    public class Calculadora
    {
        public int Resultado { get; set; }
        public int Operador { get; set; }

        public int Suma() 
        {
            Resultado = Resultado + Operador;
            return Resultado; 
        }
    }
}
