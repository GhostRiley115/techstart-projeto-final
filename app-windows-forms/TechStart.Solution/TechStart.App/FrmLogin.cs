using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace TechStart.App
{
    public partial class FrmLogin : Form
    {
        private bool ValidarLogin(string usuario, string senha)
        {
            // Caminho do arquivo usuarios.txt na pasta "dados"
            string caminhoArquivo = Path.Combine(Application.StartupPath, "dados", "usuarios.txt");

            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show(
                    "Arquivo de usuários não encontrado.\nVerifique a pasta 'dados'.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            // Lê todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] partes = linha.Split(';');

                if (partes.Length < 2)
                    continue;

                string usuarioArquivo = partes[0].Trim();
                string senhaArquivo = partes[1].Trim();

                // Comparação: usuário sem case sensitive, senha exata
                if (usuario.Equals(usuarioArquivo, StringComparison.OrdinalIgnoreCase) &&
                    senha == senhaArquivo)
                {
                    return true; // achou usuário/senha válidos
                }
            }

            // Se chegou aqui, nada bateu
            return false;
        }
        public FrmLogin()
        {
            
            InitializeComponent();
            toolTip1.SetToolTip(txtUser, "Digite o nome de usuário que você cadastrou.");
            toolTip1.SetToolTip(txtPassword, "Digite a senha correspondente ao seu usuário.");

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string senha = txtPassword.Text.Trim();
            lblErro.Visible = false;
            lblErro.Text = string.Empty;

            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(senha))
            {
                lblErro.Text = "Digite o usuário e a senha.";
                lblErro.Visible = true;

                txtUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(usuario))
            {
                lblErro.Text = "Digite o usuário.";
                lblErro.Visible = true;

                txtUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                lblErro.Text = "Digite sua senha.";
                lblErro.Visible = true;

                txtPassword.Focus();
                return;
            }

            // daqui pra baixo continua igual
            if (ValidarLogin(usuario, senha))
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.FormClosed += (s, args) => this.Close();
                principal.Show();
                this.Hide();
            }
            else
            {
                lblErro.Text = "Usuário ou senha inválidos.";
                lblErro.Visible = true;

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.FromArgb(0, 90, 190);
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.BackColor = Color.FromArgb(0, 147, 233);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlBrand_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlBrand.Width, pnlBrand.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(47, 72, 122),  // TOPO: azul mais claro (perto do logo)
                Color.FromArgb(5, 8, 22),     // BASE: bem escuro, quase preto
                LinearGradientMode.Vertical)) // gradiente de cima pra baixo
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void lnkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEsqueciSenha frm = new FrmEsqueciSenha();
            frm.ShowDialog(); // modal: usuário resolve e volta pro login
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite teclas de controle (Backspace, Delete, Tab, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Permite letras e números
            if (char.IsLetterOrDigit(e.KeyChar))
                return;

            // Opcional: permitir underline e ponto
            if (e.KeyChar == '.')
                return;

            // Se não passou em nenhuma condição acima, bloqueia
            e.Handled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FrmCadastroUsuario cadastro = new FrmCadastroUsuario())
            {
                cadastro.ShowDialog(); // abre como janela modal
            }
        }
    }
}
