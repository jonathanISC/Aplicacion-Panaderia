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
    public partial class AgregarUsuario : Form
    {
        Usuarios datosCD = new Usuarios();
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void pbCancelar_Click(object sender, EventArgs e)
        {
            empleados emp = new empleados();
            emp.Show();
            this.Close();
            
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblEdad.Text = (CalcularEdad(dateTimePicker1.Value.Date)).ToString();
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {

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

        private void pbRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty || txtApePater.Text == string.Empty || txtApeMa.Text == string.Empty || txtEmail.Text == string.Empty ||
                maskedTextBox1.Text == string.Empty || txtcalle.Text == string.Empty || txtNombre.Text == string.Empty || txtCP.Text == string.Empty ||
                txtColonia.Text == string.Empty)
            {
                MessageBox.Show("Error" +
                    "\n Porfavor no deje campos vacíos");
            }
            else
            {
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
                        if(validarCP.IsMatch(txtCP.Text))
                        {
                            if(validarTelefono.IsMatch(maskedTextBox1.Text))
                            {
                                //MessageBox.Show("Si jala");
                                if (validarNumeroCasa.IsMatch(txtNumeroCasa.Text))
                                {
                                    if(validarNombre.IsMatch(txtNombre.Text))
                                    {
                                        string repetidos = "Error al registrar un usuario" +
                            "\n Un usuario ya se encuentra registrado con el correo " + txtEmail.Text;
                                        string[] ssize = txtNombre.Text.Trim().Split(null);
                                        string nombreU = ssize[0].ToString() + "." + txtApePater.Text.Substring(0, 1) + txtApeMa.Text.Substring(0, 1);
                                        int edad = CalcularEdad(dateTimePicker1.Value.Date);
                                        
                                        Usuarios usr = new Usuarios();
                                        var result = usr.registrarUsuario((cboxTipoUsuario.GetItemText(cboxTipoUsuario.SelectedItem).ToString()), txtNombre.Text, txtApePater.Text, txtApeMa.Text, (cboxSexo.GetItemText(cboxSexo.SelectedItem).ToString()), maskedTextBox1.Text, (cboxEstado.GetItemText(cboxEstado.SelectedItem).ToString()), (cboxCiudad.GetItemText(cboxCiudad.SelectedItem).ToString()), Convert.ToInt32(txtCP.Text), txtColonia.Text, txtcalle.Text, Convert.ToInt32(txtNumeroCasa.Text), txtEmail.Text, nombreU.ToString(), dateTimePicker1.Value.ToShortDateString(), Convert.ToInt32(edad.ToString()));
                                        MessageBox.Show(result.ToString());
                                        if (result.ToString()==repetidos.ToString())
                                        {
                                            int asdasd = 1;
                                        }
                                        else
                                        {
                                            var resultado = usr.enviarDatos(txtEmail.Text);

                                            MessageBox.Show(resultado.ToString());
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nombre Invalido");
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
                           //MessageBox.Show("Si jala");
                        }
                        else
                        {
                            MessageBox.Show("Codigo postal invalido");
                        }
                       // MessageBox.Show("Si jala");
                    }
                    else
                    {
                        MessageBox.Show("Correo electronico invalido");
                    }

                    //string nombreU = txtNombre.Text + "." + txtApePater.Text.Substring(0, 1) + txtApeMa.Text.Substring(0, 1);
                    //int edad = CalcularEdad(dateTimePicker1.Value.Date);

                    //Usuarios usr = new Usuarios();
                    //var result = usr.registrarUsuario((cboxTipoUsuario.GetItemText(cboxTipoUsuario.SelectedItem).ToString()), txtNombre.Text, txtApePater.Text, txtApeMa.Text, (cboxSexo.GetItemText(cboxSexo.SelectedItem).ToString()), maskedTextBox1.Text, txtestado.Text, txtCiudad.Text, Convert.ToInt32(txtCP.Text), txtColonia.Text, txtcalle.Text, Convert.ToInt32(txtNumeroCasa.Text), txtEmail.Text, nombreU.ToString(), dateTimePicker1.Value.ToShortDateString(), Convert.ToInt32(edad.ToString()));
                    //var resultado = usr.enviarDatos(txtEmail.Text);
                    //MessageBox.Show(result.ToString());
                    //MessageBox.Show(resultado.ToString());
                }
            }

        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            
            cboxSexo.SelectedItem = "MASCULINO";
            cboxTipoUsuario.SelectedItem = "ADMINISTRADOR";
            cboxEstado.DataSource = datosCD.desplegarEstado();
            cboxEstado.DisplayMember = "estado";
            cboxEstado.SelectedIndex = 1;
            cboxCiudad.DataSource = datosCD.desplegarCiudad(cboxEstado.GetItemText(cboxEstado.SelectedItem).ToString());
            cboxCiudad.DisplayMember = "municipio";

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back|| e.KeyChar==(char)Keys.Space);
            //RegexOptions options = RegexOptions.None;
            //Regex regex = new Regex(@"[ ]{2,}", options);
            //txtNombre.Text = regex.Replace(txtNombre.Text, @" ");
        }

        private void txtApePater_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back );
        }

        private void txtApeMa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtNumeroCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
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
            
                cboxCiudad.DataSource = datosCD.desplegarCiudad(cboxEstado.GetItemText(cboxEstado.SelectedItem).ToString());
                cboxCiudad.DisplayMember = "municipio";           
        }
    }
}
