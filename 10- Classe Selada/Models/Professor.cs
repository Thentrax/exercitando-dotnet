using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10__Classe_Selada.Models
{
    public class Professor : Pessoa // para selar uma classe basta colocar "public sealed class NomeDaClasse"
    {
        public int nome { get; set; }
        public sealed override void Apresentar() // sela um método
        {
         Console.WriteLine($"Olá, meu nome é {nome}");
        }
    }
}