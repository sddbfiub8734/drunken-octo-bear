﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrouponDesktop.Core;

namespace GrouponDesktop.GUI.AbmRol
{
    public partial class ListadoRol : Form
    {
        public ListadoRol()
        {
            InitializeComponent();
        }

        private void ListadoRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2012DataSet2.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.gD2C2012DataSet2.Roles);

        }

        private void Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Si el índice es 3, quiere borrar el registro.
            if (e.ColumnIndex == 3) {
                DialogResult ret = MessageBox.Show(null, "Desea borrar el Rol?", "Confirmación", MessageBoxButtons.OKCancel);
                if (ret.Equals(DialogResult.Cancel))
                {
                    return;
                }

                DataGridViewCellCollection celdas = this.Datos.Rows[e.RowIndex].Cells;
                ParamSet builder = new ParamSet("EliminarRol");
                builder.AddParameter("nombre_rol", celdas[0].Value.ToString());
                builder.executeNoReturn();
                this.Datos.Rows.RemoveAt(e.RowIndex);
            }
            // Índice 2 es modificar columna.
            else if (e.ColumnIndex == 2)
            {
                new ModificacionRol(this.Datos.Rows[e.RowIndex].Cells[0].Value.ToString()).Show();
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void AltaRol_Click(object sender, EventArgs e)
        {
            new AltaRol().Show();
        }
    }
}
