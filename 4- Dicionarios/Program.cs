Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RJ", "Rio de Janeiro");
estados.Add("SP", "São Paulo");
estados.Add("ES", "Espírito Santo");
estados.Add("MG", "Minas Gerais");

bool ativo = true;

while (ativo)
{
   Console.WriteLine("Selecione uma sigla de estado:");

   string chave = Console.ReadLine().ToUpper();

   if (estados.ContainsKey(chave))
   {
      Console.WriteLine($"\nChave já existente\nChave: {chave}, Valor: {estados[chave]}");
   }
   else
   {
      Console.WriteLine($"\nChave não encontrada: deseja adicionar elemento com essa chave?");
      string escolha = Console.ReadLine().ToLower();

      if (escolha == "sim")
      {
         Console.WriteLine($"\nChave: {chave}\nDigite o valor: ");
         string valor = Console.ReadLine();
         if (valor != null)
         {
         estados.Add(chave, valor);
         Console.WriteLine($"\nChave: {chave}\nValor: {valor}");
         }
         else
         {
            Console.WriteLine("\nNão foi possível progredir. Valor nulo");
         }
      }
   }
}

