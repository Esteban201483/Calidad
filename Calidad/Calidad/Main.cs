using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calidad
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vuelos.Consultar consultar = new Vuelos.Consultar();
            this.Hide();
            consultar.ShowDialog();
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vuelos.Agregar agregar = new Vuelos.Agregar();
            this.Hide();
            agregar.ShowDialog();
            this.Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vuelos.Editar editar = new Vuelos.Editar();
            this.Hide();
            editar.ShowDialog();
            this.Close();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VuelosRealizados.Agregar agregar = new VuelosRealizados.Agregar();
            this.Hide();
            agregar.ShowDialog();
            this.Close();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VuelosRealizados.Consultar consultar = new VuelosRealizados.Consultar();
            this.Hide();
            consultar.ShowDialog();
            this.Close();
        }
    }
}
