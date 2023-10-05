using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularios01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void agregar_izq_Click(object sender, EventArgs e)
        {
            if (text_box_izq.Text != "" && Regex.IsMatch(text_box_izq.Text, "[a-zA-Z0-9]"))
            {
                boxIzq.Items.Add(text_box_izq.Text);
                text_box_izq.Clear();
            }
            text_box_izq.Focus();
        }

        private void agregar_der_Click(object sender, EventArgs e)
        {
            if (text_box_der.Text != "" && Regex.IsMatch(text_box_der.Text, "[a-zA-Z0-9]"))
            {
                boxDer.Items.Add(text_box_der.Text);
                text_box_der.Clear();
            }
            text_box_der.Focus();
        }

        private void text_box_der_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                agregar_der_Click(sender, e);
            }
        }
        private void text_box_izq_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                agregar_izq_Click(sender, e);
            }
        }

        private void pasar_todo_izq_Click(object sender, EventArgs e)
        {
            if (!(boxIzq.Items.Count <= 0))
            {
                for (int i = 0; i < boxIzq.Items.Count; i++)
                {
                    boxDer.Items.Add(boxIzq.Items[i]);
                }
            }
            boxIzq.Items.Clear();
        }

        private void pasar_todo_der_Click(object sender, EventArgs e)
        {
            if (!(boxDer.Items.Count <= 0))
            {
                for (int i = 0; i < boxDer.Items.Count; i++)
                {
                    boxIzq.Items.Add(boxDer.Items[i]);
                }
            }
            boxDer.Items.Clear();
        }

        private void pasar_izq_Click(object sender, EventArgs e)
        {
            if (!(boxIzq.SelectedItem == null))
            {
                boxDer.Items.Add(boxIzq.SelectedItem);
                boxIzq.Items.Remove(boxIzq.SelectedItem);
            }
        }

        private void pasar_der_Click(object sender, EventArgs e)
        {
            if (!(boxDer.SelectedItem == null))
            {
                boxIzq.Items.Add(boxDer.SelectedItem);
                boxDer.Items.Remove(boxDer.SelectedItem);
            }
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
