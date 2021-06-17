using _20210611carFixMgr.common;
using _20210611carFixMgr.ui;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20210611carFixMgr
{ 
    public partial class MainForm : MaterialForm //form 클래스에서 상속받은 메인 폼, partial = 특수한 형태(메인폼,메인폼[디자인])
    {
        public MainForm()
        {
            InitializeComponent();
            CommUtil.initTheme(this);
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {
            new ReceiptForm().ShowDialog();
        }

        private void custFixView_Click(object sender, EventArgs e)
        {

        }

        private void custFixAdmin_Click(object sender, EventArgs e)
        {

        }

        private void cusFixRand_Click(object sender, EventArgs e)
        {

        }

        private void custFixInfo_Click(object sender, EventArgs e)
        {

        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
