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
            //args = new string[] { "-aula-3" };
            //args = new string[] { "-aula-4" };
            //args = new string[] { "-aula-5" };
            args = new string[] { "-aula-6" };

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
                    case "-aula-4":
                        AulaQuatro aulaQuatro = new AulaQuatro();
                        aulaQuatro.OperadoresDeAtribuicao();
                        aulaQuatro.ConversaoImplicita();
                        aulaQuatro.ConversaoCasting();
                        break;
                    case "-aula-5":
                        AulaCinco aulaCinco = new AulaCinco();
                        aulaCinco.OperadoresAritmeticos();
                        break;
                        case "-aula-6":
                            AulaSeis aulaSeis = new AulaSeis();
                            aulaSeis.EntradaDeDados();
                            break;
                    default:
                        Console.WriteLine("Nenhuma opção foi passada como argumento.");
                        break;
                }
            }
        }
    }
}