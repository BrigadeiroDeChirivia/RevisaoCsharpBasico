using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloTres.Modelos;

namespace ModuloTres.Aulas
{
    public class AulaTres
    {
        /***
         * ========== AULA 3 ==============
         * Vetores
         * ================================
        ***/

        public void ExemploDeVetorDeStruct()
        {
            int tamanhoDoVetor = 3;

            double[] vetor = new double[tamanhoDoVetor];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine() ?? "0.0", System.Globalization.CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }

            double media = soma / tamanhoDoVetor;

            Console.WriteLine($"Média: {media}");
        }

        public void ExemploDeVetorDeObjetos()
        {
            int tamanhoDoVetor = 3;

            Produto[] vetor = new Produto[tamanhoDoVetor];

            for (int i = 0; i < vetor.Length; i++)
            {
                string nome = Console.ReadLine() ?? "";
                double preco = double.Parse(Console.ReadLine() ?? "0.0", System.Globalization.CultureInfo.InvariantCulture);

                vetor[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0.0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i].Preco;
            }

            double media = soma / tamanhoDoVetor;

            Console.WriteLine($"Média: {media}");
        }
    }
}
