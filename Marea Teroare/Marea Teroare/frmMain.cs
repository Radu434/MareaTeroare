using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marea_Teroare
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStalin_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (frmMain.ActiveForm.WindowState == FormWindowState.Maximized || frmMain.ActiveForm.WindowState == FormWindowState.Normal)
            {
                frmMain.ActiveForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnMinMax_Click_1(object sender, EventArgs e)
        {
            if (frmMain.ActiveForm.WindowState == FormWindowState.Maximized)
            {
                frmMain.ActiveForm.WindowState = FormWindowState.Normal;
            }
            else if (frmMain.ActiveForm.WindowState != FormWindowState.Maximized)
            {
                frmMain.ActiveForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
