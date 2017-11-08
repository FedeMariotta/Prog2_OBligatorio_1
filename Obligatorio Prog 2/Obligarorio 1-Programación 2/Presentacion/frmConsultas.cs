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
    public partial class frmConsultas : Form
    {
       

        public frmConsultas()
        {
            InitializeComponent();
        }



        private void btnConsulta1_Click_1(object sender, EventArgs e)
        {
            Dominio.Empresa unaEmpresa = new Dominio.Empresa();
            short pid1 = short.Parse(this.txtIDCliente.Text);
            Dominio.Relacion_Corredor_Cliente_Poliza unaRelacion_Corredor_Cliente_Poliza = unaEmpresa.BuscarRelacion_Corredor_Cliente_Poliza(pid1);
            if (unaRelacion_Corredor_Cliente_Poliza != null)
            {
                foreach (Dominio.Persona_Corredor unaPersonaCorredor in unaEmpresa.ListaPersona_Corredor())
                {
                    if (unaPersonaCorredor.IdPersona == pid1)
                        this.lblCorredor.Text = unaPersonaCorredor.ToString();
                }
                

            }
            else
            {
                this.lblCorredor.Text = "Error";

            }
        }
    }
}
