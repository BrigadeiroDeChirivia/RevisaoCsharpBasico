using System;
using ModuloDois.Aulas;

namespace ModuloDois
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ========== MÓDULO DOIS ============
            // Aulas de Orientação a Objetos
            // ===================================

            //args = new string[] { "-aula-1" };
            //args = new string[] { "-aula-2" };
            //args = new string[] { "-aula-3" };
            //args = new string[] { "-aula-4" };
            //args = new string[] { "-aula-5" };
            //args = new string[] { "-aula-6" };
            args = new string[] { "-aula-7" };

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
                    case "-aula-2":
                        AulaDois aulaDois = new AulaDois();
                        aulaDois.ExemploMembrosEstaticos();
                        break;
                    case "-aula-3":
                        AulaTres aulaTres = new AulaTres();
                        aulaTres.ExemploConstrutores();
                        break;
                    case "-aula-4":
                        AulaQuatro aulaQuatro = new AulaQuatro();
                        aulaQuatro.ExemploSobrecarga();
                        break;
                    case "-aula-5":
                        AulaCinco aulaCinco = new AulaCinco();
                        aulaCinco.ExemploThis();
                        break;
                    case "-aula-6":
                        AulaSeis aulaSeis = new AulaSeis();
                        aulaSeis.ExemploEncapsulamento();
                        break;
                    case "-aula-7":
                        AulaSete aulaSete = new AulaSete();
                        aulaSete.ExemploModificadoresDeAcesso();
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção foi passada como argumento.");
                        break;
                }
            }
        }
    }
}