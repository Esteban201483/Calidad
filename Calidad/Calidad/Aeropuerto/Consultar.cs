using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calidad.Aeropuerto
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoEstebanDataSet.Aeropuerto' Puede moverla o quitarla según sea necesario.
            this.aeropuertoTableAdapter.Fill(this.proyectoEstebanDataSet.Aeropuerto);

        }

        /// <summary>
        /// Retorna al menú principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonRegresar_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
