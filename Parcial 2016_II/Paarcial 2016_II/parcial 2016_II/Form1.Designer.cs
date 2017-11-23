namespace parcial_2016_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCarril1 = new System.Windows.Forms.Label();
            this.LblCarril2 = new System.Windows.Forms.Label();
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCarril1
            // 
            this.LblCarril1.AutoSize = true;
            this.LblCarril1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarril1.Location = new System.Drawing.Point(12, 39);
            this.LblCarril1.Name = "LblCarril1";
            this.LblCarril1.Size = new System.Drawing.Size(74, 25);
            this.LblCarril1.TabIndex = 0;
            this.LblCarril1.Text = "Carril 1";
            // 
            // LblCarril2
            // 
            this.LblCarril2.AutoSize = true;
            this.LblCarril2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarril2.Location = new System.Drawing.Point(12, 94);
            this.LblCarril2.Name = "LblCarril2";
            this.LblCarril2.Size = new System.Drawing.Size(74, 25);
            this.LblCarril2.TabIndex = 1;
            this.LblCarril2.Text = "Carril 2";
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(139, 39);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(251, 25);
            this.pgbCarril1.TabIndex = 2;
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(139, 94);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(251, 25);
            this.pgbCarril2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Correr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 203);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.pgbCarril1);
            this.Controls.Add(this.LblCarril2);
            this.Controls.Add(this.LblCarril1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCarril1;
        private System.Windows.Forms.Label LblCarril2;
        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.ProgressBar pgbCarril2;
        private System.Windows.Forms.Button button1;

    }
}

