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
    public partial class VentasH : Form
    {
        public VentasH()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentasH_Load(object sender, EventArgs e)
        {
            Usuarios desple = new Usuarios();
            dataGridView2.DataSource = desple.verVentash();
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
        }
    }
}
