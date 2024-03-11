using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PROYECTO_1;



namespace PROYECTO_1
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

        private void button3_Click(object sender, EventArgs e)
        {
            Dusuario du = new Dusuario();
            Fusuario fu = new Fusuario();

            if (txtusuario1.Text != string.Empty && txtcontraseña1.Text != string.Empty)
            {
                DataTable dt = new DataTable();
                du.set_usuario(txtusuario1.Text);
                du.set_password(txtcontraseña1.Text);
                dt = fu.validar_usuario(du);

                if (dt.Rows.Count != 0)
                {
                    string nivel;
                    nivel = Convert.ToString(dt.Rows[0]["tipo_usuario"]);
                    if (nivel.Equals("Administrador"))
                    {
                        MessageBox.Show("Bienvenido" + txtusuario1.Text);
                        this.Hide();
                        Formadministrador fa = new Formadministrador();
                        fa.Show();
                    }
                    else if (nivel.Equals("Usuario"))
                    {
                        MessageBox.Show("Bienvenido" + txtusuario1.Text);
                        this.Hide();
                        Formmenuusuario1 fa = new Formmenuusuario1();
                        fa.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error ");
                    }
                }
            }
        }

        private void txtusuario1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

