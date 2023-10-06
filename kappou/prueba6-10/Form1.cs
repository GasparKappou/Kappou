using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba6_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nombresA.Items.Add("Sofia");
            nombresA.Items.Add("Claudia");
            nombresA.Items.Add("Tamara");
            nombresA.Items.Add("Angie");
            nombresA.Items.Add("Azul");
            nombresA.Items.Add("Gaspar");
            nombresA.Items.Add("Luis");
            nombresA.Items.Add("Tobias");
            nombresA.Items.Add("Felipe");
            nombresA.Items.Add("Magda");

            nombresB.Items.Add("Jordana");
            nombresB.Items.Add("Ulises");
            nombresB.Items.Add("Alejandro");
            nombresB.Items.Add("Jeronimo");
            nombresB.Items.Add("Gustavo");
            nombresB.Items.Add("Macarena");
            nombresB.Items.Add("Candela");
            nombresB.Items.Add("Malena");
            nombresB.Items.Add("Eneas");
            nombresB.Items.Add("Matias");
        }
        private void Ordenar_Click(object sender, EventArgs e)
        {
            nombresA.Sorted = true;
            nombresB.Sorted = true;
        }
        private void Borrar_menos_5_Click(object sender, EventArgs e)
        {
            for (int i = nombresA.Items.Count - 1; i >= 0; i--)
                if (nombresA.Items[i].ToString().Count() <= 5)
                    nombresA.Items.RemoveAt(i);
            for (int i = nombresB.Items.Count - 1; i >= 0; i--)
                if (nombresB.Items[i].ToString().Count() <= 5)
                    nombresB.Items.RemoveAt(i);
        }
        private void Intercambiar_Click(object sender, EventArgs e)
        {
            int indiceA = 0;
            int indiceB = 0;
            ListBox nomC = new ListBox();
            nomC.Items.Add("itemEjemplo");
            for (int i = indiceA; i < nombresA.Items.Count; i++)
            {
                indiceA = i;
                if (nombresA.Items[i].ToString().Count() <= 5)
                    for (int j = indiceB; j < nombresB.Items.Count; j++)
                    {
                        indiceB = j;
                        if (nombresB.Items[j].ToString().Count() <= 5)
                        {
                            nomC.Items[0] = nombresA.Items[i].ToString();
                            nombresA.Items[i] = nombresB.Items[j];
                            nombresB.Items[j] = nomC.Items[0];
                        }
                    }
            }
        }

        private void Last_and_first_Click(object sender, EventArgs e)
        {
            ListBox nombresC = new ListBox();
            nombresC.Items.Add(nombresA.Items[0].ToString());
            nombresC.Items.Add(nombresA.Items[nombresA.Items.Count - 1].ToString());
            nombresC.Items.Add(nombresB.Items[0].ToString());
            nombresC.Items.Add(nombresB.Items[nombresB.Items.Count - 1].ToString());

            nombresA.Items[0] = nombresC.Items[2];
            nombresA.Items[nombresA.Items.Count - 1] = nombresC.Items[3];
            nombresB.Items[0] = nombresC.Items[0];
            nombresB.Items[nombresB.Items.Count - 1] = nombresC.Items[1];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
