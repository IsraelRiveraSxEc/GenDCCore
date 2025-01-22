using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GeneradorDeContrasenas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int longitud = (int)numericUpDownLongitud.Value;
            bool incluirMayusculas = checkBoxMayusculas.Checked;
            bool incluirEspeciales = checkBoxEspeciales.Checked;
            bool incluirNumeros = checkBoxNumeros.Checked;

            string contrasena = GenerarContrasena(longitud, incluirMayusculas, incluirEspeciales, incluirNumeros);
            textBoxContrasena.Text = contrasena;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxContrasena.Text);
            MessageBox.Show("Contraseña copiada al portapapeles");
        }

        private string GenerarContrasena(int longitud, bool incluirMayusculas, bool incluirEspeciales, bool incluirNumeros)
        {
            const string minusculas = "abcdefghijklmnopqrstuvwxyz";
            const string mayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeros = "0123456789";
            const string especiales = "!@#$%^&*()-_=+[]{}|;:,.<>?";

            StringBuilder caracteres = new StringBuilder(minusculas);
            if (incluirMayusculas) caracteres.Append(mayusculas);
            if (incluirNumeros) caracteres.Append(numeros);
            if (incluirEspeciales) caracteres.Append(especiales);

            if (caracteres.Length == 0)
                throw new ArgumentException("Debe seleccionar al menos un tipo de carácter.");

            char[] contrasena = new char[longitud];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[4 * longitud];
                rng.GetBytes(data);

                for (int i = 0; i < longitud; i++)
                {
                    int rnd = BitConverter.ToInt32(data, i * 4);
                    contrasena[i] = caracteres[rnd % caracteres.Length];
                }
            }

            return new string(contrasena);
        }
    }
}