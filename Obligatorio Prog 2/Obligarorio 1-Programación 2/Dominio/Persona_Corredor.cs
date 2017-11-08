using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligarorio_1_Programación_2.Dominio
{
    class Persona_Corredor : Persona
    {
        public Persona_Corredor(short idPersona, string nombrePersona, string apellidoPersona, string direccionPersona)
             : base(idPersona, nombrePersona, apellidoPersona, direccionPersona)
        {
        }
        public override string ToString()
        {
            return IdPersona + ", Apellido: " + ApellidoPersona + ", Nombre: " + NombrePersona + ", Direccion: " + DireccionPersona;
        }
    }
}
