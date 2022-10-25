namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private string Memoria;
        protected string status = "desligado";

      public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
      }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            status = "ligado";
        }

        public void ReceberLigacao()
        {
            if (status != "ligado")
            {
                Console.WriteLine("Recebendo ligação...");
            }
            else
            {
               Console.WriteLine("Celular desligado, impossível receber ligação.");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}