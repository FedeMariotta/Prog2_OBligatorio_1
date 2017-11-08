using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligarorio_1_Programación_2.Dominio
{
    class Relacion_Corredor_Cliente_Poliza
    {
        private static List<Persona_Cliente> _listaPersona_ClienteR = new List<Persona_Cliente>();
        private static List<Persona_Corredor> _listaPersona_CorredorR = new List<Persona_Corredor>();
        private static List<Poliza> _listaPolizaR = new List<Poliza>();
        
    
        private Persona_Corredor IdCorredorR;
        private Persona_Cliente IdClienteR;
        private Poliza IdPoliza;

        public Persona_Corredor IdCorredorR1 { get => IdCorredorR; set => IdCorredorR = value; }
        public Persona_Cliente IdClienteR1 { get => IdClienteR; set => IdClienteR = value; }
        public Poliza IdPoliza1 { get => IdPoliza; set => IdPoliza = value; }

        public List<Persona_Cliente> Persona_ClienteR()
        {
            return _listaPersona_ClienteR;
        }
        public List<Persona_Corredor> Persona_CorredorR()
        {
            return _listaPersona_CorredorR;
        }
        public List<Poliza> PolizaR()
        {
            return _listaPolizaR;
        }

       
        public Relacion_Corredor_Cliente_Poliza(Persona_Cliente pid1, Persona_Corredor pid2, Poliza pid3 )
        {
            this.IdClienteR = pid1;
            this.IdCorredorR = pid2;
            this.IdPoliza = pid3;
           
        }
        #region To String
        public override string ToString()
        {
            return  IdClienteR.IdPersona + ", Id Corredor: " + IdCorredorR.IdPersona + ", Id Poliza: " + IdPoliza.IdPoliza ;
        }
        #endregion
    }
}
