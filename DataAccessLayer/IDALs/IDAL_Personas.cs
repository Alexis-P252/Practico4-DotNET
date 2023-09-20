using DataAccessLayer.EFModels;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IDALs
{
    public interface IDAL_Personas
    {
        List<Persona> Get();

        Persona Get(string documento);

        Persona Get(int id);

        public List<Personas> GetConVehiculos();

        void Insert(Persona persona);

        void Update(Persona persona);

        void Delete(string documento);

        void AsociarPersonaAVehiculo(string documento, string matricula);

        void DesasociarPersonaDeVehiculo(string documento, string matricula);
    }
}
