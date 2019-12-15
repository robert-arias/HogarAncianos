﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HogarAncianos.Model;
using HogarAncianos.View;

namespace HogarAncianos.Controller
{
    class AgregarPrescripcionController
    {
        FRM_AgregarPrescripcion FRM_AgregarPrescripcion;
        ConnectionDB connectionDB;
        
        public AgregarPrescripcionController(FRM_AgregarPrescripcion FRM_AgregarPrescripcion)
        {
            this.connectionDB = new ConnectionDB();
            this.FRM_AgregarPrescripcion = FRM_AgregarPrescripcion;
            AgregarEventos();
            NumeroPrescripcion();
            FRM_AgregarPrescripcion.EstadoInicial();
           
        }

        public void AgregarEventos()
        {
            FRM_AgregarPrescripcion.btnAgregarMedicamento.Click += new EventHandler(AgregarMedicamento);
            FRM_AgregarPrescripcion.btnEliminarmMedicamento.Click += new EventHandler(EliminarMedicamento);
            FRM_AgregarPrescripcion.btnVerificarMedicamento.Click += new EventHandler(Verificar);
            FRM_AgregarPrescripcion.btnVerificarPaciente.Click += new EventHandler(VerificarPaciente);
            FRM_AgregarPrescripcion.btnLimpiar.Click += new EventHandler(Limpiar);
            FRM_AgregarPrescripcion.btnAgregar.Click += new EventHandler(AgregarPrescripcion);
            FRM_AgregarPrescripcion.txtCantidad.KeyPress += new KeyPressEventHandler(ValidarCantidad);
            FRM_AgregarPrescripcion.txtCedula.KeyPress += new KeyPressEventHandler(ValidarCedula);
        }

        public void NumeroPrescripcion()
        {
            Console.WriteLine("Regsitros"+ connectionDB.GetTotalRegistrosPrescripcion().ToString());
            FRM_AgregarPrescripcion.tbNumero.Text = connectionDB.GetTotalRegistrosPrescripcion().ToString();
        }

        public void VerificarPaciente(object sender, EventArgs e)
        {
                if (FRM_AgregarPrescripcion.VerificarPaciente())
                {
                    if (connectionDB.ExisteCedulaPaciente(FRM_AgregarPrescripcion.GetCedula()))
                    {
                    FRM_AgregarPrescripcion.txtNombrePaciente.Text = connectionDB.GetNombrePaciente(FRM_AgregarPrescripcion.GetCedula()).Tables[0].Rows[0][0].ToString() + " " + connectionDB.GetNombrePaciente(FRM_AgregarPrescripcion.GetCedula()).Tables[0].Rows[0][1].ToString();
                    FRM_AgregarPrescripcion.ActivarCampos();
                    }
                    else
                    {
                        FRM_AgregarPrescripcion.MensajeError("Hay campos vacios");
                    }

                }
                else
                {
                     FRM_AgregarPrescripcion.MensajeError("La cedula digitada no se encuentra en los registros");
                }
               
        }

        public void Limpiar(object sender, EventArgs e)
        {
            FRM_AgregarPrescripcion.EstadoInicial();
        }

        public void Verificar(object sender, EventArgs e)
        {
            if (connectionDB.ExisteCodigoMedicamento(FRM_AgregarPrescripcion.GetCodigo()))
            {
                FRM_AgregarPrescripcion.ActivarAgregarMedicamento();
                FRM_AgregarPrescripcion.txtNombre.Text = connectionDB.GetNombre_CantidadDisponible_Medicamento(FRM_AgregarPrescripcion.GetCodigo()).Tables[0].Rows[0][0].ToString();

                
                if (!FRM_AgregarPrescripcion.VerificarMedicamento(FRM_AgregarPrescripcion.GetCodigo()))
                {
                    FRM_AgregarPrescripcion.labelCantidadDisponible.Text = connectionDB.GetNombre_CantidadDisponible_Medicamento(FRM_AgregarPrescripcion.GetCodigo()).Tables[0].Rows[0][1].ToString();
                }
                else
                {
                    int cantidad= int.Parse(connectionDB.GetNombre_CantidadDisponible_Medicamento(FRM_AgregarPrescripcion.GetCodigo()).Tables[0].Rows[0][1].ToString()) - FRM_AgregarPrescripcion.RetornarCantidadDisponible(FRM_AgregarPrescripcion.GetCodigo());
                    FRM_AgregarPrescripcion.labelCantidadDisponible.Text = cantidad.ToString();
                }
                

                   

            }
            else
            {
                FRM_AgregarPrescripcion.MensajeError("El codigo digitado no se encuentra ingresado en los registros");
            }
        }

        public void ValidarCantidad(object sender, KeyPressEventArgs e)
        {
            FRM_AgregarPrescripcion.SoloNumeros(e);
        }

        public void ValidarCedula(object sender, KeyPressEventArgs e)
        {
            FRM_AgregarPrescripcion.SoloNumeros(e);
        }

        public void AgregarMedicamento(object sender, EventArgs e)
        {
            FRM_AgregarPrescripcion.AgregarMedicamento();
            FRM_AgregarPrescripcion.EstadoInicialMedicamento();

        }

        public void EliminarMedicamento(object sender, EventArgs e)
        {
            FRM_AgregarPrescripcion.EliminarMedicamento();
            FRM_AgregarPrescripcion.EstadoInicialMedicamento();
        }

        public void AgregarPrescripcion(object sender, EventArgs e)
        {
            
                if (FRM_AgregarPrescripcion.dtgMedicamento.Rows.Count > 0)
                {

                    if (connectionDB.AgregarPrescripcion_Medicamentos(FRM_AgregarPrescripcion.GetPrescripcionMedicamentos()))
                    {
                        if (connectionDB.AgregarPrescripcion(FRM_AgregarPrescripcion.GetPrescripcion()))
                        {
                            FRM_AgregarPrescripcion.MensajeInformativo("Prescripcion agregada exitosamente");
                            NumeroPrescripcion();
                           FRM_AgregarPrescripcion.EstadoInicial();
                         }
                        else
                        {
                            FRM_AgregarPrescripcion.MensajeError("No ha agregado la prescripcion.");
                        }
                    }
                    else
                    {
                         FRM_AgregarPrescripcion.MensajeError("No ha agregado  la prescripcion medicamentos.");
                    }
                }
                else
                {
                    FRM_AgregarPrescripcion.MensajeError("No ha agregado medicamentos a la prescripcion.");
                }
                                                   
        }

        


    }
}
