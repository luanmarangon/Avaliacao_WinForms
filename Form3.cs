using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;

namespace Avaliacao_WinForms
{
    public partial class Form3 : Form
    {
        string server = "localhost";
        string dataBase = "VARTECHS_SUPER";
        string user = "evandro";
        string passwd = "mudama23";
        string connectionString;

        public Form3()
        {
            InitializeComponent();
            connectionString = $"Server={server};Database={dataBase};user={user};Password={passwd};TrustServerCertificate=True";
        }

        public void insertPessoa(string nome, string cpf)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string querySelect = "SELECT COUNT(*) FROM luan WHERE cpf = @cpf";
                    using (SqlCommand commandQuery = new SqlCommand(querySelect, connection))
                    {
                        commandQuery.Parameters.AddWithValue("@cpf", cpf);

                        int trueQuery = (int)commandQuery.ExecuteScalar();

                        if (trueQuery == 0)
                        {
                            string query = "INSERT INTO luan (nome, cpf) VALUES (@nome, @cpf)";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@nome", nome);
                                command.Parameters.AddWithValue("@cpf", cpf);

                                command.ExecuteNonQuery();
                                MessageBox.Show("Pessoa Cadastrada com Sucesso!");
                                listarPessoa(null);
                            }
                        }
                        else
                        {
                            MessageBox.Show("CPF já cadastrado. Por favor verifique!");
                            listarPessoa(cpf);

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível cadastrar a Pessoa. {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void listarPessoa(string buscar)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query;

                    if (!string.IsNullOrEmpty(buscar))
                    {
                        query = "Select * FROM luan WHERE nome LIKE '%' + @buscar + '%' or cpf = @buscar";
                    }
                    else
                    {
                        query = "Select * FROM luan";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        if (!string.IsNullOrEmpty(buscar))
                        {
                            command.Parameters.AddWithValue("@buscar", buscar);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridPessoas.Rows.Clear();
                            while (reader.Read())
                            {
                                string idPessoa = reader["id"].ToString();
                                string nomePessoa = reader["nome"].ToString();
                                string cpfPessoa = reader["cpf"].ToString();

                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridPessoas);

                                row.Cells[0].Value = idPessoa;
                                row.Cells[1].Value = nomePessoa;
                                row.Cells[2].Value = cpfPessoa;

                                dataGridPessoas.Rows.Add(row);
                            }
                            dataGridPessoas.Refresh();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível Listar o Cadastro de Pessoas. {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updatePessoa(string idPessoa, string nome, string cpf)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE luan set nome = @nome, cpf = @cpf WHERE id = @idPessoa";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idPessoa", idPessoa);
                        command.Parameters.AddWithValue("@nome", nome);
                        command.Parameters.AddWithValue("@cpf", cpf);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Dados Cadastrais atualizados com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível Atualizar o Cadastro de Pessoas. {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void destroy(string idPessoa)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transactions = connection.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand command = connection.CreateCommand();
                            command.Transaction = transactions;
                            command.CommandText = "DELETE FROM luan WHERE id = @idPessoa";

                            command.Parameters.AddWithValue("@idPessoa", idPessoa);

                            command.ExecuteNonQuery();

                            transactions.Commit();
                            MessageBox.Show("Transação Concluída com Sucesso. Cadastro da Pessoa Excluída");
                            listarPessoa(null);
                        }
                        catch (Exception ex)
                        {
                            transactions.Rollback();
                            MessageBox.Show($"Transação Revertida devido erro! {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível Excluir o Cadastro da Pessoas. {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string cpf = tbCPF.Text;
            string nome = tbNome.Text;


            if (cpf.Length != 11)
            {
                MessageBox.Show("CPF Invalido");
                return;
            }

            if (String.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o Nome para o cadastro");
                return;
            }
            if (String.IsNullOrEmpty(tbId.Text))
            {
                insertPessoa(nome, cpf);
                tbCPF.Clear();
                tbNome.Clear();

            }

            if (!String.IsNullOrEmpty(tbId.Text))
            {
                string idPessoa = tbId.Text;
                updatePessoa(idPessoa, nome, cpf);
                listarPessoa(null);
                tbCPF.Clear();
                tbNome.Clear();
            }



        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string buscar = tbPesquisar.Text;
            listarPessoa(buscar);
        }

        private void dataGridPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaClicada = dataGridPessoas.Rows[e.RowIndex];

                tbId.Text = linhaClicada.Cells[0].Value.ToString();
                tbNome.Text = linhaClicada.Cells[1].Value.ToString();
                tbCPF.Text = linhaClicada.Cells[2].Value.ToString();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbCPF.Clear();
            tbNome.Clear();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string idPessoa = tbId.Text;
            if (!String.IsNullOrEmpty(idPessoa))
            {
                destroy(idPessoa);
                tbCPF.Clear();
                tbNome.Clear();
                tbId.Text = null;
                return;
            }
            MessageBox.Show("Não ");
        }
    }
}
