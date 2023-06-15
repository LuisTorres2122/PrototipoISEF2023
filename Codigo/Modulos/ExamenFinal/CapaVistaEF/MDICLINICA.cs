﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorEF;

namespace CapaVistaEF
{
    public partial class MDICLINICA : Form
    {
       Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        TControlador controlador = new TControlador();
        public MDICLINICA()
        {
            InitializeComponent();
            customizeDesing();
            Button[] apps = { btnProveedor, btnMoviminetos};
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(2001, apps[0]);
       
            cnseg.getAccesoApp(2101, apps[1]);
            
        }

        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelcatalogo.Visible = false;
            panelProcesos.Visible = false;
            panelReportes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelcatalogo.Visible == true)
                panelcatalogo.Visible = false;
            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelcatalogo);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void btnMoviminetos_Click(object sender, EventArgs e)
        {
            //Codigo
            facturacion moviminetos = new facturacion();
            moviminetos.MdiParent = this;
            moviminetos.Show();

            //Ocultar submenu
            hideSubMenu();
        }

        private void btnreportemovimientos_Click(object sender, EventArgs e)
        {
            /*Codigo
            Reporte_Cuentas_Por_Pagar rmoviminetos = new Reporte_Cuentas_Por_Pagar();
            rmoviminetos.MdiParent = this;
            rmoviminetos.Show();
            //Ocultar submenu
            hideSubMenu();
            
            controlador.displayReporte("5201");
            cnseg.setBtitacora("5201", "Reporte Estado de cuenta");*/
        }

        private void btnProveedor_Click_1(object sender, EventArgs e)
        {
            //Codigo
            Paciente paciente = new Paciente();
            paciente.MdiParent = this;
            paciente.Show();

            //Ocultar submenu
            hideSubMenu();
        }

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            //Codigo
            /* Concepto concepto = new Concepto();
             concepto.MdiParent = this;
             concepto.Show();
             //Ocultar submenu
             hideSubMenu();*/
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void btnTipoPago_Click(object sender, EventArgs e)
        {
            //Codigo
            /* TipoPago tipo = new TipoPago();
             tipo.MdiParent = this;
             tipo.Show();
             //Ocultar submenu
             hideSubMenu();*/
        }

        private void btnMoneda_Click(object sender, EventArgs e)
        {
            //Codigo
            /* Moneda moneda = new Moneda();
             moneda.MdiParent = this;
             moneda.Show();
             //Ocultar submenu
             hideSubMenu();*/
        }

        private void btnAntiguedad_Click(object sender, EventArgs e)
        {
            /*//Codigo
            Antiguedad_de_saldos antiguedad = new Antiguedad_de_saldos();
            antiguedad.MdiParent = this;
            antiguedad.Show();
            //Ocultar submenu
            hideSubMenu();
            controlador.displayReporte("5202");
            cnseg.setBtitacora("5202", "Reporte Balance"); */
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            //Codigo
            /* Balance balance = new Balance();
             balance.MdiParent = this;
             balance.Show();
             //Ocultar submenu
             hideSubMenu();*/

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //Codigo
            /* Factura factura = new Factura();
             factura.MdiParent = this;
             factura.Show();
             //Ocultar submenu
             hideSubMenu();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*controlador.displayReporte("5203");
            cnseg.setBtitacora("5203", "Reporte de Kardex");*/
        }

        private void btnantiguedadsaldos_Click(object sender, EventArgs e)
        {
            /* controlador.displayReporte("5204");
             cnseg.setBtitacora("5204", "Reporte de antiguedad de saldos ");*/
        }

        private void MDICLINICA_Load(object sender, EventArgs e)
        {

        }
    }
}
