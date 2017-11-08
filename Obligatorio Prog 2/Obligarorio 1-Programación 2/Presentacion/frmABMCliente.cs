using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligarorio_1_Programación_2.Presentacion
{
    public partial class frmABMCliente : Form
    {
        public frmABMCliente()
        {
            InitializeComponent();
            ListarCliente();
        }

        #region testeo de las entradas
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(Char.IsSeparator(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsSeparator(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && !(Char.IsSeparator(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        
        private void txtBaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(Char.IsSeparator(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        #endregion
        #region Metodos auxiliares
        private void Limpiar()
        {
            this.txtIDCliente.Clear();
            this.txtNombreCliente.Clear();
            this.txtApellidoCliente.Clear();
            this.txtDireccionCliente.Clear();
            this.txtIDCliente.Focus();
        }
        private void ListarCliente()
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            this.lstCliente.DataSource = null;
            this.lstCliente.DataSource = unaEmpresa.Persona_Cliente_Ordenados();

        }

        #endregion
        #region ABM
        // Ingresar BTN
        // Ingresar BTN
       
        // Modificar BTN
        // Modificar BTN
        private void Btn_Modificar(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short Id = short.Parse(this.txtIDCliente.Text);
            if (unaEmpresa.BuscarPersona_Cliente(Id) != null)
            {
                string nombrePersona = this.txtNombreCliente.Text;
                string apellidoPersona = this.txtApellidoCliente.Text;
                string direccionPersona = this.txtDireccionCliente.Text;
                unaEmpresa.ModificarPersona_Cliente(Id, nombrePersona, apellidoPersona, direccionPersona);
                this.Limpiar();
                this.ListarCliente();
                this.lblConfirmarCliente.Text = "Ingreso con Exito";
            }

            else
            {
                this.lblConfirmarCliente.Text = "Error";

            }
        }
        // Baja
        // Baja
        private void Btn_Baja(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short ID = short.Parse(this.txtIDBaja.Text);
            if (unaEmpresa.BuscarPersona_Cliente(ID) == null)
            {
                this.lblConfirmarBaja.Text = "Error";
            }
            else
            {
                unaEmpresa.BajaCliente(ID);
                this.lblConfirmarBaja.Text = "Cliente eliminada con exito";
                ListarCliente();
                txtIDBaja.Clear();
            }
        }

        #endregion

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short Id = short.Parse(this.txtIDCliente.Text);
            Dominio.Persona_Cliente unaPersona_Cliente = unaEmpresa.BuscarPersona_Cliente(Id);
            if (unaPersona_Cliente == null)
            {
                string nombrePersona = this.txtNombreCliente.Text;
                string apellidoPersona = this.txtApellidoCliente.Text;
                string direccionPersona = this.txtDireccionCliente.Text;

                Dominio.Persona_Cliente laPersona_Cliente = new Dominio.Persona_Cliente(Id, nombrePersona, apellidoPersona, direccionPersona);
                if (unaEmpresa.AltaPersona_Cliente(laPersona_Cliente))
                {
                    this.Limpiar();
                    this.ListarCliente();
                    this.lblConfirmarCliente.Text = "Ingreso con Exito";
                }
            }
            else
            {
                this.lblConfirmarCliente.Text = "Error";

            }
        }
    }
}