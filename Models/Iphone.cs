namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"APP {nomeApp} instalado com sucesso no Smartphone Iphone {this.Modelo} IMEI {this.IMEI}");
        }
    }
}