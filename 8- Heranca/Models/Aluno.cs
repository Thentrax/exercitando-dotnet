using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8__Heranca.Models
{
   public class Aluno : Pessoa // Classe do arquivo : Classe de referência já faz a herança
   {
      public Aluno() // construtor próprio para Aluno com parâmetros opcionais
      {
         
      }
      public Aluno(string nome) : base(nome) // o : base() leva a variável para o construtor do pai
      {
         
      }
      public decimal Nota { get; set; }

      public override void Apresentar() //override para sobrescrever o método da classe pai
      {
         Console.WriteLine($"Olá, eu sou {Nome}, tenho {Idade} anos e minha nota é: {Nota}.");
      }
   }
}