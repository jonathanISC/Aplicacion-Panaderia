using CapaNegocios;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            //InicioSesion ise = new InicioSesion();
            //ise.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtRecuperarContra.Text != string.Empty)
            {
                var negocios = new Usuarios();
                var result = negocios.recoverPassword(txtRecuperarContra.Text);
                MessageBox.Show(result);
                this.Close();
            }
            else
            {
                
                MessageBox.Show("Ingrese un correo electrónico");
            }
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
