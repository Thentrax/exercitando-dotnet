using _5___Nuget.Models;
using Newtonsoft.Json;

<<<<<<< HEAD
List<Venda> vendas = new List<Venda>();

Venda v1 = new Venda(0, "Mouse", 59.99M, DateTime.Now);
Venda v2 = new Venda(1, "Teclado", 159.99M, DateTime.Now);

vendas.Add(v1);
vendas.Add(v2);
=======
// Cria lista de objetos
>>>>>>> 2c1b168dd177f0745f8e354c7c609347bb08b76c

List<Venda> vendas = new List<Venda>();

<<<<<<< HEAD
string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

=======
Venda p1 = new Venda(0, "Mouse", 25.50M);
Venda p2 = new Venda(1, "Teclado", 125.50M);
Venda p3 = new Venda(2, "Monitor", 1000.50M);

vendas.Add(p1);
vendas.Add(p2);
vendas.Add(p3);

// Serializar lista em Json

string serializado = JsonConvert.SerializeObject(vendas, Formatting.Indented);

// Escrever em arquivo Json

>>>>>>> 2c1b168dd177f0745f8e354c7c609347bb08b76c
File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);