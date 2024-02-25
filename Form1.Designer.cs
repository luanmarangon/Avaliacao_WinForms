namespace Avaliacao_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            formulárioToolStripMenuItem = new ToolStripMenuItem();
            calculadoraRateioToolStripMenuItem = new ToolStripMenuItem();
            pessoaToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { formulárioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(378, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // formulárioToolStripMenuItem
            // 
            formulárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraRateioToolStripMenuItem, pessoaToolStripMenuItem });
            formulárioToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formulárioToolStripMenuItem.Name = "formulárioToolStripMenuItem";
            formulárioToolStripMenuItem.Size = new Size(124, 32);
            formulárioToolStripMenuItem.Text = "Formulário";
            // 
            // calculadoraRateioToolStripMenuItem
            // 
            calculadoraRateioToolStripMenuItem.Name = "calculadoraRateioToolStripMenuItem";
            calculadoraRateioToolStripMenuItem.Size = new Size(279, 32);
            calculadoraRateioToolStripMenuItem.Text = "Calculadora - Rateio";
            calculadoraRateioToolStripMenuItem.Click += calculadoraRateioToolStripMenuItem_Click;
            // 
            // pessoaToolStripMenuItem
            // 
            pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            pessoaToolStripMenuItem.Size = new Size(279, 32);
            pessoaToolStripMenuItem.Text = "Pessoa";
            pessoaToolStripMenuItem.Click += pessoaToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(221, 399);
            button1.Name = "button1";
            button1.Size = new Size(145, 46);
            button1.TabIndex = 1;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 457);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Avaliação";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formulárioToolStripMenuItem;
        private ToolStripMenuItem calculadoraRateioToolStripMenuItem;
        private ToolStripMenuItem pessoaToolStripMenuItem;
        private Button button1;
    }
}
