using DataAccessLayer.EFModels;
using DataAccessLayer.IDALs;
using Microsoft.Data.SqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DALs
{
    public class DAL_Personas_EF : IDAL_Personas
    {
        private DBContextCore _dbContext;

        public DAL_Personas_EF(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string documento)
        {
            var personaToDelete = _dbContext.Personas.FirstOrDefault(p => p.Documento == documento);
            if (personaToDelete != null)
            {
                _dbContext.Personas.Remove(personaToDelete);
                _dbContext.SaveChanges();
            }
        }

        public List<Persona> Get()
        {
            return _dbContext.Personas
                             .Select(p => p.getEntity())
                             .ToList();
        }

        public Persona Get(string documento)
        {
            return _dbContext.Personas.FirstOrDefault(p => p.Documento == documento)?.getEntity();
        }

        public void Insert(Persona persona)
        {
            var personaToSave= new Personas
            {
                
                Documento = persona.Documento,
                Nombres = persona.Nombre,
                Apellidos = persona.Apellidos,
                Direccion = persona.Direccion,
                Fechanacimiento = persona.FechaNac,
                Telefono = persona.Telefono
            };

            _dbContext.Personas.Add(personaToSave);
            _dbContext.SaveChanges();
        }

        public void Update(Persona persona)
        {
            var personaToUpdate = _dbContext.Personas.FirstOrDefault(p => p.Documento == persona.Documento);
            if (personaToUpdate != null)
            {
                personaToUpdate.Nombres = persona.Nombre;
                personaToUpdate.Apellidos = persona.Apellidos;
                personaToUpdate.Direccion = persona.Direccion;
                personaToUpdate.Fechanacimiento = persona.FechaNac;
                personaToUpdate.Telefono = persona.Telefono;

                _dbContext.SaveChanges();
            }
        }

        public void AsociarPersonaAVehiculo(string documento, string matricula)
        {
            var persona = _dbContext.Personas.FirstOrDefault(p => p.Documento == documento);
            var vehiculo = _dbContext.Vehiculos.FirstOrDefault(v => v.Matricula == matricula);

            if (persona != null && vehiculo != null)
            {
                vehiculo.Persona = persona;
                _dbContext.SaveChanges();
            }
        }

        public void DesasociarPersonaDeVehiculo(string documento, string matricula)
        {
            var vehiculo = _dbContext.Vehiculos.FirstOrDefault(v => v.Matricula == matricula);

            if (vehiculo != null && vehiculo.Persona != null && vehiculo.Persona.Documento == documento)
            {
                vehiculo.Persona = null;
                _dbContext.SaveChanges();
            }
        }


    }


}





