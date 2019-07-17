using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WctDb.Models;

namespace WcfServiceLibrary1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public Service1()
        {

        }



        public bool InsertarPersona(Persona p)
        {
            var modelMantenedor = new PersonaModel();
            try
            {
                modelMantenedor.PersonaInsertar(p.Nombre, p.Apellidos, p.Rut, p.DvRut.ToString(), p.Edad, p.Correo, p.Direccion);
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public Persona SeleccionarPersonaPorId(Persona p)
        {

            Persona objP = new Persona();
            var modelMantenedor = new PersonaModel();
    
            try
            {
                var lista  = modelMantenedor.obtenerPersonaPorId(p.Id);
                foreach (var item in lista)
                {
                    objP.Id = Convert.ToInt32(item.Id);
                    objP.Nombre = item.Nombre;
                    objP.Apellidos = item.Apellidos;
                    objP.Rut = Convert.ToInt32(item.Rut);
                    objP.DvRut = Convert.ToChar(item.DvRut);
                    objP.Edad = Convert.ToInt32(item.Edad);
                    objP.Direccion = item.Direccion;
                    objP.Correo = item.Correo;


                }
            
                return objP;

            }
            catch (Exception)
            {

                return objP;
            }
        }

        public bool ActualizarPersona(Persona p)
        {
            var modelMantenedor = new PersonaModel();
            try
            {
                modelMantenedor.PersonaActualizar(p.Id,p.Nombre, p.Apellidos, p.Rut, p.DvRut.ToString(), p.Edad, p.Correo, p.Direccion);
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool EliminarPersona(Persona p)
        {
            var modelMantenedor = new PersonaModel();
            try
            {
                modelMantenedor.PersonaEliminar(p.Id);
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public List<Persona> SeleccionarPersonas()
        {
            List<Persona> listaP = new List<Persona>();
            var modelMantenedor = new PersonaModel();

            try
            {
                var lista = modelMantenedor.obtenerPersonas();
                foreach (var item in lista)
                {
                    Persona objP = new Persona();
                    objP.Id = Convert.ToInt32(item.Id);
                    objP.Nombre = item.Nombre;
                    objP.Apellidos = item.Apellidos;
                    objP.Rut = Convert.ToInt32(item.Rut);
                    objP.DvRut = Convert.ToChar(item.DvRut);
                    objP.Edad = Convert.ToInt32(item.Edad);
                    objP.Direccion = item.Direccion;
                    objP.Correo = item.Correo;
                    listaP.Add(objP);

                }

                return listaP;

            }
            catch (Exception)
            {

                return listaP;
            }
        }
    }
}
