
namespace WindowsFormsApp1
{
    partial class ReciboCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PanaderiaDBDataSet = new WindowsFormsApp1.PanaderiaDBDataSet();
            this.fechaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaVentaTableAdapter = new WindowsFormsApp1.PanaderiaDBDataSetTableAdapters.fechaVentaTableAdapter();
            this.verRecibidoYCambioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verRecibidoYCambioTableAdapter = new WindowsFormsApp1.PanaderiaDBDataSetTableAdapters.verRecibidoYCambioTableAdapter();
            this.EmpleadoAtendioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpleadoAtendioTableAdapter = new WindowsFormsApp1.PanaderiaDBDataSetTableAdapters.EmpleadoAtendioTableAdapter();
            this.ticketVenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketVenderTableAdapter = new WindowsFormsApp1.PanaderiaDBDataSetTableAdapters.ticketVenderTableAdapter();
            this.totalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalTableAdapter = new WindowsFormsApp1.PanaderiaDBDataSetTableAdapters.totalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PanaderiaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verRecibidoYCambioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoAtendioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketVenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet4";
            reportDataSource1.Value = this.fechaVentaBindingSource;
            reportDataSource2.Name = "DataSet5";
            reportDataSource2.Value = this.verRecibidoYCambioBindingSource;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.EmpleadoAtendioBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.ticketVenderBindingSource;
            reportDataSource5.Name = "DataSet3";
            reportDataSource5.Value = this.totalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(463, 559);
            this.reportViewer1.TabIndex = 0;
            // 
            // PanaderiaDBDataSet
            // 
            this.PanaderiaDBDataSet.DataSetName = "PanaderiaDBDataSet";
            this.PanaderiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fechaVentaBindingSource
            // 
            this.fechaVentaBindingSource.DataMember = "fechaVenta";
            this.fechaVentaBindingSource.DataSource = this.PanaderiaDBDataSet;
            // 
            // fechaVentaTableAdapter
            // 
            this.fechaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // verRecibidoYCambioBindingSource
            // 
            this.verRecibidoYCambioBindingSource.DataMember = "verRecibidoYCambio";
            this.verRecibidoYCambioBindingSource.DataSource = this.PanaderiaDBDataSet;
            // 
            // verRecibidoYCambioTableAdapter
            // 
            this.verRecibidoYCambioTableAdapter.ClearBeforeFill = true;
            // 
            // EmpleadoAtendioBindingSource
            // 
            this.EmpleadoAtendioBindingSource.DataMember = "EmpleadoAtendio";
            this.EmpleadoAtendioBindingSource.DataSource = this.PanaderiaDBDataSet;
            // 
            // EmpleadoAtendioTableAdapter
            // 
            this.EmpleadoAtendioTableAdapter.ClearBeforeFill = true;
            // 
            // ticketVenderBindingSource
            // 
            this.ticketVenderBindingSource.DataMember = "ticketVender";
            this.ticketVenderBindingSource.DataSource = this.PanaderiaDBDataSet;
            // 
            // ticketVenderTableAdapter
            // 
            this.ticketVenderTableAdapter.ClearBeforeFill = true;
            // 
            // totalBindingSource
            // 
            this.totalBindingSource.DataMember = "total";
            this.totalBindingSource.DataSource = this.PanaderiaDBDataSet;
            // 
            // totalTableAdapter
            // 
            this.totalTableAdapter.ClearBeforeFill = true;
            // 
            // ReciboCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 559);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReciboCompra";
            this.Text = "ReciboCompra";
            this.Load += new System.EventHandler(this.ReciboCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanaderiaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verRecibidoYCambioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoAtendioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketVenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource fechaVentaBindingSource;
        private PanaderiaDBDataSet PanaderiaDBDataSet;
        private System.Windows.Forms.BindingSource verRecibidoYCambioBindingSource;
        private System.Windows.Forms.BindingSource EmpleadoAtendioBindingSource;
        private System.Windows.Forms.BindingSource ticketVenderBindingSource;
        private System.Windows.Forms.BindingSource totalBindingSource;
        private PanaderiaDBDataSetTableAdapters.fechaVentaTableAdapter fechaVentaTableAdapter;
        private PanaderiaDBDataSetTableAdapters.verRecibidoYCambioTableAdapter verRecibidoYCambioTableAdapter;
        private PanaderiaDBDataSetTableAdapters.EmpleadoAtendioTableAdapter EmpleadoAtendioTableAdapter;
        private PanaderiaDBDataSetTableAdapters.ticketVenderTableAdapter ticketVenderTableAdapter;
        private PanaderiaDBDataSetTableAdapters.totalTableAdapter totalTableAdapter;
    }
}