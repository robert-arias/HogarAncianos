﻿using System;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller {
    public class BuscarEmpleadosController {

        private FRM_BuscarEmpleados frm_BuscarEmpleados;
        private ConnectionDB connection;

        public BuscarEmpleadosController(FRM_BuscarEmpleados frm_BuscarEmpleados) {
            this.frm_BuscarEmpleados = frm_BuscarEmpleados;
            connection = new ConnectionDB();
            AgregarEventos();
        }

        private void AgregarEventos() {
            frm_BuscarEmpleados.rbCedula.CheckedChanged += new EventHandler(BuscarPorCedula);
            frm_BuscarEmpleados.rbNombre.CheckedChanged += new EventHandler(BuscarPorNombre_Apellidos);
            frm_BuscarEmpleados.rbApellidos.CheckedChanged += new EventHandler(BuscarPorNombre_Apellidos);
            frm_BuscarEmpleados.cbPuestoTrabajo.CheckedChanged += new EventHandler(CambiarEstadoDDLs);
            frm_BuscarEmpleados.cbEstadoLaboral.CheckedChanged += new EventHandler(CambiarEstadoDDLs);
            frm_BuscarEmpleados.cbTelefono.CheckedChanged += new EventHandler(NuevoCamposResultados);
            frm_BuscarEmpleados.cbDireccion.CheckedChanged += new EventHandler(NuevoCamposResultados);
            frm_BuscarEmpleados.cbSalario.CheckedChanged += new EventHandler(NuevoCamposResultados);
            frm_BuscarEmpleados.cbFechaContratacion.CheckedChanged += new EventHandler(NuevoCamposResultados);
            frm_BuscarEmpleados.cbCorreo.CheckedChanged += new EventHandler(NuevoCamposResultados);
            frm_BuscarEmpleados.btnCancelar.Click += new EventHandler(EstadoInicial);
            frm_BuscarEmpleados.btnBuscar.Click += new EventHandler(RealizarBusqueda);
        }

        private void BuscarPorCedula(object sender, EventArgs e) {
            frm_BuscarEmpleados.DesactivarBuscarPor();
        }

        private void BuscarPorNombre_Apellidos(object sender, EventArgs e) {
            frm_BuscarEmpleados.ActivarBuscarPor();
        }

        private void CambiarEstadoDDLs(object sender, EventArgs e) {
            frm_BuscarEmpleados.CambiarEstadoDDLs();
        }

        private void NuevoCamposResultados(object sender, EventArgs e) {
            frm_BuscarEmpleados.NuevosCamposResultados(sender);
        }

        private void EstadoInicial(object sender, EventArgs e) {
            frm_BuscarEmpleados.EstadoInicial();
        }

        private void RealizarBusqueda(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(frm_BuscarEmpleados.GetBusqueda())) {
                frm_BuscarEmpleados.RealizarBusqueda(connection.GetBusquedaEmpleados(
                    frm_BuscarEmpleados.GetBusqueda()));
            }
            else
                frm_BuscarEmpleados.ShowMessage("Debe ingresar algún dato de búsqueda.");
        }

    }
}