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
        //static OraHandler ora = new OraHandler();
        //맨처음 프로그램이 시작할 때.
        //ReceiptAdapter adapter = new ReceiptAdapter(ora);

        OraHandler ora;
        ReceiptAdapter adapter;

        public MainForm()
        {
            InitializeComponent();
            CommUtil.initTheme(this); //this 메인폼 객체 정보
            //MainForm main = new MainForm(); 또다시 메인 폼 만들면 안된다
            ora = new OraHandler();
            adapter = new ReceiptAdapter(ora);
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {
            new ReceiptForm(adapter).ShowDialog();
            //생성자(매개변수) 
            //Show = 모달리스, 부모폼과 자식폼이 따로, ShowDialog = 모달, 앞에 화면 떠있으면 뒤에 화면 쓸 수 없음
            adapter.addReceiptDb();
            //ora.insertdb(null);
        }

        private void custFixView_Click(object sender, EventArgs e)
        {
            new ReceiptView().ShowDialog();
            adapter.viewReceiptDb();
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
