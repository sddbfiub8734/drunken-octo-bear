﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;
using System.Globalization;

namespace GrouponDesktop.GUI.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            for (int a = 2000; a <= DateTime.Now.Year; a++)
            {
                this.Anio.Items.Add(a.ToString());
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            if (Anio.SelectedItem == null || Semestre.SelectedItem == null || TipoListado.SelectedItem == null)
            {
                MessageBox.Show("Faltan Datos");
                return;
            }

            String tipo = this.TipoListado.SelectedItem.ToString();
            SQLResponse r;
            DBManager dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
            DateTime fechaDesde;
            DateTime fechaHasta;
            if (Semestre.SelectedItem.ToString() == "1")
            {
                fechaDesde = new DateTime(Int32.Parse(Anio.Text), 1, 1, 0, 0, 0);
                fechaHasta = new DateTime(Int32.Parse(Anio.Text), 6, 30, 23, 59, 59);
            }
            else
            {
                fechaDesde = new DateTime(Int32.Parse(Anio.Text), 7, 1, 0, 0, 0);
                fechaHasta = new DateTime(Int32.Parse(Anio.Text), 12, 31, 23, 59, 59);
            }

            Listado listado;

            switch (tipo)
            {
                case "Top 5 Devoluciones":

                    r = dbManager.executeQuery("SELECT * FROM GESTION_DE_PATOS.top_devoluciones('" + fechaDesde.ToString("yyyy'-'dd'-'MM HH':'mm':'ss") + "', '" + fechaHasta.ToString("yyyy'-'dd'-'MM HH':'mm':'ss") + "')");
                    listado = new Listado();
                    listado.SetDataGridView(r.result);
                    listado.Show();

                    return;

                case "Top 5 Acreditación de Giftcards":

                    r = dbManager.executeQuery("SELECT * FROM GESTION_DE_PATOS.top_giftcards('" + fechaDesde.ToString("yyyy'-'dd'-'MM HH':'mm':'ss") + "', '" + fechaHasta.ToString("yyyy'-'dd'-'MM HH':'mm':'ss") + "')");
                    listado = new Listado();
                    listado.SetDataGridView(r.result);
                    listado.Show();

                    return;
            }


        }
    }
}
