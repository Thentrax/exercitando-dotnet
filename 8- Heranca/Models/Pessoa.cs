using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8__Heranca.Models
{
    public class Pessoa
    {
        public Pessoa() // faz com que o construtor seja opcional
        {
            
        }
        public Pessoa(string nome) // cria um construtor simples
        {
         Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() // virtual para permitir que o método seja sobrescrito da classe filha
        {
         Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos.");
        }
    }
}