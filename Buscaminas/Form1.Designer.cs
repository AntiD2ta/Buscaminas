namespace Buscaminas
{
    partial class frmDrawing
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
            this.components = new System.ComponentModel.Container();
            this.pbxGrid = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificultadDeJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.díficilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxCronoD = new System.Windows.Forms.PictureBox();
            this.pbxCronoC = new System.Windows.Forms.PictureBox();
            this.pbxCronoU = new System.Windows.Forms.PictureBox();
            this.groupBxCrono = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxCantMinasU = new System.Windows.Forms.PictureBox();
            this.pbxCantidadMinasD = new System.Windows.Forms.PictureBox();
            this.pbxCantMinasC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCronoD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCronoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCronoU)).BeginInit();
            this.groupBxCrono.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCantMinasU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCantidadMinasD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCantMinasC)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGrid
            // 
            this.pbxGrid.BackColor = System.Drawing.SystemColors.Control;
            this.pbxGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxGrid.Location = new System.Drawing.Point(12, 89);
            this.pbxGrid.Name = "pbxGrid";
            this.pbxGrid.Size = new System.Drawing.Size(360, 360);
            this.pbxGrid.TabIndex = 0;
            this.pbxGrid.TabStop = false;
            this.pbxGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxGrid_Paint);
            this.pbxGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxGrid_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.recordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuegoToolStripMenuItem,
            this.dificultadDeJuegoToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nuevoJuegoToolStripMenuItem
            // 
            this.nuevoJuegoToolStripMenuItem.Name = "nuevoJuegoToolStripMenuItem";
            this.nuevoJuegoToolStripMenuItem.ShortcutKeyDisplayString = "R";
            this.nuevoJuegoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nuevoJuegoToolStripMenuItem.Text = "Nuevo juego   ";
            this.nuevoJuegoToolStripMenuItem.Click += new System.EventHandler(this.nuevoJuegoToolStripMenuItem_Click);
            // 
            // dificultadDeJuegoToolStripMenuItem
            // 
            this.dificultadDeJuegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilToolStripMenuItem,
            this.medioToolStripMenuItem,
            this.díficilToolStripMenuItem,
            this.personalizadoToolStripMenuItem});
            this.dificultadDeJuegoToolStripMenuItem.Name = "dificultadDeJuegoToolStripMenuItem";
            this.dificultadDeJuegoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dificultadDeJuegoToolStripMenuItem.Text = "Dificultad de juego";
            // 
            // facilToolStripMenuItem
            // 
            this.facilToolStripMenuItem.Name = "facilToolStripMenuItem";
            this.facilToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.facilToolStripMenuItem.Text = "Fácil";
            this.facilToolStripMenuItem.Click += new System.EventHandler(this.facilToolStripMenuItem_Click);
            // 
            // medioToolStripMenuItem
            // 
            this.medioToolStripMenuItem.Name = "medioToolStripMenuItem";
            this.medioToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.medioToolStripMenuItem.Text = "Medio";
            this.medioToolStripMenuItem.Click += new System.EventHandler(this.medioToolStripMenuItem_Click);
            // 
            // díficilToolStripMenuItem
            // 
            this.díficilToolStripMenuItem.Name = "díficilToolStripMenuItem";
            this.díficilToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.díficilToolStripMenuItem.Text = "Díficil";
            this.díficilToolStripMenuItem.Click += new System.EventHandler(this.díficilToolStripMenuItem_Click);
            // 
            // personalizadoToolStripMenuItem
            // 
            this.personalizadoToolStripMenuItem.Name = "personalizadoToolStripMenuItem";
            this.personalizadoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.personalizadoToolStripMenuItem.Text = "Personalizado";
            this.personalizadoToolStripMenuItem.Click += new System.EventHandler(this.personalizadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeyDisplayString = "F";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 990;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxCronoD
            // 
            this.pbxCronoD.Location = new System.Drawing.Point(31, 15);
            this.pbxCronoD.Name = "pbxCronoD";
            this.pbxCronoD.Size = new System.Drawing.Size(20, 35);
            this.pbxCronoD.TabIndex = 3;
            this.pbxCronoD.TabStop = false;
            this.pbxCronoD.Tag = "2";
            this.pbxCronoD.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCrono_Paint);
            // 
            // pbxCronoC
            // 
            this.pbxCronoC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCronoC.Location = new System.Drawing.Point(11, 15);
            this.pbxCronoC.Name = "pbxCronoC";
            this.pbxCronoC.Size = new System.Drawing.Size(20, 35);
            this.pbxCronoC.TabIndex = 4;
            this.pbxCronoC.TabStop = false;
            this.pbxCronoC.Tag = "3";
            this.pbxCronoC.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCrono_Paint);
            // 
            // pbxCronoU
            // 
            this.pbxCronoU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCronoU.Location = new System.Drawing.Point(51, 15);
            this.pbxCronoU.Name = "pbxCronoU";
            this.pbxCronoU.Size = new System.Drawing.Size(20, 35);
            this.pbxCronoU.TabIndex = 2;
            this.pbxCronoU.TabStop = false;
            this.pbxCronoU.Tag = "1";
            this.pbxCronoU.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCrono_Paint);
            // 
            // groupBxCrono
            // 
            this.groupBxCrono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBxCrono.Controls.Add(this.pbxCronoU);
            this.groupBxCrono.Controls.Add(this.pbxCronoC);
            this.groupBxCrono.Controls.Add(this.pbxCronoD);
            this.groupBxCrono.Location = new System.Drawing.Point(286, 27);
            this.groupBxCrono.Name = "groupBxCrono";
            this.groupBxCrono.Size = new System.Drawing.Size(86, 56);
            this.groupBxCrono.TabIndex = 5;
            this.groupBxCrono.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbxCantMinasU);
            this.groupBox1.Controls.Add(this.pbxCantidadMinasD);
            this.groupBox1.Controls.Add(this.pbxCantMinasC);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pbxCantMinasU
            // 
            this.pbxCantMinasU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCantMinasU.Location = new System.Drawing.Point(52, 14);
            this.pbxCantMinasU.Name = "pbxCantMinasU";
            this.pbxCantMinasU.Size = new System.Drawing.Size(20, 35);
            this.pbxCantMinasU.TabIndex = 7;
            this.pbxCantMinasU.TabStop = false;
            this.pbxCantMinasU.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCantMinasU_Paint);
            // 
            // pbxCantidadMinasD
            // 
            this.pbxCantidadMinasD.Location = new System.Drawing.Point(32, 14);
            this.pbxCantidadMinasD.Name = "pbxCantidadMinasD";
            this.pbxCantidadMinasD.Size = new System.Drawing.Size(20, 35);
            this.pbxCantidadMinasD.TabIndex = 7;
            this.pbxCantidadMinasD.TabStop = false;
            this.pbxCantidadMinasD.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCantidadMinasD_Paint);
            // 
            // pbxCantMinasC
            // 
            this.pbxCantMinasC.Location = new System.Drawing.Point(12, 14);
            this.pbxCantMinasC.Name = "pbxCantMinasC";
            this.pbxCantMinasC.Size = new System.Drawing.Size(20, 35);
            this.pbxCantMinasC.TabIndex = 7;
            this.pbxCantMinasC.TabStop = false;
            this.pbxCantMinasC.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxCantMinasC_Paint);
            // 
            // frmDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBxCrono);
            this.Controls.Add(this.pbxGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmDrawing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscaminas";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDrawing_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCronoD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCronoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCronoU)).EndInit();
            this.groupBxCrono.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCantMinasU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCantidadMinasD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCantMinasC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificultadDeJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem facilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem díficilToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbxCronoD;
        private System.Windows.Forms.PictureBox pbxCronoC;
        private System.Windows.Forms.PictureBox pbxCronoU;
        private System.Windows.Forms.GroupBox groupBxCrono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxCantMinasC;
        private System.Windows.Forms.PictureBox pbxCantMinasU;
        private System.Windows.Forms.PictureBox pbxCantidadMinasD;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
    }
}

