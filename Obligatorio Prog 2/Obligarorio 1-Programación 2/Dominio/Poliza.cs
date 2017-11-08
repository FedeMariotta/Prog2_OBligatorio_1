using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligarorio_1_Programación_2.Dominio
{
    class Poliza
    {
        #region Declaracion de Elements de La Poliza
        private short _idPoliza;
        private string _nombrePoliza;
        private string _tipoPoliza; // Automoviles, Casa o Vidas
        private short _precioPoliza;
        private DateTime _fechaVencimientoPoliza;
        private DateTime _fechaAdqusiscionPoliza;

        public short IdPoliza { get => _idPoliza; set => _idPoliza = value; }
        public string NombrePoliza { get => _nombrePoliza; set => _nombrePoliza = value; }
        public string TipoPoliza { get => _tipoPoliza; set => _tipoPoliza = value; }
        public short PrecioPoliza { get => _precioPoliza; set => _precioPoliza = value; }
        public DateTime FechaAdqusiscionPoliza { get => _fechaAdqusiscionPoliza; set => _fechaAdqusiscionPoliza = value; }
        public DateTime FechaVencimientoPoliza { get => _fechaVencimientoPoliza; set => _fechaVencimientoPoliza = value; }

        #endregion
        #region  Creacion de La Poliza (Union de los datos)
        public Poliza(short idPoliza, string nombrePoliza, string tipoPoliza, short precioPoliza, DateTime fechaVencimientoPoliza, DateTime fechaAdqusiscionPoliza)
        {
            this.IdPoliza = idPoliza;
            this.NombrePoliza = nombrePoliza;
            this.TipoPoliza = tipoPoliza;
            this.PrecioPoliza = precioPoliza;
            this.FechaAdqusiscionPoliza = fechaAdqusiscionPoliza;
            this.FechaVencimientoPoliza = fechaVencimientoPoliza;
        }

        #endregion
        #region Escritura y orden de Poliza
        public override string ToString()
        {
            return IdPoliza + ", Nombre: " + this.NombrePoliza + ", Tipo: " + this.TipoPoliza + ", Precio: " + this.PrecioPoliza + " , Adquisicion: " + this.FechaAdqusiscionPoliza + ", Vence:" + this.FechaVencimientoPoliza;
        }
        public bool Poliza_Orden_Alfabetico(Poliza pPoliza)
        {
            return this.NombrePoliza.ToUpper().CompareTo(pPoliza.NombrePoliza.ToUpper()) < 0;

        }

        public static implicit operator Poliza(Persona_Corredor v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
