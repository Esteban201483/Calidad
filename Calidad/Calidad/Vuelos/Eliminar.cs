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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
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

        /// <summary>
        /// Carga el código de todos los vuelos en el comboBoxCodigo
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

        private void Eliminar_Load(object sender, EventArgs e)
        {
            cargar_codigos();
        }

        /// <summary>
        /// Realiza el proceso de eliminación del vuelo
        /// </summary>
        /// <param name="codigo">El código del vuelo a eliminar</param>
        private void eliminar_vuelo(String codigo)
        {

            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "DELETE FROM Vuelo WHERE codigo = '"+codigo+"' ";
            Debug.WriteLine(sqlcomando);
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcomando, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("El vuelo se ha eliminado correctamente");
            con.Close();
        }

        /// <summary>
        /// Se encarga de pedir la confirmación al usuario para eliminar el vuelo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult boton = MessageBox.Show("¿Desea eliminar este vuelo?", "Confirmación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (boton == DialogResult.OK)
            {
                eliminar_vuelo(comboBoxCodigo.Text);
                //Recarga los códigos de los vuelos existentes
                comboBoxCodigo.Items.Clear(); 
                cargar_codigos();
            }

        }
    }
}
