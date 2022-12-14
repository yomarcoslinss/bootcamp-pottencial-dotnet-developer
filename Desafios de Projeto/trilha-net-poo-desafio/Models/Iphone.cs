namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"App Store: Instalando o aplicativo {nomeApp}... 25%");
            Console.WriteLine($"App Store: Instalando o aplicativo {nomeApp}... 50%");
            Console.WriteLine($"App Store: Instalando o aplicativo {nomeApp}... 75%");
            Console.WriteLine($"App Store: Instalando o aplicativo {nomeApp}... 100%");
            Console.WriteLine($"App Store: O aplicativo {nomeApp} foi instalado com sucesso!");
        }
    }
}