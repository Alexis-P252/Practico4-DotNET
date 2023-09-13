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
    public class Vehiculos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long Id { get; set; }

        [MaxLength(128), MinLength(3), Required]
        public string Marca { get; set; } = "";

        [MaxLength(128), MinLength(3), Required]
        public string Modelo { get; set; } = "";

        [MaxLength(128), MinLength(3), Required]
        public string Matricula{ get; set; } = "";

        public long PersonaId { get; set; }
        public Personas Persona { get; set; }


        public Vehiculo getEntity()
        {
            return new Vehiculo
            {
                Marca = this.Marca,
                Modelo = this.Modelo,
                Matricula = this.Matricula,
                PersonaID = this.PersonaId,
                Persona = this.Persona.getEntity()
            };
        }
    }
}
