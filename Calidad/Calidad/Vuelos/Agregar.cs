using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;


namespace Calidad.Vuelos
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

            if (textBoxCodigo.Text.Equals("") || textBoxCompañia.Text.Equals("") || textBoxPais.Text.Equals("")
                || comboBoxDia.SelectedText.Equals("") || comboBoxTipo.SelectedText.Equals(""))
                valido = false;

            return valido;
        }

        private bool existeVuelo(string codigo)
        {
            bool existe = false;
            int count = 0;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            //SqlConnection con = new SqlConnection("Data Source=ESTEBAN\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "SELECT COUNT(*) AS TOTAL FROM Vuelo WHERE codigo = '" + codigo + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcomando, con);
            count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                existe = true;
            }
            return existe;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!existeVuelo(textBoxCodigo.Text))
            {
                string tipo = "A";
                if (comboBoxTipo.SelectedIndex == 1)
                {
                    tipo = "D";
                }
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
                //SqlConnection con = new SqlConnection("Data Source=ESTEBAN\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
                string sqlcomando = "INSERT INTO Vuelo VALUES('" + textBoxCodigo.Text + "','"
                                                                + textBoxCompañia.Text + "','"
                                                                + comboBoxDia.Text + "','"
                                                                + textBoxPais.Text + "','"
                                                                + tipo + "',"
                                                                + numericUpDownCapacidad.Value + "); ";
                Debug.WriteLine(sqlcomando);
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlcomando, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(sqlcomando);
                con.Close();
            }
            else
            {
                MessageBox.Show("El vuelo ingresado ya existe");
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
