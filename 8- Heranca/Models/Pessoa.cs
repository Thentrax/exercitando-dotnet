using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8__Heranca.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() // virtual para permitir que o método seja sobrescrito da classe filha
        {
         Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos.");
        }
    }
}