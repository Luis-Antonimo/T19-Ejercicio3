using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T19_Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(trackBar1.Value);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radioboton="";
            if (radioButton1.Checked) { radioboton = radioButton1.Text; }
            if (radioButton2.Checked) { radioboton = radioButton2.Text; }
            if (radioButton3.Checked) { radioboton = radioButton3.Text; }

            //Es un tipo de string que solo memoriza si hay elementos. Es variable.
            List<string> opciones = new List<string>();
            if (checkBox1.Checked) { opciones.Add("Programación");}
            if (checkBox2.Checked) { opciones.Add("Diseño gráfico");}
            if (checkBox3.Checked) { opciones.Add("Administración");}
            string[] arrayboxes = opciones.ToArray();
            //Añade una coma después de cada elemento.
            string checkboxes = String.Join(", ", arrayboxes);


            MessageBox.Show("\nHoras dedicadas: "+ label2.Text + "\nSistema operativo: " + radioboton  + "\nEspecialidad/es: " + checkboxes,"Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
