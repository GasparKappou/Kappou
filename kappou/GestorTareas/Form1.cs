using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorTareas
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (tarea1.Text != "")
				listTareas.Items.Add(tarea1.Text);
		}

		private void tarea1_TextChanged(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Eliminar_Click(object sender, EventArgs e)
		{
			listTareas.Items.Remove(listTareas.SelectedItem);
		}

		private void Editar_Click(object sender, EventArgs e)
		{
			if(listTareas.SelectedIndex != -1)
				listTareas.Items[listTareas.SelectedIndex] = tarea2.Text;
		}
	}
}