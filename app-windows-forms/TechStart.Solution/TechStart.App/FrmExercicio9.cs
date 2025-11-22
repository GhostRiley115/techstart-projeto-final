using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechStart.App
{
    public partial class FrmExercicio9 : Form
    {
        public FrmExercicio9()
        {
            InitializeComponent();
        }

        private void FrmExercicio9_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(b, this.ClientRectangle);
            }
        }

        private void FrmExercicio9_Load(object sender, EventArgs e)
        {

        }
    }
}
