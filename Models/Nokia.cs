namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo '{nomeApp}' foi instalado com sucesso no meu {Modelo}.");
        }

        public string Config()
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"Configuração do meu {Modelo}");
            return $"Número: {Numero}\nModelo: {Modelo}\nIMEI: {IMEI}\nMemória: {Memoria}";
        }
    }
}
