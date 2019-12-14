﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Controller;
using HogarAncianos.Model;

namespace HogarAncianos.View
{
    public partial class FRM_EliminarMedicamento : Form
    {
        EliminarMedicamentoController eliminar;
        public FRM_EliminarMedicamento()
        {
            InitializeComponent();
            eliminar = new EliminarMedicamentoController(this);
        }

        public string GetCodigo()
        {
            return txtCodigo.Text;
        }

        public void llenarCampos(DataSet data)
        {
            txtNombre.Text = data.Tables[0].Rows[0][1].ToString();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Advertencia");
        }

        public void EstadoInicial()
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtNombre.Text = "";
            txtCodigo.Text = "";

            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public void ActivarCampo()
        {

            btnCancelar.Enabled = true;
            btnEliminar.Enabled = true;

            txtCodigo.Enabled = false;
        }

        public bool VerificarCampos()
        {
            bool vacio = true;

            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtNombre.Text))
            {
              
                vacio = false;
            }
            else
            {
                vacio = true;
            }
            return vacio;
        }

    }
}
