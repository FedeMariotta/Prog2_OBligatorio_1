using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obligarorio_1_Programación_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region patrón singleton
        private void Singleton(string pformularioHijo)
        {
            bool encontrado = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name.Equals(pformularioHijo))
                {
                    encontrado = true;
                    form.Activate();
                }
            }

            if (!encontrado)
            {
                switch (pformularioHijo)
                {
                    case "frmABMPoliza":
                        Presentacion.frmABMPoliza unFrmABMPoliza = new Presentacion.frmABMPoliza
                        {
                            MdiParent = this
                        };
                        unFrmABMPoliza.Show();
                        break;
                    case "frmABMCliente":
                        Presentacion.frmABMCliente unFrmABMCliente = new Presentacion.frmABMCliente
                        {
                            MdiParent = this
                        };
                        unFrmABMCliente.Show();
                        break;
                    case "frmABMCorredor":
                        Presentacion.frmABMCorredor unFrmABMCorredor = new Presentacion.frmABMCorredor
                        {
                            MdiParent = this
                        };
                        unFrmABMCorredor.Show();
                        break;
                    case "frmRelacionClienteCorredor":
                        Presentacion.frmRelacionClienteCorredor unFrmRelacionClienteCorredor = new Presentacion.frmRelacionClienteCorredor
                        {
                            MdiParent = this
                        };
                        unFrmRelacionClienteCorredor.Show();
                        break;
                    case "frmConsultas":
                        Presentacion.frmConsultas unFrmConsultas = new Presentacion.frmConsultas
                        {
                            MdiParent = this
                        };
                        unFrmConsultas.Show();
                        break;
                    case "frmListar":
                        Presentacion.FrmListar unFrmListar = new Presentacion.FrmListar
                        {
                            MdiParent = this
                        };
                        unFrmListar.Show();
                        break;
                   
                }
            }
        }
        #endregion

        private void PolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFrmHijo = "frmABMPoliza";
            Singleton(nombreFrmHijo);
        }
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFrmHijo = "frmABMCliente";
            Singleton(nombreFrmHijo);
        }

        private void CorredorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFrmHijo = "frmABMCorredor";
            Singleton(nombreFrmHijo);
        }

        private void RelaciónCorredorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFrmHijo = "frmRelacionClienteCorredor";
            Singleton(nombreFrmHijo);
        }
        private void consutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFrmHijo = "frmConsultas";
            Singleton(nombreFrmHijo);
        }
        private void ListarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreFrmHijo = "frmListar";
            Singleton(nombreFrmHijo);
        }

        private void Function_Salir(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

/*  
        static short ppid = 1;
        static Random auxnota = new Random();
        static short ppid1 = 1;
        static Random auxnota1 = new Random();
        static short ppid2 = 1;
        static Random auxnota2 = new Random();

    private void Agragar_datos(object sender, EventArgs e)
        {
            short id = ppid;
            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            Random obj = new Random();
            int longitud = posibles.Length;
            char letra1;
            char letra2;
            char letra3;
            int longitudnuevacadena = 8;
            for (int a = 0; a < 100; a++)
            {
                string nuevacadena1 = "";
                for (int i = 0; i < longitudnuevacadena; i++)
                {
                    letra1 = posibles[obj.Next(longitud)];
                    nuevacadena1 += letra1.ToString();
                }
                string nuevacadena2 = "";
                for (int i = 0; i < longitudnuevacadena; i++)
                {
                    letra2 = posibles[obj.Next(longitud)];
                    nuevacadena2 += letra2.ToString();
                }

                string nuevacadena3 = "";
                for (int i = 0; i < longitudnuevacadena; i++)
                {
                    letra3 = posibles[obj.Next(longitud)];
                    nuevacadena3 += letra3.ToString();
                }

                Dominio.Empresa unaEmpresa = new Dominio.Empresa();
                string apellido = nuevacadena1;
                string nombre = nuevacadena2;
                string direccion = nuevacadena3;
                int Nota = auxnota.Next(0, 101);
                Dominio.Persona_Corredor unEmpleado = new Dominio.Persona_Corredor(id, apellido, nombre, direccion);
                unaEmpresa.AltaPersona_Corredor(unEmpleado);
                id++;
                ppid = id;
                // // // // //
                short id1 = ppid;
                for (int qw = 0; qw < 100; a++)
                {

                    for (int i = 0; i < longitudnuevacadena; i++)
                    {
                        letra1 = posibles[obj.Next(longitud)];
                        nuevacadena1 += letra1.ToString();
                    }
                    for (int i = 0; i < longitudnuevacadena; i++)
                    {
                        letra2 = posibles[obj.Next(longitud)];
                        nuevacadena2 += letra2.ToString();
                    }

                    for (int i = 0; i < longitudnuevacadena; i++)
                    {
                        letra3 = posibles[obj.Next(longitud)];
                        nuevacadena3 += letra3.ToString();
                    }

                    Dominio.Empresa unaEmpresa2 = new Dominio.Empresa();
                    string apellido1 = nuevacadena1;
                    string nombre1 = nuevacadena2;
                    string direccion1 = nuevacadena3;
                    Dominio.Persona_Corredor unEmpleado1 = new Dominio.Persona_Corredor(id1, apellido1, nombre1, direccion1);
                    unaEmpresa.AltaPersona_Corredor(unEmpleado);
                    id1++;
                    ppid1 = id1;
                }
            }
     */
