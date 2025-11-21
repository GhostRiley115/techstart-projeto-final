namespace TechStart.App
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer6 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer7 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer8 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer9 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer10 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSistema,
            this.mnuCadastros,
            this.mnuConsultas,
            this.mnuAjuda,
            this.mnuExercicios});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnuSistema
            // 
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrocarUsuario,
            this.mnuSair});
            this.mnuSistema.Image = ((System.Drawing.Image)(resources.GetObject("mnuSistema.Image")));
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(76, 20);
            this.mnuSistema.Text = "Sistema";
            // 
            // mnuTrocarUsuario
            // 
            this.mnuTrocarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("mnuTrocarUsuario.Image")));
            this.mnuTrocarUsuario.Name = "mnuTrocarUsuario";
            this.mnuTrocarUsuario.Size = new System.Drawing.Size(180, 22);
            this.mnuTrocarUsuario.Text = "Trocar usuário";
            // 
            // mnuSair
            // 
            this.mnuSair.Image = ((System.Drawing.Image)(resources.GetObject("mnuSair.Image")));
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(180, 22);
            this.mnuSair.Text = "Sair";
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadProdutos,
            this.mnuCadEventos});
            this.mnuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("mnuCadastros.Image")));
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(87, 20);
            this.mnuCadastros.Text = "Cadastros";
            // 
            // mnuCadProdutos
            // 
            this.mnuCadProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnuCadProdutos.Image")));
            this.mnuCadProdutos.Name = "mnuCadProdutos";
            this.mnuCadProdutos.Size = new System.Drawing.Size(180, 22);
            this.mnuCadProdutos.Text = "Produtos da Lojinha";
            // 
            // mnuCadEventos
            // 
            this.mnuCadEventos.Image = ((System.Drawing.Image)(resources.GetObject("mnuCadEventos.Image")));
            this.mnuCadEventos.Name = "mnuCadEventos";
            this.mnuCadEventos.Size = new System.Drawing.Size(180, 22);
            this.mnuCadEventos.Text = "Eventos TechStart";
            // 
            // mnuConsultas
            // 
            this.mnuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConProdutos,
            this.mnuConEventos});
            this.mnuConsultas.Image = ((System.Drawing.Image)(resources.GetObject("mnuConsultas.Image")));
            this.mnuConsultas.Name = "mnuConsultas";
            this.mnuConsultas.Size = new System.Drawing.Size(87, 20);
            this.mnuConsultas.Text = "Consultas";
            // 
            // mnuConProdutos
            // 
            this.mnuConProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnuConProdutos.Image")));
            this.mnuConProdutos.Name = "mnuConProdutos";
            this.mnuConProdutos.Size = new System.Drawing.Size(180, 22);
            this.mnuConProdutos.Text = "Consultar Produtos";
            // 
            // mnuConEventos
            // 
            this.mnuConEventos.Image = ((System.Drawing.Image)(resources.GetObject("mnuConEventos.Image")));
            this.mnuConEventos.Name = "mnuConEventos";
            this.mnuConEventos.Size = new System.Drawing.Size(180, 22);
            this.mnuConEventos.Text = "Consultar Eventos";
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Image = ((System.Drawing.Image)(resources.GetObject("mnuAjuda.Image")));
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(66, 20);
            this.mnuAjuda.Text = "Ajuda";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Image = ((System.Drawing.Image)(resources.GetObject("mnuSobre.Image")));
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(180, 22);
            this.mnuSobre.Text = "Sobre";
            // 
            // mnuExercicios
            // 
            this.mnuExercicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExer1,
            this.mnuExer2,
            this.mnuExer3,
            this.mnuExer4,
            this.mnuExer5,
            this.mnuExer6,
            this.mnuExer7,
            this.mnuExer8,
            this.mnuExer9,
            this.mnuExer10});
            this.mnuExercicios.Image = ((System.Drawing.Image)(resources.GetObject("mnuExercicios.Image")));
            this.mnuExercicios.Name = "mnuExercicios";
            this.mnuExercicios.Size = new System.Drawing.Size(86, 20);
            this.mnuExercicios.Text = "Exercícios";
            // 
            // mnuExer1
            // 
            this.mnuExer1.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer1.Image")));
            this.mnuExer1.Name = "mnuExer1";
            this.mnuExer1.Size = new System.Drawing.Size(180, 22);
            this.mnuExer1.Text = "Exercício 1";
            // 
            // mnuExer2
            // 
            this.mnuExer2.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer2.Image")));
            this.mnuExer2.Name = "mnuExer2";
            this.mnuExer2.Size = new System.Drawing.Size(180, 22);
            this.mnuExer2.Text = "Exercício 2";
            // 
            // mnuExer3
            // 
            this.mnuExer3.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer3.Image")));
            this.mnuExer3.Name = "mnuExer3";
            this.mnuExer3.Size = new System.Drawing.Size(180, 22);
            this.mnuExer3.Text = "Exercício 3";
            // 
            // mnuExer4
            // 
            this.mnuExer4.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer4.Image")));
            this.mnuExer4.Name = "mnuExer4";
            this.mnuExer4.Size = new System.Drawing.Size(180, 22);
            this.mnuExer4.Text = "Exercício 4";
            // 
            // mnuExer5
            // 
            this.mnuExer5.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer5.Image")));
            this.mnuExer5.Name = "mnuExer5";
            this.mnuExer5.Size = new System.Drawing.Size(180, 22);
            this.mnuExer5.Text = "Exercício 5";
            // 
            // mnuExer6
            // 
            this.mnuExer6.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer6.Image")));
            this.mnuExer6.Name = "mnuExer6";
            this.mnuExer6.Size = new System.Drawing.Size(180, 22);
            this.mnuExer6.Text = "Exercício 6";
            // 
            // mnuExer7
            // 
            this.mnuExer7.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer7.Image")));
            this.mnuExer7.Name = "mnuExer7";
            this.mnuExer7.Size = new System.Drawing.Size(180, 22);
            this.mnuExer7.Text = "Exercício 7";
            // 
            // mnuExer8
            // 
            this.mnuExer8.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer8.Image")));
            this.mnuExer8.Name = "mnuExer8";
            this.mnuExer8.Size = new System.Drawing.Size(180, 22);
            this.mnuExer8.Text = "Exercício 8";
            // 
            // mnuExer9
            // 
            this.mnuExer9.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer9.Image")));
            this.mnuExer9.Name = "mnuExer9";
            this.mnuExer9.Size = new System.Drawing.Size(180, 22);
            this.mnuExer9.Text = "Exercício 9";
            // 
            // mnuExer10
            // 
            this.mnuExer10.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer10.Image")));
            this.mnuExer10.Name = "mnuExer10";
            this.mnuExer10.Size = new System.Drawing.Size(180, 22);
            this.mnuExer10.Text = "Exercício 10";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechStart - Painel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnuCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuCadEventos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultas;
        private System.Windows.Forms.ToolStripMenuItem mnuConProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuConEventos;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuExercicios;
        private System.Windows.Forms.ToolStripMenuItem mnuExer1;
        private System.Windows.Forms.ToolStripMenuItem mnuExer2;
        private System.Windows.Forms.ToolStripMenuItem mnuExer3;
        private System.Windows.Forms.ToolStripMenuItem mnuExer4;
        private System.Windows.Forms.ToolStripMenuItem mnuExer5;
        private System.Windows.Forms.ToolStripMenuItem mnuExer6;
        private System.Windows.Forms.ToolStripMenuItem mnuExer7;
        private System.Windows.Forms.ToolStripMenuItem mnuExer8;
        private System.Windows.Forms.ToolStripMenuItem mnuExer9;
        private System.Windows.Forms.ToolStripMenuItem mnuExer10;
    }
}

