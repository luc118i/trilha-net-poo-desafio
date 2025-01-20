namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }

        private string _modelo;
        public string Modelo
        {
            get => _modelo;
            private set => _modelo = value;
        }
        private string _IMEI;
        public string IMEI
        {
            get => _IMEI;
            private set => _IMEI = value;
        }
        private string _memoria;
        public string Memoria
        {
            get => _memoria;
            private set => _memoria = value;
        }


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
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}