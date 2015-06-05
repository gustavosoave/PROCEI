namespace PROCEI
{
    partial class fmLogin
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.lbCaptcha = new System.Windows.Forms.Label();
            this.btAtualizaCaptcha = new System.Windows.Forms.Button();
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(44, 38);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(44, 77);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(96, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(96, 74);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(200, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(220, 227);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Location = new System.Drawing.Point(96, 181);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(200, 20);
            this.txtCaptcha.TabIndex = 3;
            // 
            // lbCaptcha
            // 
            this.lbCaptcha.Location = new System.Drawing.Point(44, 112);
            this.lbCaptcha.Name = "lbCaptcha";
            this.lbCaptcha.Size = new System.Drawing.Size(72, 50);
            this.lbCaptcha.TabIndex = 8;
            this.lbCaptcha.Text = "Digite o que aparece na imagem";
            // 
            // btAtualizaCaptcha
            // 
            this.btAtualizaCaptcha.Image = global::PROCEI.Properties.Resources.refresh1;
            this.btAtualizaCaptcha.Location = new System.Drawing.Point(314, 116);
            this.btAtualizaCaptcha.Name = "btAtualizaCaptcha";
            this.btAtualizaCaptcha.Size = new System.Drawing.Size(29, 28);
            this.btAtualizaCaptcha.TabIndex = 9;
            this.btAtualizaCaptcha.UseVisualStyleBackColor = true;
            this.btAtualizaCaptcha.Click += new System.EventHandler(this.btAtualizaCaptcha_Click);
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.Location = new System.Drawing.Point(136, 112);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(100, 50);
            this.pbCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCaptcha.TabIndex = 5;
            this.pbCaptcha.TabStop = false;
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 270);
            this.Controls.Add(this.btAtualizaCaptcha);
            this.Controls.Add(this.lbCaptcha);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.pbCaptcha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmLogin";
            this.ShowIcon = false;
            this.Text = "PROCEI";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox pbCaptcha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.Label lbCaptcha;
        private System.Windows.Forms.Button btAtualizaCaptcha;
    }
}

