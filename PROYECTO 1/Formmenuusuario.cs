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
    public partial class Formmenuusuario : Form
    {
        public Formmenuusuario()
        {
            InitializeComponent();
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
    }
}
