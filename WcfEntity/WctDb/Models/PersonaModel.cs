using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WctDb.Models.Resources;

namespace WctDb.Models
{
    public class PersonaModel
    {
        private readonly Models.Resources.WcfPersonaEntities db = new Models.Resources.WcfPersonaEntities();

        public bool PersonaInsertar(string nombres, string apellidos, int rut, string dvrut, int edad, string direccion, string correo)
        {
            try
            {

                db.InsertarPersona(nombres, apellidos, rut, dvrut, edad, direccion, correo);
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("AccesoToDb.Models (IngresarPersona): " + ex.Message);
                return false;
            }
        }

        public List<Persona> obtenerPersonaPorId(int personaId)
        {

            List<Persona> lista = new List<Persona>();
            try
            {

                var persona = db.Persona.Where(p => p.Id == personaId);   
                foreach (var Persona in persona)
                {

                    lista.Add(Persona);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("AccesoToDb.Models (obtenerPersonaPorId): " + ex.Message);
                lista = new List<Persona>();
            }
            return lista;
        }

        public bool PersonaActualizar(int Id,string nombres, string apellidos, int rut, string dvrut, int edad, string direccion, string correo)
        {
            try
            {

                db.ActualizarPersona(Id,nombres, apellidos, rut, dvrut, edad, direccion, correo);
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("AccesoToDb.Models (PersonaActualizar): " + ex.Message);
                return false;
            }
        }

        public bool PersonaEliminar(int Id)
        {
            try
            {

                db.EliminarPersona(Id);
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("AccesoToDb.Models (PersonaEliminar): " + ex.Message);
                return false;
            }
        }

        public List<Persona> obtenerPersonas()
        {
            List<Persona> lista = new List<Persona>();
            try
            {

                var personas = db.Persona.ToList();
                foreach (var persona in personas)
                {

                    lista.Add(persona);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("AccesoToDb.Models (PersonaEliminar): " + ex.Message);
                lista = new List<Persona>();
            }
            return lista;
        }
    }
}
