using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStart.App
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Para o timer (pra não ficar executando várias vezes)
            timer1.Stop();

            // Cria a tela de login
            FrmLogin login = new FrmLogin();

            // Quando a tela de login for fechada, fecha também a splash (e assim fecha a aplicação)
            login.FormClosed += (s, args) => this.Close();

            // Mostra a tela de login
            login.Show();

            // Esconde a splash (ela continua "existindo", mas invisível)
            this.Hide();
        }
    }
}
