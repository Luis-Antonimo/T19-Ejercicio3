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
            
            string check1 = "";
            string check2 = "";
            string check3 = "";
            if (checkBox1.Checked) { check1 = "Programación ";}
            if (checkBox2.Checked) { check2 = "Diseño gráfico ";}
            if (checkBox3.Checked) { check3 = "Administración ";}
            

            MessageBox.Show("\nHoras dedicadas: "+ label2.Text + "\nSistema operativo: " + radioboton  + "\nEspecialidad/es: " + check1 + check2 + check3,"Resumen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
