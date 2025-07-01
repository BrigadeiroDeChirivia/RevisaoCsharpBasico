using System;
using ModuloUm.Aulas;

namespace ModuloUm
{
    class Program
    {
        public static void Main(string[] args)
        {
            //args = new string[] { "-aula-1" };
            //args = new string[] { "-aula-2" };
            args = new string[] { "-aula-3" };

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
                        aulaUm.TiposBasicos();
                        break;
                    case "-aula-2":
                        AulaDois aulaDois = new AulaDois();
                        aulaDois.TiposBasicos();
                        break;
                    case "-aula-3":
                        AulaTres aulaTres = new AulaTres();
                        aulaTres.SaidaDeDados();
                        break;
                    default:
                        Console.WriteLine("Nenhuma opção foi passada como argumento.");
                        break;
                }
            }
        }
    }
}