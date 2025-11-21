using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TechStart.App
{
    public partial class FrmCadastroUsuario : Form
    {
        private readonly string caminhoArquivo;

        public FrmCadastroUsuario()
        {
            InitializeComponent();

            caminhoArquivo = Path.Combine(
                Application.StartupPath,
                "dados",
                "usuarios.txt"
            );
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtNovoUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void chkMostrarSenha2_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmarSenha.UseSystemPasswordChar = !chkMostrarSenha2.Checked;
        }

        private void chkMostrarSenha1_CheckedChanged(object sender, EventArgs e)
        {
            txtNovaSenha.UseSystemPasswordChar = !chkMostrarSenha1.Checked;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuario = txtNovoUsuario.Text.Trim();
            string senha = txtNovaSenha.Text.Trim();
            string confirmar = txtConfirmarSenha.Text.Trim();
            lblErro.Visible = false;
            lblErro.Text = string.Empty;

            // 1) Valida campos vazios
            if (string.IsNullOrEmpty(usuario) ||
                string.IsNullOrEmpty(senha) ||
                string.IsNullOrEmpty(confirmar))
            {
                lblErro.Text = "Preencha todos os campos.";
                lblErro.Visible = true;
                return;
            }

            // 2) Confirmação de senha
            if (senha != confirmar)
            {
                lblErro.Text = "A confirmação de senha não confere.";
                lblErro.Visible = true;
                txtConfirmarSenha.Focus();
                return;
            }

            // 3) Verifica se o arquivo de usuários existe
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show(
                    "Arquivo de usuários não encontrado.\nVerifique a pasta 'dados'.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // 4) Verifica se o usuário já existe
            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 2)
                    continue;

                string usuarioArquivo = partes[0].Trim();

                if (usuario.Equals(usuarioArquivo, StringComparison.OrdinalIgnoreCase))
                {
                    lblErro.Text = "Usuário já existe. Escolha outro nome.";
                    lblErro.Visible = true;
                    txtNovoUsuario.Focus();
                    return;
                }
            }

            // 5) Se chegou até aqui, pode cadastrar
            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivo, append: true))
                {
                    sw.WriteLine($"{usuario};{senha}");
                }

                MessageBox.Show(
                    "Usuário cadastrado com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao gravar o usuário.\nDetalhes: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
