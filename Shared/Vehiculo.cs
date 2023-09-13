
namespace Shared
{

    public class Vehiculo
    {
        public string Marca { get; set; } = "";
        public string Modelo { get; set; } = "";
        public string Matricula { get; set; } = "";

        public long PersonaID { get; set; }
        
        public Persona Persona { get; set; }


        public void Print()
        {
            Console.WriteLine("-- Vehiculo --");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Matricula: " + Matricula);
            Console.WriteLine("Persona: " + Persona.Nombre + "- C.I. "  + Persona.Documento);
        }

        public void PrintTable()
        {
            Console.WriteLine("| " + Marca + " | " + Modelo+ " |" + Matricula+ " |" + Persona.Nombre + "- C.I. " + Persona.Documento + " |");
        }
    }
}