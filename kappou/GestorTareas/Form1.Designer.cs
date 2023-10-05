namespace GestorTareas
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
			this.listTareas = new System.Windows.Forms.ListBox();
			this.Agregar = new System.Windows.Forms.Button();
			this.Eliminar = new System.Windows.Forms.Button();
			this.Editar = new System.Windows.Forms.Button();
			this.tarea1 = new System.Windows.Forms.TextBox();
			this.tarea2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// listTareas
			// 
			this.listTareas.FormattingEnabled = true;
			this.listTareas.Location = new System.Drawing.Point(12, 12);
			this.listTareas.Name = "listTareas";
			this.listTareas.Size = new System.Drawing.Size(165, 420);
			this.listTareas.TabIndex = 0;
			this.listTareas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// Agregar
			// 
			this.Agregar.Location = new System.Drawing.Point(183, 38);
			this.Agregar.Name = "Agregar";
			this.Agregar.Size = new System.Drawing.Size(100, 23);
			this.Agregar.TabIndex = 1;
			this.Agregar.Text = "Agregar";
			this.Agregar.UseVisualStyleBackColor = true;
			this.Agregar.Click += new System.EventHandler(this.button1_Click);
			// 
			// Eliminar
			// 
			this.Eliminar.Location = new System.Drawing.Point(183, 67);
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.Size = new System.Drawing.Size(100, 23);
			this.Eliminar.TabIndex = 2;
			this.Eliminar.Text = "Eliminar";
			this.Eliminar.UseVisualStyleBackColor = true;
			this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
			// 
			// Editar
			// 
			this.Editar.Location = new System.Drawing.Point(183, 177);
			this.Editar.Name = "Editar";
			this.Editar.Size = new System.Drawing.Size(100, 23);
			this.Editar.TabIndex = 3;
			this.Editar.Text = "Editar";
			this.Editar.UseVisualStyleBackColor = true;
			this.Editar.Click += new System.EventHandler(this.Editar_Click);
			// 
			// tarea1
			// 
			this.tarea1.Location = new System.Drawing.Point(183, 12);
			this.tarea1.Name = "tarea1";
			this.tarea1.Size = new System.Drawing.Size(100, 20);
			this.tarea1.TabIndex = 4;
			this.tarea1.TextChanged += new System.EventHandler(this.tarea1_TextChanged);
			// 
			// tarea2
			// 
			this.tarea2.Location = new System.Drawing.Point(183, 151);
			this.tarea2.Name = "tarea2";
			this.tarea2.Size = new System.Drawing.Size(100, 20);
			this.tarea2.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 450);
			this.Controls.Add(this.tarea2);
			this.Controls.Add(this.tarea1);
			this.Controls.Add(this.Editar);
			this.Controls.Add(this.Eliminar);
			this.Controls.Add(this.Agregar);
			this.Controls.Add(this.listTareas);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listTareas;
		private System.Windows.Forms.Button Agregar;
		private System.Windows.Forms.Button Eliminar;
		private System.Windows.Forms.Button Editar;
		private System.Windows.Forms.TextBox tarea1;
		private System.Windows.Forms.TextBox tarea2;
	}
}

