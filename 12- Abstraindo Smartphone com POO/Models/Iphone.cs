namespace DesafioPOO.Models
{
   // TODO: Herdar da classe "Smartphone"
   public class Iphone : Smartphone
   {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }
        
      public override void InstalarAplicativo(string nomeApp)
      {
         Console.WriteLine($"Insalando aplicativo {nomeApp}... by Apple"); 
      }
   }
}