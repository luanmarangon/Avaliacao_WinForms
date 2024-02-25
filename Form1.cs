namespace Avaliacao_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }



        private void calculadoraRateioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 calculadora = new Form2();
            calculadora.ShowDialog();

        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 pessoa = new Form3();
            pessoa.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
