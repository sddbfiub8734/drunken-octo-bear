﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;
using System.Data.SqlClient;

namespace GrouponDesktop.AbmCliente
{
    public partial class AltaProveedor : Form
    {
        public AltaProveedor()
        {
            InitializeComponent();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.RazonSocial.Text = "";
            this.UsernameP.Text = "";
            this.CUIT.Text = "";
            this.MailP.Text = "";
            this.TelefonoP.Text = "";
            this.NombreContacto.Text = "";
            this.Direccion.Text = "";
            this.CodigoPostalP.Text = "";
            this.PassP.Text = "";
            
        }

        private void AltaProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea rechazar los cambios?", "Alta proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (UsernameP.Text == "" || PassP.Text == "" ||
                       RazonSocial.Text == "" || CUIT.Text == "" ||
                       MailP.Text == "" || TelefonoP.Text == "" ||
                       Direccion.Text == "" || NombreContacto.Text == "" ||
                       ciudadP.SelectedItem.ToString() == "" ||
                       CodigoPostalP.Text == "" ||
                       RubroP.SelectedItem.ToString() == "")
            {

                MessageBox.Show("Faltan datos");
                return;
            }

            ParamSet ps = new ParamSet("GESTION_DE_PATOS.AltaProveedor");
            ps.AddParameter("@user", UsernameP.Text);
            ps.AddParameter("@pass", PassP.Text);
            ps.AddParameter("@cuit", CUIT.Text);
            ps.AddParameter("@razon_social", RazonSocial.Text);
            ps.AddParameter("@mail", MailP.Text);
            ps.AddParameter("@telefono", Int64.Parse(TelefonoP.Text));
            ps.AddParameter("@direccion", Direccion.Text);
            ps.AddParameter("@nombre_contacto", NombreContacto.Text);
            ps.AddParameter("@ciudad", ciudadP.SelectedItem.ToString());
            ps.AddParameter("@rubro", RubroP.SelectedItem.ToString());
            ps.AddParameter("@cp", Int64.Parse(CodigoPostalP.Text));


            try
            {
                SqlParameter ret = ps.execSP();
                switch (ret.Value.ToString())
                {
                    case "0":
                        MessageBox.Show("Registro realizado con éxito");
                        return;

                    case "2":
                        MessageBox.Show("El usuario ya existe");
                        return;

                    case "1":
                        MessageBox.Show("Los datos ingresados corresponden a un usuario existente");
                        return;

                }

                return;

            }
            catch (SqlException)
            {
                MessageBox.Show("Ingrese un valor correcto para el teléfono o el código postal");
            }

            return;



        }

        private void AltaProveedor_Load(object sender, EventArgs e)
        {
            DBManager manager = (DBManager)AppContext.getObject(typeof(DBManager));

            SQLResponse response = manager.executeQuery("SELECT localidad from GESTION_DE_PATOS.Localidades");

            foreach (DataRow r in response.result.Rows)
            {
                ciudadP.Items.Add(r[0]);
       
            }

            response = manager.executeQuery("SELECT descripcion from GESTION_DE_PATOS.Rubros");
            foreach (DataRow r in response.result.Rows)
            {
                RubroP.Items.Add(r[0]);
            }
            RubroP.Items.Add("Otro");
        }
       
    }
}
