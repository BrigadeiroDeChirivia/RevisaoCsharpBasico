using ModuloDois.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDois.Aulas
{
    public class AulaUm
    {
        /***
         * ========== AULA 1 ==============
         * 
         * ================================
        ***/

        public void CalcularAreaDeTriangulo()
        {
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Digite os valores de cada lado do triângulo:");

            triangulo.A = double.Parse(Console.ReadLine() ?? "0");
            triangulo.B = double.Parse(Console.ReadLine() ?? "0");
            triangulo.C = double.Parse(Console.ReadLine() ?? "0");

            double perimetro = (triangulo.A + triangulo.B + triangulo.C) / 2;

            double area = Math.Sqrt(perimetro * (perimetro - triangulo.A) * (perimetro - triangulo.B) * (perimetro - triangulo.C));

            Console.WriteLine($"A área do triângulo é: {area:F2}");
        }
    }
}
