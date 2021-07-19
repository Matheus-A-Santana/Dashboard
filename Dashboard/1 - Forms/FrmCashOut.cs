using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard._1___Forms
{
    public partial class FrmCashOut : Form
    {
        public FrmCashOut()
        {
            InitializeComponent();
            TxtType.Select();
        }

        // Para deixar o cantos arredondados
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Código para o form
            Rectangle Rect = new Rectangle(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            this.Region = new Region(GraphPath);
            base.OnPaint(e);
        }

        private bool moving; // booleano para deixar ou não mover o form
        private Point point = new Point(0, 0); // ponteiro para mover

        // Ação do painel superior se pressionado 
        private void FrmCashOut_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            point = new Point(e.X, e.Y);
        }

        // Ação do painel superior se não estiver pressionado
        private void FrmCashOut_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        // Ação do painel superior se estiver pressionado e mover o mouse
        private void FrmCashOut_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving == true)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.point.X, p.Y - this.point.Y);
            }
        }

        private void FrmCashOut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
                this.Close();
        }
    }
}
