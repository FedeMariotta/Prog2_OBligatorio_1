namespace Obligarorio_1_Programación_2.Presentacion
{
    partial class FrmListar
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
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.lstCorredor = new System.Windows.Forms.ListBox();
            this.lstPoliza = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRelacion = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCliente
            // 
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(12, 201);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(505, 134);
            this.lstCliente.TabIndex = 0;
            // 
            // lstCorredor
            // 
            this.lstCorredor.FormattingEnabled = true;
            this.lstCorredor.Location = new System.Drawing.Point(12, 372);
            this.lstCorredor.Name = "lstCorredor";
            this.lstCorredor.Size = new System.Drawing.Size(505, 134);
            this.lstCorredor.TabIndex = 1;
            // 
            // lstPoliza
            // 
            this.lstPoliza.FormattingEnabled = true;
            this.lstPoliza.Location = new System.Drawing.Point(12, 37);
            this.lstPoliza.Name = "lstPoliza";
            this.lstPoliza.Size = new System.Drawing.Size(505, 134);
            this.lstPoliza.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Polizas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista de Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista de Corredores";
            // 
            // lstRelacion
            // 
            this.lstRelacion.FormattingEnabled = true;
            this.lstRelacion.Location = new System.Drawing.Point(541, 37);
            this.lstRelacion.Name = "lstRelacion";
            this.lstRelacion.Size = new System.Drawing.Size(430, 472);
            this.lstRelacion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de Relaciones";
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstRelacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPoliza);
            this.Controls.Add(this.lstCorredor);
            this.Controls.Add(this.lstCliente);
            this.Name = "FrmListar";
            this.Text = "Listar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCliente;
        private System.Windows.Forms.ListBox lstCorredor;
        private System.Windows.Forms.ListBox lstPoliza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRelacion;
        private System.Windows.Forms.Label label4;
    }
}