namespace Obligarorio_1_Programación_2.Presentacion
{
    partial class frmABMPoliza
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblNomPoliza = new System.Windows.Forms.Label();
            this.lblPPoliza = new System.Windows.Forms.Label();
            this.lblTPoliza = new System.Windows.Forms.Label();
            this.lblFVencimiento = new System.Windows.Forms.Label();
            this.lblFAd = new System.Windows.Forms.Label();
            this.txtIDPoliza = new System.Windows.Forms.TextBox();
            this.txtNombrePoliza = new System.Windows.Forms.TextBox();
            this.txtPrecioPoliza = new System.Windows.Forms.TextBox();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.rdbAutomoviles = new System.Windows.Forms.RadioButton();
            this.rdbCasa = new System.Windows.Forms.RadioButton();
            this.rdbVida = new System.Windows.Forms.RadioButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDBaja = new System.Windows.Forms.TextBox();
            this.btnBajaPoliza = new System.Windows.Forms.Button();
            this.lblConfirmarPoliza = new System.Windows.Forms.Label();
            this.grpBaja = new System.Windows.Forms.GroupBox();
            this.lblConfirmarBaja = new System.Windows.Forms.Label();
            this.grpAlta = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstPoliza = new System.Windows.Forms.ListBox();
            this.grpBaja.SuspendLayout();
            this.grpAlta.SuspendLayout();
            this.SuspendLayout();
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
            // lblNomPoliza
            // 
            this.lblNomPoliza.AutoSize = true;
            this.lblNomPoliza.Location = new System.Drawing.Point(6, 57);
            this.lblNomPoliza.Name = "lblNomPoliza";
            this.lblNomPoliza.Size = new System.Drawing.Size(75, 13);
            this.lblNomPoliza.TabIndex = 1;
            this.lblNomPoliza.Text = "Nombre Poliza";
            // 
            // lblPPoliza
            // 
            this.lblPPoliza.AutoSize = true;
            this.lblPPoliza.Location = new System.Drawing.Point(6, 174);
            this.lblPPoliza.Name = "lblPPoliza";
            this.lblPPoliza.Size = new System.Drawing.Size(68, 13);
            this.lblPPoliza.TabIndex = 2;
            this.lblPPoliza.Text = "Precio Poliza";
            // 
            // lblTPoliza
            // 
            this.lblTPoliza.AutoSize = true;
            this.lblTPoliza.Location = new System.Drawing.Point(6, 91);
            this.lblTPoliza.Name = "lblTPoliza";
            this.lblTPoliza.Size = new System.Drawing.Size(59, 13);
            this.lblTPoliza.TabIndex = 3;
            this.lblTPoliza.Text = "Tipo Poliza";
            // 
            // lblFVencimiento
            // 
            this.lblFVencimiento.AutoSize = true;
            this.lblFVencimiento.Location = new System.Drawing.Point(6, 206);
            this.lblFVencimiento.Name = "lblFVencimiento";
            this.lblFVencimiento.Size = new System.Drawing.Size(98, 13);
            this.lblFVencimiento.TabIndex = 4;
            this.lblFVencimiento.Text = "Fecha Vencimiento";
            // 
            // lblFAd
            // 
            this.lblFAd.AutoSize = true;
            this.lblFAd.Location = new System.Drawing.Point(6, 238);
            this.lblFAd.Name = "lblFAd";
            this.lblFAd.Size = new System.Drawing.Size(94, 13);
            this.lblFAd.TabIndex = 5;
            this.lblFAd.Text = "Fecha Adquisición";
            // 
            // txtIDPoliza
            // 
            this.txtIDPoliza.Location = new System.Drawing.Point(121, 24);
            this.txtIDPoliza.Name = "txtIDPoliza";
            this.txtIDPoliza.Size = new System.Drawing.Size(118, 20);
            this.txtIDPoliza.TabIndex = 6;
            this.txtIDPoliza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtNombrePoliza
            // 
            this.txtNombrePoliza.Location = new System.Drawing.Point(121, 54);
            this.txtNombrePoliza.Name = "txtNombrePoliza";
            this.txtNombrePoliza.Size = new System.Drawing.Size(118, 20);
            this.txtNombrePoliza.TabIndex = 7;
            this.txtNombrePoliza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPrecioPoliza
            // 
            this.txtPrecioPoliza.Location = new System.Drawing.Point(121, 171);
            this.txtPrecioPoliza.Name = "txtPrecioPoliza";
            this.txtPrecioPoliza.Size = new System.Drawing.Size(118, 20);
            this.txtPrecioPoliza.TabIndex = 8;
            this.txtPrecioPoliza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(121, 200);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerVencimiento.TabIndex = 9;
            // 
            // dateTimePickerAdquisicion
            // 
            this.dateTimePickerAdquisicion.Location = new System.Drawing.Point(121, 232);
            this.dateTimePickerAdquisicion.Name = "dateTimePickerAdquisicion";
            this.dateTimePickerAdquisicion.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerAdquisicion.TabIndex = 10;
            // 
            // rdbAutomoviles
            // 
            this.rdbAutomoviles.AutoSize = true;
            this.rdbAutomoviles.Location = new System.Drawing.Point(121, 91);
            this.rdbAutomoviles.Name = "rdbAutomoviles";
            this.rdbAutomoviles.Size = new System.Drawing.Size(82, 17);
            this.rdbAutomoviles.TabIndex = 12;
            this.rdbAutomoviles.TabStop = true;
            this.rdbAutomoviles.Text = "Automoviles";
            this.rdbAutomoviles.UseVisualStyleBackColor = true;
            // 
            // rdbCasa
            // 
            this.rdbCasa.AutoSize = true;
            this.rdbCasa.Location = new System.Drawing.Point(121, 114);
            this.rdbCasa.Name = "rdbCasa";
            this.rdbCasa.Size = new System.Drawing.Size(49, 17);
            this.rdbCasa.TabIndex = 13;
            this.rdbCasa.TabStop = true;
            this.rdbCasa.Text = "Casa";
            this.rdbCasa.UseVisualStyleBackColor = true;
            // 
            // rdbVida
            // 
            this.rdbVida.AutoSize = true;
            this.rdbVida.Location = new System.Drawing.Point(121, 137);
            this.rdbVida.Name = "rdbVida";
            this.rdbVida.Size = new System.Drawing.Size(46, 17);
            this.rdbVida.TabIndex = 14;
            this.rdbVida.TabStop = true;
            this.rdbVida.Text = "Vida";
            this.rdbVida.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(9, 276);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(116, 27);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar poliza por ID";
            // 
            // txtIDBaja
            // 
            this.txtIDBaja.Location = new System.Drawing.Point(9, 55);
            this.txtIDBaja.Name = "txtIDBaja";
            this.txtIDBaja.Size = new System.Drawing.Size(137, 20);
            this.txtIDBaja.TabIndex = 17;
            this.txtIDBaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaja_KeyPress);
            // 
            // btnBajaPoliza
            // 
            this.btnBajaPoliza.Location = new System.Drawing.Point(9, 90);
            this.btnBajaPoliza.Name = "btnBajaPoliza";
            this.btnBajaPoliza.Size = new System.Drawing.Size(136, 25);
            this.btnBajaPoliza.TabIndex = 18;
            this.btnBajaPoliza.Text = "Baja";
            this.btnBajaPoliza.UseVisualStyleBackColor = true;
            this.btnBajaPoliza.Click += new System.EventHandler(this.BtnBajaPoliza_Click);
            // 
            // lblConfirmarPoliza
            // 
            this.lblConfirmarPoliza.AutoSize = true;
            this.lblConfirmarPoliza.Location = new System.Drawing.Point(17, 318);
            this.lblConfirmarPoliza.Name = "lblConfirmarPoliza";
            this.lblConfirmarPoliza.Size = new System.Drawing.Size(10, 13);
            this.lblConfirmarPoliza.TabIndex = 19;
            this.lblConfirmarPoliza.Text = ".";
            // 
            // grpBaja
            // 
            this.grpBaja.Controls.Add(this.lblConfirmarBaja);
            this.grpBaja.Controls.Add(this.label1);
            this.grpBaja.Controls.Add(this.txtIDBaja);
            this.grpBaja.Controls.Add(this.btnBajaPoliza);
            this.grpBaja.Location = new System.Drawing.Point(301, 3);
            this.grpBaja.Name = "grpBaja";
            this.grpBaja.Size = new System.Drawing.Size(158, 330);
            this.grpBaja.TabIndex = 20;
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
            // grpAlta
            // 
            this.grpAlta.Controls.Add(this.lblConfirmarPoliza);
            this.grpAlta.Controls.Add(this.btnIngresar);
            this.grpAlta.Controls.Add(this.rdbVida);
            this.grpAlta.Controls.Add(this.rdbCasa);
            this.grpAlta.Controls.Add(this.rdbAutomoviles);
            this.grpAlta.Controls.Add(this.button1);
            this.grpAlta.Controls.Add(this.dateTimePickerAdquisicion);
            this.grpAlta.Controls.Add(this.dateTimePickerVencimiento);
            this.grpAlta.Controls.Add(this.txtPrecioPoliza);
            this.grpAlta.Controls.Add(this.txtNombrePoliza);
            this.grpAlta.Controls.Add(this.txtIDPoliza);
            this.grpAlta.Controls.Add(this.lblFAd);
            this.grpAlta.Controls.Add(this.lblFVencimiento);
            this.grpAlta.Controls.Add(this.lblTPoliza);
            this.grpAlta.Controls.Add(this.lblPPoliza);
            this.grpAlta.Controls.Add(this.lblNomPoliza);
            this.grpAlta.Controls.Add(this.lblID);
            this.grpAlta.Location = new System.Drawing.Point(12, 3);
            this.grpAlta.Name = "grpAlta";
            this.grpAlta.Size = new System.Drawing.Size(275, 335);
            this.grpAlta.TabIndex = 21;
            this.grpAlta.TabStop = false;
            this.grpAlta.Text = "Alta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lstPoliza
            // 
            this.lstPoliza.FormattingEnabled = true;
            this.lstPoliza.Location = new System.Drawing.Point(13, 346);
            this.lstPoliza.Name = "lstPoliza";
            this.lstPoliza.Size = new System.Drawing.Size(528, 82);
            this.lstPoliza.TabIndex = 22;
            // 
            // frmABMPoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 438);
            this.Controls.Add(this.lstPoliza);
            this.Controls.Add(this.grpAlta);
            this.Controls.Add(this.grpBaja);
            this.Name = "frmABMPoliza";
            this.grpBaja.ResumeLayout(false);
            this.grpBaja.PerformLayout();
            this.grpAlta.ResumeLayout(false);
            this.grpAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNomPoliza;
        private System.Windows.Forms.Label lblPPoliza;
        private System.Windows.Forms.Label lblTPoliza;
        private System.Windows.Forms.Label lblFVencimiento;
        private System.Windows.Forms.Label lblFAd;
        private System.Windows.Forms.TextBox txtIDPoliza;
        private System.Windows.Forms.TextBox txtNombrePoliza;
        private System.Windows.Forms.TextBox txtPrecioPoliza;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdquisicion;
        private System.Windows.Forms.RadioButton rdbAutomoviles;
        private System.Windows.Forms.RadioButton rdbCasa;
        private System.Windows.Forms.RadioButton rdbVida;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDBaja;
        private System.Windows.Forms.Button btnBajaPoliza;
        private System.Windows.Forms.Label lblConfirmarPoliza;
        private System.Windows.Forms.GroupBox grpBaja;
        private System.Windows.Forms.Label lblConfirmarBaja;
        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.ListBox lstPoliza;
        private System.Windows.Forms.Button button1;
    }
}