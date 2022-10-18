using _5___Nuget.Models;
using Newtonsoft.Json;

List<Venda> vendas = new List<Venda>();

Venda v1 = new Venda(0, "Mouse", 59.99M, DateTime.Now);
Venda v2 = new Venda(1, "Teclado", 159.99M, DateTime.Now);

vendas.Add(v1);
vendas.Add(v2);

// Serializar objetos em Json

string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);