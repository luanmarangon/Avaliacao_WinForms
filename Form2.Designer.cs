namespace Avaliacao_WinForms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            tbConsumido = new TextBox();
            label2 = new Label();
            tbPorcentagem = new TextBox();
            label3 = new Label();
            tbPessoa = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbConta = new Label();
            tbContaPessoa = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(212, 35);
            label1.TabIndex = 0;
            label1.Text = "Total Consumido";
            // 
            // tbConsumido
            // 
            tbConsumido.Font = new Font("Segoe UI", 15F);
            tbConsumido.Location = new Point(12, 75);
            tbConsumido.Name = "tbConsumido";
            tbConsumido.Size = new Size(437, 41);
            tbConsumido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(131, 35);
            label2.TabIndex = 2;
            label2.Text = "% Serviço";
            // 
            // tbPorcentagem
            // 
            tbPorcentagem.Font = new Font("Segoe UI", 15F);
            tbPorcentagem.Location = new Point(12, 182);
            tbPorcentagem.Name = "tbPorcentagem";
            tbPorcentagem.Size = new Size(437, 41);
            tbPorcentagem.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 253);
            label3.Name = "label3";
            label3.Size = new Size(433, 35);
            label3.TabIndex = 4;
            label3.Text = "Quantidade de Pessoas pra o Rateio";
            // 
            // tbPessoa
            // 
            tbPessoa.Font = new Font("Segoe UI", 15F);
            tbPessoa.Location = new Point(12, 291);
            tbPessoa.Name = "tbPessoa";
            tbPessoa.Size = new Size(437, 41);
            tbPessoa.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 376);
            button1.Name = "button1";
            button1.Size = new Size(437, 45);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 452);
            label4.Name = "label4";
            label4.Size = new Size(190, 38);
            label4.TabIndex = 7;
            label4.Text = "RESULTADOS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 522);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 8;
            label5.Text = "Total da Conta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 561);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 9;
            label6.Text = "Total por Pessoa:";
            // 
            // tbConta
            // 
            tbConta.AutoSize = true;
            tbConta.Location = new Point(152, 522);
            tbConta.Name = "tbConta";
            tbConta.Size = new Size(0, 20);
            tbConta.TabIndex = 10;
            // 
            // tbContaPessoa
            // 
            tbContaPessoa.AutoSize = true;
            tbContaPessoa.Location = new Point(152, 561);
            tbContaPessoa.Name = "tbContaPessoa";
            tbContaPessoa.Size = new Size(0, 20);
            tbContaPessoa.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 618);
            Controls.Add(tbContaPessoa);
            Controls.Add(tbConta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(tbPessoa);
            Controls.Add(label3);
            Controls.Add(tbPorcentagem);
            Controls.Add(label2);
            Controls.Add(tbConsumido);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Calculadora - Rateio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbConsumido;
        private Label label2;
        private TextBox tbPorcentagem;
        private Label label3;
        private TextBox tbPessoa;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label tbConta;
        private Label tbContaPessoa;
    }
}