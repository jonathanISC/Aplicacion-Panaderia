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
using System.Text.RegularExpressions;


namespace WindowsFormsApp1
{
    public partial class EditarUsuarios : Form
    {
        Usuarios desple = new Usuarios();
        public string xdId;
        public EditarUsuarios()
        {
            InitializeComponent();
        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            empleados emp = new empleados();
            emp.Show();
            this.Close();
        }

        private void EditarUsuarios_Load(object sender, EventArgs e)
        {
            
            empleados id = new empleados();
            cboxEstado.DataSource = desple.desplegarEstado();
            cboxEstado.DisplayMember = "estado";
            cboxEstado.SelectedIndex = 1;
            cboxCiudad.DataSource = desple.desplegarCiudad(cboxEstado.GetItemText(cboxEstado.SelectedItem).ToString());
            cboxCiudad.DisplayMember = "municipio";
            dataGridView1.DataSource = desple.desplegarUsuariosEdit(xdId);
            txtNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
            txtApePater.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Apellido Paterno"].Value);
            txtApeMa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Apellido Materno"].Value);
            maskedTextBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Numero de telefono celular"].Value);
            cboxEstado.SelectedItem = Convert.ToString(dataGridView1.CurrentRow.Cells["Estado"].Value);
            cboxEstado.SelectedItem = Convert.ToString(dataGridView1.CurrentRow.Cells["Ciudad"].Value);
            txtCP.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Codigo Postal"].Value);
            txtColonia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Colonia"].Value);
            txtcalle.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre de la calle"].Value);
            txtNumeroCasa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Numero de casa"].Value);
            txtEmail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Correo electronico"].Value);
            cboxSexo.SelectedItem = (cboxSexo.GetItemText(Convert.ToString(dataGridView1.CurrentRow.Cells["Sexo"].Value)));
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["Fecha de nacimiento"].Value);

            
        }

        public int CalcularEdad(DateTime FechaDeNacimiento)
        {


            int edad = DateTime.Today.Year - FechaDeNacimiento.Year;

            if (DateTime.Today.Month < FechaDeNacimiento.Month)
            {
                --edad;
            }

            else if (DateTime.Today.Month == FechaDeNacimiento.Month && DateTime.Today.Day < FechaDeNacimiento.Day)
            {
                --edad;
            }

            return edad;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblEdad.Text = (CalcularEdad(dateTimePicker1.Value.Date)).ToString();
        }

        private void pbEditar_Click(object sender, EventArgs e)
        {


            string nombreU = string.Empty;
            string id = string.Empty;
            int edad = 0;
            Usuarios usr = new Usuarios();
            empleados emp = new empleados();


            if (txtNombre.Text == string.Empty || txtApePater.Text == string.Empty || txtApeMa.Text == string.Empty || txtEmail.Text == string.Empty ||
                maskedTextBox1.Text == string.Empty || txtcalle.Text == string.Empty || txtNombre.Text == string.Empty || txtCP.Text == string.Empty ||
                txtColonia.Text == string.Empty)
            {
                MessageBox.Show("Error" +
                    "\n Porfavor no deje campos vacíos");
            }
            else
            {
                string[] ssize = txtNombre.Text.Trim().Split(null);
                nombreU = ssize[0].ToString() + "." + txtApePater.Text.Substring(0, 1) + txtApeMa.Text.Substring(0, 1);
                id = Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value);
                edad = CalcularEdad(dateTimePicker1.Value.Date);

                if (Convert.ToInt32(lblEdad.Text) < 18)
                {
                    MessageBox.Show("Error" +
                        "\n El usuario debe tener al menos 18 años");
                }
                else
                {
                    Regex validarEmail = new Regex(@"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-z0A-Z-9])?");
                    Regex validarCP = new Regex(@"[0-9]{5,5}(\.[0-9]{5,5})?$");
                    Regex validarNumeroCasa = new Regex(@"[0-9]{2,5}(\.[0-9]{2,5})?$");
                    Regex validarTelefono = new Regex(@"\(?([0-9]{3})\)?([ .-]?)([0-9]{2})\2([0-9]{5})");
                    Regex validarNombre = new Regex(@"^[ ]?([^ ]+[ ])*[^ ]*$");
                    if (validarEmail.IsMatch(txtEmail.Text))
                    {
                        if (validarCP.IsMatch(txtCP.Text))
                        {
                            if (validarTelefono.IsMatch(maskedTextBox1.Text))
                            {
                                
                                if (validarNumeroCasa.IsMatch(txtNumeroCasa.Text))
                                {
                                    if (validarNombre.IsMatch(txtNombre.Text))
                                    {
                                        
                                        
                                        var edit = usr.editarUsuario(Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value), txtNombre.Text, txtApePater.Text, txtApeMa.Text, (cboxSexo.GetItemText(cboxSexo.SelectedItem).ToString()), maskedTextBox1.Text, (cboxEstado.GetItemText(cboxEstado.SelectedItem).ToString()), (cboxCiudad.GetItemText(cboxCiudad.SelectedItem).ToString()), Convert.ToInt32(txtCP.Text), txtColonia.Text, txtcalle.Text, Convert.ToInt32(txtNumeroCasa.Text), txtEmail.Text, nombreU.ToString(), dateTimePicker1.Value.ToShortDateString(), Convert.ToInt32(edad.ToString()));
                                        MessageBox.Show(edit.ToString());
                                        if (edit.ToString() == "Error al editar un usuario" +
                            "\n Un usuario ya se encuentra registrado con el correo " + txtEmail.Text.ToString())
                                        {
                                            int asdddd = 1;
                                        }
                                        else
                                        {
                                            var resultado = usr.enviarDatosEditados(txtEmail.Text, (Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value)));
                                            MessageBox.Show(resultado.ToString());
                                            this.Close();

                                            emp.Show();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nombre invalido");
                                    }

                                    }
                                else
                                {
                                    MessageBox.Show("Numero de casa invalido");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Numero de telefono invalido");
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Codigo postal invalido");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Correo electronico invalido");
                    }
                }
            }




        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Usuarios usr = new Usuarios();
            if (Cache.Id == Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value)&& Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value)!= "CWZLW")
            {
                MessageBox.Show(usr.eliminarUsuario(Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value), (Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value)), (Convert.ToString(dataGridView1.CurrentRow.Cells["Apellido Paterno"].Value))));
                Application.Restart();
            }
            else
            {
                MessageBox.Show(usr.eliminarUsuario(Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value), (Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value)), (Convert.ToString(dataGridView1.CurrentRow.Cells["Apellido Paterno"].Value))));
                this.Close();
                empleados emp = new empleados();
                emp.Show();
            }
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            //RegexOptions options = RegexOptions.None;
            //Regex regex = new Regex(@"[ ]{2,}", options);
            //txtNombre.Text = regex.Replace(txtNombre.Text, @" ");
        }

        private void txtApePater_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtApeMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtNumeroCasa_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtNumeroCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtcalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);
            txtcalle.Text = regex.Replace(txtcalle.Text, @" ");
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);
            txtColonia.Text = regex.Replace(txtColonia.Text, @" ");
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        private void cboxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboxCiudad.DataSource = desple.desplegarCiudad(cboxEstado.GetItemText(cboxEstado.SelectedItem).ToString());
            cboxCiudad.DisplayMember = "municipio";
        }
    }
}
