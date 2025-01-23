using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Generadordecontrasenas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int longitud = (int)numericLongitud.Value;
            int iteraciones = (int)numericIteraciones.Value;

            if (longitud < 8 || longitud > 129)
            {
                MessageBox.Show("La longitud debe estar entre 8 y 129 caracteres.");
                return;
            }

            string contrasena = GenerarContrasena(longitud, iteraciones);
            txtContrasena.Text = contrasena;
        }

        private string GenerarContrasena(int longitud, int iteraciones)
        {
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+={}[]|:;<>,.?/";
            Random rand = new Random();
            char[] contrasena = new char[longitud];

            for (int i = 0; i < longitud; i++)
            {
                contrasena[i] = caracteres[rand.Next(caracteres.Length)];
            }

            return new string(contrasena);
        }

        private string GenerarPbkdf2Contrasena(int longitud, int iteraciones, KeyDerivationPrf prf)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            string contrasena = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: "password", // Puedes usar una cadena aleatoria aquí
                salt: salt,
                prf: prf,
                iterationCount: iteraciones,
                numBytesRequested: longitud));

            return contrasena;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtContrasena.Text);
            MessageBox.Show("Contraseña copiada al portapapeles.");
        }
    }
}