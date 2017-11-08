namespace Obligarorio_1_Programación_2.Presentacion
{
    partial class frmRelacionClienteCorredor
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
            this.btnRelacionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDPoliza = new System.Windows.Forms.TextBox();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtIDCorredor = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lstRelacion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRelacionar
            // 
            this.btnRelacionar.Location = new System.Drawing.Point(26, 77);
            this.btnRelacionar.Name = "btnRelacionar";
            this.btnRelacionar.Size = new System.Drawing.Size(296, 24);
            this.btnRelacionar.TabIndex = 2;
            this.btnRelacionar.Text = "Relacionar";
            this.btnRelacionar.UseVisualStyleBackColor = true;
            this.btnRelacionar.Click += new System.EventHandler(this.btnRelacionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Corredor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Poliza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Cliente";
            // 
            // txtIDPoliza
            // 
            this.txtIDPoliza.Location = new System.Drawing.Point(26, 35);
            this.txtIDPoliza.Name = "txtIDPoliza";
            this.txtIDPoliza.Size = new System.Drawing.Size(81, 20);
            this.txtIDPoliza.TabIndex = 6;
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(126, 35);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(81, 20);
            this.txtIDCliente.TabIndex = 7;
            // 
            // txtIDCorredor
            // 
            this.txtIDCorredor.Location = new System.Drawing.Point(231, 35);
            this.txtIDCorredor.Name = "txtIDCorredor";
            this.txtIDCorredor.Size = new System.Drawing.Size(81, 20);
            this.txtIDCorredor.TabIndex = 8;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(32, 104);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(10, 13);
            this.lblConfirmar.TabIndex = 9;
            this.lblConfirmar.Text = ".";
            // 
            // lstRelacion
            // 
            this.lstRelacion.FormattingEnabled = true;
            this.lstRelacion.Location = new System.Drawing.Point(26, 129);
            this.lstRelacion.Name = "lstRelacion";
            this.lstRelacion.Size = new System.Drawing.Size(304, 134);
            this.lstRelacion.TabIndex = 10;
            // 
            // frmRelacionClienteCorredor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 276);
            this.Controls.Add(this.lstRelacion);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtIDCorredor);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.txtIDPoliza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelacionar);
            this.Name = "frmRelacionClienteCorredor";
            this.Text = "RelacionClienteCorredor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRelacionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDPoliza;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtIDCorredor;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.ListBox lstRelacion;
    }
}