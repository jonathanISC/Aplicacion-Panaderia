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
    public partial class matrizPermisos : Form
    {
        string AccesoAlmacen;
        string AccesoProveedor;
        string AccesoUsuarios;
        string AccesoMermas;
        string AccesoPan;
        string nombreTipo;
        Usuarios desple = new Usuarios();
        public matrizPermisos()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void matrizPermisos_Load(object sender, EventArgs e)
        {
            

            dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            nombreTipo = "ADMINISTRADOR";
            groupBox1.Text = "-";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             nombreTipo = Convert.ToString(dataGridView1.CurrentRow.Cells["Rol"].Value);
            groupBox1.Text = nombreTipo;

             AccesoAlmacen = Convert.ToString(dataGridView1.CurrentRow.Cells["Acceso a Almacen"].Value);
             AccesoProveedor = Convert.ToString(dataGridView1.CurrentRow.Cells["Acceso a Proveedor"].Value);
             AccesoUsuarios = Convert.ToString(dataGridView1.CurrentRow.Cells["Acceso a Usuarios"].Value);
             AccesoMermas = Convert.ToString(dataGridView1.CurrentRow.Cells["Acceso a Mermas"].Value);
             AccesoPan = Convert.ToString(dataGridView1.CurrentRow.Cells["Acceso a Pan"].Value);

            if (AccesoAlmacen == "1")
            {
                ckboxAlmacen.Checked = true;
            }
            else
            {
                ckboxAlmacen.Checked = false;
            }

            if (AccesoProveedor == "1")
            {
                ckboxProveedor.Checked = true;
            }
            else
            {
                ckboxProveedor.Checked = false;
            }

            if (AccesoUsuarios == "1")
            {
                ckboxUsuarios.Checked = true;
            }
            else
            {
                ckboxUsuarios.Checked = false;
            }

            if (AccesoMermas == "1")
            {
                ckboxMermas.Checked = true;
            }
            else
            {
                ckboxMermas.Checked = false;
            }

            if (AccesoPan == "1")
            {
                ckboxPan.Checked = true;
            }
            else
            {
                ckboxPan.Checked = false;
            }

        }

        private void pbEditarPermiso_Click(object sender, EventArgs e)
        {
            if (groupBox1.Text != "-")
            {
                if (ckboxAlmacen.Checked == true)
                {
                    MessageBox.Show(desple.editarPermisos("permisoAlmacen", 1, nombreTipo));
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                else if (ckboxAlmacen.Checked == false)
                {
                    MessageBox.Show(desple.editarPermisos("permisoAlmacen", 0, nombreTipo));
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                if (ckboxProveedor.Checked == true)
                {
                    desple.editarPermisos("permisoProveedor", 1, nombreTipo);
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                else
                {
                    desple.editarPermisos("permisoProveedor", 0, nombreTipo);
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                if (ckboxUsuarios.Checked == true)
                {
                    desple.editarPermisos("permisoUsuarios", 1, nombreTipo);
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                else
                {
                    desple.editarPermisos("permisoUsuarios", 0, nombreTipo);
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                if (ckboxMermas.Checked == true)
                {
                    desple.editarPermisos("permisoMermas", 1, nombreTipo);
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                else
                {
                    desple.editarPermisos("permisoMermas", 0, nombreTipo);
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                if (ckboxPan.Checked == true)
                {
                    desple.editarPermisos("permisoPan", 1, nombreTipo);
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                else
                {
                    desple.editarPermisos("permisoPan", 0, nombreTipo);
                    dataGridView1.DataSource = desple.desplegarPermisos(); dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoResizeRows();
                }
                Application.Restart();

            }
            else
            {
                MessageBox.Show("Seleccione un rol");
            }
        }
    }
}
