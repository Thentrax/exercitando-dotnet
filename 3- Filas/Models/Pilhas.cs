using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3__Filas.Models
{
    public class Pilhas
    {
        private Stack<int> pilha = new Stack<int>();
      private int ticket = 0;

      public void Adicionar(){
        ticket += 1;
        pilha.Push(ticket);
        Console.WriteLine($"O seu ticket é: {ticket}.");
      }
      
      public void Atender(){
        if (pilha.Count != 0)
         {
            Console.WriteLine($"Ticket {pilha.Pop()} recebido.");
         }
         else{
            Console.WriteLine("Não há tickets pendentes");
         }
      }

      public void Listar(){
        if (pilha.Count != 0)
         {
            Console.WriteLine("Próximos Tickets na Fila:");
            foreach (int item in pilha)
            {
               Console.WriteLine($"{pilha};");
            }
         }
         
         else{
            Console.WriteLine("Não há tickets na fila");
         }
      }
    }
}