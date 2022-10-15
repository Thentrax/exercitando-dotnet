using _6__Recebendo_Json.Models;
using Newtonsoft.Json;

string conteudo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> vendas = JsonConvert.DeserializeObject<List<Venda>>(conteudo);

foreach (Venda venda in vendas)
{
    Console.WriteLine($"Id:{venda.Id}, Nome: {venda.Produto}, Preço: R${venda.Preco}");
}