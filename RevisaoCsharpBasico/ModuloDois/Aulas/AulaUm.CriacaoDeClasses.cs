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
         * Criação de Classes e Objetos
         * A partir da classe Triangulo, o objeto triangulo é criado e os valores dos lados são lidos do console
         * Em seguida, a área do triângulo é calculada usando a fórmula de Heron
         * ================================
        ***/

        public void CalcularAreaDeTriangulo()
        {
            // Cria uma instância da classe Triangulo
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Digite os valores de cada lado do triângulo:");

            // Atribui os valores lidos do console às propriedades A, B e C do triângulo
            triangulo.A = double.Parse(Console.ReadLine() ?? "0");
            triangulo.B = double.Parse(Console.ReadLine() ?? "0");
            triangulo.C = double.Parse(Console.ReadLine() ?? "0");

            // Calcula a área do triângulo usando a fórmula de Heron
            double perimetro = (triangulo.A + triangulo.B + triangulo.C) / 2;
            double area = Math.Sqrt(perimetro * (perimetro - triangulo.A) * (perimetro - triangulo.B) * (perimetro - triangulo.C));

            Console.WriteLine($"A área do triângulo é: {area:F2}");
        }
    }
}
