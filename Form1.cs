using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Modelo : Form
    {
        public Modelo()
        {
            InitializeComponent();
        }

        static double acumulador;
        static int contador;

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {

        }
        static double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = acumulador/contador;
            return promedio;
        }
        static void RegistrarNota(double nota)
        {
            acumulador += nota;
            contador++;
        }

        private void btnAgregarNota_Click_1(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(tbIngresarNota.Text);
            RegistrarNota(nota);
            tbIngresarNota.Clear();
            lbContador.Text = contador.ToString();
        }

        private void btnConsultarPromedio_Click(object sender, EventArgs e)
        {
            double promedio = CalcularPromedio();
            lbMostrarPromedio.Text = promedio.ToString();
            
        }
    }
}
