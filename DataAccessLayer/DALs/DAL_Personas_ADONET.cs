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
    public class DAL_Personas_ADONET : IDAL_Personas
    {
        public void Delete(string documento)
        {
            throw new NotImplementedException();
        }

        public List<Persona> Get()
        {
            throw new NotImplementedException();
        }

        public Persona Get(string documento)
        {
            throw new NotImplementedException();
        }

        public void Insert(Persona persona)
        {
            throw new NotImplementedException();
        }

        public void Update(Persona persona)
        {
            throw new NotImplementedException();
        }

        void IDAL_Personas.AsociarPersonaAVehiculo(string documento, string matricula)
        {
            throw new NotImplementedException();
        }

        void IDAL_Personas.DesasociarPersonaDeVehiculo(string documento, string matricula)
        {
            throw new NotImplementedException();
        }

        Persona IDAL_Personas.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Personas> IDAL_Personas.GetConVehiculos()
        {
            throw new NotImplementedException();
        }
    }
}
