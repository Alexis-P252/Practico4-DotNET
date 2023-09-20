using DataAccessLayer.EFModels;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.IBLs
{
    public interface IBL_Personas
    {
        List<Persona> Get();

        List<Personas> GetConVehiculos(); 

        Persona Get(string documento);

        Persona Get(int id);

        void Insert(Persona persona);

        void Update(Persona persona);

        void Delete(string documento);

        void AsociarPersonaAVehiculo(string documento, string matricula);

        void DesasociarPersonaDeVehiculo(string documento, string matricula);
    }
}
