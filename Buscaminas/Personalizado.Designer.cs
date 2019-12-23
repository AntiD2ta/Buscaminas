namespace Buscaminas
{
    partial class Personalizado
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
            this.numPDFilas = new System.Windows.Forms.NumericUpDown();
            this.numUPDColumnas = new System.Windows.Forms.NumericUpDown();
            this.numUPDMinas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPDFilas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDMinas)).BeginInit();
            this.SuspendLayout();
            // 
            // numPDFilas
            // 
            this.numPDFilas.Location = new System.Drawing.Point(152, 67);
            this.numPDFilas.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPDFilas.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numPDFilas.Name = "numPDFilas";
            this.numPDFilas.Size = new System.Drawing.Size(120, 20);
            this.numPDFilas.TabIndex = 0;
            this.numPDFilas.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numUPDColumnas
            // 
            this.numUPDColumnas.Location = new System.Drawing.Point(152, 127);
            this.numUPDColumnas.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numUPDColumnas.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numUPDColumnas.Name = "numUPDColumnas";
            this.numUPDColumnas.Size = new System.Drawing.Size(120, 20);
            this.numUPDColumnas.TabIndex = 1;
            this.numUPDColumnas.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numUPDMinas
            // 
            this.numUPDMinas.Location = new System.Drawing.Point(152, 189);
            this.numUPDMinas.Name = "numUPDMinas";
            this.numUPDMinas.Size = new System.Drawing.Size(120, 20);
            this.numUPDMinas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columnas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Minas";
            // 
            // bttonAceptar
            // 
            this.bttonAceptar.Location = new System.Drawing.Point(99, 226);
            this.bttonAceptar.Name = "bttonAceptar";
            this.bttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.bttonAceptar.TabIndex = 6;
            this.bttonAceptar.Text = "Hecho";
            this.bttonAceptar.UseVisualStyleBackColor = true;
            this.bttonAceptar.Click += new System.EventHandler(this.bttonAceptar_Click);
            // 
            // Personalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.bttonAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUPDMinas);
            this.Controls.Add(this.numUPDColumnas);
            this.Controls.Add(this.numPDFilas);
            this.Name = "Personalizado";
            this.Text = "Personalizado";
            this.Load += new System.EventHandler(this.Personalizado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPDFilas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPDMinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown numPDFilas;
        public System.Windows.Forms.NumericUpDown numUPDColumnas;
        public System.Windows.Forms.NumericUpDown numUPDMinas;
        private System.Windows.Forms.Button bttonAceptar;
    }
}