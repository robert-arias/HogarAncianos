﻿using HogarAncianos.Controller;
using HogarAncianos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HogarAncianos.View {
    public partial class FRM_Login : Form {
        
        private Usuario usuario;
        private ConnectionDB db;

        public FRM_Login() {
            InitializeComponent();
            usuario = null;
            db = new ConnectionDB();
        }

        public void ShowMessage(string message) {
            MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool VerificarCampos() {
            return string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContrasenia.Text);
        }

        public string GetUsername() {
            return txtUsuario.Text;
        }

        public bool CheckPassword(DataTable user) {
            byte[] passwordBytes = Encoding.Unicode.GetBytes(txtContrasenia.Text);
            var hasher = System.Security.Cryptography.SHA256.Create();
            byte[] hashedBytes = hasher.ComputeHash(passwordBytes);

            if (Convert.ToBase64String(hashedBytes).Equals(Convert.ToBase64String((byte[])user.Rows[0][1]))) {
                usuario = new Usuario(user.Rows[0][0].ToString(), null, user.Rows[0][2].ToString());
                return true;
            }
            else
                return false;
        }

        public Usuario GetUsuario() {
            return usuario;
        }

        public void SetUsuario() {
            usuario = null;
        }

        public void EstadoInicial() {
            txtContrasenia.Text = "";
            txtUsuario.Text = "";
        }

        public bool IniciarSesion() {
            if (!VerificarCampos()) {
                DataTable user = db.GetUsuario(GetUsername());
                if (user.Rows.Count > 0) {
                    if (CheckPassword(user)) {
                        ShowMessage("Hola, " + user.Rows[0][0].ToString() + ".\n" +
                            "Se ha ingresado al sistema correctamente");
                        EstadoInicial();
                        return true;
                    }
                    else {
                        ShowMessage("El usuario o la contraseña ingresada son incorrectas.");
                        return false;
                    }
                }
                else {
                    ShowMessage("El usuario o la contraseña ingresada son incorrectas.");
                    return false;
                }
            }
            else {
                ShowMessage("El usuario o la contraseña ingresada son incorrectas.");
                return false;
            }
        }

    }
}
