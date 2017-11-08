namespace Obligarorio_1_Programación_2.Presentacion
{
    partial class frmABMCliente
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
            this.grpAlta = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblConfirmarCliente = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.lblFVencimiento = new System.Windows.Forms.Label();
            this.lblPPoliza = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grpBaja = new System.Windows.Forms.GroupBox();
            this.lblConfirmarBaja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDBaja = new System.Windows.Forms.TextBox();
            this.btnBajaCiente = new System.Windows.Forms.Button();
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.grpAlta.SuspendLayout();
            this.grpBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlta
            // 
            this.grpAlta.Controls.Add(this.btnModificar);
            this.grpAlta.Controls.Add(this.txtDireccionCliente);
            this.grpAlta.Controls.Add(this.lblConfirmarCliente);
            this.grpAlta.Controls.Add(this.btnIngresar);
            this.grpAlta.Controls.Add(this.txtApellidoCliente);
            this.grpAlta.Controls.Add(this.txtNombreCliente);
            this.grpAlta.Controls.Add(this.txtIDCliente);
            this.grpAlta.Controls.Add(this.lblFVencimiento);
            this.grpAlta.Controls.Add(this.lblPPoliza);
            this.grpAlta.Controls.Add(this.lblNom);
            this.grpAlta.Controls.Add(this.lblID);
            this.grpAlta.Location = new System.Drawing.Point(12, 12);
            this.grpAlta.Name = "grpAlta";
            this.grpAlta.Size = new System.Drawing.Size(275, 239);
            this.grpAlta.TabIndex = 23;
            this.grpAlta.TabStop = false;
            this.grpAlta.Text = "Alta";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(147, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 27);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.Btn_Modificar);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(121, 124);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(118, 20);
            this.txtDireccionCliente.TabIndex = 20;
            
            // 
            // lblConfirmarCliente
            // 
            this.lblConfirmarCliente.AutoSize = true;
            this.lblConfirmarCliente.Location = new System.Drawing.Point(14, 218);
            this.lblConfirmarCliente.Name = "lblConfirmarCliente";
            this.lblConfirmarCliente.Size = new System.Drawing.Size(10, 13);
            this.lblConfirmarCliente.TabIndex = 19;
            this.lblConfirmarCliente.Text = ".";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(16, 188);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(125, 27);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(121, 89);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(118, 20);
            this.txtApellidoCliente.TabIndex = 8;
            this.txtApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(121, 54);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(118, 20);
            this.txtNombreCliente.TabIndex = 7;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(121, 24);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(118, 20);
            this.txtIDCliente.TabIndex = 6;
            this.txtIDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
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
            this.grpBaja.Controls.Add(this.btnBajaCiente);
            this.grpBaja.Location = new System.Drawing.Point(301, 12);
            this.grpBaja.Name = "grpBaja";
            this.grpBaja.Size = new System.Drawing.Size(188, 239);
            this.grpBaja.TabIndex = 22;
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
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar cliente por ID";
            // 
            // txtIDBaja
            // 
            this.txtIDBaja.Location = new System.Drawing.Point(9, 55);
            this.txtIDBaja.Name = "txtIDBaja";
            this.txtIDBaja.Size = new System.Drawing.Size(173, 20);
            this.txtIDBaja.TabIndex = 17;
            this.txtIDBaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaja_KeyPress);
            // 
            // btnBajaCiente
            // 
            this.btnBajaCiente.Location = new System.Drawing.Point(9, 90);
            this.btnBajaCiente.Name = "btnBajaCiente";
            this.btnBajaCiente.Size = new System.Drawing.Size(173, 25);
            this.btnBajaCiente.TabIndex = 18;
            this.btnBajaCiente.Text = "Baja";
            this.btnBajaCiente.UseVisualStyleBackColor = true;
            this.btnBajaCiente.Click += new System.EventHandler(this.Btn_Baja);
            // 
            // lstCliente
            // 
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(14, 257);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(474, 95);
            this.lstCliente.TabIndex = 24;
            // 
            // frmABMCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 359);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.grpAlta);
            this.Controls.Add(this.grpBaja);
            this.Name = "frmABMCliente";
            this.Text = "Cliente";
            this.grpAlta.ResumeLayout(false);
            this.grpAlta.PerformLayout();
            this.grpBaja.ResumeLayout(false);
            this.grpBaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.Label lblConfirmarCliente;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label lblFVencimiento;
        private System.Windows.Forms.Label lblPPoliza;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grpBaja;
        private System.Windows.Forms.Label lblConfirmarBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDBaja;
        private System.Windows.Forms.Button btnBajaCiente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.ListBox lstCliente;
    }
}