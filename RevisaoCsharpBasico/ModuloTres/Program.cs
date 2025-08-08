using System;
using ModuloTres.Aulas;

namespace ModuloTres
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ========== MÓDULO TRÊS ============
            // Aulas de Estruturas de Dados
            // ===================================

            args = new string[] { "-aula-1" };

            if (args.Length == 0)
            {
                Console.WriteLine("Nenhuma opção foi passada como argumento.");
                return;
            }

            foreach (var arg in args)
            {
                switch (arg)
                {
                    case "-aula-1":
                        AulaUm aulaUm = new AulaUm();
                        aulaUm.ExemploDeTipoValor();
                        aulaUm.ExemploDeTipoReferencia();
                        aulaUm.ExemploDeStruct();
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção foi passada como argumento.");
                        break;
                }
            }
        }
    }
}