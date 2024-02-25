namespace Avaliacao_WinForms
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            tbCPF = new TextBox();
            label2 = new Label();
            tbNome = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnDeletar = new Button();
            label3 = new Label();
            tbPesquisar = new TextBox();
            btnPesquisar = new Button();
            dataGridPessoas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            tbId = new Label();
            cpfCheck = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPessoas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // tbCPF
            // 
            tbCPF.Location = new Point(22, 44);
            tbCPF.Name = "tbCPF";
            tbCPF.Size = new Size(393, 27);
            tbCPF.TabIndex = 1;
            tbCPF.TextChanged += tbCPF_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 85);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "NOME";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(22, 122);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(641, 27);
            tbNome.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(356, 174);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(456, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(569, 174);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(94, 29);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 234);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Pesquisar";
            // 
            // tbPesquisar
            // 
            tbPesquisar.Location = new Point(25, 272);
            tbPesquisar.Name = "tbPesquisar";
            tbPesquisar.Size = new Size(510, 27);
            tbPesquisar.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(569, 270);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dataGridPessoas
            // 
            dataGridPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPessoas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridPessoas.Location = new Point(22, 305);
            dataGridPessoas.Name = "dataGridPessoas";
            dataGridPessoas.RowHeadersWidth = 51;
            dataGridPessoas.Size = new Size(638, 188);
            dataGridPessoas.TabIndex = 10;
            dataGridPessoas.CellDoubleClick += dataGridPessoas_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Codigo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 315;
            // 
            // Column3
            // 
            Column3.HeaderText = "CPF";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 180;
            // 
            // tbId
            // 
            tbId.AutoSize = true;
            tbId.Location = new Point(571, 48);
            tbId.Name = "tbId";
            tbId.Size = new Size(0, 20);
            tbId.TabIndex = 12;
            tbId.Visible = false;
            // 
            // cpfCheck
            // 
            cpfCheck.AutoSize = true;
            cpfCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cpfCheck.Location = new Point(421, 43);
            cpfCheck.Name = "cpfCheck";
            cpfCheck.Size = new Size(0, 28);
            cpfCheck.TabIndex = 13;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 534);
            Controls.Add(cpfCheck);
            Controls.Add(tbId);
            Controls.Add(dataGridPessoas);
            Controls.Add(btnPesquisar);
            Controls.Add(tbPesquisar);
            Controls.Add(label3);
            Controls.Add(btnDeletar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(tbNome);
            Controls.Add(label2);
            Controls.Add(tbCPF);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Pessoa";
            ((System.ComponentModel.ISupportInitialize)dataGridPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCPF;
        private Label label2;
        private TextBox tbNome;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnDeletar;
        private Label label3;
        private TextBox tbPesquisar;
        private Button btnPesquisar;
        private DataGridView dataGridPessoas;
        private Label label4;
        private Label tbId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label cpfCheck;
    }
}