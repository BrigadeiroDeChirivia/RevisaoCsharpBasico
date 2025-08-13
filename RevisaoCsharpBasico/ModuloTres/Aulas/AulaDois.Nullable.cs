using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloTres.Aulas
{
    public class AulaDois
    {
        /***
         * ========== AULA 2 ==============
         * Nullable
         * ================================
        ***/

        public void ValoresNullable()
        {
            // Para criarmos uma variável que aceita valores nulos, devemos optar por uma das duas formas abaixo:
            Nullable<decimal> dinheiro = null;
            decimal? maisDinheiro = 10.0M;

            // O método GetValueOrDefault() retorna ou o valor atribuído à variável ou o valor padrão do tipo de variável
            Console.WriteLine(dinheiro);                         // essa linha retornará null, pois a variável dinheiro está nula
            Console.WriteLine(dinheiro.GetValueOrDefault());     // já essa retornará o valor padrão do tipo decimal, que é 0.0
            Console.WriteLine(maisDinheiro);                     // no caso de maisDinheiro, o valor atribuído foi 10.0
            Console.WriteLine(maisDinheiro.GetValueOrDefault()); // e como maisDinheiro tem valor atribuído, o método não apresentará valor padrão 0.0

            // Uma forma de validar se a variável possui valor seria através da propriedade booleana HasValue
            if (dinheiro.HasValue)
                Console.WriteLine($"A variável dinheiro tem valor: {dinheiro.Value}");
            if (maisDinheiro.HasValue)
                Console.WriteLine($"A variável maisDinheiro tem valor: {maisDinheiro.Value}");
        }

        public void OperadorDeCoalescenciaNula()
        {
            // O C# tem um tipo especial de operador chamado "operador de coalescência nula"
            // Ele serve para definir um valor padrão no momento da atribuição
            // E ele é representado através do sinal ?? (interrogação dupla)

            double? x = null;
            double y = x ?? 0.0;

            // O exemplo acima demonstra isso:
            //      - Se x for nulo, y receberá 0.0 (como ocorreu no exemplo)
            //      - Mas caso x não fosse nulo, y receberia o valor de x

            Console.WriteLine($"valor de y: {y}");
        }
    }
}
