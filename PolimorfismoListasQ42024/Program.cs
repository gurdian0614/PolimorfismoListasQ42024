
using PolimorfismoListasQ42024;

string tipo, opcion;
double precio;
List<Edificio> edificioLista = new List<Edificio>();
do
{
    Console.WriteLine("Ingrese el tipo de Edificio:");
    tipo = Console.ReadLine();

    Console.WriteLine("Ingrese el valor del Edificio:");
    precio = Convert.ToDouble(Console.ReadLine());

    Edificio edificio = new Edificio(tipo, precio);
    edificioLista.Add(edificio);

    Console.WriteLine("Desea continuar? (S/N o s/n)");
    opcion = Console.ReadLine();

} while (opcion.ToUpper() != "N");

foreach (Edificio edificio in edificioLista)
{
    edificio.Vender();
}
