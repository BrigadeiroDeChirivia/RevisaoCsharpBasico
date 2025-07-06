using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDois.Modelos
{
    public class Calculadora
    {
        // Propriedade estática que representa o valor de PI
        public static double PI = 3.14;

        /// <summary>
        /// Calcula a área de um círculo dado o raio.
        /// </summary>
        /// <param name="raio">Raio do círculo</param>
        /// <returns>A circunferência do círculo</returns>
        public static double CalcularCircunferencia(double raio)
        {
            return 2.0 * PI * raio;
        }

        /// <summary>
        /// Calcula o volume de uma esfera dado o raio.
        /// </summary>
        /// <param name="raio">Raio da esfera</param>
        /// <returns>Retorna o volume da esfera</returns>
        public static double CalcularVolume(double raio)
        {
            return 4.0 / 3.0 * PI * raio * raio * raio;
        }
    }
}
