using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligarorio_1_Programación_2.Dominio
{
    class Persona
    {
        #region Declaracion de Elementos de Persona
        private short _idPersona;
        private string _nombrePersona;
        private string _apellidoPersona;
        private string _direccionPersona;

        public short IdPersona { get => _idPersona; set => _idPersona = value; }
        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }
        public string ApellidoPersona { get => _apellidoPersona; set => _apellidoPersona = value; }
        public string DireccionPersona { get => _direccionPersona; set => _direccionPersona = value; }
        #endregion
        #region Creacion de los elementos de Persona
        public Persona(short idPersona, string nombrePersona, string apellidoPersona, string direccionPersona)
        {
            _idPersona = idPersona;
            _nombrePersona = nombrePersona;
            _apellidoPersona = apellidoPersona;
            _direccionPersona = direccionPersona;
        }
        #endregion
        #region To String
        public override string ToString()
        {
            return IdPersona + ", Apellido: "+ApellidoPersona+", Nombre: "+NombrePersona+", Direccion: "+DireccionPersona;
        }
        #endregion
    }
}
