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
            AoClicarEmCadastrar = new Button();
            AoClicarEmAtualizar = new Button();
            AoClicarEmDeletar = new Button();
            SuspendLayout();
            // 
            // AoClicarEmCadastrar
            // 
            AoClicarEmCadastrar.Location = new Point(551, 415);
            AoClicarEmCadastrar.Name = "AoClicarEmCadastrar";
            AoClicarEmCadastrar.Size = new Size(75, 23);
            AoClicarEmCadastrar.TabIndex = 0;
            AoClicarEmCadastrar.Text = "Cadastrar";
            AoClicarEmCadastrar.UseVisualStyleBackColor = true;
            AoClicarEmCadastrar.Click += button1_Click;
            // 
            // AoClicarEmAtualizar
            // 
            AoClicarEmAtualizar.Location = new Point(632, 415);
            AoClicarEmAtualizar.Name = "AoClicarEmAtualizar";
            AoClicarEmAtualizar.Size = new Size(75, 23);
            AoClicarEmAtualizar.TabIndex = 1;
            AoClicarEmAtualizar.Text = "Atualizar";
            AoClicarEmAtualizar.UseVisualStyleBackColor = true;
            // 
            // AoClicarEmDeletar
            // 
            AoClicarEmDeletar.Location = new Point(713, 415);
            AoClicarEmDeletar.Name = "AoClicarEmDeletar";
            AoClicarEmDeletar.Size = new Size(75, 23);
            AoClicarEmDeletar.TabIndex = 2;
            AoClicarEmDeletar.Text = "Deletar";
            AoClicarEmDeletar.UseVisualStyleBackColor = true;
            // 
            // ListaCelular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AoClicarEmDeletar);
            Controls.Add(AoClicarEmAtualizar);
            Controls.Add(AoClicarEmCadastrar);
            Name = "ListaCelular";
            Text = "Lista de celulares";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button AoClicarEmCadastrar;
        private Button AoClicarEmAtualizar;
        private Button AoClicarEmDeletar;
    }
}