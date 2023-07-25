namespace GerenciadorPecasPC.View
{
    partial class TelaCadastrarPecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPecas = new System.Windows.Forms.TextBox();
            this.txtBoxMarcas = new System.Windows.Forms.TextBox();
            this.txtBoxCapac = new System.Windows.Forms.TextBox();
            this.btnCadastrarPecas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR PEÇAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peças";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marcas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidades";
            // 
            // txtBoxPecas
            // 
            this.txtBoxPecas.Location = new System.Drawing.Point(131, 123);
            this.txtBoxPecas.Name = "txtBoxPecas";
            this.txtBoxPecas.Size = new System.Drawing.Size(153, 23);
            this.txtBoxPecas.TabIndex = 4;
            // 
            // txtBoxMarcas
            // 
            this.txtBoxMarcas.Location = new System.Drawing.Point(131, 163);
            this.txtBoxMarcas.Name = "txtBoxMarcas";
            this.txtBoxMarcas.Size = new System.Drawing.Size(153, 23);
            this.txtBoxMarcas.TabIndex = 5;
            // 
            // txtBoxCapac
            // 
            this.txtBoxCapac.Location = new System.Drawing.Point(131, 211);
            this.txtBoxCapac.Name = "txtBoxCapac";
            this.txtBoxCapac.Size = new System.Drawing.Size(153, 23);
            this.txtBoxCapac.TabIndex = 6;
            // 
            // btnCadastrarPecas
            // 
            this.btnCadastrarPecas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarPecas.Location = new System.Drawing.Point(217, 280);
            this.btnCadastrarPecas.Name = "btnCadastrarPecas";
            this.btnCadastrarPecas.Size = new System.Drawing.Size(95, 32);
            this.btnCadastrarPecas.TabIndex = 7;
            this.btnCadastrarPecas.Text = "Cadastrar";
            this.btnCadastrarPecas.UseVisualStyleBackColor = true;
            this.btnCadastrarPecas.Click += new System.EventHandler(this.btnCadastrarPecas_Click);
            // 
            // TelaCadastrarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.btnCadastrarPecas);
            this.Controls.Add(this.txtBoxCapac);
            this.Controls.Add(this.txtBoxMarcas);
            this.Controls.Add(this.txtBoxPecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrarPecas";
            this.Text = "Cadastro Peças";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxPecas;
        private TextBox txtBoxMarcas;
        private TextBox txtBoxCapac;
        private Button btnCadastrarPecas;
    }
}