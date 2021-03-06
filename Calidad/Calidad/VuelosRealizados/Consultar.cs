﻿using System;
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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Se encarga de comprobar si el formato de los valores de los campos del formulario es el correcto
        /// </summary>
        /// <returns>True si el formato es el correcto</returns>
        private bool validar()
        {
            bool valido = true;

            if (comboBoxTipo.SelectedItem == null)
                valido = false;
            else if (dateTimePicker2.Value < dateTimePicker2.Value)
                valido = false;

            return valido;
        }
        
        /// <summary>
        /// Genera el reporte de los pasajeros que partieron de cada aeropuerto y en general
        /// entre 2 fechas
        /// </summary>
        /// <param name="fecha1">Fecha inicial de pasajeros a reportar</param>
        /// <param name="fecha2">Fecha final de pasajeros a reportar</param>
        private void pasajeros_partieron_general(String fecha1, String fecha2)
        {
            int count = 0;
            String resultado = "";
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "Select nombre,cantidad_pasajeros FROM Vuelo_Realizado, Aeropuerto WHERE fecha >= '"+fecha1+"'" +
                "and fecha <= '" + fecha2 + "' AND codigo_aeropuerto = Aeropuerto.codigo AND TIPO = 'A';";

            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcomando, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                String aeropuerto = reader["nombre"].ToString();
                int cantidadPasajeros = Int32.Parse(reader["cantidad_pasajeros"].ToString());

                count += cantidadPasajeros;
                resultado += "Aeropuerto: " + aeropuerto + "\tCantidad de pasajeros: " + cantidadPasajeros.ToString() + "\n";
            }
            resultado += "Cantidad de pasajeros que partieron en general: " + count.ToString();
            MessageBox.Show(resultado,"Cantidad de Pasajeros que partieron");
            con.Close();
        }

        /// <summary>
        /// Genera el reporte de la cantidad de pasajeros que llegaron por cada aeropuerto y en general
        /// entre 2 fechas
        /// </summary>
        /// <param name="fecha1">Fecha inicial de pasajeros a reportar</param>
        /// <param name="fecha2">Fecha final de pasajeros a reportar</param>
        private void pasajeros_llegaron_general(String fecha1, String fecha2)
        {
            int count = 0;
            String resultado = "";
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "Select nombre,cantidad_pasajeros FROM Vuelo_Realizado, Aeropuerto WHERE fecha >= '" + fecha1 + "'" +
                "and fecha <= '" + fecha2 + "' AND codigo_aeropuerto = Aeropuerto.codigo AND TIPO = 'D';";

            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcomando, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String aeropuerto = reader["nombre"].ToString();
                int cantidadPasajeros = Int32.Parse(reader["cantidad_pasajeros"].ToString());

                count += cantidadPasajeros;
                resultado += "Aeropuerto: " + aeropuerto + "\tCantidad de pasajeros: " + cantidadPasajeros.ToString() + "\n";
            }
            resultado += "Cantidad de pasajeros que llegaron en general: " + count.ToString();
            MessageBox.Show(resultado, "Cantidad de Pasajeros que llegaron");
            con.Close();
        }

        /// <summary>
        /// Genera el reporte de la cantidad de pasajeros que partieron por cada día de la semana
        /// entre 2 fechas
        /// </summary>
        /// <param name="fecha1">Fecha inicial de pasajeros a reportar</param>
        /// <param name="fecha2">Fecha final de pasajeros a reportar</param>
        private void pasajeros_partieron_semanal(String fecha1, String fecha2)
        {
            int count = 0;
            String resultado = "";
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "Select dia_semana,SUM(cantidad_pasajeros) as cantidad FROM Vuelo_Realizado, Vuelo WHERE fecha >= '"
                + fecha1 + "'" + "and fecha <= '" + fecha2 + "' AND codigo_vuelo = Vuelo.codigo AND Vuelo_Realizado.TIPO = 'A'" +
                "GROUP BY dia_semana;";

            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcomando, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String dia = reader["dia_semana"].ToString();
                int cantidadPasajeros = Int32.Parse(reader["cantidad"].ToString());

                count += cantidadPasajeros;
                resultado += "partidass ocurridas el " + dia + ":\t" + cantidadPasajeros.ToString() + "\n";
            }
            resultado += "Partidas ocurridas en general:\t" + count.ToString();
            MessageBox.Show(resultado, "Cantidad de Pasajeros que partieron por días de la semana");
            con.Close();
        }

        /// <summary>
        /// Genera el reporte de la cantidad de pasajeros que llegaron por cada día de la semana
        /// entre 2 fechas
        /// </summary>
        /// <param name="fecha1">Fecha inicial de pasajeros a reportar</param>
        /// <param name="fecha2">Fecha final de pasajeros a reportar</param>
        private void pasajeros_llegaron_semanal(String fecha1, String fecha2)
        {
            int count = 0;
            String resultado = "";
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-QUT45OF;Initial Catalog=Proyecto;Integrated Security=True");
            SqlConnection con = new SqlConnection("Data Source=ESTEBAN\\SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True");
            string sqlcomando = "Select dia_semana,SUM(cantidad_pasajeros) as cantidad FROM Vuelo_Realizado, Vuelo WHERE fecha >= '"
                + fecha1 + "'" + "and fecha <= '" + fecha2 + "' AND codigo_vuelo = Vuelo.codigo AND Vuelo_Realizado.TIPO = 'D'" +
                "GROUP BY dia_semana;";

            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcomando, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String dia = reader["dia_semana"].ToString();
                int cantidadPasajeros = Int32.Parse(reader["cantidad"].ToString());

                count += cantidadPasajeros;
                resultado += " Llegadas ocurridas el " + dia + ":\t" + cantidadPasajeros.ToString() + "\n";
            }
            resultado += "Llegadas ocurridas en general:\t" + count.ToString();
            MessageBox.Show(resultado, "Cantidad de Pasajeros que llegaron por días de la semana");
            con.Close();
        }
        /// <summary>
        /// Realiza las validaciones y empieza el proceso de consulta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if(validar() == true)
            {
                string fecha1 = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string fecha2 = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");

                //Selecciona el tipo de consulta según el valor del comboBox 
                switch (comboBoxTipo.SelectedIndex)
                {
                    case 0:
                        pasajeros_partieron_general(fecha1,fecha2);
                        break;
                    case 1:
                        pasajeros_llegaron_general(fecha1, fecha2);
                        break;
                    case 2:
                        pasajeros_partieron_semanal(fecha1, fecha2);
                        break;
                    case 3:
                        pasajeros_llegaron_semanal(fecha1, fecha2);
                        break;

                }
            }
            else
            {
                MessageBox.Show("Error: El formato de los datos ingresos en los campos en inválido", 
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
