using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificaTaxaFrete.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxGramas.Text = string.Empty;
            tbxNome.Text = string.Empty;
            cbxDestino.Text = string.Empty;
            tbxFrete.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularFrete(); 
        }

        public void CalcularFrete()
        {
            string destino = cbxDestino.Text;
            decimal valorDestino = 0;
            decimal valorFreteMinino = 10;
            decimal valorFrete = 0;

            switch (destino)
            {
                case "SP":
                    valorDestino = 0.5m;

                    break;
                case "RJ":
                    valorDestino = 0.8m;
                    break;
                case "MG":
                    valorDestino = 0.9m;
                    break;
                case "BA":
                    valorDestino = 1m;
                    break;
                case "PB":
                    valorDestino = 1.5m;
                    break;
                default:
                    valorDestino = 2m;
                    break;
            }
            valorFrete = (valorFreteMinino * valorDestino) + valorFreteMinino;

            tbxFrete.Text = valorFrete.ToString();

        }
    }
}
