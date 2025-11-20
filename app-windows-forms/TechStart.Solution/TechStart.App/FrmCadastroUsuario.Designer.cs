namespace TechStart.App
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            this.lblNovoUsuario = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtNovoUsuario = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkMostrarSenha1 = new System.Windows.Forms.CheckBox();
            this.chkMostrarSenha2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNovoUsuario
            // 
            this.lblNovoUsuario.AutoSize = true;
            this.lblNovoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNovoUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNovoUsuario.Location = new System.Drawing.Point(9, 58);
            this.lblNovoUsuario.Name = "lblNovoUsuario";
            this.lblNovoUsuario.Size = new System.Drawing.Size(153, 25);
            this.lblNovoUsuario.TabIndex = 98;
            this.lblNovoUsuario.Text = "Crie um usuário";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblNovaSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNovaSenha.Location = new System.Drawing.Point(9, 108);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(147, 25);
            this.lblNovaSenha.TabIndex = 97;
            this.lblNovaSenha.Text = "Crie uma senha";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(9, 174);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(186, 25);
            this.lblConfirmarSenha.TabIndex = 96;
            this.lblConfirmarSenha.Text = "Confirme sua senha";
            this.lblConfirmarSenha.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.txtNovaSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.ForeColor = System.Drawing.Color.White;
            this.txtNovaSenha.Location = new System.Drawing.Point(201, 105);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(230, 33);
            this.txtNovaSenha.TabIndex = 2;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.White;
            this.txtConfirmarSenha.Location = new System.Drawing.Point(201, 171);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(230, 33);
            this.txtConfirmarSenha.TabIndex = 3;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            this.txtConfirmarSenha.TextChanged += new System.EventHandler(this.txtConfirmarSenha_TextChanged);
            // 
            // txtNovoUsuario
            // 
            this.txtNovoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.txtNovoUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoUsuario.ForeColor = System.Drawing.Color.White;
            this.txtNovoUsuario.Location = new System.Drawing.Point(201, 55);
            this.txtNovoUsuario.Name = "txtNovoUsuario";
            this.txtNovoUsuario.Size = new System.Drawing.Size(230, 33);
            this.txtNovoUsuario.TabIndex = 1;
            this.txtNovoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNovoUsuario_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalvar.Location = new System.Drawing.Point(95, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 30);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(265, 246);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 25);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(137, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 30);
            this.lblTitulo.TabIndex = 99;
            this.lblTitulo.Text = "Crie uma conta";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblErro.Location = new System.Drawing.Point(89, 276);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(209, 19);
            this.lblErro.TabIndex = 100;
            this.lblErro.Text = "Nome de usuário já existe.";
            this.lblErro.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // chkMostrarSenha1
            // 
            this.chkMostrarSenha1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMostrarSenha1.AutoSize = true;
            this.chkMostrarSenha1.BackColor = System.Drawing.Color.Transparent;
            this.chkMostrarSenha1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMostrarSenha1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarSenha1.Location = new System.Drawing.Point(201, 144);
            this.chkMostrarSenha1.Name = "chkMostrarSenha1";
            this.chkMostrarSenha1.Size = new System.Drawing.Size(91, 23);
            this.chkMostrarSenha1.TabIndex = 102;
            this.chkMostrarSenha1.Text = "Mostrar senha";
            this.chkMostrarSenha1.UseVisualStyleBackColor = false;
            this.chkMostrarSenha1.CheckedChanged += new System.EventHandler(this.chkMostrarSenha1_CheckedChanged);
            // 
            // chkMostrarSenha2
            // 
            this.chkMostrarSenha2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMostrarSenha2.AutoSize = true;
            this.chkMostrarSenha2.BackColor = System.Drawing.Color.Transparent;
            this.chkMostrarSenha2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMostrarSenha2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarSenha2.Location = new System.Drawing.Point(201, 210);
            this.chkMostrarSenha2.Name = "chkMostrarSenha2";
            this.chkMostrarSenha2.Size = new System.Drawing.Size(91, 23);
            this.chkMostrarSenha2.TabIndex = 103;
            this.chkMostrarSenha2.Text = "Mostrar senha";
            this.chkMostrarSenha2.UseVisualStyleBackColor = false;
            this.chkMostrarSenha2.CheckedChanged += new System.EventHandler(this.chkMostrarSenha2_CheckedChanged);
            // 
            // FrmCadastroUsuario
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(459, 311);
            this.Controls.Add(this.chkMostrarSenha2);
            this.Controls.Add(this.chkMostrarSenha1);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNovoUsuario);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblNovaSenha);
            this.Controls.Add(this.lblNovoUsuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechStart - Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FrmCadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNovoUsuario;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtNovoUsuario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkMostrarSenha1;
        private System.Windows.Forms.CheckBox chkMostrarSenha2;
    }
}