using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dashboard._1___Forms
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            this.Enabled = true;
            BtnAddbanco.Enabled = false;
            button2.Enabled = false;
        }

        // Código para deixar o botão de lançamento e saida redondo, e códgos para arredondar os cantos do panel
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gr = new GraphicsPath();
            gr.AddEllipse(0, 0, BtnEntry.Width, BtnEntry.Height);
            BtnEntry.Region = new System.Drawing.Region(gr);
            BtnOut.Region = new System.Drawing.Region(gr);

            //base.OnPaint(e);
            Rectangle Rect = new Rectangle(0, 0, PanelReceita.Width, PanelReceita.Height);
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, 50, 50, 180, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y, 50, 50, 270, 90);
            GraphPath.AddArc(Rect.X + Rect.Width - 50, Rect.Y + Rect.Height - 50, 50, 50, 0, 90);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - 50, 50, 50, 90, 90);
            PanelReceita.Region = new Region(GraphPath);
            PanelDespesa.Region = new Region(GraphPath);
            PanelSaldo.Region = new Region(GraphPath);

            Rectangle rectangl = new Rectangle(0, 0, BtnAddbanco.Width, BtnAddbanco.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rectangl.X, rectangl.Y, 50, 50, 180, 90);
            path.AddArc(rectangl.X + rectangl.Width - 50, rectangl.Y, 50, 50, 270, 90);
            path.AddArc(rectangl.X + rectangl.Width - 50, rectangl.Y + rectangl.Height - 50, 50, 50, 0, 90);
            path.AddArc(rectangl.X, rectangl.Y + rectangl.Height - 50, 50, 50, 90, 90);
            BtnAddbanco.Region = new Region(path);
            button2.Region = new Region(path);
        }

        //ação do botão mais
        private void BtnEntry_Click(object sender, EventArgs e)
        {
            FrmCashEntry frm = new FrmCashEntry();
            frm.ShowDialog();
        }

        //Ação do botão menos
        private void BtnOut_Click(object sender, EventArgs e)
        {
            FrmCashOut frm = new FrmCashOut();
            frm.ShowDialog();
        }

        private void TimerDay_Tick(object sender, EventArgs e)
        {
            LblTimer.Text = DateTime.Now.ToString("F");
        }
    }
}
