using BusinessLayer.BLs;
using BusinessLayer.IBLs;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticoClase1
{
    public class Commands
    {
        IBL_Personas _personasBL;

        public Commands(IBL_Personas personasBL)
        {
            _personasBL = personasBL;
        }

        public void AddPersona()
        {
            // Pedimos los datos de la pesona.
            Persona persona = new Persona();
            Console.WriteLine("Ingrese el nombre de la persona: ");
            persona.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el documento de la persona: ");
            persona.Documento = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido de la persona: ");
            persona.Apellidos = Console.ReadLine();

            Console.WriteLine("Ingrese la direccion de la persona: ");
            persona.Direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono de la persona: ");
            string inputTelefono = Console.ReadLine();

            if (int.TryParse(inputTelefono, out int telefono))
            {
                persona.Telefono = telefono;
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un número válido.");
            }

            Console.WriteLine("Ingrese la fecha de nacimiento de la persona (formato: dd/MM/yyyy): ");
            string inputFechaNacimiento = Console.ReadLine();

            if (DateTime.TryParseExact(inputFechaNacimiento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {
                // La conversión fue exitosa, 'fechaNacimiento' contiene la fecha.
                persona.FechaNac = fechaNacimiento;
            }
            else
            {
                Console.WriteLine("El formato de fecha ingresado no es válido.");
            }

            _personasBL.Insert(persona);

            _personasBL.Get(persona.Documento).Print();
        }

        public void ListPersonas()
        {
            List<Persona> personas = _personasBL.Get();

            Console.WriteLine("Listado de personas:");
            Console.WriteLine("| Documento | Nombre |");

            foreach (Persona persona in personas)
            {
                persona.PrintTable();
            }
        }

        public void RemovePersona()
        {
            Console.WriteLine("Ingrese el documento de la persona a eliminar: ");
            string documento = Console.ReadLine();

            _personasBL.Delete(documento);

            Console.WriteLine("Persona eliminada correctamente.");
        }
    }
}
