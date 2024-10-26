
namespace PolimorfismoListasQ42024
{
    public class Edificio
    {
        public string Tipo { get; set; }
        public double Precio { get; set; }

        public Edificio(string Tipo, double Precio) {
            this.Tipo = Tipo;
            this.Precio = Precio;
        }

        public void Vender()
        {
            Console.WriteLine();
            Console.WriteLine($"Edificio de tipo {Tipo} ha sido vendido por el precio de L.{Precio.ToString("N2")}");
        }

        public void Vender(string Vendedor)
        {
            Console.WriteLine();
            Console.WriteLine($"Edificio de tipo {Tipo} ha sido vendido por el precio de L.{Precio.ToString("N2")} y vendido por {Vendedor}");
        }
    }
}
