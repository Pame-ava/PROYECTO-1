using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_1
{
    public partial class Formadministrador : Form
    {
        public Formadministrador()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form CambioA = new Formventas();
            CambioA.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form enviar12 = new Formusuario();
            enviar12.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Form CambioA = new Form1();
            CambioA.Show();
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
