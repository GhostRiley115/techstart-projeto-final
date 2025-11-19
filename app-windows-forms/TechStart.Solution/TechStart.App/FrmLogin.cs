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

namespace TechStart.App
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            
            InitializeComponent();
            toolTip1.SetToolTip(txtUser, "Digite o nome de usuário que você cadastrou.");
            toolTip1.SetToolTip(txtPassword, "Digite a senha correspondente ao seu usuário.");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

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
         
        }

        private void lnkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
