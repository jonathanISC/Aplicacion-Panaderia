using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun;
using CapaNegocios;

namespace WindowsFormsApp1
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != string.Empty)
            {
                if (txtpass.Text != string.Empty)
                {
                    Usuarios usuarios = new Usuarios();
                    var validarLogin = usuarios.Login(txtuser.Text.Trim(), txtpass.Text.Trim());
                    if (validarLogin == true)
                    {
                        MessageBox.Show("Bienvenido " + Cache.Nombre + " " + Cache.ApellidoPatern);
                        this.Hide();
                        MenuPrincipal mp = new MenuPrincipal();
                        mp.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrecta. \n Porfavor intente nuevamente");
                    }

                }
                else
                {
                    MessageBox.Show("Porfavor introduzca una contraseña");
                }
            }
            else
            {
                MessageBox.Show("Porfavor introduzca un nombre de usuario");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            RecuperarContraseña fr = new RecuperarContraseña();
            fr.ShowDialog();
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = e.KeyChar == ' ';
        }
    }
}
