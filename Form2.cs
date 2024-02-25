using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao_WinForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

       private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(tbPessoa.Text))
            {
                MessageBox.Show("Informe a Quantidade de Pessoas para o Rateio");
                return;
            }

            if (string.IsNullOrEmpty(tbConsumido.Text))
            {
                MessageBox.Show("Informe a Quantidade de Pessoas para o Rateio");
                return;
            }

            if (tbConsumido.Text.Contains(','))
            {
                tbConsumido.Text = tbConsumido.Text.Replace(',', '.');
            }

            if (tbPorcentagem.Text.Contains(','))
            {
                tbPorcentagem.Text = tbPorcentagem.Text.Replace(',', '.');
            }

            double consumido = double.Parse(tbConsumido.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            double porcentagem= double.Parse(tbPorcentagem.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            int qtdPessoas = int.Parse(tbPessoa.Text);

           
            double totalConta = consumido + (consumido * porcentagem / 100);
            double totalPessoa = totalConta / qtdPessoas;

            tbConta.Text = "R$ " + totalConta.ToString("N2");
            tbContaPessoa.Text = "R$ " + totalPessoa.ToString("N2");
            


        }
    }
}
