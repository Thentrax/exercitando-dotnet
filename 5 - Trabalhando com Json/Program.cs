using _5___Nuget.Models;
using Newtonsoft.Json;

Venda produto = new Venda(0, "Mouse", 25.50M);

// Serializar objetos em Json

string serializado = JsonConvert.SerializeObject(produto, Formatting.Indented);

Console.WriteLine(serializado);