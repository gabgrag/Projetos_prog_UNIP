namespace WindowsFormsApplication1
{
    partial class FRM_Endereco
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
            this.TXT_Rua = new System.Windows.Forms.TextBox();
            this.TXT_CEP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Ler = new System.Windows.Forms.Button();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.BTN_Gravar = new System.Windows.Forms.Button();
            this.BTN_Verificar_CEP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXT_Rua
            // 
            this.TXT_Rua.Location = new System.Drawing.Point(12, 25);
            this.TXT_Rua.Name = "TXT_Rua";
            this.TXT_Rua.Size = new System.Drawing.Size(247, 20);
            this.TXT_Rua.TabIndex = 0;
            // 
            // TXT_CEP
            // 
            this.TXT_CEP.Location = new System.Drawing.Point(12, 74);
            this.TXT_CEP.Name = "TXT_CEP";
            this.TXT_CEP.Size = new System.Drawing.Size(100, 20);
            this.TXT_CEP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP";
            // 
            // BTN_Ler
            // 
            this.BTN_Ler.Location = new System.Drawing.Point(103, 118);
            this.BTN_Ler.Name = "BTN_Ler";
            this.BTN_Ler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ler.TabIndex = 5;
            this.BTN_Ler.Text = "Ler";
            this.BTN_Ler.UseVisualStyleBackColor = true;
            this.BTN_Ler.Click += new System.EventHandler(this.BTN_Ler_Click);
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.Location = new System.Drawing.Point(184, 118);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Limpar.TabIndex = 6;
            this.BTN_Limpar.Text = "Limpar";
            this.BTN_Limpar.UseVisualStyleBackColor = true;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Location = new System.Drawing.Point(184, 226);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(75, 23);
            this.BTN_Sair.TabIndex = 7;
            this.BTN_Sair.Text = "Sair";
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // BTN_Gravar
            // 
            this.BTN_Gravar.Location = new System.Drawing.Point(22, 118);
            this.BTN_Gravar.Name = "BTN_Gravar";
            this.BTN_Gravar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Gravar.TabIndex = 8;
            this.BTN_Gravar.Text = "Gravar";
            this.BTN_Gravar.UseVisualStyleBackColor = true;
            this.BTN_Gravar.Click += new System.EventHandler(this.BTN_Gravar_Click);
            // 
            // BTN_Verificar_CEP
            // 
            this.BTN_Verificar_CEP.Location = new System.Drawing.Point(118, 71);
            this.BTN_Verificar_CEP.Name = "BTN_Verificar_CEP";
            this.BTN_Verificar_CEP.Size = new System.Drawing.Size(80, 23);
            this.BTN_Verificar_CEP.TabIndex = 9;
            this.BTN_Verificar_CEP.Text = "Verificar CEP";
            this.BTN_Verificar_CEP.UseVisualStyleBackColor = true;
            this.BTN_Verificar_CEP.Click += new System.EventHandler(this.BTN_Verificar_CEP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rua";
            // 
            // FRM_Endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Verificar_CEP);
            this.Controls.Add(this.BTN_Gravar);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.BTN_Limpar);
            this.Controls.Add(this.BTN_Ler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_CEP);
            this.Controls.Add(this.TXT_Rua);
            this.Name = "FRM_Endereco";
            this.Text = "FRM_Endereco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Rua;
        private System.Windows.Forms.TextBox TXT_CEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Ler;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Button BTN_Gravar;
        private System.Windows.Forms.Button BTN_Verificar_CEP;
        private System.Windows.Forms.Label label1;
    }
}