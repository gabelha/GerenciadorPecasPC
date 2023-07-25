namespace GerenciadorPecasPC.View
{
    partial class TelaAlterarPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarPecas));
            buscar = new Button();
            textBoxCapacidade = new TextBox();
            textBoxMarca = new TextBox();
            textBoxPeca = new TextBox();
            textBoxCod = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Alterar = new Button();
            textBoxCodigo = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // buscar
            // 
            buscar.Image = (Image)resources.GetObject("buscar.Image");
            buscar.Location = new Point(271, 25);
            buscar.Name = "buscar";
            buscar.Size = new Size(34, 33);
            buscar.TabIndex = 17;
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // textBoxCapacidade
            // 
            textBoxCapacidade.Location = new Point(184, 211);
            textBoxCapacidade.Name = "textBoxCapacidade";
            textBoxCapacidade.Size = new Size(95, 23);
            textBoxCapacidade.TabIndex = 16;
            // 
            // textBoxMarca
            // 
            textBoxMarca.Location = new Point(184, 164);
            textBoxMarca.Name = "textBoxMarca";
            textBoxMarca.Size = new Size(95, 23);
            textBoxMarca.TabIndex = 15;
            // 
            // textBoxPeca
            // 
            textBoxPeca.Location = new Point(184, 121);
            textBoxPeca.Name = "textBoxPeca";
            textBoxPeca.Size = new Size(95, 23);
            textBoxPeca.TabIndex = 14;
            // 
            // textBoxCod
            // 
            textBoxCod.Location = new Point(170, 31);
            textBoxCod.Name = "textBoxCod";
            textBoxCod.Size = new Size(95, 23);
            textBoxCod.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 219);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Capacidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 172);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 129);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 10;
            label2.Text = "Peças";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 9;
            label1.Text = "Digite o Código";
            // 
            // Alterar
            // 
            Alterar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Alterar.Location = new Point(43, 266);
            Alterar.Name = "Alterar";
            Alterar.Size = new Size(287, 32);
            Alterar.TabIndex = 18;
            Alterar.Text = "Alterar os Dados";
            Alterar.UseVisualStyleBackColor = true;
            Alterar.Click += Alterar_Click;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(184, 83);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(95, 23);
            textBoxCodigo.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 91);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 20;
            label5.Text = "Código";
            // 
            // TelaAlterarPecas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 320);
            Controls.Add(label5);
            Controls.Add(textBoxCodigo);
            Controls.Add(Alterar);
            Controls.Add(buscar);
            Controls.Add(textBoxCapacidade);
            Controls.Add(textBoxMarca);
            Controls.Add(textBoxPeca);
            Controls.Add(textBoxCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaAlterarPecas";
            Text = "Alterar Peças";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buscar;
        private TextBox textBoxCapacidade;
        private TextBox textBoxMarca;
        private TextBox textBoxPeca;
        private TextBox textBoxCod;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Alterar;
        private TextBox textBoxCodigo;
        private Label label5;
    }
}