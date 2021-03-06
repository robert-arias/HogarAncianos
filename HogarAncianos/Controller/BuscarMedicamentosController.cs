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
    
    class BuscarMedicamentosController
    {
        FRM_ConsultaMedicamentos FRM_ConsultaMedicamentos;
        ConnectionDB connectionDB;

        public BuscarMedicamentosController(FRM_ConsultaMedicamentos FRM_ConsultaMedicamentos)
        {
            this.FRM_ConsultaMedicamentos = FRM_ConsultaMedicamentos;
            connectionDB = new ConnectionDB();
            AgregarEventos();
            FRM_ConsultaMedicamentos.EstadoInicial();

        }

        public void AgregarEventos()
        {
            FRM_ConsultaMedicamentos.btnCancelar.Click += new EventHandler(EstadoInicial);
            FRM_ConsultaMedicamentos.btnBuscar.Click += new EventHandler(RealizarBusqueda);                    
            FRM_ConsultaMedicamentos.btnResultados.Click += new EventHandler(TodosLosMedicamentos);
            FRM_ConsultaMedicamentos.btnReporteMedicamentos.Click += new EventHandler(Reporte);
            FRM_ConsultaMedicamentos.txtBuscar.KeyDown += new KeyEventHandler(RealizarBusquedaEnter);
        }

        public void Reporte(object sender, EventArgs e)
        {
            FRM_ConsultaMedicamentos.RealizarReporte();
        }

        public void EstadoInicial(object sender, EventArgs e)
        {
            FRM_ConsultaMedicamentos.EstadoInicial();
        }

        public void TodosLosMedicamentos(object sender, EventArgs e)
        {
            if(connectionDB.GetAllMedicamento().Tables[0].Rows.Count > 0)
            {
                FRM_ConsultaMedicamentos.FillBusqueda(connectionDB.GetAllMedicamento());
            }
            else
            {
                FRM_ConsultaMedicamentos.MensajeInformativo("No se han encontrado resultados.");
            }
           

        }

        public void RealizarBusquedaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FRM_ConsultaMedicamentos.LimpiarBusqueda();
                if (FRM_ConsultaMedicamentos.verificar())
                {   if(FRM_ConsultaMedicamentos.GetBusquedaMedicamentos()!= "")
                    {
                        if (connectionDB.GetBusquedaMedicamento(FRM_ConsultaMedicamentos.GetBusquedaMedicamentos()) != null)
                        {
                            if (connectionDB.GetBusquedaMedicamento(FRM_ConsultaMedicamentos.GetBusquedaMedicamentos()).Tables[0].Rows.Count >= 1)
                            {
                                FRM_ConsultaMedicamentos.FillBusqueda(connectionDB.GetBusquedaMedicamento(FRM_ConsultaMedicamentos.GetBusquedaMedicamentos()));


                            }
                            else
                            {
                                FRM_ConsultaMedicamentos.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                            }
                        }
                        else
                        {
                            FRM_ConsultaMedicamentos.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                        }
                    }
                    else
                    {
                        FRM_ConsultaMedicamentos.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                    }
                   


                }
                else
                
                    FRM_ConsultaMedicamentos.MensajeError("Verifique que todos los datos selecccionados e ingresados " +
                        "sean correctos.");
                e.SuppressKeyPress = true; //remove ding windows sound.

            }
        }
        public void RealizarBusqueda(object sender, EventArgs e)
        {
            FRM_ConsultaMedicamentos.LimpiarBusqueda();
            if (FRM_ConsultaMedicamentos.verificar())
            {
                if (FRM_ConsultaMedicamentos.GetBusquedaMedicamentos() != "")
                {
                    if (connectionDB.GetBusquedaMedicamento(FRM_ConsultaMedicamentos.GetBusquedaMedicamentos()) != null)
                    {
                        if (connectionDB.GetBusquedaMedicamento(FRM_ConsultaMedicamentos.GetBusquedaMedicamentos()).Tables[0].Rows.Count >= 1)
                        {
                            FRM_ConsultaMedicamentos.FillBusqueda(connectionDB.GetBusquedaMedicamento(FRM_ConsultaMedicamentos.GetBusquedaMedicamentos()));


                        }
                        else
                        {
                            FRM_ConsultaMedicamentos.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                        }
                    }
                    else
                    {
                        FRM_ConsultaMedicamentos.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                    }
                }
                else
                {
                    FRM_ConsultaMedicamentos.MensajeInformativo("No se han encontrado resultados para la búsqueda especificada.");
                }



            }
            else
            { 

                FRM_ConsultaMedicamentos.MensajeError("Verifique que todos los datos selecccionados e ingresados " +
                    "sean correctos.");
            }
        }


    }
}
