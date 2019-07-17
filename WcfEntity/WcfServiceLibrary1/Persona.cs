using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    public class Persona
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Apellidos { get; set; }

        [DataMember]
        public int Rut { get; set; }

        [DataMember]
        public char DvRut { get; set; }

        [DataMember]
        public int Edad { get; set; }

        [DataMember]
        public string Direccion { get; set; }

        [DataMember]
        public string Correo { get; set; }
    }
}
