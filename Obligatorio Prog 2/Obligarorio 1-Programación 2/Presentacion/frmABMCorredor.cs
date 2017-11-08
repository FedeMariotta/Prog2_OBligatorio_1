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
    public partial class frmABMCorredor : Form
    {
        public frmABMCorredor()
        {
            InitializeComponent();
            ListarCorredor();
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
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
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
            this.txtIDCorredor.Clear();
            this.txtNombreCorredor.Clear();
            this.txtApellidoCorredor.Clear();
            this.txtDireccionCorredor.Clear();
            this.txtIDCorredor.Focus();
        }
        private void ListarCorredor()
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            this.lstCorredor.DataSource = null;
            this.lstCorredor.DataSource = unaEmpresa.Persona_Corredor_Ordenados();

        }

        #endregion
        #region ABM
        // Ingresar BTN
        // Ingresar BTN
        private void Btn_Ingresar(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short Id = short.Parse(this.txtIDCorredor.Text);
            Dominio.Persona_Corredor unaPersona_Corredor = unaEmpresa.BuscarPersona_Corredor(Id);
            if (unaPersona_Corredor == null)
            {
                string nombrePersona = this.txtNombreCorredor.Text;
                string apellidoPersona = this.txtApellidoCorredor.Text;
                string direccionPersona = this.txtDireccionCorredor.Text;

                Dominio.Persona_Corredor laPersona_Corredor = new Dominio.Persona_Corredor(Id, nombrePersona, apellidoPersona, direccionPersona);
                if (unaEmpresa.AltaPersona_Corredor(laPersona_Corredor))
                {
                    this.Limpiar();
                    this.ListarCorredor();
                    this.lblConfirmarCliente.Text = "Ingreso con Exito";
                }
            }
            else
            {
                this.lblConfirmarCliente.Text = "Error";

            }
        }
        // Modificar BTN
        // Modificar BTN
        private void Btn_Modificar(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short Id = short.Parse(this.txtIDCorredor.Text);
            if (unaEmpresa.BuscarPersona_Corredor(Id) != null)
            {
                string nombrePersona = this.txtNombreCorredor.Text;
                string apellidoPersona = this.txtApellidoCorredor.Text;
                string direccionPersona = this.txtDireccionCorredor.Text;
                unaEmpresa.ModificarPersona_Corredor(Id, nombrePersona, apellidoPersona, direccionPersona);
                this.Limpiar();
                this.ListarCorredor();
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
            if (unaEmpresa.BuscarPersona_Corredor(ID) == null)
            {
                this.lblConfirmarBaja.Text = "Error";
            }
            else
            {
                unaEmpresa.BajaPersona_Corredor(ID);
                this.lblConfirmarBaja.Text = "Corredor eliminada con exito";
                ListarCorredor();
                txtIDBaja.Clear();
            }
        }
        #endregion
    }
}