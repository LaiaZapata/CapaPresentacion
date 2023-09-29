namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
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
            else if (user == "user" && pass == "2020")
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
    }
}