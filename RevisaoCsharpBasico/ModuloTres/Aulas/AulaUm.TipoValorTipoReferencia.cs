using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloTres.Modelos;

namespace ModuloTres.Aulas
{
    public class AulaUm
    {
        /***
         * ========== AULA 1 ==============
         * Tipo Valor e Tipo Referência
         * 
         * A memória é dividida em duas partes principais:
         *  - Stack (Pilha) e Heap (Montão).
         *  
         *  A Stack é usada para armazenar tipos de valor, enquanto a Heap é usada para armazenar tipos de referência.
         *  Sendo assim, os tipos de valor são armazenados diretamente na Stack, enquanto os tipos de referência 
         *  armazenam uma referência (endereço) para o local onde os dados estão na Heap.
         *  
         *  Por exemplo, quando declaramos uma variável do tipo `int`, ela é armazenada diretamente na Stack.
         *  Já no caso da intância de uma classe, como `Pessoa`, a variável armazena uma referência para o objeto na Heap.
         * ================================
        ***/

        public void ExemploDeTipoValor()
        {
            Console.WriteLine();
            Console.WriteLine("====== Exemplo de Tipo Valor ======");
            Console.WriteLine();
            // Tipos valor são armazenados diretamente na Stack.
            // Exemplo: int, float, double, decimal, bool, char, struct, enum.
            // Vamos criar uma variável do tipo int
            int numero = 10;

            // A variável "numero" é armazenada na Stack
            Console.WriteLine($"Valor inicial de numero: {numero}");

            // Agora vamos criar uma nova variável e atribuir o valor de "numero" a ela
            int outroNumero = numero;

            // Ambas as variáveis agora possuem o mesmo valor, mas são independentes
            Console.WriteLine($"Valor de outroNumero: {outroNumero}");

            // Se alterarmos o valor de "outroNumero", isso não afetará "numero"
            outroNumero = 20;
            Console.WriteLine($"Novo valor de outroNumero: {outroNumero}");
            Console.WriteLine($"Valor de numero após alteração: {numero}");
        }

        public void ExemploDeTipoReferencia()
        {
            Console.WriteLine();
            Console.WriteLine("====== Exemplo de Tipo Referência ======");
            Console.WriteLine();
            // Classes são tipos de referência, ou seja, ao criar uma instância de uma classe, estamos criando um objeto na Heap.
            Pessoa pessoa = new Pessoa("Jeff", new DateTime(2006,8,8));

            // O objeto "pessoa" é um ponteiro criado na Stack que aponta para a instância de Pessoa na Heap.
            // Se criarmos uma nova variável e atribuirmos a ela a mesma instância, ambas apontarão para o mesmo objeto na Heap.

            // Observe os valores iniciais
            Console.WriteLine($"Nome da pessoa: {pessoa.Nome}");
            Console.WriteLine($"Data de Nascimento da pessoa: {pessoa.DataNascimento.ToString("dd/MM/yyyy")}");

            // Agora, vamos criar uma nova variável que aponta para o mesmo objeto
            Pessoa outraPessoa = pessoa;

            Console.WriteLine($"Nome da outra pessoa: {outraPessoa.Nome}");
            Console.WriteLine($"Data de Nascimento da outra pessoa: {outraPessoa.DataNascimento.ToString("dd/MM/yyyy")}");

            // Se alterarmos a propriedade de outraPessoa, isso afetará também pessoa, pois ambas referenciam o mesmo objeto na Heap.
            outraPessoa.Nome = "Andréa";
            outraPessoa.DataNascimento = new DateTime(2000, 1, 1);

            // Observe que a outraPessoa agora apresenta os novos valores
            Console.WriteLine($"Nome da outra pessoa: {outraPessoa.Nome}");
            Console.WriteLine($"Data de Nascimento da outra pessoa: {outraPessoa.DataNascimento.ToString("dd/MM/yyyy")}");

            // E a pessoa também foi afetada, pois ambas referenciam o mesmo objeto na Heap
            Console.WriteLine($"Nome da pessoa: {pessoa.Nome}");
            Console.WriteLine($"Data de Nascimento da pessoa: {pessoa.DataNascimento.ToString("dd/MM/yyyy")}");
        }

        public void ExemploDeStruct()
        {
            Console.WriteLine();
            Console.WriteLine("====== Exemplo de Struct ======");
            Console.WriteLine();
            // Structs são tipos valor personalizados.
            // Apesar de serem tipos valor, os Structs podem conter campos e propriedades.
            // Exemplos de Structs são DateTime, Guid, Int32 etc.

            // Vamos criar uma struct simples para representar um ponto 2D
            Point ponto = new Point(3, 4);

            // Exibindo as coordenadas do ponto
            Console.WriteLine($"Coordenadas do ponto: ({ponto.X}, {ponto.Y})");
            // Atribuindo novas coordenadas ao ponto usando o método
            ponto.AtribuirNovasCoordenadas(7, 8);
            // Exibindo as novas coordenadas do ponto
            Console.WriteLine($"Novas coordenadas do ponto: ({ponto.X}, {ponto.Y})");
        }
    }
}
