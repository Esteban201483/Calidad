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

        /// <summary>
        /// Comprueba si existe o no el vuelo especificado
        /// </summary>
        /// <param name="codigo">El código del vuelo a verificar</param>
        /// <returns></returns>
        private bool existeVuelo(string codigo)
        {
            bool existe = false;
            int count = 0;
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
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

        /// <summary>
        /// Indica si existe o no el aeropuerto específicado
        /// </summary>
        /// <param name="codigo">El código del aeropuerto a verificar</param>
        /// <returns></returns>
        private bool existeAeropuerto(string codigo)
        {
            bool existe = false;
            int count = 0;
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "SELECT COUNT(*) AS TOTAL FROM Aeropuerto WHERE codigo = '" + codigo + "'";
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



        /// <summary>
        /// Verifica que todos los campos de la aplicación cumplan con el formato requerido 
        /// </summary>
        /// <returns>True si se cumple con el formato establecido</returns>
        private bool validar()
        {
            bool valido = true;

            /*if (textBoxAeropuerto.Text.Equals("") || textBoxVuelo.Text.Equals("") || dateTimePickerFecha.Text.Equals("")
                || numericUpDownPasajeros.Value.Equals("") || comboBoxTipo.SelectedText.Equals(""))
                valido = false;*/

            return valido;
        }

        /// <summary>
        /// Realiza las validaciones y el proceso de inserción de un vuelo realizado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                if (existeVuelo(textBoxVuelo.Text))
                {
                    if (existeAeropuerto(textBoxAeropuerto.Text))
                    {
                        string tipo = "A";
                        if (comboBoxTipo.SelectedIndex == 1)
                        {
                            tipo = "D";
                        }
                        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
                        SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
                        string sqlcomando = "INSERT INTO Vuelo_Realizado VALUES('" + textBoxAeropuerto.Text + "','"
                                                    + textBoxVuelo.Text + "','"
                                                    + dateTimePickerFecha.Value.ToString("yyyy-MM-dd HH:mm:ss.fff") + "','"
                                                    + tipo + "','"
                                                    + numericUpDownPasajeros.Value + "'); ";
                        Debug.WriteLine(sqlcomando);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sqlcomando, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("El vuelo ha sido agregado correctamente");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("El aeropuerto ingresado no existe");
                    }
                }
                else
                {
                    MessageBox.Show("El vuelo ingresado no existe");
                }
            }
            else
            {
                MessageBox.Show("Error: El valor ingresado en los campos no cumple con el formato especificado.");
            }
        }

        /// <summary>
        /// Retorna al menú principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
