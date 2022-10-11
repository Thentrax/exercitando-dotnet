using _2___Pessoa.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

decimal valorMonetario = 100.00M;

Console.WriteLine($"{valorMonetario:C}");

// Pessoa p1 = new Pessoa("Thiago", 21);

// p1.Apresentar();
