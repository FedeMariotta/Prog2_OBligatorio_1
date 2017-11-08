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
    public partial class frmRelacionClienteCorredor : Form
    {
        public frmRelacionClienteCorredor()
        {
            InitializeComponent();
        }

        private void ListarRelacion()
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            this.lstRelacion.DataSource = null;
            this.lstRelacion.DataSource = unaEmpresa.Relacion_Corredor_Cliente_Poliza_Ordenados();

        }
        private void btnRelacionar_Click(object sender, EventArgs e)
        {
            
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short Id1 = short.Parse(this.txtIDCliente.Text);
            short Id2 = short.Parse(this.txtIDCorredor.Text);
            short Id3 = short.Parse(this.txtIDPoliza.Text);
            Dominio.Relacion_Corredor_Cliente_Poliza unaRelacion_Corredor_Cliente_Poliza = new Dominio.Relacion_Corredor_Cliente_Poliza(Id1, Id2, Id3);
            if (unaEmpresa.BuscarRelacion_Corredor_Cliente_Poliza(Id1) == null)
            {
                if (unaEmpresa.Alta_Relacion_Corredor_Cliente_Poliza(Id1, Id2, Id3))
                {
                    this.txtIDCliente.Clear();
                    this.txtIDCorredor.Clear();
                    this.txtIDPoliza.Clear();
                }
                this.lblConfirmar.Text = "Ingreso con Exito";
                this.ListarRelacion();
               
            }
            else
            {
                this.lblConfirmar.Text = "Error";

            }
        }
    }
}
                                            
