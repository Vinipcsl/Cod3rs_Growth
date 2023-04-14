namespace Cod3r_s_Growth
{
    partial class CadastroCelular
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
            AoClicarEmSalvar = new Button();
            AoClicarEmLimpar = new Button();
            AoClicarEmCancelar = new Button();
            TextoMarca = new TextBox();
            TextoModelo = new TextBox();
            TextoAnoFabricado = new TextBox();
            TextoMemoria = new TextBox();
            TextoCor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TextoId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // AoClicarEmSalvar
            // 
            AoClicarEmSalvar.Location = new Point(65, 318);
            AoClicarEmSalvar.Name = "AoClicarEmSalvar";
            AoClicarEmSalvar.Size = new Size(75, 23);
            AoClicarEmSalvar.TabIndex = 0;
            AoClicarEmSalvar.Text = "Salvar";
            AoClicarEmSalvar.UseVisualStyleBackColor = true;
            AoClicarEmSalvar.Click += AoClicarEmSalvar_Click;
            // 
            // AoClicarEmLimpar
            // 
            AoClicarEmLimpar.Location = new Point(146, 318);
            AoClicarEmLimpar.Name = "AoClicarEmLimpar";
            AoClicarEmLimpar.Size = new Size(75, 23);
            AoClicarEmLimpar.TabIndex = 1;
            AoClicarEmLimpar.Text = "Limpar";
            AoClicarEmLimpar.UseVisualStyleBackColor = true;
            AoClicarEmLimpar.Click += AoClicarEmLimpar_Click;
            // 
            // AoClicarEmCancelar
            // 
            AoClicarEmCancelar.Location = new Point(227, 318);
            AoClicarEmCancelar.Name = "AoClicarEmCancelar";
            AoClicarEmCancelar.Size = new Size(75, 23);
            AoClicarEmCancelar.TabIndex = 2;
            AoClicarEmCancelar.Text = "Cancelar";
            AoClicarEmCancelar.UseVisualStyleBackColor = true;
            AoClicarEmCancelar.Click += AoClicarEmCancelar_Click;
            // 
            // TextoMarca
            // 
            TextoMarca.Location = new Point(12, 65);
            TextoMarca.Name = "TextoMarca";
            TextoMarca.Size = new Size(100, 23);
            TextoMarca.TabIndex = 4;
            // 
            // TextoModelo
            // 
            TextoModelo.Location = new Point(12, 109);
            TextoModelo.Name = "TextoModelo";
            TextoModelo.Size = new Size(100, 23);
            TextoModelo.TabIndex = 5;
            // 
            // TextoAnoFabricado
            // 
            TextoAnoFabricado.Location = new Point(12, 241);
            TextoAnoFabricado.Name = "TextoAnoFabricado";
            TextoAnoFabricado.Size = new Size(100, 23);
            TextoAnoFabricado.TabIndex = 8;
            // 
            // TextoMemoria
            // 
            TextoMemoria.Location = new Point(12, 197);
            TextoMemoria.Name = "TextoMemoria";
            TextoMemoria.Size = new Size(100, 23);
            TextoMemoria.TabIndex = 7;
            // 
            // TextoCor
            // 
            TextoCor.Location = new Point(12, 153);
            TextoCor.Name = "TextoCor";
            TextoCor.Size = new Size(100, 23);
            TextoCor.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 135);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 12;
            label4.Text = "Cor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 179);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "Memoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 223);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Ano Fabricado";
            // 
            // TextoId
            // 
            TextoId.Location = new Point(12, 21);
            TextoId.Name = "TextoId";
            TextoId.Size = new Size(100, 23);
            TextoId.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 3);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 16;
            label1.Text = "ID";
            // 
            // CadastroCelular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 353);
            Controls.Add(label1);
            Controls.Add(TextoId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextoAnoFabricado);
            Controls.Add(TextoMemoria);
            Controls.Add(TextoCor);
            Controls.Add(TextoModelo);
            Controls.Add(TextoMarca);
            Controls.Add(AoClicarEmCancelar);
            Controls.Add(AoClicarEmLimpar);
            Controls.Add(AoClicarEmSalvar);
            Name = "CadastroCelular";
            Text = "CadastroCelular";
            Load += CadastroCelular_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AoClicarEmSalvar;
        private Button AoClicarEmLimpar;
        private Button AoClicarEmCancelar;
        private TextBox TextoMarca;
        private TextBox TextoModelo;
        private TextBox TextoAnoFabricado;
        private TextBox TextoMemoria;
        private TextBox TextoCor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TextoId;
        private Label label1;
    }
}