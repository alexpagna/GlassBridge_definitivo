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
    public partial class Form2 : Form
    {
        private int tiempoRestante;

        public Form2()
        {
            InitializeComponent();

            // Inicializar el Timer con el nuevo nombre tmrCronometroJuego
            tmrCronometroJuego.Interval = 1000; // Intervalo de 1 segundo
            tmrCronometroJuego.Tick += tmrCronometroJuego_Tick;

            // Inicializar el tiempo basado en la dificultad
            InicializarTiempo();
        }

        private void InicializarTiempo()
        {
            // Obtener la dificultad seleccionada de Form1 (Inicio)
            string dificultad = Form1.DificultadSeleccionada;

            // Ajustar el tiempo restante según la dificultad
            switch (dificultad)
            {
                case "Fácil":
                    tiempoRestante = 25;
                    break;
                case "Normal":
                    tiempoRestante = 15;
                    break;
                case "Difícil":
                    tiempoRestante = 10;
                    break;
                default:
                    tiempoRestante = 25; // Valor por defecto
                    break;
            }

            // Actualizar el label con el tiempo inicial
            lblTimer.Text = tiempoRestante.ToString();

            // Iniciar el Timer
            tmrCronometroJuego.Start();
        }

        private void tmrCronometroJuego_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                tiempoRestante--; // Decrementar el tiempo
                lblTimer.Text = tiempoRestante.ToString(); // Actualizar el label con el tiempo restante
            }
            else
            {
                tmrCronometroJuego.Stop(); // Detener el Timer cuando llegue a 0
                MessageBox.Show("¡El tiempo ha terminado!"); // Mostrar un mensaje cuando llegue a 0
            }
        }
    }
}
