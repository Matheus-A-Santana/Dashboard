using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Dashboard : Form
    {

        // inicio
        public Dashboard()
        {
            InitializeComponent();
            CustomizeMenu();
            ShowFormPanel(new _1___Forms.FrmHome());
            BtnReport.Enabled = false;
        }

        #region Código para a borda do form redimensionavel

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

#endregion

        private bool drag = false; // Drag para mover o form 
        private Point startPoint = new Point(); //Point para mover o form

        // Botão para encerrar a aplicação
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Botão de maximizar e minimizar o form
        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
                BtnMaximize.Image = Image.FromFile("../../Resources/quadrados.png");
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                BtnMaximize.Image = Image.FromFile("../../Resources/quadrado-com-cantos-arredondados.png");
            }
        }

        // Botão para minimizar a aplicação
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // Ação do painel superior se pressionado 
        private void PanelControl_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }

        // Ação do painel superior se não estiver pressionado
        private void PanelControl_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        // Ação do painel superior se estiver pressionado e mover o mouse
        private void PanelControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true) // se drag igual a true mover o form
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Normal;
                    BtnMaximize.Image = Image.FromFile("../../Resources/quadrado-com-cantos-arredondados.png");
                }
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }


        #region Código do menu para visualizar e esconder os submenus
        private void CustomizeMenu()
        {
            PanelReport.Visible = false;
        }

        private void HideMenu()
        {
            if (PanelReport.Visible == true)
                PanelReport.Visible = false;
        }

        private void ShowMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                HideMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void ShowFormPanel(object FormFilho)
        {
            if (this.PanelForms.Controls.Count > 0)
                this.PanelForms.Controls.RemoveAt(0);
            Form formfilho = FormFilho as Form;
            formfilho.TopLevel = false;
            formfilho.Dock = DockStyle.Fill;
            this.PanelForms.Controls.Add(formfilho);
            this.PanelForms.Tag = formfilho;
            formfilho.Show();
        }

        #endregion


        //Botão aparecer o subMenu de Relatórios 
        private void BtnReport_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelReport);
        }

        // Botão do subMenu para form Mensal
        private void BtnMonthly_Click(object sender, EventArgs e)
        {
            ShowFormPanel(new _1___Forms.FrmMonthly());
            HideMenu();
        }

        // Botão do subMneu para form Anual
        private void BtnYearly_Click(object sender, EventArgs e)
        {
            ShowFormPanel(new _1___Forms.FrmYearly());
            HideMenu();
        }

        //Botão do subMneu para form Semanal
        private void BtnWeekly_Click(object sender, EventArgs e)
        {
            ShowFormPanel(new _1___Forms.FrmWeekly());
            HideMenu();
        }

        // Botão do form home
        private void BtnHome_Click(object sender, EventArgs e)
        {
            ShowFormPanel(new _1___Forms.FrmHome());
        }
    }
}
