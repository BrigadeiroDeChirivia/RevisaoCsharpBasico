using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloDois.Modelos;

namespace ModuloDois.Aulas
{
    internal class AulaDois
    {
        /***
         * ========== AULA 2 ==============
         * Membros Estáticos
         * 
         * Membros estáticos são aqueles que pertencem à classe em si, e não a uma instância específica da classe
         * Eles podem ser acessados diretamente através do nome da classe, sem a necessidade de criar um objeto
         * 
         * Exemplo: Math.PI, Console.WriteLine() etc
         * ================================
        ***/

        public void ExemploMembrosEstaticos()
        {
            Console.Write("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine() ?? "0");

            // Utilizando os membros estáticos da classe Calculadora
            double circunferencia = Calculadora.CalcularCircunferencia(raio);
            double volume = Calculadora.CalcularVolume(raio);

            Console.WriteLine($"A circunferência do círculo é: {circunferencia:F2}");
            Console.WriteLine($"O volume da esfera é: {volume:F2}");
            Console.WriteLine($"O valor de PI é: {Calculadora.PI:F2}");
        }
    }
}
