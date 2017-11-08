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
    public partial class frmABMPoliza : Form
    {
        public frmABMPoliza()
        {
            InitializeComponent();
            ListarPoliza();
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
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && !(Char.IsSeparator(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.txtIDPoliza.Clear();
            this.txtNombrePoliza.Clear();
            this.txtIDPoliza.Focus();
        }
        private void ListarPoliza()
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            this.lstPoliza.DataSource = null;
            this.lstPoliza.DataSource = unaEmpresa.PolizasOrdenados();

        }

        #endregion
        #region ABM POLIZA
        // Ingresar BTN
        // Ingresar BTN
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short Id = short.Parse(this.txtIDPoliza.Text);
            Dominio.Poliza laPoliza = unaEmpresa.BuscarPoliza(Id);
            if (laPoliza == null && (rdbAutomoviles.Checked == true || rdbCasa.Checked == true || rdbVida.Checked == true))
            {
                string nombrePoliza = this.txtNombrePoliza.Text;
                string tipoPoliza = "";
                short precioPoliza = short.Parse(this.txtPrecioPoliza.Text);
                if (rdbAutomoviles.Checked == true)
                {
                    tipoPoliza = "Automoviles";
                    this.rdbAutomoviles.Checked = false;
                }
                if (rdbCasa.Checked == true)
                {
                    tipoPoliza = "Casa";
                    this.rdbCasa.Checked = false;
                }
                if (rdbVida.Checked == true)
                {
                    tipoPoliza = "Vida";
                    this.rdbVida.Checked = false;
                }
                DateTime fechaAdqusiscionPoliza = this.dateTimePickerAdquisicion.Value.Date;
                DateTime fechaVencimientoPoliza = this.dateTimePickerVencimiento.Value.Date;
                Dominio.Poliza unaPoliza = new Dominio.Poliza(Id, nombrePoliza, tipoPoliza, precioPoliza, fechaAdqusiscionPoliza, fechaVencimientoPoliza);
                if (unaEmpresa.AltaPoliza(unaPoliza))
                {
                    this.Limpiar();
                    this.ListarPoliza();
                    this.lblConfirmarPoliza.Text = "Ingreso con Exito";
                    this.txtPrecioPoliza.Clear();
                    this.dateTimePickerAdquisicion.Update(); // Limpiar
                    this.dateTimePickerVencimiento.Update();
                }
            }
            else
            {
                this.lblConfirmarPoliza.Text = "Error";
            }
        }
        // Baja BTN
        // Baja BTN
        private void BtnBajaPoliza_Click(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short ID = short.Parse(this.txtIDBaja.Text);
            if (unaEmpresa.BuscarPoliza(ID) == null)
            {
                this.lblConfirmarBaja.Text = "Error";
            }
            else
            {
                unaEmpresa.BajaPoliza(ID);
                this.lblConfirmarBaja.Text = "Poliza eliminada con exito";
                ListarPoliza();
                txtIDBaja.Clear();
            }
        }
        //Modificar BTN
        // Modificar BTN
        private void Button1_Click(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short Id = short.Parse(this.txtIDPoliza.Text);
            Dominio.Poliza laPoliza = unaEmpresa.BuscarPoliza(Id);
            if (laPoliza != null && (rdbAutomoviles.Checked == true || rdbCasa.Checked == true || rdbVida.Checked == true))
            {
                string nombrePoliza = this.txtNombrePoliza.Text;
                string tipoPoliza = "";
                short precioPoliza = short.Parse(this.txtPrecioPoliza.Text);
                if (rdbAutomoviles.Checked == true)
                {
                    tipoPoliza = "Automoviles";
                    this.rdbAutomoviles.Checked = false;
                }
                if (rdbCasa.Checked == true)
                {
                    tipoPoliza = "Casa";
                    this.rdbCasa.Checked = false;
                }
                if (rdbVida.Checked == true)
                {
                    tipoPoliza = "Vida";
                    this.rdbVida.Checked = false;
                }
                DateTime fechaAdqusiscionPoliza = this.dateTimePickerAdquisicion.Value.Date;
                DateTime fechaVencimientoPoliza = this.dateTimePickerVencimiento.Value.Date;
                if (unaEmpresa.ModificarPoliza(Id, nombrePoliza, tipoPoliza, precioPoliza, fechaAdqusiscionPoliza, fechaVencimientoPoliza))
                {
                    this.Limpiar();
                    this.ListarPoliza();
                    this.txtPrecioPoliza.Clear();
                    this.lblConfirmarPoliza.Text = "Modificacion con Exito";
                    fechaVencimientoPoliza = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0); // extraido de: https://stackoverflow.com/questions/1282366/how-to-reset-the-time-of-datetimepicker-in-c-sharp 
                    fechaVencimientoPoliza = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0); // extraido de: https://stackoverflow.com/questions/1282366/how-to-reset-the-time-of-datetimepicker-in-c-sharp
                }
            }
        }
        #endregion
    }
}