using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercícioDAL15_03_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valor1, valor2, soma, subtracao, multiplicacao, divisao, resto;

            valor1 = Convert.ToInt32(txtValor1.Text);
            valor2 = Convert.ToInt32(txtValor2.Text);

            soma = valor1 + valor2;
            subtracao = valor1 - valor2;
            multiplicacao = valor1 * valor2;
            divisao = valor1 / valor2;
            resto = valor1 % valor2;

            txtSoma.Text = soma.ToString();
            txtSubtracao.Text = subtracao.ToString();
            txtMultiplicacao.Text = multiplicacao.ToString();
            txtDivisao.Text = divisao.ToString();
            txtResto.Text = resto.ToString() ;

        }
    }
}
