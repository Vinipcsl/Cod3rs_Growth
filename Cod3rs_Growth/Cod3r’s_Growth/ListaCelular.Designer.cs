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
            AoClicarEmAtualizar = new Button();
            AoClicarEmDeletar = new Button();
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
            // AoClicarEmAtualizar
            // 
            AoClicarEmAtualizar.Location = new Point(489, 415);
            AoClicarEmAtualizar.Name = "AoClicarEmAtualizar";
            AoClicarEmAtualizar.Size = new Size(75, 23);
            AoClicarEmAtualizar.TabIndex = 1;
            AoClicarEmAtualizar.Text = "Atualizar";
            AoClicarEmAtualizar.UseVisualStyleBackColor = true;
            // 
            // AoClicarEmDeletar
            // 
            AoClicarEmDeletar.Location = new Point(570, 415);
            AoClicarEmDeletar.Name = "AoClicarEmDeletar";
            AoClicarEmDeletar.Size = new Size(75, 23);
            AoClicarEmDeletar.TabIndex = 2;
            AoClicarEmDeletar.Text = "Deletar";
            AoClicarEmDeletar.UseVisualStyleBackColor = true;
            AoClicarEmDeletar.Click += AoClicarEmDeletar_Click;
            // 
            // dataGridView2
            // 
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
            Controls.Add(AoClicarEmDeletar);
            Controls.Add(AoClicarEmAtualizar);
            Controls.Add(BotaoCadastrar);
            Name = "ListaCelular";
            Text = "Lista de celulares";
            Load += ListarCelular;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BotaoCadastrar;
        private Button AoClicarEmAtualizar;
        private Button AoClicarEmDeletar;
        private DataGridView dataGridView2;
    }
}