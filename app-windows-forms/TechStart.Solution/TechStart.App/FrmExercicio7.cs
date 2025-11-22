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
    public partial class FrmExercicio7 : Form
    {
        public FrmExercicio7()
        {
            InitializeComponent();
        }

        private void FrmExercicio7_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(b, this.ClientRectangle);
            }
        }

        private void FrmExercicio7_Load(object sender, EventArgs e)
        {

        }
    }
}
