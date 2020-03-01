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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool validar()
        {
            bool valido = true;

            if (comboBoxTipo.SelectedItem == null)
                valido = false;
            else if (dateTimePicker2.Value < dateTimePicker2.Value)
                valido = false;

            return valido;
        }

        private void pasajeros_partieron_diario()
        {

        }

        private void pasajeros_llegaron_diario()
        {

        }

        private void pasajeros_partieron_semanal()
        {

        }

        private void pasajeros_llegaron_semanal()
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(validar() == true)
            {
                switch(comboBoxTipo.SelectedIndex)
                {
                    case 0:
                        pasajeros_partieron_diario();
                        break;
                    case 1:
                        pasajeros_llegaron_diario();
                        break;
                    case 2:
                        pasajeros_partieron_semanal();
                        break;
                    case 3:
                        pasajeros_llegaron_semanal();
                        break;

                }
            }
            else
            {
                MessageBox.Show("Error: El formato de los datos ingresos en los campos en inválido", 
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
