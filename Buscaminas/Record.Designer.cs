namespace Buscaminas
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttonGRecord = new System.Windows.Forms.Button();
            this.lblNick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 145);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bttonGRecord
            // 
            this.bttonGRecord.Location = new System.Drawing.Point(115, 269);
            this.bttonGRecord.Name = "bttonGRecord";
            this.bttonGRecord.Size = new System.Drawing.Size(107, 23);
            this.bttonGRecord.TabIndex = 1;
            this.bttonGRecord.Text = "Guardar Record";
            this.bttonGRecord.UseVisualStyleBackColor = true;
            this.bttonGRecord.Click += new System.EventHandler(this.bttonGRecord_Click);
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNick.Location = new System.Drawing.Point(72, 62);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(224, 24);
            this.lblNick.TabIndex = 3;
            this.lblNick.Text = "Escriba su nombre o nick";
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 392);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.bttonGRecord);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Record";
            this.Text = "Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttonGRecord;
        private System.Windows.Forms.Label lblNick;
    }
}