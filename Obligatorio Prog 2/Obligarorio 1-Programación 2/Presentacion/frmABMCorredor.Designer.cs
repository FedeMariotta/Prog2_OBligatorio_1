namespace Obligarorio_1_Programación_2.Presentacion
{
    partial class frmABMCorredor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCorredor = new System.Windows.Forms.ListBox();
            this.grpAlta = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDireccionCorredor = new System.Windows.Forms.TextBox();
            this.lblConfirmarCliente = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtApellidoCorredor = new System.Windows.Forms.TextBox();
            this.txtNombreCorredor = new System.Windows.Forms.TextBox();
            this.txtIDCorredor = new System.Windows.Forms.TextBox();
            this.lblFVencimiento = new System.Windows.Forms.Label();
            this.lblPPoliza = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grpBaja = new System.Windows.Forms.GroupBox();
            this.lblConfirmarBaja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDBaja = new System.Windows.Forms.TextBox();
            this.btnBajaCorredor = new System.Windows.Forms.Button();
            this.grpAlta.SuspendLayout();
            this.grpBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCorredor
            // 
            this.lstCorredor.FormattingEnabled = true;
            this.lstCorredor.Location = new System.Drawing.Point(12, 254);
            this.lstCorredor.Name = "lstCorredor";
            this.lstCorredor.Size = new System.Drawing.Size(474, 95);
            this.lstCorredor.TabIndex = 27;
            // 
            // grpAlta
            // 
            this.grpAlta.Controls.Add(this.btnModificar);
            this.grpAlta.Controls.Add(this.txtDireccionCorredor);
            this.grpAlta.Controls.Add(this.lblConfirmarCliente);
            this.grpAlta.Controls.Add(this.btnIngresar);
            this.grpAlta.Controls.Add(this.txtApellidoCorredor);
            this.grpAlta.Controls.Add(this.txtNombreCorredor);
            this.grpAlta.Controls.Add(this.txtIDCorredor);
            this.grpAlta.Controls.Add(this.lblFVencimiento);
            this.grpAlta.Controls.Add(this.lblPPoliza);
            this.grpAlta.Controls.Add(this.lblNom);
            this.grpAlta.Controls.Add(this.lblID);
            this.grpAlta.Location = new System.Drawing.Point(12, 12);
            this.grpAlta.Name = "grpAlta";
            this.grpAlta.Size = new System.Drawing.Size(275, 231);
            this.grpAlta.TabIndex = 26;
            this.grpAlta.TabStop = false;
            this.grpAlta.Text = "Alta";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(140, 160);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 27);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.Btn_Modificar);
            // 
            // txtDireccionCorredor
            // 
            this.txtDireccionCorredor.Location = new System.Drawing.Point(121, 124);
            this.txtDireccionCorredor.Name = "txtDireccionCorredor";
            this.txtDireccionCorredor.Size = new System.Drawing.Size(118, 20);
            this.txtDireccionCorredor.TabIndex = 20;
            this.txtDireccionCorredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblConfirmarCliente
            // 
            this.lblConfirmarCliente.AutoSize = true;
            this.lblConfirmarCliente.Location = new System.Drawing.Point(13, 202);
            this.lblConfirmarCliente.Name = "lblConfirmarCliente";
            this.lblConfirmarCliente.Size = new System.Drawing.Size(10, 13);
            this.lblConfirmarCliente.TabIndex = 19;
            this.lblConfirmarCliente.Text = ".";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(9, 160);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(125, 27);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.Btn_Ingresar);
            // 
            // txtApellidoCorredor
            // 
            this.txtApellidoCorredor.Location = new System.Drawing.Point(121, 89);
            this.txtApellidoCorredor.Name = "txtApellidoCorredor";
            this.txtApellidoCorredor.Size = new System.Drawing.Size(118, 20);
            this.txtApellidoCorredor.TabIndex = 8;
            this.txtApellidoCorredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombreCorredor
            // 
            this.txtNombreCorredor.Location = new System.Drawing.Point(121, 54);
            this.txtNombreCorredor.Name = "txtNombreCorredor";
            this.txtNombreCorredor.Size = new System.Drawing.Size(118, 20);
            this.txtNombreCorredor.TabIndex = 7;
            this.txtNombreCorredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtIDCorredor
            // 
            this.txtIDCorredor.Location = new System.Drawing.Point(121, 24);
            this.txtIDCorredor.Name = "txtIDCorredor";
            this.txtIDCorredor.Size = new System.Drawing.Size(118, 20);
            this.txtIDCorredor.TabIndex = 6;
            this.txtIDCorredor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblFVencimiento
            // 
            this.lblFVencimiento.AutoSize = true;
            this.lblFVencimiento.Location = new System.Drawing.Point(6, 131);
            this.lblFVencimiento.Name = "lblFVencimiento";
            this.lblFVencimiento.Size = new System.Drawing.Size(46, 13);
            this.lblFVencimiento.TabIndex = 4;
            this.lblFVencimiento.Text = "Direción";
            // 
            // lblPPoliza
            // 
            this.lblPPoliza.AutoSize = true;
            this.lblPPoliza.Location = new System.Drawing.Point(6, 96);
            this.lblPPoliza.Name = "lblPPoliza";
            this.lblPPoliza.Size = new System.Drawing.Size(44, 13);
            this.lblPPoliza.TabIndex = 2;
            this.lblPPoliza.Text = "Apellido";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 57);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(44, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // grpBaja
            // 
            this.grpBaja.Controls.Add(this.lblConfirmarBaja);
            this.grpBaja.Controls.Add(this.label1);
            this.grpBaja.Controls.Add(this.txtIDBaja);
            this.grpBaja.Controls.Add(this.btnBajaCorredor);
            this.grpBaja.Location = new System.Drawing.Point(298, 12);
            this.grpBaja.Name = "grpBaja";
            this.grpBaja.Size = new System.Drawing.Size(188, 231);
            this.grpBaja.TabIndex = 25;
            this.grpBaja.TabStop = false;
            this.grpBaja.Text = "Baja";
            // 
            // lblConfirmarBaja
            // 
            this.lblConfirmarBaja.AutoSize = true;
            this.lblConfirmarBaja.Location = new System.Drawing.Point(6, 118);
            this.lblConfirmarBaja.Name = "lblConfirmarBaja";
            this.lblConfirmarBaja.Size = new System.Drawing.Size(10, 13);
            this.lblConfirmarBaja.TabIndex = 20;
            this.lblConfirmarBaja.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar corredor por ID";
            // 
            // txtIDBaja
            // 
            this.txtIDBaja.Location = new System.Drawing.Point(9, 55);
            this.txtIDBaja.Name = "txtIDBaja";
            this.txtIDBaja.Size = new System.Drawing.Size(173, 20);
            this.txtIDBaja.TabIndex = 17;
            this.txtIDBaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaja_KeyPress);
            // 
            // btnBajaCorredor
            // 
            this.btnBajaCorredor.Location = new System.Drawing.Point(9, 90);
            this.btnBajaCorredor.Name = "btnBajaCorredor";
            this.btnBajaCorredor.Size = new System.Drawing.Size(173, 25);
            this.btnBajaCorredor.TabIndex = 18;
            this.btnBajaCorredor.Text = "Baja";
            this.btnBajaCorredor.UseVisualStyleBackColor = true;
            this.btnBajaCorredor.Click += new System.EventHandler(this.Btn_Baja);
            // 
            // frmABMCorredor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 361);
            this.Controls.Add(this.lstCorredor);
            this.Controls.Add(this.grpAlta);
            this.Controls.Add(this.grpBaja);
            this.Name = "frmABMCorredor";
            this.Text = "Corredor";
            this.grpAlta.ResumeLayout(false);
            this.grpAlta.PerformLayout();
            this.grpBaja.ResumeLayout(false);
            this.grpBaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCorredor;
        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtDireccionCorredor;
        private System.Windows.Forms.Label lblConfirmarCliente;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtApellidoCorredor;
        private System.Windows.Forms.TextBox txtNombreCorredor;
        private System.Windows.Forms.TextBox txtIDCorredor;
        private System.Windows.Forms.Label lblFVencimiento;
        private System.Windows.Forms.Label lblPPoliza;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grpBaja;
        private System.Windows.Forms.Label lblConfirmarBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDBaja;
        private System.Windows.Forms.Button btnBajaCorredor;
    }
}