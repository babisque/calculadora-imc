using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(txtAltura.Text);
            double peso = double.Parse(txtPeso.Text);
            double imc = Math.Round(peso / (altura * altura), 2);

            if (imc < 18.5)
            {
                lblIMC.Text = $"Você sofre de magreza. IMC: {imc}";
            } else if (imc <= 24.9 && imc >= 18.5)
            {
                lblIMC.Text = $"Saudável! IMC: {imc}";
            } else if (imc <= 29.9 && imc >= 25)
            {
                lblIMC.Text = $"Você está com o peso acima. IMC: {imc}";
            } else if (imc <= 34.9 && imc >= 30)
            {
                lblIMC.Text = $"CUIDADO! Você está sofrendo de obesidade grau 1. IMC: {imc}";
            } else if (imc <= 39.9 && imc >= 35)
            {
                lblIMC.Text = $"Obesidade Severa de grau 2, procure um médico. IMC: {imc}";
            } else if (imc > 40)
            {
                lblIMC.Text = $"Obesidade mórbida, você precisa procurar um médico urgentemente. IMC: {imc}";
            }
        }
    }
}
