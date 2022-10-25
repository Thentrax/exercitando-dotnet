using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using _11__Interfaces.Interfaces; //usando pasta "Interfaces"

namespace _11__Interfaces.Models
{
   public class Calculadora : ICalculadora //implementando Interface Calculadora
   {
      public int Dividir(int num1, int num2) //implementando métodos da Interface
      {
         return num1 / num2;
      }

      public int Multiplicar(int num1, int num2)
      {
         return num1 * num2;
      }

      public int Somar(int num1, int num2)
      {
        return num1 + num2;
      }

      public int Subtrair(int num1, int num2)
      {
         return num1 - num2;
      }
   }
}