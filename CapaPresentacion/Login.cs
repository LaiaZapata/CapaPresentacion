using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;

            if (user == "Admin" && pass == "1234")
            {
                MessageBox.Show("INICIO DE SESIÓN EXITOSO", "¡BIENVENIDO ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                Form1 fp = new Form1();
                fp.Show();
            }
            else if (user == "User" && pass == "2020")
            {
                MessageBox.Show("INICIO DE SESIÓN EXITOSO", "¡BIENVENIDO ADMINISTRADOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                Form1 fp = new Form1();
                fp.Show();


            }
            else
            {
                MessageBox.Show("SE PRODUJO UN ERRO", "CONTRASEÑA O USUARIO INCORRECTOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarprog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
