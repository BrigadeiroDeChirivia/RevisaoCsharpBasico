using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDois.Modelos
{
    public class Dragao
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public int Idade { get; set; }

        // Construtor padrão
        public Dragao()
        {
            // "this" usado para referenciar o próprio objeto
            this.Nome = "Dragão Padrão";
            this.Cor = "Cor Padrão";
            this.Idade = 0;
        }

        // Sobrecargas de construtores utilizando 'this' para referência a outros construtores
        // Construtor referenciando o construtor padrão
        public Dragao(string nome) : this()
        {
            this.Nome = nome;
        }

        // Construtor referenciando o construtor com nome
        public Dragao(string nome, string cor) : this(nome)
        {
            this.Cor = cor;
        }

        // Construtor referenciando o construtor com nome e cor
        public Dragao(string nome, string cor, int idade) : this(nome, cor)
        {
            if (idade < 0)
            {
                throw new ArgumentException("A idade do dragão não pode ser negativa.");
            }

            this.Idade = idade;
        }

        
        public void Rugir(Dragao dragao)
        {
            if (dragao == null)
            {
                throw new ArgumentNullException(nameof(dragao), "O dragão não pode rugir.");
            }

            Console.WriteLine($"{dragao.Nome} está rugindo!");
        }

        public void ImprimirRugido()
        {
            // "this" usado para referenciar o próprio objeto Dragao
            Rugir(this);
        }

        // Método para exibir informações do dragão
        public override string ToString()
        {
            return $"Dragão: {Nome}, Cor: {Cor}, Idade: {Idade} anos";
        }
    }
}
