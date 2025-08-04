using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloDois.Modelos;

namespace ModuloDois.Aulas
{
    public class AulaSete
    {
        /***
         * ========== AULA 7 ==============
         * Modificadores de Acesso
         * 
         * --------------------------------------------------------------------------------------------
         * |                    | própria | subclasses  | classes do | subclasses fora | classes fora |
         * |                    | classe  | no assembly |  assembly  |   do assembly   | do assembly  |
         * --------------------------------------------------------------------------------------------
         * |       public       |    X    |      X      |     X      |        X        |       X      |
         * | protected internal |    X    |      X      |     X      |        X        |              |
         * |      internal      |    X    |      X      |     X      |                 |              |
         * |      protected     |    X    |      X      |            |        X        |              |
         * | private protected  |    X    |      X      |            |                 |              |
         * |       private      |    X    |             |            |                 |              |
         * --------------------------------------------------------------------------------------------
         * 
         * ================================
        ***/

        public void ExemploModificadoresDeAcesso()
        {
            // Exemplo de uso dos modificadores de acesso
            // public, protected, internal, private, protected internal, private protected
            // Classe exemplo
            var exemplo = new ModificadorDeAcessoExemplo();
            // Acessando membros públicos
            Console.WriteLine(exemplo.Publico);
            
            // Acessando membros protegidos (somente dentro da classe ou subclasses)
            // Console.WriteLine(exemplo.Protegido); // Não é possível acessar aqui
            
            // Acessando membros internos (somente dentro do mesmo assembly)
            Console.WriteLine(exemplo.Interno);
            
            // Acessando membros privados (somente dentro da própria classe)
            // Console.WriteLine(exemplo.Privado); // Não é possível acessar aqui
            
            // Acessando membros protected internal (dentro do assembly ou subclasses)
            Console.WriteLine(exemplo.ProtectedInternal);

            // Acessando membros private protected (somente dentro do assembly e subclasses)
            // Console.WriteLine(exemplo.PrivateProtected); // Não é possível acessar aqui
        }
    }
}
