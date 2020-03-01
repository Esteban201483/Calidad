using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calidad.VuelosRealizados
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /**
         * Verifica que todos los campos de la aplicación cumplan con el formato requerido 
         * return true si todos los campos cumplen con el formato especificado, de lo contrario false
         */
        private bool validar()
        {
            bool valido = true;

            if (comboBoxAeropuerto.Text.Equals("") || comboBoxVuelo.Text.Equals("") || dateTimePickerFecha.Text.Equals("")
                || numericUpDownPasajeros.Value.Equals("") || comboBoxTipo.SelectedText.Equals(""))
                valido = false;

            return valido;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                //Meter lógica aca xd
            }
            else
            {
                MessageBox.Show("Error: El valor ingresado en los campos no cumple con el formato especificado.");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
