using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDois.Modelos
{
    public class Triangulo
    {
        /// Propriedades do triângulo
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Perimetro { get; set; }
        public double Area { get; set; }

        /// <summary>
        /// Calcula o perímetro do triângulo.
        /// </summary>
        public void CalcularPerimetro()
        {
            Perimetro = A + B + C;
        }

        /// <summary>
        /// Calcula a área do triângulo usando a fórmula de Heron.
        /// </summary>
        public void CalcularArea()
        {
            CalcularPerimetro();
            double semiPerimetro = Perimetro / 2;
            Area = Math.Sqrt(semiPerimetro * (semiPerimetro - A) * (semiPerimetro - B) * (semiPerimetro - C));
        }
    }
}
