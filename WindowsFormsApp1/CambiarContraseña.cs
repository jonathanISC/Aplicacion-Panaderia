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
    public partial class CambiarContraseña : Form
    {

        int cantidadAnterior;
        class ListaGenericaDoble
        {
            class Nodo
            {
                public int info;
                public Nodo ant, sig;
            }

            private Nodo raiz;

            public ListaGenericaDoble()
            {
                raiz = null;
            }

            public void Insertar(int pos, int x)
            {
                if (pos <= Cantidad() + 1)
                {
                    Nodo nuevo = new Nodo();
                    nuevo.info = x;
                    if (pos == 1)
                    {
                        nuevo.sig = raiz;
                        if (raiz != null)
                            raiz.ant = nuevo;
                        raiz = nuevo;
                    }
                    else
                        if (pos == Cantidad() + 1)
                    {
                        Nodo reco = raiz;
                        while (reco.sig != null)
                        {
                            reco = reco.sig;
                        }
                        reco.sig = nuevo;
                        nuevo.ant = reco;
                        nuevo.sig = null;
                    }
                    else
                    {
                        Nodo reco = raiz;
                        for (int f = 1; f <= pos - 2; f++)
                            reco = reco.sig;
                        Nodo siguiente = reco.sig;
                        reco.sig = nuevo;
                        nuevo.ant = reco;
                        nuevo.sig = siguiente;
                        siguiente.ant = nuevo;
                    }
                }
            }



            public void Borrar(int pos)
            {
                if (pos <= Cantidad())
                {
                    if (pos == 1)
                    {
                        raiz = raiz.sig;
                        if (raiz != null)
                            raiz.ant = null;
                    }
                    else
                    {
                        Nodo reco;
                        reco = raiz;
                        for (int f = 1; f <= pos - 2; f++)
                            reco = reco.sig;
                        Nodo prox = reco.sig;
                        prox = prox.sig;
                        reco.sig = prox;
                        if (prox != null)
                            prox.ant = reco;
                    }
                }
            }






            public bool Secuencial()
            {

                if (!Vacia())
                {
                    int actu = raiz.info;
                    Nodo sigien = raiz.sig;

                    Nodo ater = raiz.ant;
                    while (sigien != null)
                    {
                        if (sigien.info == (actu - 1) || sigien.info == (actu + 1))
                        {
                            return true;

                        }

                        actu = sigien.info;
                        sigien = sigien.sig;
                        //MessageBox.Show(actu.ToString());
                    }
                    return false;
                }
                else
                    return false;
            }



            public int Cantidad()
            {
                int cant = 0;
                Nodo reco = raiz;
                while (reco != null)
                {
                    reco = reco.sig;
                    cant++;
                }
                return cant;
            }


            public bool Vacia()
            {
                if (raiz == null)
                    return true;
                else
                    return false;
            }

            public ListBox Imprimir(ListBox lis)
            {

                Nodo reco = raiz;
                while (reco != null)
                {
                    //Console.Write(reco.info + "-");
                    lis.Items.Add(reco.info/*+"-"*/);
                    reco = reco.sig;
                }
                return lis;
            }



        }

        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            //MenuPrincipal mp = new MenuPrincipal();
            //mp.Show();
            
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtActual.UseSystemPasswordChar = false;
                txtNueva.UseSystemPasswordChar = false;
                txtRepetirNueva.UseSystemPasswordChar = false;
            }
            else
            {
                txtActual.UseSystemPasswordChar = true;
                txtNueva.UseSystemPasswordChar = true;
                txtRepetirNueva.UseSystemPasswordChar = true;
            }
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {
            Usuarios desple = new Usuarios();
            dataGridView1.DataSource= desple.verContraseña(Convert.ToString(Cache.Id));
            txtActual.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["contraseña"].Value);
            label2.Text= ("Debe contener." +
                    "\n" +
                    "\n -Minimo 8 caracteres" +
                    "\n -Maximo 255 caracteres" +
                    "\n -Al menos 1 caracter especial" +
                    "\n -Al menos una letra miniscula" +
                    "\n -Al menos una letra MAYUSCULA" +
                    "\n -No se permiten numeros de forma consecutiva" +
                    "\n -Ejemplo: 0123, 3210");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            ListaGenericaDoble lg = new ListaGenericaDoble();
            int posi = 1;
            while (posi < cantidadAnterior)
            {
                lg.Borrar(posi);
                posi++;
            }

            string cadenax = string.Empty;
            //label1.Text = (CalcularEdad(dateTimePicker1.Value.Date)).ToString();
            cadenax = txtNueva.Text;
            string cadena = string.Empty;
            int uwu = 0;

            for (int i = 0; i < cadenax.Length; i++)
            {

                if (Char.IsDigit(Convert.ToChar(cadenax[i].ToString())) == true)
                {

                    uwu++;
                    cadena = cadena.ToString() + cadenax[i].ToString();

                }
                else
                {
                    uwu++;


                    if (uwu > 1)
                    {
                        cadena = cadena + "-";

                    }
                }

            }

            var strResult = string.Empty;


            //foreach (var element in cadena.ToCharArray())
            //{
            //    if (strResult.Length == 0 || strResult[strResult.Length - 1] != element || char.IsDigit(element) == true)
            //        strResult = $"{strResult}{element}";
            //}
            //label2.Text = strResult.ToString();
            //string[] numDivididos = strResult.Split("-");

            string cadenaNumero = cadena;
            int posLista = 1;
            cantidadAnterior = cadenaNumero.Length;

            for (int i = 0; i < cadenaNumero.Length; i++)
            {
                if (cadenaNumero[i] == '-')
                {
                    //MessageBox.Show("aqui");
                    lg.Insertar(posLista, 999999);
                    posLista++;
                }
                else
                {
                    lg.Insertar(posLista, Convert.ToInt32(cadenaNumero[i].ToString()));
                    posLista++;

                }

            }

            lg.Imprimir(listBox1);

            if (lg.Secuencial() == true)
            {
                MessageBox.Show("Contraseña no valida."+
                    "\n La contraseña NO permite numeros de forma consecutiva."+
                    "\n Ejemplo: 0123, 3210");
            }
            else
            {

                Regex rgx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[&%$#!¡_@¿?+*´^`~><;\\"",\-:\[\].{}!¨|¬/()='\;])([A-Za-z\d&%$#!¡_@¿?+*´^`~><\-;¨,\\"":.{ }|¬\[\]!/()='\;^]){8,255}$");
                if (rgx.IsMatch(txtNueva.Text))
                {
                    Usuarios desple = new Usuarios();
                    if (txtNueva.Text == txtRepetirNueva.Text)
                    {
                        
                        MessageBox.Show(desple.editarContraseña(Convert.ToString(Cache.Id), txtNueva.Text));
                        MessageBox.Show( desple.enviarContraNueva(Cache.Email,Cache.Id));
                        Application.Restart();
                    }
                    else
                        MessageBox.Show("Eror Las contraseñas no coinciden");
                }
                else
                {
                    MessageBox.Show("Contraseña no valida." +
                    "\n La contraseña debe contener:" +
                    "\n -Minimo 8 caracteres" +
                    "\n -Maximo 255 caracteres"+
                    "\n -Al menos 1 caracter especial"+
                    "\n -Al menos una letra miniscula"+
                    "\n -Al menos una letra MAYUSCULA"+
                    "\n -No se permiten numeros de forma consecutiva"+
                    "\n -Ejemplo: 0123, 3210");
                }
            }


            //Usuarios desple = new Usuarios();
            //if (txtNueva.Text == txtRepetirNueva.Text)
            //{
            //    MessageBox.Show(desple.editarContraseña(Convert.ToString(Cache.Id), txtNueva.Text));
            //    Application.Restart();
            //}
            //else
            //    MessageBox.Show("Eror Las contraseñas no coinciden");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRepetirNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
           


        }

        private void txtRepetirNueva_TextChanged(object sender, EventArgs e)
        {
            if (txtRepetirNueva.Text != txtNueva.Text)
            {
                txtRepetirNueva.BackColor = Color.FromArgb(255, 106, 106);
            }
            else
                txtRepetirNueva.BackColor = Color.FromArgb(225, 225, 225);
        }

        private void txtNueva_TextChanged(object sender, EventArgs e)
        {
            if (txtRepetirNueva.Text != txtNueva.Text)
            {
                txtRepetirNueva.BackColor = Color.FromArgb(255, 106, 106);
            }
            else
                txtRepetirNueva.BackColor = Color.FromArgb(225, 225, 225);
        }
    }
}
