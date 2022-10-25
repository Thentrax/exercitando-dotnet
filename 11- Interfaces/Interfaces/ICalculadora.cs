using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11__Interfaces.Interfaces
{
    public interface ICalculadora
    //funciona como uma classe abstrata porém pode ser implementada mais de uma interface
    {
      int Somar(int num1, int num2); //como método abstrato
      int Subtrair(int num1, int num2);
      int Multiplicar(int num1, int num2);
      int Dividir(int num1, int num2);

    //   int Dividit(int num1, int num2) é possível criar métodos padrão
    // {
        // return num1 / num2
    // }
   }
}