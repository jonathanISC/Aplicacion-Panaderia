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
    public partial class empleados : Form
    {

        public empleados()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAgregarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarUsuario au = new AgregarUsuario();
            au.Show();
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            Usuarios desple = new Usuarios();
            dataGridView1.DataSource = desple.desplegarUsuarios(); dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            //comboBox2.SelectedIndex = 0;
        }


            

        private void pbEditarUsuario_Click(object sender, EventArgs e)
        {
            EditarUsuarios eu = new EditarUsuarios();
            eu.xdId = (Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value));
            eu.Show();
            this.Close();
        }

        private void pbCambiarTipoUsuario_Click(object sender, EventArgs e)
        {
            CambiarTipoUsuario ct = new CambiarTipoUsuario();
            ct.id = (Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value));
            ct.Show();
            this.Close();

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox2.GetItemText(comboBox2.SelectedItem).ToString() == "Nombre")
            {
                Usuarios desple = new Usuarios();
                dataGridView1.DataSource = desple.desplegarUsuariosNombre(txtFiltro.Text); dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                
            }

            if (comboBox2.GetItemText(comboBox2.SelectedItem).ToString() == "Correo electronico")
            {
                Usuarios desple = new Usuarios();
                dataGridView1.DataSource = desple.desplegarUsuariosEmail(txtFiltro.Text); dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                
            }

            if (comboBox2.GetItemText(comboBox2.SelectedItem).ToString() == "Numero de telefono")
            {
                Usuarios desple = new Usuarios();
                dataGridView1.DataSource = desple.desplegarUsuariosTelefono(txtFiltro.Text); dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRows();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pbReenviarCreedenciales_Click(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios();
            var resultado = usr.REenviarDatos(Convert.ToString(dataGridView1.CurrentRow.Cells["Correo electronico"].Value));
            MessageBox.Show(resultado.ToString());
        }
    }
}
