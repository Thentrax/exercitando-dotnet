using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9__Classe_Abstrata.Models
{
    public abstract class Conta // com abstract declaramos que a classe é abstrata
    {
      protected decimal saldo;
      public abstract void Creditar(decimal valor); // declaramos que o método é abstrato, sem corpo
      public void ExibirSaldo()
      {
        Console.WriteLine($"Saldo: R${saldo}");
      }
   }
}