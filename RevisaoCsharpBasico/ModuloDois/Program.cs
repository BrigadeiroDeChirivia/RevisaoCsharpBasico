using System;
using ModuloDois.Aulas;

namespace ModuloDois
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ========== MÓDULO DOIS ============
            // Aulas de Lógica de Programação
            // =================================

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
                        aulaUm.CalcularAreaDeTriangulo();
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção foi passada como argumento.");
                        break;
                }
            }
        }
    }
}