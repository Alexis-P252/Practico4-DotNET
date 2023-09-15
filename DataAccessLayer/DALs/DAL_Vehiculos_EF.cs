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
    public class DAL_Vehiculos_EF : IDAL_Vehiculos
    {
        private DBContextCore _dbContext;

        public DAL_Vehiculos_EF(DBContextCore dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(string matricula)
        {
            var vehiculoToDelete = _dbContext.Vehiculos.FirstOrDefault(v => v.Matricula== matricula);
            if (vehiculoToDelete != null)
            {
                _dbContext.Vehiculos.Remove(vehiculoToDelete);
                _dbContext.SaveChanges();
            }
        }

        public List<Vehiculo> Get()
        {
            return _dbContext.Vehiculos
                             .Select(v => v.getEntity())
                             .ToList();
        }

        public Vehiculo Get(string matricula)
        {
            return _dbContext.Vehiculos.FirstOrDefault(v => v.Matricula == matricula)?.getEntity();
        }

        public void Insert(Vehiculo vehiculo)
        {
            var vehiculoToSave = new Vehiculos
            {
                Matricula = vehiculo.Matricula,
                Marca = vehiculo.Marca,
                Modelo  = vehiculo.Modelo,

     
            };

            _dbContext.Vehiculos.Add(vehiculoToSave);
            _dbContext.SaveChanges();
        }

        public void Update(Vehiculo vehiculo)
        {
            var vehiculoToUpdate = _dbContext.Vehiculos.FirstOrDefault(v => v.Matricula == vehiculo.Matricula);
            if (vehiculoToUpdate != null)
            {
                vehiculoToUpdate.Marca = vehiculo.Marca;
                vehiculoToUpdate.Modelo = vehiculo.Modelo;
                

                _dbContext.SaveChanges();
            }
        }

        public List<Vehiculo> GetVehiculosByDocumento(string documento)
        {
            return _dbContext.Vehiculos
                             .Where(v => v.Persona.Documento == documento)
                             .Select(v => v.getEntity())
                             .ToList();
        }
    }
}





