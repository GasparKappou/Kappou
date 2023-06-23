namespace formularios01
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
            this.pasar_todo_izq = new System.Windows.Forms.Button();
            this.pasar_izq = new System.Windows.Forms.Button();
            this.pasar_der = new System.Windows.Forms.Button();
            this.pasar_todo_der = new System.Windows.Forms.Button();
            this.boxIzq = new System.Windows.Forms.ListBox();
            this.boxDer = new System.Windows.Forms.ListBox();
            this.text_box_izq = new System.Windows.Forms.TextBox();
            this.text_box_der = new System.Windows.Forms.TextBox();
            this.agregar_izq = new System.Windows.Forms.Button();
            this.agregar_der = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pasar_todo_izq
            // 
            this.pasar_todo_izq.Location = new System.Drawing.Point(327, 11);
            this.pasar_todo_izq.Name = "pasar_todo_izq";
            this.pasar_todo_izq.Size = new System.Drawing.Size(149, 52);
            this.pasar_todo_izq.TabIndex = 0;
            this.pasar_todo_izq.Text = "Pasar Todo Izq";
            this.pasar_todo_izq.UseVisualStyleBackColor = true;
            this.pasar_todo_izq.Click += new System.EventHandler(this.pasar_todo_izq_Click);
            // 
            // pasar_izq
            // 
            this.pasar_izq.Location = new System.Drawing.Point(328, 70);
            this.pasar_izq.Name = "pasar_izq";
            this.pasar_izq.Size = new System.Drawing.Size(149, 52);
            this.pasar_izq.TabIndex = 1;
            this.pasar_izq.Text = "Pasar Izq";
            this.pasar_izq.UseVisualStyleBackColor = true;
            this.pasar_izq.Click += new System.EventHandler(this.pasar_izq_Click);
            // 
            // pasar_der
            // 
            this.pasar_der.Location = new System.Drawing.Point(328, 263);
            this.pasar_der.Name = "pasar_der";
            this.pasar_der.Size = new System.Drawing.Size(149, 52);
            this.pasar_der.TabIndex = 2;
            this.pasar_der.Text = "Pasar Der";
            this.pasar_der.UseVisualStyleBackColor = true;
            this.pasar_der.Click += new System.EventHandler(this.pasar_der_Click);
            // 
            // pasar_todo_der
            // 
            this.pasar_todo_der.Location = new System.Drawing.Point(328, 321);
            this.pasar_todo_der.Name = "pasar_todo_der";
            this.pasar_todo_der.Size = new System.Drawing.Size(149, 52);
            this.pasar_todo_der.TabIndex = 3;
            this.pasar_todo_der.Text = "Pasar Todo Der";
            this.pasar_todo_der.UseVisualStyleBackColor = true;
            this.pasar_todo_der.Click += new System.EventHandler(this.pasar_todo_der_Click);
            // 
            // boxIzq
            // 
            this.boxIzq.FormattingEnabled = true;
            this.boxIzq.Location = new System.Drawing.Point(12, 12);
            this.boxIzq.Name = "boxIzq";
            this.boxIzq.Size = new System.Drawing.Size(294, 277);
            this.boxIzq.TabIndex = 4;
            // 
            // boxDer
            // 
            this.boxDer.FormattingEnabled = true;
            this.boxDer.Location = new System.Drawing.Point(494, 12);
            this.boxDer.Name = "boxDer";
            this.boxDer.Size = new System.Drawing.Size(294, 277);
            this.boxDer.TabIndex = 5;
            // 
            // text_box_izq
            // 
            this.text_box_izq.Location = new System.Drawing.Point(12, 295);
            this.text_box_izq.Name = "text_box_izq";
            this.text_box_izq.Size = new System.Drawing.Size(294, 20);
            this.text_box_izq.TabIndex = 6;
            this.text_box_izq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_box_izq_KeyUp);
            // 
            // text_box_der
            // 
            this.text_box_der.Location = new System.Drawing.Point(494, 295);
            this.text_box_der.Name = "text_box_der";
            this.text_box_der.Size = new System.Drawing.Size(294, 20);
            this.text_box_der.TabIndex = 7;
            this.text_box_der.KeyUp += new System.Windows.Forms.KeyEventHandler(this.text_box_der_KeyUp);
            // 
            // agregar_izq
            // 
            this.agregar_izq.Location = new System.Drawing.Point(157, 321);
            this.agregar_izq.Name = "agregar_izq";
            this.agregar_izq.Size = new System.Drawing.Size(149, 52);
            this.agregar_izq.TabIndex = 8;
            this.agregar_izq.Text = "Agregar";
            this.agregar_izq.UseVisualStyleBackColor = true;
            this.agregar_izq.Click += new System.EventHandler(this.agregar_izq_Click);
            // 
            // agregar_der
            // 
            this.agregar_der.Location = new System.Drawing.Point(494, 321);
            this.agregar_der.Name = "agregar_der";
            this.agregar_der.Size = new System.Drawing.Size(149, 52);
            this.agregar_der.TabIndex = 9;
            this.agregar_der.Text = "Agregar";
            this.agregar_der.UseVisualStyleBackColor = true;
            this.agregar_der.Click += new System.EventHandler(this.agregar_der_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregar_der);
            this.Controls.Add(this.agregar_izq);
            this.Controls.Add(this.text_box_der);
            this.Controls.Add(this.text_box_izq);
            this.Controls.Add(this.boxDer);
            this.Controls.Add(this.boxIzq);
            this.Controls.Add(this.pasar_todo_der);
            this.Controls.Add(this.pasar_der);
            this.Controls.Add(this.pasar_izq);
            this.Controls.Add(this.pasar_todo_izq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pasar_todo_izq;
        private System.Windows.Forms.Button pasar_izq;
        private System.Windows.Forms.Button pasar_der;
        private System.Windows.Forms.Button pasar_todo_der;
        private System.Windows.Forms.ListBox boxIzq;
        private System.Windows.Forms.ListBox boxDer;
        private System.Windows.Forms.TextBox text_box_izq;
        private System.Windows.Forms.TextBox text_box_der;
        private System.Windows.Forms.Button agregar_izq;
        private System.Windows.Forms.Button agregar_der;
    }
}

