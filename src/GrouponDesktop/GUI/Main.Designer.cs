﻿namespace GrouponDesktop.GUI
{
    partial class Main
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
            this.funcionalidades = new System.Windows.Forms.ComboBox();
            this.bienvenida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // funcionalidades
            // 
            this.funcionalidades.FormattingEnabled = true;
            this.funcionalidades.Location = new System.Drawing.Point(31, 49);
            this.funcionalidades.Name = "funcionalidades";
            this.funcionalidades.Size = new System.Drawing.Size(231, 21);
            this.funcionalidades.TabIndex = 0;
            // 
            // bienvenida
            // 
            this.bienvenida.AutoSize = true;
            this.bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenida.Location = new System.Drawing.Point(12, 9);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(90, 16);
            this.bienvenida.TabIndex = 1;
            this.bienvenida.Text = "Bienvenido ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "¿Qué desea hacer?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cerrar Sesión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bienvenida);
            this.Controls.Add(this.funcionalidades);
            this.Name = "Main";
            this.Text = "Funcionalidades";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox funcionalidades;
        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}