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
            BotaoSalvar = new Button();
            BotaoCancelar = new Button();
            TextoMarca = new TextBox();
            TextoModelo = new TextBox();
            TextoMemoria = new TextBox();
            TextoCor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DataFabricado = new DateTimePicker();
            SuspendLayout();
            // 
            // BotaoSalvar
            // 
            BotaoSalvar.ForeColor = SystemColors.ActiveCaptionText;
            BotaoSalvar.Location = new Point(12, 311);
            BotaoSalvar.Name = "BotaoSalvar";
            BotaoSalvar.Size = new Size(75, 23);
            BotaoSalvar.TabIndex = 0;
            BotaoSalvar.Text = "Salvar";
            BotaoSalvar.UseVisualStyleBackColor = true;
            BotaoSalvar.Click += AoClicarEmSalvar;
            // 
            // BotaoCancelar
            // 
            BotaoCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BotaoCancelar.Location = new Point(182, 311);
            BotaoCancelar.Name = "BotaoCancelar";
            BotaoCancelar.Size = new Size(75, 23);
            BotaoCancelar.TabIndex = 2;
            BotaoCancelar.Text = "Cancelar";
            BotaoCancelar.UseVisualStyleBackColor = true;
            BotaoCancelar.Click += AoClicarEmCancelar;
            // 
            // TextoMarca
            // 
            TextoMarca.Location = new Point(14, 27);
            TextoMarca.Name = "TextoMarca";
            TextoMarca.Size = new Size(243, 23);
            TextoMarca.TabIndex = 4;
            // 
            // TextoModelo
            // 
            TextoModelo.Location = new Point(12, 86);
            TextoModelo.Name = "TextoModelo";
            TextoModelo.Size = new Size(243, 23);
            TextoModelo.TabIndex = 5;
            // 
            // TextoMemoria
            // 
            TextoMemoria.Location = new Point(12, 192);
            TextoMemoria.MaxLength = 5;
            TextoMemoria.Name = "TextoMemoria";
            TextoMemoria.Size = new Size(243, 23);
            TextoMemoria.TabIndex = 7;
            TextoMemoria.KeyPress += ValidarCampoMemoria;
            // 
            // TextoCor
            // 
            TextoCor.Location = new Point(12, 140);
            TextoCor.Name = "TextoCor";
            TextoCor.Size = new Size(245, 23);
            TextoCor.TabIndex = 6;
            TextoCor.KeyPress += ValidarCampoCor;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 68);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 12;
            label4.Text = "Cor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 174);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "Memória";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 227);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Ano Fabricado";
            // 
            // DataFabricado
            // 
            DataFabricado.Format = DateTimePickerFormat.Short;
            DataFabricado.Location = new Point(14, 245);
            DataFabricado.Name = "DataFabricado";
            DataFabricado.Size = new Size(245, 23);
            DataFabricado.TabIndex = 18;
            // 
            // CadastroCelular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(275, 350);
            Controls.Add(DataFabricado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextoMemoria);
            Controls.Add(TextoCor);
            Controls.Add(TextoModelo);
            Controls.Add(TextoMarca);
            Controls.Add(BotaoCancelar);
            Controls.Add(BotaoSalvar);
            ForeColor = SystemColors.ControlLightLight;
            Name = "CadastroCelular";
            Text = "CadastroCelular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotaoSalvar;
        private Button BotaoCancelar;
        private TextBox TextoMarca;
        private TextBox TextoModelo;
        private TextBox TextoMemoria;
        private TextBox TextoCor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker DataFabricado;
    }
}