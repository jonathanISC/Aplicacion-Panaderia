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
    public partial class Pan : Form
    {
        public Pan()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Close();

        }

        private void Pan_Load(object sender, EventArgs e)
        {
            Usuarios desple = new Usuarios();
            dataGridView1.DataSource = desple.PanRegistrado();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void pbAgregarPan_Click(object sender, EventArgs e)
        {
            registrarPan rp = new registrarPan();
            rp.Show();
            this.Close();

        }
    }
}
