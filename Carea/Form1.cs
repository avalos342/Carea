using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Cuadrado(numLadoCuadrado.Value);
            lblAreaCuadrado.Text = resultado + ""; 
        }

        private void BtnAreaTriangulo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Triangulo(numBaseTriangulo.Value, numAlturaTriangulo.Value);
            lblAreaTriangulo.Text = resultado + "";
        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Rectangulo(numBaseRectangulo.Value, numAlturaRectangulo.Value);
            lblAreaRectangulo.Text = resultado + "";
        }

        private void btnAreaRombo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Rombo(numDiagonalMayorRombo.Value, numDiagonalMenorRombo.Value);
            lblAreaRombo.Text = resultado + "";
        }

        private void btnAreaRomboide_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Romboide(numBaseRomboide.Value, numAlturaRomboide.Value);
            lblAreaRomboide.Text = resultado + "";
        }

        private void btnAreaTrapecio_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Trapecio(numAlturaTrapecio.Value, numBaseMayorTrapecio.Value, numBaseMenorTrapecio.Value);
            lblAreaTrapecio.Text = resultado + "";
        }

        private void btnAreaCirculo_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Circulo(numRadioAlCuadradoCirculo.Value);
            lblAreaCirculo.Text = resultado + "";
        }

        private void btnAreaPoligono_Click(object sender, EventArgs e)
        {
            decimal resultado = CAreas.Poligono(numPerimetroPoligono.Value , numApotemaPoligono.Value);
            lblAreaPoligono.Text = resultado + "";
        }
    }
}
