using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
namespace DataAccessLayer.EFModels
{
    public class Personas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [MaxLength(128), MinLength(3), Required]
        public string Documento { get; set; } = "";

        [MaxLength(128), MinLength(3), Required]
        public string Nombres { get; set; } = "";
        
        [MaxLength(128), MinLength(3), Required]
        public string Apellidos { get; set; } = "";

        [MaxLength(128), MinLength(3), Required]
        public string Direccion { get; set; } = "";

        public DateTime Fechanacimiento{ get; set; } 
        public int Telefono { get; set; }

        public ICollection<Vehiculos> Vehiculos { get; set; } = new List<Vehiculos>();



        public Persona getEntity()
        {
            return new Persona
            {
                Documento = this.Documento,
                Nombre = this.Nombres,
                Apellidos = this.Apellidos,
                Direccion = this.Direccion,
                FechaNac = this.Fechanacimiento,
                Telefono = this.Telefono
            };    
        }
    }
}
