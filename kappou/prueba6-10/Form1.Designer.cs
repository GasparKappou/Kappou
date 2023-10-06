namespace prueba6_10
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
            this.Ordenar = new System.Windows.Forms.Button();
            this.nombresA = new System.Windows.Forms.ListBox();
            this.nombresB = new System.Windows.Forms.ListBox();
            this.Last_and_first = new System.Windows.Forms.Button();
            this.Borrar_menos_5 = new System.Windows.Forms.Button();
            this.Intercambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ordenar
            // 
            this.Ordenar.Location = new System.Drawing.Point(12, 12);
            this.Ordenar.Name = "Ordenar";
            this.Ordenar.Size = new System.Drawing.Size(75, 23);
            this.Ordenar.TabIndex = 0;
            this.Ordenar.Text = "Ordenar";
            this.Ordenar.UseVisualStyleBackColor = true;
            this.Ordenar.Click += new System.EventHandler(this.Ordenar_Click);
            // 
            // nombresA
            // 
            this.nombresA.FormattingEnabled = true;
            this.nombresA.Location = new System.Drawing.Point(12, 41);
            this.nombresA.Name = "nombresA";
            this.nombresA.Size = new System.Drawing.Size(387, 368);
            this.nombresA.TabIndex = 4;
            this.nombresA.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nombresB
            // 
            this.nombresB.FormattingEnabled = true;
            this.nombresB.Location = new System.Drawing.Point(401, 41);
            this.nombresB.Name = "nombresB";
            this.nombresB.Size = new System.Drawing.Size(387, 368);
            this.nombresB.TabIndex = 5;
            // 
            // Last_and_first
            // 
            this.Last_and_first.Location = new System.Drawing.Point(713, 415);
            this.Last_and_first.Name = "Last_and_first";
            this.Last_and_first.Size = new System.Drawing.Size(75, 23);
            this.Last_and_first.TabIndex = 3;
            this.Last_and_first.Text = "Last and first";
            this.Last_and_first.UseVisualStyleBackColor = true;
            this.Last_and_first.Click += new System.EventHandler(this.Last_and_first_Click);
            // 
            // Borrar_menos_5
            // 
            this.Borrar_menos_5.Location = new System.Drawing.Point(12, 415);
            this.Borrar_menos_5.Name = "Borrar_menos_5";
            this.Borrar_menos_5.Size = new System.Drawing.Size(75, 23);
            this.Borrar_menos_5.TabIndex = 6;
            this.Borrar_menos_5.Text = "Borrar <5";
            this.Borrar_menos_5.UseVisualStyleBackColor = true;
            this.Borrar_menos_5.Click += new System.EventHandler(this.Borrar_menos_5_Click);
            // 
            // Intercambiar
            // 
            this.Intercambiar.Location = new System.Drawing.Point(713, 12);
            this.Intercambiar.Name = "Intercambiar";
            this.Intercambiar.Size = new System.Drawing.Size(75, 23);
            this.Intercambiar.TabIndex = 7;
            this.Intercambiar.Text = "Intercambiar";
            this.Intercambiar.UseVisualStyleBackColor = true;
            this.Intercambiar.Click += new System.EventHandler(this.Intercambiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Intercambiar);
            this.Controls.Add(this.Borrar_menos_5);
            this.Controls.Add(this.nombresB);
            this.Controls.Add(this.nombresA);
            this.Controls.Add(this.Last_and_first);
            this.Controls.Add(this.Ordenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ordenar;
        private System.Windows.Forms.ListBox nombresA;
        private System.Windows.Forms.ListBox nombresB;
        private System.Windows.Forms.Button Last_and_first;
        private System.Windows.Forms.Button Borrar_menos_5;
        private System.Windows.Forms.Button Intercambiar;
    }
}

