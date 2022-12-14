namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Playstore: Instalando o aplicativo {nomeApp}... 25%");
            Console.WriteLine($"Playstore: Instalando o aplicativo {nomeApp}... 50%");
            Console.WriteLine($"Playstore: Instalando o aplicativo {nomeApp}... 75%");
            Console.WriteLine($"Playstore: Instalando o aplicativo {nomeApp}... 100%");
            Console.WriteLine($"Playstore: O aplicativo {nomeApp} foi instalado com sucesso!");
        }
    }
}