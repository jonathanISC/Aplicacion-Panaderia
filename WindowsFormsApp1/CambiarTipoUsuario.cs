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
    public partial class CambiarTipoUsuario : Form
    {
        public string id;
        public CambiarTipoUsuario()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            empleados emp = new empleados();
            emp.Show();
            this.Close();
        }

        private void CambiarTipoUsuario_Load(object sender, EventArgs e)
        {
            Usuarios desple = new Usuarios();
            //empleados id = new empleados();
            dataGridView1.DataSource = desple.desplegarUsuariosEdit(id);
            lbltipo.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Puesto"].Value);
            lblNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value) + " " + Convert.ToString(dataGridView1.CurrentRow.Cells["Apellido Paterno"].Value) + " " + Convert.ToString(dataGridView1.CurrentRow.Cells["Apellido Materno"].Value);
            comboBox1.SelectedItem= Convert.ToString(dataGridView1.CurrentRow.Cells["Puesto"].Value);
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {
            Usuarios desple = new Usuarios();
            MessageBox.Show(desple.editarElTipoDeUsuario(id, (comboBox1.GetItemText(comboBox1.SelectedItem).ToString())));
            if(Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value)==Cache.Id)
            {
                Application.Restart();
            }
            


        }
    }
}
