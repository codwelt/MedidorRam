namespace ram
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbram = new System.Windows.Forms.ProgressBar();
            this.Ibramdiponible = new System.Windows.Forms.Label();
            this.Ibramutilizada = new System.Windows.Forms.Label();
            this.tm1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbram
            // 
            this.pbram.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbram.Location = new System.Drawing.Point(-7, 12);
            this.pbram.Name = "pbram";
            this.pbram.Size = new System.Drawing.Size(1127, 79);
            this.pbram.TabIndex = 0;
            // 
            // Ibramdiponible
            // 
            this.Ibramdiponible.AutoSize = true;
            this.Ibramdiponible.Font = new System.Drawing.Font("Century Gothic", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibramdiponible.Location = new System.Drawing.Point(12, 109);
            this.Ibramdiponible.Name = "Ibramdiponible";
            this.Ibramdiponible.Size = new System.Drawing.Size(237, 45);
            this.Ibramdiponible.TabIndex = 1;
            this.Ibramdiponible.Text = "Disponible: ";
            this.Ibramdiponible.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ibramutilizada
            // 
            this.Ibramutilizada.AutoSize = true;
            this.Ibramutilizada.Font = new System.Drawing.Font("Century Gothic", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ibramutilizada.Location = new System.Drawing.Point(12, 336);
            this.Ibramutilizada.Name = "Ibramutilizada";
            this.Ibramutilizada.Size = new System.Drawing.Size(204, 45);
            this.Ibramutilizada.TabIndex = 2;
            this.Ibramutilizada.Text = "Utilizada: ";
            this.Ibramutilizada.Click += new System.EventHandler(this.label2_Click);
            // 
            // tm1
            // 
            this.tm1.Enabled = true;
            this.tm1.Interval = 300;
            this.tm1.Tick += new System.EventHandler(this.tm1_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 652);
            this.Controls.Add(this.Ibramutilizada);
            this.Controls.Add(this.Ibramdiponible);
            this.Controls.Add(this.pbram);
            this.Name = "Form1";
            this.Text = "Medidor de memoria ram";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbram;
        private System.Windows.Forms.Label Ibramdiponible;
        private System.Windows.Forms.Label Ibramutilizada;
        private System.Windows.Forms.Timer tm1;
    }
}

