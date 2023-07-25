namespace GerenciadorPecasPC.View
{
    partial class TelaDeletarPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeletarPecas));
            btnDeletar = new Button();
            textBoxCapacidade = new TextBox();
            textBoxMarcas = new TextBox();
            textBoxPecas = new TextBox();
            textBoxCodigoVer = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPesquisar = new Button();
            textBoxCodigo = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeletar.Location = new Point(42, 268);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(287, 32);
            btnDeletar.TabIndex = 28;
            btnDeletar.Text = "Deletar Peça";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // textBoxCapacidade
            // 
            textBoxCapacidade.Location = new Point(183, 213);
            textBoxCapacidade.Name = "textBoxCapacidade";
            textBoxCapacidade.Size = new Size(95, 23);
            textBoxCapacidade.TabIndex = 26;
            // 
            // textBoxMarcas
            // 
            textBoxMarcas.Location = new Point(183, 166);
            textBoxMarcas.Name = "textBoxMarcas";
            textBoxMarcas.Size = new Size(95, 23);
            textBoxMarcas.TabIndex = 25;
            // 
            // textBoxPecas
            // 
            textBoxPecas.Location = new Point(183, 123);
            textBoxPecas.Name = "textBoxPecas";
            textBoxPecas.Size = new Size(95, 23);
            textBoxPecas.TabIndex = 24;
            // 
            // textBoxCodigoVer
            // 
            textBoxCodigoVer.Location = new Point(183, 85);
            textBoxCodigoVer.Name = "textBoxCodigoVer";
            textBoxCodigoVer.Size = new Size(95, 23);
            textBoxCodigoVer.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 221);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 22;
            label4.Text = "Capacidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 174);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 21;
            label3.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 131);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 20;
            label2.Text = "Peças";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 93);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 19;
            label1.Text = "Código";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(271, 29);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(34, 33);
            btnPesquisar.TabIndex = 31;
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(170, 35);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(95, 23);
            textBoxCodigo.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(46, 35);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 29;
            label5.Text = "Digite o Código";
            // 
            // TelaDeletarPecas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 330);
            Controls.Add(btnPesquisar);
            Controls.Add(textBoxCodigo);
            Controls.Add(label5);
            Controls.Add(btnDeletar);
            Controls.Add(textBoxCapacidade);
            Controls.Add(textBoxMarcas);
            Controls.Add(textBoxPecas);
            Controls.Add(textBoxCodigoVer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaDeletarPecas";
            Text = "TelaDeletarPecas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeletar;
        private Button button1;
        private TextBox textBoxCapacidade;
        private TextBox textBoxMarcas;
        private TextBox textBoxPecas;
        private TextBox textBox2;
        private TextBox textBoxCodigoVer;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnPesquisar;
        private TextBox textBoxCodigo;
        private Label label5;
    }
}