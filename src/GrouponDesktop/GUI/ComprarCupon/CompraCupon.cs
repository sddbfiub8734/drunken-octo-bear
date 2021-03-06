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

namespace GrouponDesktop.GUI.ComprarCupon
{
    public partial class CompraCupon : Form
    {
         DBManager dbManager = (DBManager)AppContext.getObject(typeof(DBManager));
        Session s = (Session)AppContext.getObject(typeof(Session));
        SQLResponse r;
        
        public CompraCupon()
        {
            InitializeComponent();

        }

        private void CompraCupon_Load(object sender, EventArgs e)
        {
            
            String query = "select distinct gc.id_promocion Promoción, gc.descripcion Descripción, gc.precio_real Precio, gc.fecha_vencimiento_oferta 'Vencimiento Oferta', gc.fecha_vencimiento_canje 'Vencimiento Canje', pr.CUIT Proveedor from GESTION_DE_PATOS.Promociones gc join GESTION_DE_PATOS.Localidad_por_promocion lpg on lpg.id_promocion = gc.id_promocion join GESTION_DE_PATOS.Localidad_por_usuario lpu on lpu.id_localidad = lpg.id_localidad join GESTION_DE_PATOS.Proveedores pr on pr.username = gc.proveedor where GESTION_DE_PATOS.NombreEstadoPromocion(gc.estado) = 'Publicado' and lpu.username = '" + s.username + "' and gc.fecha_vencimiento_oferta >= '" + (String)AppContext.getObject(typeof(String)) + "'";
            r = dbManager.executeQuery(query);

            this.cuponesDisponibles.DataSource = r.result;

            this.cuponesDisponibles.ReadOnly = true;
            this.cuponesDisponibles.Columns["Vencimiento Oferta"].Width = 120;
            this.cuponesDisponibles.Columns["Vencimiento Canje"].Width = 120;


            DataGridViewButtonColumn comprar = new DataGridViewButtonColumn();
            comprar.Name = "comprar";
            comprar.HeaderText = "Comprar";
            this.cuponesDisponibles.Columns.Add(comprar);
            this.cuponesDisponibles.Columns["comprar"].ReadOnly = false;

            this.cuponesDisponibles.AllowUserToAddRows = false;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cuponesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String columna_seleccionada = this.cuponesDisponibles.Columns[e.ColumnIndex].Name;

            if (columna_seleccionada == "comprar")
            {

                if (this.Cantidad.Text == "") {
                    MessageBox.Show("Ingrese una cantidad");
                    return;
                }

                Int64 cantidad = 1;
                
                try{
                    cantidad = Int64.Parse(this.Cantidad.Text);
                    
                }
                catch(FormatException){
                    MessageBox.Show("Ingrese una cantidad correcta");
                    return;
                }
                if(cantidad < 1 ){
                    MessageBox.Show("Ingrese una cantidad positiva");
                    return;
                }
                
                ParamSet ps = new ParamSet("GESTION_DE_PATOS.ValidarCompraCupon");
                ps.AddParameter("@id_promocion", this.cuponesDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
                ps.AddParameter("@fecha", (String)AppContext.getObject(typeof(String)));
                ps.AddParameter("@username", s.username);
                ps.AddParameter("@cantidad", cantidad);

                SqlParameter retval;
                
                retval = ps.execSP();
                String ret = retval.Value.ToString();

                switch (ret)
                {
                    case "1": MessageBox.Show("La compra solicitada supera el límite por usuario permitido.");
                        return;
                    case "2": MessageBox.Show("No hay stock para la compra deseada.");
                        return;
                    case "3": MessageBox.Show("El usuario no tiene saldo suficiente.");
                        return;

                    case "0":
                        String mensaje;
                        if (cantidad == 1)
                        {
                            mensaje = "Compra realizada con éxito. \nCupón nro: ";
                        }
                        else
                        {
                            mensaje = "Compra realizada con éxito. \nCupones: ";
                        }
                        SqlParameter r;
                        ps.NombreSP("GESTION_DE_PATOS.ComprarCupon");
                        mensaje += "\n";
                        int cambioDeLinea = 0;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (cambioDeLinea == 10)
                            {
                                mensaje += "\n";
                                cambioDeLinea = 0;
                            }
                            ps.AddParameter("@id_promocion", this.cuponesDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
                            ps.AddParameter("@fecha", (String)AppContext.getObject(typeof(String)));
                            ps.AddParameter("@username", s.username);
                            r = ps.execSP();
                            
                            if (i == cantidad-1)
                            {
                                mensaje += r.Value.ToString() + ".";
                            }
                            else {
                                mensaje += r.Value.ToString() + ", ";
                            }
                                Main.actualizar();
                                cambioDeLinea++;
                        }
                        MessageBox.Show(mensaje);
                        return;
                }
            }
        }
    }
}
