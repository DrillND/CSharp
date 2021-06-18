using carFixMgr0611.common;
using carFixMgr0611.handler;
using carFixMgr0611.ui;
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

namespace carFixMgr0611
{
    public partial class MainForm : MaterialForm
    {
        OraHandler ora = new OraHandler();
        //맨처음 프로그램이 시작할 때.
        ReceiptAdapter adapter = new ReceiptAdapter();
        public MainForm()
        {
            InitializeComponent();
            CommUtil.initTheme(this); //this 메인폼 객체 정보
            //MainForm main = new MainForm(); 또다시 메인 폼 만들면 안된다
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {
            new ReceiptForm(adapter).ShowDialog();
            //생성자(매개변수)
        }

        private void custFixView_Click(object sender, EventArgs e)
        {
            adapter.viewReceipt();
        }

        private void custFixAdmin_Click(object sender, EventArgs e)
        {

        }

        private void custFixRand_Click(object sender, EventArgs e)
        {

        }

        private void custfixInfo_Click(object sender, EventArgs e)
        {

        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
