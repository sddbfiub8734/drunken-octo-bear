﻿namespace GrouponDesktop.AbmCliente
{
    partial class AltaCliente
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
            this.Limpiar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.datosClientes = new System.Windows.Forms.GroupBox();
            this.ConfirmarPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.MonthCalendar();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.CodigoPostal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ciudadCliente = new System.Windows.Forms.ComboBox();
            this.PasswordCliente = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DireccionC = new System.Windows.Forms.TextBox();
            this.DNICliente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.FchNacimientoCliente = new System.Windows.Forms.TextBox();
            this.TelefonoCliente = new System.Windows.Forms.TextBox();
            this.ApellidoCliente = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.TextBox();
            this.MailCliente = new System.Windows.Forms.TextBox();
            this.UsernameCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.ListaZonas = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datosClientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(20, 454);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 2;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(536, 454);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 3;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // datosClientes
            // 
            this.datosClientes.Controls.Add(this.ConfirmarPassword);
            this.datosClientes.Controls.Add(this.label8);
            this.datosClientes.Controls.Add(this.Fecha);
            this.datosClientes.Controls.Add(this.Seleccionar);
            this.datosClientes.Controls.Add(this.CodigoPostal);
            this.datosClientes.Controls.Add(this.label4);
            this.datosClientes.Controls.Add(this.ciudadCliente);
            this.datosClientes.Controls.Add(this.PasswordCliente);
            this.datosClientes.Controls.Add(this.label19);
            this.datosClientes.Controls.Add(this.label12);
            this.datosClientes.Controls.Add(this.DireccionC);
            this.datosClientes.Controls.Add(this.DNICliente);
            this.datosClientes.Controls.Add(this.label20);
            this.datosClientes.Controls.Add(this.FchNacimientoCliente);
            this.datosClientes.Controls.Add(this.TelefonoCliente);
            this.datosClientes.Controls.Add(this.ApellidoCliente);
            this.datosClientes.Controls.Add(this.NombreCliente);
            this.datosClientes.Controls.Add(this.MailCliente);
            this.datosClientes.Controls.Add(this.UsernameCliente);
            this.datosClientes.Controls.Add(this.label7);
            this.datosClientes.Controls.Add(this.label6);
            this.datosClientes.Controls.Add(this.label5);
            this.datosClientes.Controls.Add(this.label3);
            this.datosClientes.Controls.Add(this.label2);
            this.datosClientes.Controls.Add(this.label1);
            this.datosClientes.Controls.Add(this.Nombre);
            this.datosClientes.Location = new System.Drawing.Point(15, 12);
            this.datosClientes.Name = "datosClientes";
            this.datosClientes.Size = new System.Drawing.Size(421, 436);
            this.datosClientes.TabIndex = 28;
            this.datosClientes.TabStop = false;
            this.datosClientes.Text = "Datos Personales";
            // 
            // ConfirmarPassword
            // 
            this.ConfirmarPassword.Location = new System.Drawing.Point(144, 82);
            this.ConfirmarPassword.MaxLength = 30;
            this.ConfirmarPassword.Name = "ConfirmarPassword";
            this.ConfirmarPassword.Size = new System.Drawing.Size(209, 20);
            this.ConfirmarPassword.TabIndex = 57;
            this.ConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Confirmación de Password:";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(191, 167);
            this.Fecha.Name = "Fecha";
            this.Fecha.TabIndex = 55;
            this.Fecha.Visible = false;
            this.Fecha.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Fecha_DateSelected);
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(277, 238);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.Seleccionar.TabIndex = 54;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.Location = new System.Drawing.Point(143, 385);
            this.CodigoPostal.MaxLength = 9;
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(209, 20);
            this.CodigoPostal.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Código Postal";
            // 
            // ciudadCliente
            // 
            this.ciudadCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadCliente.FormattingEnabled = true;
            this.ciudadCliente.Location = new System.Drawing.Point(144, 341);
            this.ciudadCliente.Name = "ciudadCliente";
            this.ciudadCliente.Size = new System.Drawing.Size(209, 21);
            this.ciudadCliente.TabIndex = 51;
            // 
            // PasswordCliente
            // 
            this.PasswordCliente.Location = new System.Drawing.Point(144, 52);
            this.PasswordCliente.MaxLength = 30;
            this.PasswordCliente.Name = "PasswordCliente";
            this.PasswordCliente.Size = new System.Drawing.Size(209, 20);
            this.PasswordCliente.TabIndex = 47;
            this.PasswordCliente.UseSystemPasswordChar = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 344);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Ciudad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Password";
            // 
            // DireccionC
            // 
            this.DireccionC.Location = new System.Drawing.Point(144, 300);
            this.DireccionC.MaxLength = 100;
            this.DireccionC.Name = "DireccionC";
            this.DireccionC.Size = new System.Drawing.Size(209, 20);
            this.DireccionC.TabIndex = 49;
            // 
            // DNICliente
            // 
            this.DNICliente.Location = new System.Drawing.Point(144, 269);
            this.DNICliente.MaxLength = 18;
            this.DNICliente.Name = "DNICliente";
            this.DNICliente.Size = new System.Drawing.Size(209, 20);
            this.DNICliente.TabIndex = 45;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 303);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Direccion";
            // 
            // FchNacimientoCliente
            // 
            this.FchNacimientoCliente.Enabled = false;
            this.FchNacimientoCliente.Location = new System.Drawing.Point(144, 238);
            this.FchNacimientoCliente.MaxLength = 50;
            this.FchNacimientoCliente.Name = "FchNacimientoCliente";
            this.FchNacimientoCliente.Size = new System.Drawing.Size(127, 20);
            this.FchNacimientoCliente.TabIndex = 44;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.Location = new System.Drawing.Point(144, 206);
            this.TelefonoCliente.MaxLength = 18;
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.Size = new System.Drawing.Size(209, 20);
            this.TelefonoCliente.TabIndex = 43;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.Location = new System.Drawing.Point(144, 140);
            this.ApellidoCliente.MaxLength = 30;
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.Size = new System.Drawing.Size(209, 20);
            this.ApellidoCliente.TabIndex = 42;
            // 
            // NombreCliente
            // 
            this.NombreCliente.Location = new System.Drawing.Point(144, 108);
            this.NombreCliente.MaxLength = 30;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(209, 20);
            this.NombreCliente.TabIndex = 40;
            // 
            // MailCliente
            // 
            this.MailCliente.Location = new System.Drawing.Point(144, 174);
            this.MailCliente.MaxLength = 30;
            this.MailCliente.Name = "MailCliente";
            this.MailCliente.Size = new System.Drawing.Size(209, 20);
            this.MailCliente.TabIndex = 41;
            // 
            // UsernameCliente
            // 
            this.UsernameCliente.Location = new System.Drawing.Point(144, 23);
            this.UsernameCliente.MaxLength = 30;
            this.UsernameCliente.Name = "UsernameCliente";
            this.UsernameCliente.Size = new System.Drawing.Size(209, 20);
            this.UsernameCliente.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(2, 111);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 33;
            this.Nombre.Text = "Nombre";
            // 
            // ListaZonas
            // 
            this.ListaZonas.FormattingEnabled = true;
            this.ListaZonas.Location = new System.Drawing.Point(18, 19);
            this.ListaZonas.Name = "ListaZonas";
            this.ListaZonas.Size = new System.Drawing.Size(217, 244);
            this.ListaZonas.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListaZonas);
            this.groupBox1.Location = new System.Drawing.Point(460, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 293);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zonas de Preferencia";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datosClientes);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Limpiar);
            this.MaximizeBox = false;
            this.Name = "AltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente - Alta";
            this.Load += new System.EventHandler(this.AltaCliente_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AltaCliente_FormClosing);
            this.datosClientes.ResumeLayout(false);
            this.datosClientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.GroupBox datosClientes;
        private System.Windows.Forms.TextBox CodigoPostal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ciudadCliente;
        private System.Windows.Forms.TextBox PasswordCliente;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DireccionC;
        private System.Windows.Forms.TextBox DNICliente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TelefonoCliente;
        private System.Windows.Forms.TextBox ApellidoCliente;
        private System.Windows.Forms.TextBox NombreCliente;
        private System.Windows.Forms.TextBox MailCliente;
        private System.Windows.Forms.TextBox UsernameCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.CheckedListBox ListaZonas;
        private System.Windows.Forms.TextBox FchNacimientoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar Fecha;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.TextBox ConfirmarPassword;
        private System.Windows.Forms.Label label8;

    }
}