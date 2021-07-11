
namespace WindowsFormsApp1
{
    partial class empleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.pbAgregarUsuario = new System.Windows.Forms.PictureBox();
            this.pbEditarUsuario = new System.Windows.Forms.PictureBox();
            this.pbCambiarTipoUsuario = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pbReenviarCreedenciales = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCambiarTipoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReenviarCreedenciales)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Montserrat Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nombre",
            "Correo electronico",
            "Numero de telefono"});
            this.comboBox2.Location = new System.Drawing.Point(202, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(239, 45);
            this.comboBox2.TabIndex = 1;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltro.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(503, 204);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(0);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(254, 24);
            this.txtFiltro.TabIndex = 10;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // pbSalir
            // 
            this.pbSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalir.Location = new System.Drawing.Point(31, 91);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(246, 61);
            this.pbSalir.TabIndex = 11;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // pbAgregarUsuario
            // 
            this.pbAgregarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAgregarUsuario.Location = new System.Drawing.Point(87, 709);
            this.pbAgregarUsuario.Name = "pbAgregarUsuario";
            this.pbAgregarUsuario.Size = new System.Drawing.Size(221, 145);
            this.pbAgregarUsuario.TabIndex = 12;
            this.pbAgregarUsuario.TabStop = false;
            this.pbAgregarUsuario.Click += new System.EventHandler(this.pbAgregarUsuario_Click);
            // 
            // pbEditarUsuario
            // 
            this.pbEditarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbEditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditarUsuario.Location = new System.Drawing.Point(334, 709);
            this.pbEditarUsuario.Name = "pbEditarUsuario";
            this.pbEditarUsuario.Size = new System.Drawing.Size(221, 145);
            this.pbEditarUsuario.TabIndex = 13;
            this.pbEditarUsuario.TabStop = false;
            this.pbEditarUsuario.Click += new System.EventHandler(this.pbEditarUsuario_Click);
            // 
            // pbCambiarTipoUsuario
            // 
            this.pbCambiarTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbCambiarTipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCambiarTipoUsuario.Location = new System.Drawing.Point(595, 709);
            this.pbCambiarTipoUsuario.Name = "pbCambiarTipoUsuario";
            this.pbCambiarTipoUsuario.Size = new System.Drawing.Size(252, 145);
            this.pbCambiarTipoUsuario.TabIndex = 14;
            this.pbCambiarTipoUsuario.TabStop = false;
            this.pbCambiarTipoUsuario.Click += new System.EventHandler(this.pbCambiarTipoUsuario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Location = new System.Drawing.Point(1, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 439);
            this.dataGridView1.TabIndex = 15;
            // 
            // pbReenviarCreedenciales
            // 
            this.pbReenviarCreedenciales.BackColor = System.Drawing.Color.Transparent;
            this.pbReenviarCreedenciales.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.reenviar_mensaje1;
            this.pbReenviarCreedenciales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbReenviarCreedenciales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReenviarCreedenciales.Location = new System.Drawing.Point(1257, 406);
            this.pbReenviarCreedenciales.Name = "pbReenviarCreedenciales";
            this.pbReenviarCreedenciales.Size = new System.Drawing.Size(127, 84);
            this.pbReenviarCreedenciales.TabIndex = 16;
            this.pbReenviarCreedenciales.TabStop = false;
            this.pbReenviarCreedenciales.Click += new System.EventHandler(this.pbReenviarCreedenciales_Click);
            // 
            // empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.MenuUsuarios__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1396, 873);
            this.Controls.Add(this.pbReenviarCreedenciales);
            this.Controls.Add(this.pbCambiarTipoUsuario);
            this.Controls.Add(this.pbEditarUsuario);
            this.Controls.Add(this.pbAgregarUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.pbSalir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "empleados";
            this.Load += new System.EventHandler(this.empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgregarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCambiarTipoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReenviarCreedenciales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.PictureBox pbAgregarUsuario;
        private System.Windows.Forms.PictureBox pbEditarUsuario;
        private System.Windows.Forms.PictureBox pbCambiarTipoUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbReenviarCreedenciales;
    }
}