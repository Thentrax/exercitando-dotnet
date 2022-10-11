using _3__Filas.Models;
// Fila de guichê

Tickets fila = new Tickets();
int select = 0;

while (select != 4)
{
   Console.WriteLine("Máquina de Tickets");
   Console.WriteLine("1- Novo Ticket");
   Console.WriteLine("2- Receber Ticket");
   Console.WriteLine("3- Listar Tickets Ativos");
   Console.WriteLine("4- Finalizar");
   select = Convert.ToInt32(Console.ReadLine());

   switch (select)
   {
      case 1:
         Console.Clear();
         fila.Adicionar();
         select = 0;
         break;

      case 2:
         Console.Clear();
         fila.Atender();
         break;

      case 3:
         Console.Clear();
         fila.Listar();
         break;

      case 4:
         Console.Clear();
         Console.WriteLine("Fechando Programa");
         break;

      default:
         Console.Clear();
         Console.WriteLine("Valor inválido!");
         break;

   }

   

}