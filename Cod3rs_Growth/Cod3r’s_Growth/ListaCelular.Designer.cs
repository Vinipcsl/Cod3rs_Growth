namespace Cod3r_s_Growth
{
    partial class ListaCelular
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
            BotaoCadastrar = new Button();
            BotaoAtualizar = new Button();
            BotaoDeletar = new Button();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // BotaoCadastrar
            // 
            BotaoCadastrar.Location = new Point(408, 415);
            BotaoCadastrar.Name = "BotaoCadastrar";
            BotaoCadastrar.Size = new Size(75, 23);
            BotaoCadastrar.TabIndex = 0;
            BotaoCadastrar.Text = "Cadastrar";
            BotaoCadastrar.UseVisualStyleBackColor = true;
            BotaoCadastrar.Click += AoClicarEmCadastrar;
            // 
            // BotaoAtualizar
            // 
            BotaoAtualizar.Location = new Point(489, 415);
            BotaoAtualizar.Name = "BotaoAtualizar";
            BotaoAtualizar.Size = new Size(75, 23);
            BotaoAtualizar.TabIndex = 1;
            BotaoAtualizar.Text = "Atualizar";
            BotaoAtualizar.UseVisualStyleBackColor = true;
            BotaoAtualizar.Click += AoClicarEmAtualizar;
            // 
            // BotaoDeletar
            // 
            BotaoDeletar.Location = new Point(570, 415);
            BotaoDeletar.Name = "BotaoDeletar";
            BotaoDeletar.Size = new Size(75, 23);
            BotaoDeletar.TabIndex = 2;
            BotaoDeletar.Text = "Deletar";
            BotaoDeletar.UseVisualStyleBackColor = true;
            BotaoDeletar.Click += AoClicarEmDeletar;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(643, 397);
            dataGridView2.TabIndex = 4;
            // 
            // ListaCelular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(669, 450);
            Controls.Add(dataGridView2);
            Controls.Add(BotaoDeletar);
            Controls.Add(BotaoAtualizar);
            Controls.Add(BotaoCadastrar);
            Name = "ListaCelular";
            Text = "Lista de celulares";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BotaoCadastrar;
        private Button BotaoAtualizar;
        private Button BotaoDeletar;
        private DataGridView dataGridView2;
    }
}