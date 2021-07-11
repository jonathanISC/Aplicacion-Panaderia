using System.Windows.Forms;
using CapaComun;
using CapaNegocios;
using System;

namespace WindowsFormsApp1
{
    public partial class MenuPrincipal : Form
    {
        int aAlmacen, aProveedor, aUsuarios, aMermas, aPan;
        double recibido;
        double cambio;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void pbSalir_Click(object sender, System.EventArgs e)
        {
            this.Close();
            InicioSesion inis = new InicioSesion();
            inis.Show();

        }

        private void pbCambiarContra_Click(object sender, System.EventArgs e)
        {
           // this.Hide();
            CambiarContraseña camC = new CambiarContraseña();
            camC.ShowDialog(); 
        }

        private void pbEmpleados_Click(object sender, System.EventArgs e)
        {
            empleados me = new empleados();
            me.ShowDialog();
        }

        private void pbMatrizPermisos_Click(object sender, System.EventArgs e)
        {
            matrizPermisos mPermisos = new matrizPermisos();
            mPermisos.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, System.EventArgs e)
        {
            //MessageBox.Show(Cache.tipoUs);
            Usuarios desple = new Usuarios();
            dataGridView1.DataSource = desple.mostrarPermisosLogin(Cache.tipoUs); dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
            aAlmacen = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Acceso a Almacen"].Value);
            aProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Acceso a Proveedor"].Value);
            aUsuarios = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Acceso a Usuarios"].Value);
            aMermas = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Acceso a Mermas"].Value);
            aPan = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Acceso a Pan"].Value);

            dataGridView3.DataSource = desple.stockPan();
            dataGridView3.AutoResizeColumns();
            dataGridView3.AutoResizeRows();
            dataGridView4.DataSource = desple.ventaTempo();
            dataGridView2.DataSource = desple.articulosTabla();
            dataGridView2.Columns["Numero del artículo"].Visible = false;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
            label1.Text = "-";

            //dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;





            if (Cache.tipoUs=="CAPTURISTA")
            {
                pbMatrizPermisos.Enabled = false;
            }
            else
            {
                pbMatrizPermisos.Enabled = true;
            }

            if(aAlmacen==0)
            {
                pbAlmacen.Enabled = false;
            }
            else if(aAlmacen == 1)
            {
                pbAlmacen.Enabled = true;
            }

            if (aProveedor == 0)
            {
                pbProveedor.Enabled = false;
            }
            else if (aProveedor == 1)
            {
                pbProveedor.Enabled = true;
            }
            if (aUsuarios == 0)
            {
                pbEmpleados.Enabled = false;
            }
            else if (aUsuarios == 1)
            {
                pbEmpleados.Enabled = true;
            }
            if (aMermas == 0)
            {
                pictureBox1.Enabled = false;
            }
            else if (aMermas == 1)
            {
                pictureBox1.Enabled = true;
            }
            if (aPan == 0)
            {
                pbPan.Enabled = false;
            }
            else if (aPan == 1)
            {
                pbPan.Enabled = true;
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbAgregar_Click(object sender, EventArgs e)
        {
            
            int cantiDispo = Convert.ToInt32(dataGridView3.CurrentRow.Cells["Cantidad"].Value);
            lblPrecioUni.Text= Convert.ToString(dataGridView3.CurrentRow.Cells["Precio"].Value);
            lblidPan.Text= Convert.ToString(dataGridView3.CurrentRow.Cells["ID"].Value);
            if (cantiDispo >= 1 && label1.Text!="-")
            {
                Usuarios desple = new Usuarios();
                string xd = desple.restarPan(label1.Text);
                int cantidad = Convert.ToInt32(label3.Text);
                cantidad = cantidad + 1;
                label3.Text = cantidad.ToString();
                
                dataGridView3.DataSource = desple.stockPan();
                dataGridView3.AutoResizeColumns();
                dataGridView3.AutoResizeRows();

            }
            else if(cantiDispo ==0)
            {
                MessageBox.Show("Pan Agotado");
            }
            else
            {

            }
            //Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value)


        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            
            int cantidad = Convert.ToInt32(label3.Text);
            if (cantidad <= 0)
            {
                dataGridView3.Enabled = true;
                label1.Text = "-";
                lblPrecioUni.Text = "0";
               
            }
            else
            {
                Usuarios desple = new Usuarios();
                string xd = desple.agregarPan(label1.Text);
                dataGridView3.DataSource = desple.stockPan();
                dataGridView3.AutoResizeColumns();
                dataGridView3.AutoResizeRows();
                cantidad = cantidad - 1;
                label3.Text = cantidad.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convert.ToString(dataGridView1.CurrentRow.Cells["ID"].Value)
            if (label3.Text != "0")
            {
                string fecha = DateTime.Now.ToShortDateString();
                Usuarios desple = new Usuarios();
                //string xd = desple.restarPan(label1.Text);
                //dataGridView3.DataSource = desple.stockPan();
                //dataGridView3.AutoResizeColumns();
                //dataGridView3.AutoResizeRows();

                desple.agregarArticulo(Cache.IdUser,(Cache.Nombre+" "+Cache.ApellidoPatern+" "+Cache.ApellidoMatern),label1.Text,Convert.ToDouble(lblPrecioUni.Text),Convert.ToInt32(label3.Text),fecha,Convert.ToInt32(lblidPan.Text));
                dataGridView3.Enabled = true;

                dataGridView4.DataSource = desple.ventaTempo();

                dataGridView2.DataSource = desple.articulosTabla();
                dataGridView2.Columns["Numero del artículo"].Visible = false;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoResizeRows();
                label3.Text = "0";

                double sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView2.Rows[i].Cells["Subtotal"].Value);
                }
                label4.Text = sum.ToString();
                label5.Text = (sum * .16).ToString();
                label6.Text = (sum + Convert.ToDouble(label5.Text)).ToString();

            }
            else
            {
                MessageBox.Show("Primero selecciona un articulo");
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = Convert.ToString(dataGridView3.CurrentRow.Cells["Nombre"].Value);
            dataGridView3.Enabled = false;
        }

        private void pbBorrar_Click(object sender, EventArgs e)
        {
            Usuarios desple = new Usuarios();

            //MessageBox.Show((Convert.ToInt32(dataGridView2.CurrentRow.Cells["Cantidad"].Value).ToString()));         
            desple.quitarArticulo(Convert.ToInt32(dataGridView2.CurrentRow.Cells["Numero del artículo"].Value), (Convert.ToInt32(dataGridView2.CurrentRow.Cells["Cantidad"].Value)),((dataGridView2.CurrentRow.Cells["Artículo"].Value).ToString()));
            dataGridView2.DataSource = desple.articulosTabla();
            dataGridView2.Columns["Numero del artículo"].Visible = false;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();
            dataGridView3.DataSource = desple.stockPan();
            dataGridView3.AutoResizeColumns();
            dataGridView3.AutoResizeRows();
            dataGridView4.DataSource = desple.ventaTempo();

            double sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView2.Rows[i].Cells["Subtotal"].Value);
            }
            label4.Text = sum.ToString();
            label5.Text = (sum * .16).ToString();
            label6.Text = (sum + Convert.ToDouble(label5.Text)).ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            recibido = 0;
            cambio = 0;
            Usuarios desple = new Usuarios();
            if (Convert.ToDouble(textBox1.Text) >= Convert.ToDouble(label6.Text))
            {
                
                
                desple.venderPan();
                dataGridView4.DataSource = desple.ventaTempo();
                dataGridView2.DataSource = desple.articulosTabla();
                dataGridView2.Columns["Numero del artículo"].Visible = false;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoResizeRows();
                label11.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(label6.Text)).ToString();
                recibido = Convert.ToDouble(textBox1.Text);
                cambio = Convert.ToDouble(label11.Text);
                desple.insertarRecibidoCambio(recibido, cambio);
                ReciboCompra ticket = new ReciboCompra();
                ticket.ShowDialog();
                textBox1.Text = "0";
                label4.Text = "0";
                label5.Text = "0";
                label6.Text = "0";
                label3.Text = "0";
                desple.limpiarRecibiCambi();

            }
            else
            {
                MessageBox.Show("Cantidad recibida insuficiente");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios desple = new Usuarios();
            desple.sumarStocks(label1.Text,Convert.ToInt32(textBox2.Text));
            dataGridView3.DataSource = desple.stockPan();
            dataGridView3.AutoResizeColumns();
            dataGridView3.AutoResizeRows();
            textBox2.Text = "0";
            dataGridView3.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentasH vh = new VentasH();
            vh.ShowDialog();
        }

        private void pbProveedor_Click(object sender, System.EventArgs e)
        {
            Proveedor camC = new Proveedor();
            camC.ShowDialog();
        }

        private void pbAlmacen_Click(object sender, System.EventArgs e)
        {
            Almacen camC = new Almacen();
            camC.ShowDialog();
        }

        private void pbPan_Click(object sender, System.EventArgs e)
        {
            Pan camC = new Pan();
            camC.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            Mermas camC = new Mermas();
            camC.ShowDialog();
        }
    }
}
