using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3__Filas.Models
{
    public class Tickets
    {
      private Queue<int> fila = new Queue<int>();
      private int ticket = 0;

      public void Adicionar(){
        ticket += 1;
        fila.Enqueue(ticket);
        Console.WriteLine($"O seu ticket é: {ticket}.");
      }
      
      public void Atender(){
        if (fila.Count != 0)
         {
            Console.WriteLine($"Ticket {fila.Dequeue()} recebido.");
         }
         else{
            Console.WriteLine("Não há tickets pendentes");
         }
      }

      public void Listar(){
        if (fila.Count != 0)
         {
            Console.WriteLine("Próximos Tickets na Fila:");
            foreach (int item in fila)
            {
               Console.WriteLine($"{item};");
            }
         }
         
         else{
            Console.WriteLine("Não há tickets na fila");
         }
      }
   }
}