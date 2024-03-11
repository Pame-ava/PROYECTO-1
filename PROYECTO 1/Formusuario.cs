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
    public partial class Formusuario : Form
    {
        public Formusuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            Form enviar1234 = new FormTresLeches();
            enviar1234.Show();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Form enviarAE = new FormTresLeches();
            enviarAE.Show();
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            Form enviarAD = new FormTresLeches();
            enviarAD.Show();
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            Form enviarAC = new FormTresLeches();
            enviarAC.Show();
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            Form enviarAB = new FormTresLeches();
            enviarAB.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
