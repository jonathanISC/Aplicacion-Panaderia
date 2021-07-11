
namespace WindowsFormsApp1
{
    partial class AgregarUsuario
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
            this.cboxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cboxSexo = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pbCancelar = new System.Windows.Forms.PictureBox();
            this.pbRegistrar = new System.Windows.Forms.PictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApeMa = new System.Windows.Forms.TextBox();
            this.txtApePater = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.cboxCiudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxTipoUsuario
            // 
            this.cboxTipoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.cboxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoUsuario.Font = new System.Drawing.Font("Montserrat Light", 9F);
            this.cboxTipoUsuario.FormattingEnabled = true;
            this.cboxTipoUsuario.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAPTURISTA"});
            this.cboxTipoUsuario.Location = new System.Drawing.Point(491, 263);
            this.cboxTipoUsuario.Name = "cboxTipoUsuario";
            this.cboxTipoUsuario.Size = new System.Drawing.Size(103, 24);
            this.cboxTipoUsuario.TabIndex = 2;
            // 
            // cboxSexo
            // 
            this.cboxSexo.BackColor = System.Drawing.SystemColors.Window;
            this.cboxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSexo.Font = new System.Drawing.Font("Montserrat Light", 9F);
            this.cboxSexo.FormattingEnabled = true;
            this.cboxSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cboxSexo.Location = new System.Drawing.Point(628, 263);
            this.cboxSexo.Name = "cboxSexo";
            this.cboxSexo.Size = new System.Drawing.Size(103, 24);
            this.cboxSexo.TabIndex = 3;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Montserrat Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(500, 321);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(20, 21);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "0";
            this.lblEdad.Click += new System.EventHandler(this.lblEdad_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Montserrat Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 321);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 27);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            // 
            // pbCancelar
            // 
            this.pbCancelar.BackColor = System.Drawing.Color.Transparent;
            this.pbCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCancelar.Location = new System.Drawing.Point(693, 684);
            this.pbCancelar.Name = "pbCancelar";
            this.pbCancelar.Size = new System.Drawing.Size(137, 29);
            this.pbCancelar.TabIndex = 15;
            this.pbCancelar.TabStop = false;
            this.pbCancelar.Click += new System.EventHandler(this.pbCancelar_Click);
            // 
            // pbRegistrar
            // 
            this.pbRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.pbRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRegistrar.Location = new System.Drawing.Point(355, 678);
            this.pbRegistrar.Name = "pbRegistrar";
            this.pbRegistrar.Size = new System.Drawing.Size(191, 29);
            this.pbRegistrar.TabIndex = 16;
            this.pbRegistrar.TabStop = false;
            this.pbRegistrar.Click += new System.EventHandler(this.pbRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(215, 152);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(229, 24);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApeMa
            // 
            this.txtApeMa.BackColor = System.Drawing.Color.White;
            this.txtApeMa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApeMa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMa.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMa.Location = new System.Drawing.Point(215, 209);
            this.txtApeMa.Margin = new System.Windows.Forms.Padding(0);
            this.txtApeMa.MaxLength = 30;
            this.txtApeMa.Name = "txtApeMa";
            this.txtApeMa.ShortcutsEnabled = false;
            this.txtApeMa.Size = new System.Drawing.Size(229, 24);
            this.txtApeMa.TabIndex = 18;
            this.txtApeMa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApeMa_KeyPress);
            // 
            // txtApePater
            // 
            this.txtApePater.BackColor = System.Drawing.Color.White;
            this.txtApePater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApePater.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePater.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePater.Location = new System.Drawing.Point(489, 152);
            this.txtApePater.Margin = new System.Windows.Forms.Padding(0);
            this.txtApePater.MaxLength = 30;
            this.txtApePater.Name = "txtApePater";
            this.txtApePater.ShortcutsEnabled = false;
            this.txtApePater.Size = new System.Drawing.Size(229, 24);
            this.txtApePater.TabIndex = 19;
            this.txtApePater.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApePater_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(215, 265);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(229, 24);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtcalle
            // 
            this.txtcalle.BackColor = System.Drawing.Color.White;
            this.txtcalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcalle.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcalle.Location = new System.Drawing.Point(221, 440);
            this.txtcalle.Margin = new System.Windows.Forms.Padding(0);
            this.txtcalle.MaxLength = 40;
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.ShortcutsEnabled = false;
            this.txtcalle.Size = new System.Drawing.Size(229, 24);
            this.txtcalle.TabIndex = 22;
            this.txtcalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcalle_KeyPress);
            // 
            // txtCP
            // 
            this.txtCP.BackColor = System.Drawing.Color.White;
            this.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCP.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(221, 496);
            this.txtCP.Margin = new System.Windows.Forms.Padding(0);
            this.txtCP.MaxLength = 5;
            this.txtCP.Name = "txtCP";
            this.txtCP.ShortcutsEnabled = false;
            this.txtCP.Size = new System.Drawing.Size(229, 24);
            this.txtCP.TabIndex = 23;
            this.txtCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCP_KeyPress);
            // 
            // txtColonia
            // 
            this.txtColonia.BackColor = System.Drawing.Color.White;
            this.txtColonia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColonia.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(221, 553);
            this.txtColonia.Margin = new System.Windows.Forms.Padding(0);
            this.txtColonia.MaxLength = 40;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.ShortcutsEnabled = false;
            this.txtColonia.Size = new System.Drawing.Size(229, 24);
            this.txtColonia.TabIndex = 24;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColonia_KeyPress);
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.BackColor = System.Drawing.Color.White;
            this.txtNumeroCasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroCasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroCasa.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(491, 440);
            this.txtNumeroCasa.Margin = new System.Windows.Forms.Padding(0);
            this.txtNumeroCasa.MaxLength = 5;
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.ShortcutsEnabled = false;
            this.txtNumeroCasa.Size = new System.Drawing.Size(229, 24);
            this.txtNumeroCasa.TabIndex = 25;
            this.txtNumeroCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCasa_KeyPress);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Montserrat Light", 14.25F);
            this.maskedTextBox1.Location = new System.Drawing.Point(489, 209);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.maskedTextBox1.Mask = "999-99-99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ShortcutsEnabled = false;
            this.maskedTextBox1.Size = new System.Drawing.Size(229, 24);
            this.maskedTextBox1.TabIndex = 28;
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // cboxEstado
            // 
            this.cboxEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.Font = new System.Drawing.Font("Montserrat Light", 9.3F);
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Location = new System.Drawing.Point(497, 496);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(112, 24);
            this.cboxEstado.TabIndex = 29;
            this.cboxEstado.SelectedIndexChanged += new System.EventHandler(this.cboxEstado_SelectedIndexChanged);
            // 
            // cboxCiudad
            // 
            this.cboxCiudad.BackColor = System.Drawing.SystemColors.Window;
            this.cboxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCiudad.Font = new System.Drawing.Font("Montserrat Light", 9.3F);
            this.cboxCiudad.FormattingEnabled = true;
            this.cboxCiudad.Location = new System.Drawing.Point(628, 496);
            this.cboxCiudad.Name = "cboxCiudad";
            this.cboxCiudad.Size = new System.Drawing.Size(168, 24);
            this.cboxCiudad.TabIndex = 30;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.RegistroUsuarios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(916, 750);
            this.Controls.Add(this.cboxCiudad);
            this.Controls.Add(this.cboxEstado);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApePater);
            this.Controls.Add(this.txtApeMa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pbRegistrar);
            this.Controls.Add(this.pbCancelar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.cboxSexo);
            this.Controls.Add(this.cboxTipoUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxTipoUsuario;
        private System.Windows.Forms.ComboBox cboxSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pbCancelar;
        private System.Windows.Forms.PictureBox pbRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApeMa;
        private System.Windows.Forms.TextBox txtApePater;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.ComboBox cboxCiudad;
    }
}