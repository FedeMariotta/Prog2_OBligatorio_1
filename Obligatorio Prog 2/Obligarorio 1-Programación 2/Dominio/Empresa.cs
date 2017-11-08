using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligarorio_1_Programación_2.Dominio
{
    class Empresa
    {
        #region Declaracion de Listas
        private static List<Persona_Cliente> _listaPersona_Cliente = new List<Persona_Cliente>(); // Creacion de Lista de Clientes
        private static List<Persona_Corredor> _listaPersona_Corredor = new List<Persona_Corredor>(); // Cracion de Lista de Corredores
        private static List<Poliza> _listaPoliza = new List<Poliza>(); // Creacion de la Lista Poliza
        private static List<Relacion_Corredor_Cliente_Poliza> _listaRelacion_Corredor_Cliente_Poliza = new List<Relacion_Corredor_Cliente_Poliza>(); // Creacion de la Lista de ralacion entra Cleinte-Corredor-Poliza
        

        public List<Persona_Cliente> ListaPersona_Cliente() //Declaracion de la lsita como publica para su gestion/modificacion
        {
            return _listaPersona_Cliente;
        }
        public List<Persona_Corredor> ListaPersona_Corredor() //Declaracion de la lsita como publica para su gestion/modificacion
        {
            return _listaPersona_Corredor;
        }
        public List<Poliza> ListaPoliza() //Declaracion de la lsita como publica para su gestion/modificacion
        {
            return _listaPoliza;
        }
        public List<Relacion_Corredor_Cliente_Poliza> ListaRelacion_Corredor_Cliente() //Declaracion de la lsita como publica para su gestion/modificacion
        {
            return _listaRelacion_Corredor_Cliente_Poliza;
        }

        

        #endregion
        #region   ABM Persona_Cliente
        // Buscar Cliente por ID
        // Buscar Cliente por ID
        public Persona_Cliente BuscarPersona_Cliente(short pId)
        {
            foreach (Persona_Cliente unaPersona_Cliente in _listaPersona_Cliente)
            {
                if (unaPersona_Cliente.IdPersona == pId)
                    return unaPersona_Cliente;
            }
            return null;
        }
        //Lista ordenada Cliente
        //Lista ordenada Cliente
        public List<Persona_Cliente> Persona_Cliente_Ordenados()
        {
            List<Persona_Cliente> Persona_Cliente_Ordenados = new List<Persona_Cliente>(_listaPersona_Cliente);
            for (short i = 0; i < Persona_Cliente_Ordenados.Count; i++)
                for (short j = 0; j < Persona_Cliente_Ordenados.Count - 1; j++)
                {
                    if (Persona_Cliente_Ordenados[j].ApellidoPersona.ToUpper().CompareTo(Persona_Cliente_Ordenados[j + 1].ApellidoPersona.ToUpper()) > 0)
                    {
                        Persona_Cliente auxPersona_Cliente = Persona_Cliente_Ordenados[j];
                        Persona_Cliente_Ordenados[j] = Persona_Cliente_Ordenados[j + 1];
                        Persona_Cliente_Ordenados[j + 1] = auxPersona_Cliente;
                    }
                }
            return Persona_Cliente_Ordenados;
        }
        // Alta Cliente
        // Alta Cliente
        public bool AltaPersona_Cliente(Persona_Cliente pPersona_Cliente)
        {
            Persona_Cliente unaPersona_Cliente = BuscarPersona_Cliente(pPersona_Cliente.IdPersona);
            if (unaPersona_Cliente == null)
            {
                _listaPersona_Cliente.Add(pPersona_Cliente);
                return true;
            }
            else
                return false;
        }
        // Baja Cliente
        // Baja Cliente
        public bool BajaCliente(short pid)
        {
            Persona_Cliente unaPersona_Cliente = BuscarPersona_Cliente(pid);
            if (unaPersona_Cliente != null)
            {
                _listaPersona_Cliente.Remove(unaPersona_Cliente);
                return true;
            }
            else
                return false;
        }
        // Modificar Cliente
        // Modificar Cliente
        public bool ModificarPersona_Cliente(short pId, string pNombre, string pApellido, string pDireccion)
        {
            Persona_Cliente unaPersona_Cliente = BuscarPersona_Cliente(pId);
            if (unaPersona_Cliente != null)
            {
                unaPersona_Cliente.NombrePersona = pNombre;
                unaPersona_Cliente.NombrePersona = pApellido;
                unaPersona_Cliente.DireccionPersona = pDireccion;
                return true;
            }
            else
                return false;
        }
        #endregion
        #region   ABM Persona_Corredor
        // Buscar Corredor
        // Buscar Corredor
        public Persona_Corredor BuscarPersona_Corredor(short pId)
        {
            foreach (Persona_Corredor unaPersona_Corredor in _listaPersona_Corredor)
            {
                if (unaPersona_Corredor.IdPersona == pId)
                    return unaPersona_Corredor;
            }
            return null;
        }
        // Persona Corredor Ordenada la Lista
        // Persona Corredor Ordenada la Lista
        public List<Persona_Corredor> Persona_Corredor_Ordenados()
        {
            List<Persona_Corredor> Persona_Corredor_Ordenados = new List<Persona_Corredor>(_listaPersona_Corredor);
            for (short i = 0; i < Persona_Corredor_Ordenados.Count; i++)
                for (short j = 0; j < Persona_Corredor_Ordenados.Count - 1; j++)
                {
                    if (Persona_Corredor_Ordenados[j].ApellidoPersona.ToUpper().CompareTo(Persona_Corredor_Ordenados[j + 1].ApellidoPersona.ToUpper()) > 0)
                    {
                        Persona_Corredor auxProfesor = Persona_Corredor_Ordenados[j];
                        Persona_Corredor_Ordenados[j] = Persona_Corredor_Ordenados[j + 1];
                        Persona_Corredor_Ordenados[j + 1] = auxProfesor;
                    }
                }
            return Persona_Corredor_Ordenados;
        }
        // Alta Corredor
        // Alta Corredor
        public bool AltaPersona_Corredor(Persona_Corredor pPersona_Corredor)
        {
            Persona_Corredor unaPersona_Corredor = this.BuscarPersona_Corredor(pPersona_Corredor.IdPersona);
            if (unaPersona_Corredor == null)
            {
                _listaPersona_Corredor.Add(pPersona_Corredor);
                return true;
            }
            else
                return false;
        }
        // Baja Corredor
        // Baja Corredor
        public bool BajaPersona_Corredor(short pid)
        {
            Persona_Corredor unaPersona_Corredor = this.BuscarPersona_Corredor(pid);
            if (unaPersona_Corredor != null)
            {
                _listaPersona_Corredor.Remove(unaPersona_Corredor);
                return true;
            }
            else
                return false;
        }
        // Modificar Corredor
        // Modificar Corredor
        public bool ModificarPersona_Corredor(short pId, string pNombre, string pApellido, string pDireccion)
        {
            Persona_Corredor unaPersona_Corredor = this.BuscarPersona_Corredor(pId);
            if (unaPersona_Corredor != null)
            {
                unaPersona_Corredor.NombrePersona = pNombre;
                unaPersona_Corredor.ApellidoPersona = pApellido;
                unaPersona_Corredor.DireccionPersona = pDireccion;
                return true;
            }
            else
                return false;
        }
        #endregion
        #region   ABM Polizas
        // Buscar ID poliza
        // Buscar ID poliza
        public Poliza BuscarPoliza(short pId)
        {
            foreach (Poliza unaPoliza in _listaPoliza)
            {
                if (unaPoliza.IdPoliza == pId)
                    return unaPoliza;
            }
            return null;
        }
        // Lista de Polizas Ordenada
        // Lista de Polizas Ordenada
        public List<Poliza> PolizasOrdenados()
        {
            List<Poliza> PolizasOrdenados = new List<Poliza>(_listaPoliza);
            for (short i = 0; i < PolizasOrdenados.Count; i++)
                for (short j = 0; j < PolizasOrdenados.Count - 1; j++)
                {
                    if (!PolizasOrdenados[j].Poliza_Orden_Alfabetico(PolizasOrdenados[j + 1]))
                    {
                        Poliza auxPoliza = PolizasOrdenados[j];
                        PolizasOrdenados[j] = PolizasOrdenados[j + 1];
                        PolizasOrdenados[j + 1] = auxPoliza;
                    }
                }
            return PolizasOrdenados;
        }
        // Alta Poliza
        // Alta Poliza
        public bool AltaPoliza(Poliza pPoliza)
        {
            Poliza unaPoliza = BuscarPoliza(pPoliza.IdPoliza);
            if (unaPoliza == null)
            {
                _listaPoliza.Add(pPoliza);
                return true;
            }
            else
                return false;
        }
        // Baja Poliza
        // Baja Poliza
        public bool BajaPoliza(short pId)
        {
            Poliza unaPoliza = BuscarPoliza(pId);
            if (unaPoliza != null)
            {
                _listaPoliza.Remove(unaPoliza);
                return true;
            }
            else
                return false;
        }
        // Modificar por Fecha de Venc.
        // Modificar por Fecha de Venc.
        public bool ModificarPolizaxFecha(short pId, DateTime pAnoVencePoliza)
        {
            Poliza unaPoliza = BuscarPoliza(pId);
            if (unaPoliza != null)
            {
                unaPoliza.FechaVencimientoPoliza = pAnoVencePoliza;
                return true;
            }
            else
                return false;
        }
        // Modificar Poliza
        // Modificar Poliza
        public bool ModificarPoliza(short id, string nombrePoliza, string tipoPoliza, short precioPoliza, DateTime fechaAdqusiscionPoliza, DateTime fechaVencimientoPoliza)
        {
            Poliza unaPoliza = BuscarPoliza(id);
            if (unaPoliza != null)
            {
                unaPoliza.NombrePoliza = nombrePoliza;
                unaPoliza.TipoPoliza = tipoPoliza;
                unaPoliza.PrecioPoliza = precioPoliza;
                unaPoliza.FechaAdqusiscionPoliza = fechaAdqusiscionPoliza;
                unaPoliza.FechaVencimientoPoliza = fechaVencimientoPoliza;
                return true;
            }
            else
                return false;
        }
        #endregion
        #region Relacion
        // Alta_Relacion_Corredor_Cliente
        // Alta_Relacion_Corredor_Cliente
        public bool Alta_Relacion_Corredor_Cliente_Poliza(Persona_Cliente pPersona_Cliente, Persona_Corredor pPersona_Corredor, Poliza pPoliza)
        {
            if (pPoliza != null && pPersona_Cliente != null && pPersona_Corredor != null)
            {
                Relacion_Corredor_Cliente_Poliza laRelacion_Corredor_Cliente_Poliza = new Relacion_Corredor_Cliente_Poliza(pPersona_Cliente, pPersona_Corredor, pPoliza);
                _listaRelacion_Corredor_Cliente_Poliza.Add(laRelacion_Corredor_Cliente_Poliza);
                return true;
            }
            else
                return false;
        }
        public Relacion_Corredor_Cliente_Poliza BuscarRelacion_Corredor_Cliente_Poliza(short pId)
        {
            foreach (Relacion_Corredor_Cliente_Poliza unaRelacion_Corredor_Cliente_Poliza in _listaRelacion_Corredor_Cliente_Poliza)
            {
                if (unaRelacion_Corredor_Cliente_Poliza.IdClienteR1.IdPersona == pId)
                    return unaRelacion_Corredor_Cliente_Poliza;
            }
            return null;
        }
        public bool Baja_Relacion_Corredor_Cliente_Poliza(short pId1)
        {
            Relacion_Corredor_Cliente_Poliza una_Relacion_Corredor_Cliente_Poliza = BuscarRelacion_Corredor_Cliente_Poliza(pId1);
            if (una_Relacion_Corredor_Cliente_Poliza != null)
            {
                _listaRelacion_Corredor_Cliente_Poliza.Remove(una_Relacion_Corredor_Cliente_Poliza);
                return true;
            }
            else
                return false;
        }
        public bool Modificar_Relacion_Corredor_Cliente_Poliza(short pid1, Persona_Corredor pid2, Poliza pid3, Persona_Cliente a)
        {
            Relacion_Corredor_Cliente_Poliza unaRelacion_Corredor_Cliente_Poliza = BuscarRelacion_Corredor_Cliente_Poliza(pid1);
            if (unaRelacion_Corredor_Cliente_Poliza != null)
            {
                unaRelacion_Corredor_Cliente_Poliza.IdClienteR1 = a;
                unaRelacion_Corredor_Cliente_Poliza.IdCorredorR1 = pid2;
                unaRelacion_Corredor_Cliente_Poliza.IdPoliza1 = pid3;
               
                return true;
            }
            else
                return false;
        }
       #endregion
    }
}
