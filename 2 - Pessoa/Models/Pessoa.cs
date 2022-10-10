using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2___Pessoa.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                   throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                   throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
         }
        }
        public void Apresentar()
        {
         Console.WriteLine($"Olá, eu sou {Nome}, tenho {Idade}");
        }
    }
}