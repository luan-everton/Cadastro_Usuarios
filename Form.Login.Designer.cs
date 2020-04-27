namespace Cadastro_Usuarios_Forms
{
    partial class Frm_Login
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_acesso = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.mask_senha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(43, 22);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(470, 33);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Para acessar, digite as credencias";
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_entrar.Location = new System.Drawing.Point(90, 362);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(120, 42);
            this.btn_entrar.TabIndex = 1;
            this.btn_entrar.Text = "entrar";
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sair.Location = new System.Drawing.Point(858, 585);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(125, 39);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 164);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 29);
            this.textBox1.TabIndex = 3;
            // 
            // lbl_acesso
            // 
            this.lbl_acesso.AutoSize = true;
            this.lbl_acesso.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acesso.Location = new System.Drawing.Point(86, 111);
            this.lbl_acesso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_acesso.Name = "lbl_acesso";
            this.lbl_acesso.Size = new System.Drawing.Size(76, 30);
            this.lbl_acesso.TabIndex = 5;
            this.lbl_acesso.Text = "Login";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(87, 237);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(78, 27);
            this.lbl_senha.TabIndex = 6;
            this.lbl_senha.Text = "Senha";
            this.lbl_senha.Click += new System.EventHandler(this.lbl_senha_Click);
            // 
            // mask_senha
            // 
            this.mask_senha.Location = new System.Drawing.Point(90, 278);
            this.mask_senha.Name = "mask_senha";
            this.mask_senha.Size = new System.Drawing.Size(247, 29);
            this.mask_senha.TabIndex = 7;
            this.mask_senha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 762);
            this.Controls.Add(this.mask_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_acesso);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_acesso;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.MaskedTextBox mask_senha;
    }
}

