
namespace WindowsFormsApp1
{
    partial class matrizPermisos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckboxPan = new System.Windows.Forms.CheckBox();
            this.ckboxMermas = new System.Windows.Forms.CheckBox();
            this.ckboxUsuarios = new System.Windows.Forms.CheckBox();
            this.ckboxProveedor = new System.Windows.Forms.CheckBox();
            this.ckboxAlmacen = new System.Windows.Forms.CheckBox();
            this.pbEditarPermiso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPermiso)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSalir
            // 
            this.pbSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSalir.Location = new System.Drawing.Point(871, 399);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(157, 37);
            this.pbSalir.TabIndex = 1;
            this.pbSalir.TabStop = false;
            this.pbSalir.Click += new System.EventHandler(this.pbSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(62, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(780, 126);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ckboxPan);
            this.groupBox1.Controls.Add(this.ckboxMermas);
            this.groupBox1.Controls.Add(this.ckboxUsuarios);
            this.groupBox1.Controls.Add(this.ckboxProveedor);
            this.groupBox1.Controls.Add(this.ckboxAlmacen);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Light", 12F);
            this.groupBox1.Location = new System.Drawing.Point(848, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 214);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ckboxPan
            // 
            this.ckboxPan.AutoSize = true;
            this.ckboxPan.Location = new System.Drawing.Point(251, 101);
            this.ckboxPan.Name = "ckboxPan";
            this.ckboxPan.Size = new System.Drawing.Size(134, 26);
            this.ckboxPan.TabIndex = 4;
            this.ckboxPan.Text = "Acceso a Pan";
            this.ckboxPan.UseVisualStyleBackColor = true;
            // 
            // ckboxMermas
            // 
            this.ckboxMermas.AutoSize = true;
            this.ckboxMermas.Location = new System.Drawing.Point(251, 49);
            this.ckboxMermas.Name = "ckboxMermas";
            this.ckboxMermas.Size = new System.Drawing.Size(168, 26);
            this.ckboxMermas.TabIndex = 3;
            this.ckboxMermas.Text = "Acceso a Mermas";
            this.ckboxMermas.UseVisualStyleBackColor = true;
            // 
            // ckboxUsuarios
            // 
            this.ckboxUsuarios.AutoSize = true;
            this.ckboxUsuarios.Location = new System.Drawing.Point(20, 160);
            this.ckboxUsuarios.Name = "ckboxUsuarios";
            this.ckboxUsuarios.Size = new System.Drawing.Size(172, 26);
            this.ckboxUsuarios.TabIndex = 2;
            this.ckboxUsuarios.Text = "Acceso a Usuarios";
            this.ckboxUsuarios.UseVisualStyleBackColor = true;
            // 
            // ckboxProveedor
            // 
            this.ckboxProveedor.AutoSize = true;
            this.ckboxProveedor.Location = new System.Drawing.Point(23, 101);
            this.ckboxProveedor.Name = "ckboxProveedor";
            this.ckboxProveedor.Size = new System.Drawing.Size(185, 26);
            this.ckboxProveedor.TabIndex = 1;
            this.ckboxProveedor.Text = "Acceso a Proveedor";
            this.ckboxProveedor.UseVisualStyleBackColor = true;
            // 
            // ckboxAlmacen
            // 
            this.ckboxAlmacen.AutoSize = true;
            this.ckboxAlmacen.Location = new System.Drawing.Point(23, 49);
            this.ckboxAlmacen.Name = "ckboxAlmacen";
            this.ckboxAlmacen.Size = new System.Drawing.Size(174, 26);
            this.ckboxAlmacen.TabIndex = 0;
            this.ckboxAlmacen.Text = "Acceso a Almacen";
            this.ckboxAlmacen.UseVisualStyleBackColor = true;
            // 
            // pbEditarPermiso
            // 
            this.pbEditarPermiso.BackColor = System.Drawing.Color.Transparent;
            this.pbEditarPermiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditarPermiso.Location = new System.Drawing.Point(386, 399);
            this.pbEditarPermiso.Name = "pbEditarPermiso";
            this.pbEditarPermiso.Size = new System.Drawing.Size(221, 37);
            this.pbEditarPermiso.TabIndex = 18;
            this.pbEditarPermiso.TabStop = false;
            this.pbEditarPermiso.Click += new System.EventHandler(this.pbEditarPermiso_Click);
            // 
            // matrizPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.EditarPermisos_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1444, 562);
            this.Controls.Add(this.pbEditarPermiso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pbSalir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "matrizPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "matrizPermisos";
            this.Load += new System.EventHandler(this.matrizPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPermiso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckboxPan;
        private System.Windows.Forms.CheckBox ckboxMermas;
        private System.Windows.Forms.CheckBox ckboxUsuarios;
        private System.Windows.Forms.CheckBox ckboxProveedor;
        private System.Windows.Forms.CheckBox ckboxAlmacen;
        private System.Windows.Forms.PictureBox pbEditarPermiso;
    }
}