using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassBridge
{
    public partial class Form1 : Form
    {
        public static string DificultadSeleccionada { get; private set; }
        public Form1()
        {
            InitializeComponent();
            txtJugador1.Text = "Jugador 1";
            txtJugador2.Text = "Jugador 2";
        }

        private void txtJugador1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJugador2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDificultad_Click(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            DificultadSeleccionada = cbxDificultad.SelectedItem?.ToString() ?? "Fácil";
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void lblJugador2_Click(object sender, EventArgs e)
        {

        }
    }
}
