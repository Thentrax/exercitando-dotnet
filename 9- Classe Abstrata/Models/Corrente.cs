using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9__Classe_Abstrata.Models
{
   public class Corrente : Conta
   {
      public override void Creditar(decimal valor)
      {
         saldo += valor;
      }
   }
}