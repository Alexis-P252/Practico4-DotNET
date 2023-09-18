
namespace Shared
{

    public class Persona
    {
        public string Nombre { get; set; } = "-- Sin Nombre --";

        public string Documento { get; set;}

        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaNac { get; set; }

        public int Telefono { get; set; }

      

        public void Print()
        {
            Console.WriteLine("-- Persona --");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Documento: " + Documento);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Fecha de nacimiento: " + FechaNac.ToString());
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfono: " + Telefono);
        }

        public void PrintTable()
        {
            Console.WriteLine("| " + Documento + " | " + Nombre + " |" + Apellidos + " |" + FechaNac + " |" + Direccion + " |" + Telefono + " |");
        }
    }
}