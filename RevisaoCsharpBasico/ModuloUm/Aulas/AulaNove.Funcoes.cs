using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloUm.Aulas
{
    internal class AulaNove
    {
        /***
         * ========== AULA 9 ============
         * Funções são blocos de código que podem ser reutilizados.
         * Elas podem receber parâmetros e retornar valores.
         * As funções ajudam a organizar o código e evitar repetição.
         * 
         * Sintaxe:
         * [modificador] [tipo de retorno] NomeDaFuncao([tipo parametro1, tipo parametro2, ...])
         * {
         *     // corpo da função
         * }
         * ==============================
        ***/

        public void MaiorDeTresNumeros()
        {
            // Função para encontrar o maior de três números
            Console.WriteLine("Digite três números:");
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());

            int maior = EncontrarMaior(numero1, numero2, numero3);
            Console.WriteLine($"O maior número é: {maior}");
        }

        private int EncontrarMaior(int num1, int num2, int num3)
        {
            // Função que retorna o maior número entre três
            int maior;
            
            if (num1 > num2 && num1 > num3)
                maior = num1;
            else if (num2 > num3)
                maior = num2;
            else
                maior = num3;

            return maior;
        }
    }
}
