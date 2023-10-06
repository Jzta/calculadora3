using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;


namespace calculadora3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                      
        }


        public class LineaRecta
        {
            public double Pendiente { get; set; }
            public double Intercepto { get; set; }
            public double PuntoX1 { get; set; }
            public double PuntoY1 { get; set; }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string ecuacion1 = textBoxEcuacion1.Text.Trim(); // Elimina espacios en blanco al principio y al final
            string ecuacion2 = textBoxEcuacion2.Text.Trim();
           

            if (string.IsNullOrWhiteSpace(ecuacion1) || string.IsNullOrWhiteSpace(ecuacion2))
            {
                MessageBox.Show("Debe escribir sus ecuaciones primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método sin  hacer cálculos
            }

            LineaRecta linea1 = ParseEcuacion(ecuacion1);
            LineaRecta linea2 = ParseEcuacion(ecuacion2);

            double xInterseccion, yInterseccion;

            double m1 = linea1.Pendiente;
            double b1 = linea1.Intercepto;
            double m2 = linea2.Pendiente;
            double b2 = linea2.Intercepto;
           

            if (ResolverSistema(linea1, linea2, out xInterseccion, out yInterseccion))
            {
                labelResultado.Text = $"Las líneas se cruzan en el punto ({xInterseccion}, {yInterseccion}).";
            }
            else if (SonParalelas(linea1, linea2))
            {
                labelResultado.Text = "Las líneas son paralelas.";
            }
            else if (SonPerpendiculares(linea1, linea2))
            {
                labelResultado.Text = "Las líneas son perpendiculares.";
            }
            else
            {
                labelResultado.Text = "Las líneas son coincidentes (una es un múltiplo de la otra).";

            }


        }

        private LineaRecta ParseEcuacion(string ecuacion)
        {
            // Patrón para encontrar la pendiente (m) y el intercepto (b) en la notación "Pendiente intercepto"
            string patronPendienteIntercepto = @"y\s*=\s*(-?\d+(?:\.\d+)?)\s*x\s*([+\-])\s*(-?\d+(?:\.\d+)?)";

            // Patrón para encontrar la pendiente (m) y los puntos (x1, y1) en la notación "Punto pendiente"
            string patronPuntoPendiente = @"y\s*([+\-])\s*(-?\d+(?:\.\d+)?)\s*=\s*(-?\d+(?:\.\d+)?)\s*\*\s*\(\s*x\s*([+\-])\s*(-?\d+(?:\.\d+)?)\s*\)";

            Match matchPendienteIntercepto = Regex.Match(ecuacion, patronPendienteIntercepto);
            Match matchPuntoPendiente = Regex.Match(ecuacion, patronPuntoPendiente);

            LineaRecta linea = new LineaRecta();

            if (matchPendienteIntercepto.Success)
            {
                // Encontró la notación "Pendiente intercepto"
                double pendiente = double.Parse(matchPendienteIntercepto.Groups[1].Value);
                double intercepto = double.Parse(matchPendienteIntercepto.Groups[3].Value);

                if (matchPendienteIntercepto.Groups[2].Value == "-")
                {
                    intercepto = -intercepto; // Si el signo es "-", cambia el signo del intercepto.
                }

                linea.Pendiente = pendiente;
                linea.Intercepto = intercepto;
            }
            else if (matchPuntoPendiente.Success)
            {
                // Encontró la notación "Punto pendiente"
                double pendiente = double.Parse(matchPuntoPendiente.Groups[3].Value);
                double x1 = double.Parse(matchPuntoPendiente.Groups[5].Value);
                double y1 = double.Parse(matchPuntoPendiente.Groups[2].Value);

                if (matchPuntoPendiente.Groups[1].Value == "-")
                {
                    y1 = -y1; // Si el signo es "-", cambia el signo de y1.
                }

                if (matchPuntoPendiente.Groups[4].Value == "-")
                {
                    x1 = -x1; // Si el signo es "-", cambia el signo de x1.
                }

                linea.Pendiente = pendiente;
                linea.PuntoX1 = x1;
                linea.PuntoY1 = y1;
            }
            else
            {
                // No se pudo analizar la ecuación
                throw new ArgumentException("La ecuación no es válida.");
            }

            return linea;
        }

        private bool ResolverSistema(LineaRecta linea1, LineaRecta linea2, out double xInterseccion, out double yInterseccion)
        {
            // Calcula las coordenadas x e y de la intersección
            xInterseccion = (linea2.Intercepto - linea1.Intercepto) / (linea1.Pendiente - linea2.Pendiente);
            yInterseccion = linea1.Pendiente * xInterseccion + linea1.Intercepto;

            // Verifica si las líneas son coincidentes (una es un múltiplo de la otra)
            if (linea1.Pendiente == linea2.Pendiente && linea1.Intercepto == linea2.Intercepto)
            {
                return false; // Las líneas son coincidentes
            }

            // Si las líneas se cruzan, devuelve true
            return true;
        }

        private bool SonParalelas(LineaRecta linea1, LineaRecta linea2)
        {
            // Verifica si las pendientes son iguales (las líneas son paralelas)
            return linea1.Pendiente == linea2.Pendiente;
        }

        private bool SonPerpendiculares(LineaRecta linea1, LineaRecta linea2)
        {
            // Verifica si el producto de las pendientes es igual a -1 (las líneas son perpendiculares)
            return Math.Abs(linea1.Pendiente * linea2.Pendiente) == 1;
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }

       
       

    }
}