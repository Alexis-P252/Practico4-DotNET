
namespace Shared
{

    public class Persona
    {
        public string Nombre { get; set; } = "-- Sin Nombre --";

        private string documento = "";
        public string Documento
        {
            get
            {
                return documento;
            }
            set
            {
                if (value.Length >= 7)
                {
                    documento = value;
                }
                else
                {
                    throw new Exception("El formato del documento no es correcto.");
                }
            }
        }

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