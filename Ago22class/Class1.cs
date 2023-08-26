using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ago22class
{
    internal class Class1
    { 
        public static int EjecutarEjercicio8(string numero1, string numero2, string numero3){
            int resultado = int.Parse(numero1) + int.Parse(numero2) + int.Parse(numero3) / 3;
            return resultado;
        }
        public static int Area(string bases, string altura)
        {
            int area = int.Parse(bases) * int.Parse(altura);
            return area;
        }
        public static int Perimetro(string bases, string altura)
        {
            int perimetro = (int.Parse(bases) + int.Parse(altura)) * 2;
            return perimetro;
        }
        public static int Volumen(string radio, string altura)
        {
            int volumen = ((3, 14 + int.Parse(radio) * *2) * int.Parse(altura));
            return volumen;
        }
    }
}
