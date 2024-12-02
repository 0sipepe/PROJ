using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsvetovoyKod
{
    internal class NPanel : Panel
    {
        protected override CreateParams CreateParams
        {

            get
            {
                CreateParams Param = base.CreateParams;
                Param.ExStyle = Param.ExStyle | 0x2000000;
                return Param;
            }
        }
    }
    internal class FPanel : Panel
    {
        
        protected Figure figur;
        public FPanel() { }
        public FPanel(Figure fig)
        {
            figur = fig;
            Top = fig.X;
            Left = fig.X;
            BackColor = Color.FromArgb(0, 0, 0, 0);
            Height = fig.Heigth;
            Width = fig.Wigth;
            Paint += FPanel_Paint;

        }

        private void FPanel_Paint(object sender, PaintEventArgs e)
        {
            figur.Draw(e.Graphics);
        }

        public new void Move(int ex, int ey, int mx, int my)
        {
            Top = ex - mx;
            Left = ey - my;
        }

    }
    
}
