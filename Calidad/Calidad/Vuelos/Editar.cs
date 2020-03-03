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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Verifica que todos los campos de la aplicación cumplan con el formato requerido 
        /// </summary>
        /// <returns>True si se cumple el formato establecido</returns>
        private bool validar()
        {
            bool valido = true;

            if (textBoxCompañia.Text.Equals("") || textBoxPais.Text.Equals("")
                || comboBoxDia.Text.Equals("") || comboBoxTipo.Text.Equals(""))
                valido = false;


            return valido;
        }

        /// <summary>
        /// Se encarga de realizar las validaciones y de realizar el proceso de modificación del vuelo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                DialogResult boton = MessageBox.Show("¿Desea modificar los datos de este vuelo?", "Confirmación",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (boton == DialogResult.OK)
                { 
                    //Meter lógica aca xd
                    string tipo = "A";
                    if (comboBoxTipo.SelectedIndex == 1)
                    {
                        tipo = "D";
                    }
                    //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
                    SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
                    string sqlcomando = "UPDATE Vuelo SET "
                                                + "dia_semana='" + comboBoxDia.Text + "',"
                                                + "tipo='" + tipo + "',"
                                                + "capacidad_maxima='" + numericUpDownCapacidad.Value.ToString() + "',"
                                                + "pais='" + textBoxPais.Text + "',"
                                                + "compañia='" + textBoxCompañia.Text + "'"
                                                + "WHERE codigo='" +comboBoxCodigo.Text+ "'; ";
                    Debug.WriteLine(sqlcomando);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sqlcomando, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos se han actualizado correctamente");
                    con.Close();
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
        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Carga todos los códigos de vuelos existentes en el comboBoxCodigo
        /// </summary>
        private void cargar_codigos()
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "SELECT codigo FROM Vuelo";
            Debug.WriteLine(sqlcomando);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcomando, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxCodigo.Items.Add(reader["codigo"]);
            }

            con.Close();
        }

        /// <summary>
        /// Carga todos los datos de un vuelo en los campos correspondientes del formulario.
        /// </summary>
        /// <param name="codigo">El código del vuelo a cargar</param>
        private void cargar_datos(String codigo)
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "SELECT * FROM Vuelo WHERE codigo = '"+codigo+"'";
            Debug.WriteLine(sqlcomando);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcomando, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                textBoxCompañia.Text = reader["compañia"].ToString();
                textBoxPais.Text = reader["pais"].ToString();
                comboBoxDia.Text = reader["dia_semana"].ToString();
                if(reader["tipo"].ToString().Equals("A"))
                    comboBoxTipo.Text = "Arrival";
                else
                    comboBoxTipo.Text = "Departure";

                numericUpDownCapacidad.Value = Int32.Parse(reader["capacidad_maxima"].ToString());
            }

            con.Close();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            cargar_codigos();
        }

        private void comboBoxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargar_datos(comboBoxCodigo.Text.ToString());
        }
    }
}
