using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrando_datos
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string paterno = textBox2.Text;
            string materno = textBox3.Text;
            string edad = textBox4.Text;
            string gmail = textBox5.Text;
            string usuario = usuarioo.Text;
            string contraseña = this.contraseña.Text;
            string telefono = textBox8.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(nombre) || !ValidarSoloLetras(nombre))
                {
                    MessageBox.Show("Por favor, completa el campo nombre solo con letras.");
                }
                else if (string.IsNullOrWhiteSpace(paterno) || !ValidarSoloLetras(paterno))
                {
                    MessageBox.Show("Por favor, completa el campo apellido paterno solo con letras.");
                }
                else if (string.IsNullOrWhiteSpace(materno) || !ValidarSoloLetras(materno))
                {
                    MessageBox.Show("Por favor, completa el campo apellido materno solo con letras.");
                }
                else if (string.IsNullOrWhiteSpace(edad) || !ValidarEdad(edad))
                {
                    MessageBox.Show("Por favor, ingresa una edad válida de 2 caracteres numéricos.");
                }
                else if (string.IsNullOrWhiteSpace(telefono) || !ValidarTelefono(telefono))
                {
                    MessageBox.Show("Por favor, completa el campo teléfono con 10 dígitos numéricos.");
                }
                else if (string.IsNullOrWhiteSpace(gmail) || !ValidarCorreoElectronico(gmail))
                {
                    MessageBox.Show("Por favor, ingresa un correo electrónico válido.");
                }
                else if (string.IsNullOrWhiteSpace(usuario) || usuario.Length < 3)
                {
                    MessageBox.Show("El nombre de usuario debe contener al menos 3 caracteres.");
                }
                else
               {
                    MessageBox.Show("¡Bienvenido!");
                    this.Hide();

                    Form2 producto = new Form2();
                    producto.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarSoloLetras(string texto)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(texto, @"^[a-zA-Z\s]+$");
        }

        private bool ValidarEdad(string edad)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(edad, @"^\d{2}$");
        }

        private bool ValidarTelefono(string telefono)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^\d{10}$");
        }

        private bool ValidarCorreoElectronico(string correo)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(correo, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$");
        }

        private bool ValidarContraseña(string contraseña)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(contraseña, @"^(?=.*[a-zA-Z])(?=.*\d).{6,15}$");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ingresa = new Form1();
            ingresa.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


