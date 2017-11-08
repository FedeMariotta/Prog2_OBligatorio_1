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
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
            ListarCliente();
            ListarCorredor();
            ListarPoliza();
            ListarRelacion();
        }
        private void ListarCliente()
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            this.lstCliente.DataSource = null;
            this.lstCliente.DataSource = unaEmpresa.ListaPersona_Cliente();

        }
        private void ListarPoliza()
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            this.lstPoliza.DataSource = null;
            this.lstPoliza.DataSource = unaEmpresa.ListaPoliza();

        }
        private void ListarCorredor()
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            this.lstCorredor.DataSource = null;
            this.lstCorredor.DataSource = unaEmpresa.ListaPersona_Corredor();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ListarCliente();
            ListarCorredor();
            ListarPoliza();
            ListarRelacion();
        }
        private void ListarRelacion()
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            this.lstRelacion.DataSource = null;
            this.lstRelacion.DataSource = unaEmpresa.Relacion_Corredor_Cliente_Poliza_Ordenados();

        }
    }
}
