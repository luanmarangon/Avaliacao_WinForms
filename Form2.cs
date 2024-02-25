using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            int consumido = int.Parse(tbConsumido.Text);
            double porcentagem = float.Parse(tbPorcentagem.Text);
            int qtdPessoas = int.Parse(tbPessoa.Text);

           
            double totalConta = consumido + (consumido * porcentagem / 100);
            double totalPessoa = totalConta / qtdPessoas;

            tbConta.Text = "R$ " + totalConta.ToString("N2");
            tbContaPessoa.Text = "R$ " + totalPessoa.ToString("N2");
            


        }
    }
}
