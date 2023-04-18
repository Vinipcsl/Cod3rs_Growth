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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Cor = new DataGridViewTextBoxColumn();
            Memoria = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.MenuHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Marca, Modelo, Cor, Memoria, Data });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(633, 397);
            dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            // 
            // Cor
            // 
            Cor.HeaderText = "Cor";
            Cor.Name = "Cor";
            // 
            // Memoria
            // 
            Memoria.HeaderText = "Memoria";
            Memoria.Name = "Memoria";
            // 
            // Data
            // 
            Data.HeaderText = "Ano Fabricado";
            Data.Name = "Data";
            // 
            // ListaCelular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(655, 450);
            Controls.Add(dataGridView1);
            Controls.Add(AoClicarEmDeletar);
            Controls.Add(AoClicarEmAtualizar);
            Controls.Add(BotaoCadastrar);
            Name = "ListaCelular";
            Text = "Lista de celulares";
            Load += ListaCelular_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BotaoCadastrar;
        private Button AoClicarEmAtualizar;
        private Button AoClicarEmDeletar;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Cor;
        private DataGridViewTextBoxColumn Memoria;
        private DataGridViewTextBoxColumn Data;
    }
}