﻿namespace GrouponDesktop.GUI.ComprarGiftCard
{
    partial class ComprarGirftcard
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
            this.Guardar = new System.Windows.Forms.Button();
            this.Monto = new System.Windows.Forms.TextBox();
            this.ClienteDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(15, 105);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 31;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(132, 49);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(209, 20);
            this.Monto.TabIndex = 30;
            // 
            // ClienteDestino
            // 
            this.ClienteDestino.Location = new System.Drawing.Point(132, 17);
            this.ClienteDestino.Name = "ClienteDestino";
            this.ClienteDestino.Size = new System.Drawing.Size(209, 20);
            this.ClienteDestino.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Monto";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 20);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(81, 13);
            this.Nombre.TabIndex = 26;
            this.Nombre.Text = "Cliente Destino:";
            // 
            // ComprarGirftcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 140);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.ClienteDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Name = "ComprarGirftcard";
            this.Text = "ComprarGirftcard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.TextBox ClienteDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nombre;
    }
}