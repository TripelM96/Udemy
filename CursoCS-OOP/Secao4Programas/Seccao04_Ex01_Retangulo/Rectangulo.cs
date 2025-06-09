using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccao04_Ex01_Retangulo
{
    public class Rectangulo
    {
        public double Cumprimento;
        public double Altura;

        public double Area()
        {
            return Cumprimento * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Cumprimento + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Cumprimento * Cumprimento + Altura * Altura);
        }
    }
}
