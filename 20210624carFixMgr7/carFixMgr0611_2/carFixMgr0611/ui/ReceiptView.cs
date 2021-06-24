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

namespace carFixMgr0611.ui
{
    public partial class ReceiptView : MaterialForm
    {
        public ReceiptView()
        {
            InitializeComponent();
            //initList(); //가장빠른 처리,이니셜라이즈 밑에
        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void initList()
        {
            string strPrice = string.Format("{0:#,0}원", 120000);
            string[] data = { "1", "2021년6월24일", strPrice, "김담당", "박고객" };
            viewList.Items.Add(new ListViewItem(data));

            for(int i =0; i<50; i++)
            {
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+2).ToString(),"2021년6월24일",strPrice,"김담당","박고객"
                    }
                    ));
            }
        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            initList();
        }
    }
}
