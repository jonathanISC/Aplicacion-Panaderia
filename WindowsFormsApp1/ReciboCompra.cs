using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReciboCompra : Form
    {
        public ReciboCompra()
        {
            InitializeComponent();
        }

        private void ReciboCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'PanaderiaDBDataSet.fechaVenta' Puede moverla o quitarla según sea necesario.
            this.fechaVentaTableAdapter.Fill(this.PanaderiaDBDataSet.fechaVenta);
            // TODO: esta línea de código carga datos en la tabla 'PanaderiaDBDataSet.verRecibidoYCambio' Puede moverla o quitarla según sea necesario.
            this.verRecibidoYCambioTableAdapter.Fill(this.PanaderiaDBDataSet.verRecibidoYCambio);
            // TODO: esta línea de código carga datos en la tabla 'PanaderiaDBDataSet.EmpleadoAtendio' Puede moverla o quitarla según sea necesario.
            this.EmpleadoAtendioTableAdapter.Fill(this.PanaderiaDBDataSet.EmpleadoAtendio);
            // TODO: esta línea de código carga datos en la tabla 'PanaderiaDBDataSet.ticketVender' Puede moverla o quitarla según sea necesario.
            this.ticketVenderTableAdapter.Fill(this.PanaderiaDBDataSet.ticketVender);
            // TODO: esta línea de código carga datos en la tabla 'PanaderiaDBDataSet.total' Puede moverla o quitarla según sea necesario.
            this.totalTableAdapter.Fill(this.PanaderiaDBDataSet.total);

            this.reportViewer1.RefreshReport();
        }
    }
}
