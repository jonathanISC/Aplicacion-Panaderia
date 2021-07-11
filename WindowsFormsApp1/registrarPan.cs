using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace WindowsFormsApp1
{
    public partial class registrarPan : Form
    {
        string imagenAr;
        public registrarPan()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Pan pn= new Pan();
            pn.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Escoge la imagen(*.jpg;*.png;*.JPE)|*.jpg;*.png;*.JPE";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                imagenAr = opf.FileName;
                pictureBox3.Image = Image.FromFile(opf.FileName);
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (imagenAr == string.Empty)
            {
                MessageBox.Show("Por favor, carge una imagen");
            }
            else
            {


                Usuarios desple = new Usuarios();
                string imagenPath = "'" + imagenAr + "'";
                MessageBox.Show(imagenPath);
                desple.registrarPanN(txtNombrePan.Text, Convert.ToDouble(txtPrecio.Text), imagenAr);
                MessageBox.Show("Pan registrado exitosamente ! ");
                txtNombrePan.Text = "";
                txtPrecio.Text = "0";
                pictureBox1.Image = null;
                imagenAr = string.Empty;
                MenuPrincipal mp = new MenuPrincipal();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pan pn = new Pan();
            pn.Show();
            this.Close();
        }
    }
}
