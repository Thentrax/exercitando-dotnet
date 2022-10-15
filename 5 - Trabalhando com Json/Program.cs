using _5___Nuget.Models;
using Newtonsoft.Json;

// Cria lista de objetos

List<Venda> vendas = new List<Venda>();

Venda p1 = new Venda(0, "Mouse", 25.50M);
Venda p2 = new Venda(1, "Teclado", 125.50M);
Venda p3 = new Venda(2, "Monitor", 1000.50M);

vendas.Add(p1);
vendas.Add(p2);
vendas.Add(p3);

// Serializar lista em Json

string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

// Escrever em arquivo Json

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);