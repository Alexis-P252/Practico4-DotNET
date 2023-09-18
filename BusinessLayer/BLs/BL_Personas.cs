using BusinessLayer.IBLs;
using DataAccessLayer.IDALs;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BLs
{
    public class BL_Personas : IBL_Personas
    {
        private IDAL_Personas _personas;

        public BL_Personas(IDAL_Personas personas)
        {
            _personas = personas;
        }

        public List<Persona> Get()
        {
            return _personas.Get();
        }

        public Persona Get(string documento)
        {
            return _personas.Get(documento);
        }

        public Persona Get(int id)
        {
            return _personas.Get(id);
        }

        public void Insert(Persona persona)
        {
            _personas.Insert(persona);
        }

        public void Update(Persona persona)
        {
            _personas.Update(persona);
        }

        public void Delete(string documento)
        {
            _personas.Delete(documento);
        }

        void IBL_Personas.AsociarPersonaAVehiculo(string documento, string matricula)
        {
            _personas.AsociarPersonaAVehiculo(documento, matricula);
        }

        void IBL_Personas.DesasociarPersonaDeVehiculo(string documento, string matricula)
        {
            _personas.DesasociarPersonaDeVehiculo(documento, matricula);
        }
    }
}
