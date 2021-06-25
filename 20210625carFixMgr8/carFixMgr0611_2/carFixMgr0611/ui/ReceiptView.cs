using carFixMgr0611.common;
using carFixMgr0611.handler;
using carFixMgr0611.model;
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
    partial class ReceiptView : MaterialForm //여기서 퍼블릭 뺏다
    {
        ReceiptAdapter adapter;
        public ReceiptView()
        {
            InitializeComponent();
            //initList(); //가장빠른 처리,이니셜라이즈 밑에
        }

        public ReceiptView(ReceiptAdapter adapter)
        {
            InitializeComponent();
            //initList(); //가장빠른 처리,이니셜라이즈 밑에
            this.adapter = adapter;
        }

        private void viewExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void initList()
        {
            //데이터베이스에 있는 정보-->ReceiptAdapter-->ReceiptView에 보여주기
            //ReceiptAdapter receiptAdapter = new ReceiptAdapter();
            
            /*
            string strPrice = string.Format("{0:#,0}원", 120000);
            string[] data = { "1", "2021년6월24일", strPrice, "김담당", "박고객" };
            viewList.Items.Add(new ListViewItem(receiptAdapter.getReceiptDb()));

            for(int i =0; i< receiptAdapter.getReceiptDb().count; i++)
            {
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+2).ToString(),"2021년6월24일",strPrice,"김담당","박고객"
                    }
                    ));
            }
            */
        }

        public void initList(List<ReceiptVO> list)
        {
            //데이터베이스에 있는 정보-->ReceiptAdapter-->ReceiptView에 보여주기
            //ReceiptAdapter receiptAdapter = new ReceiptAdapter();

            
            
            for (int i = 0; i < list.Count; i++)
            {
                string strPrice = string.Format("{0:#,0}원", list[i].TotalPrice);

                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),list[i].Indate,
                        strPrice,
                        list[i].StaffName,
                        list[i].CustName
                    }
                    ));
            }
            CommUtil.setRowColor(viewList, Color.White, Color.LightGray);
        }

        private void ReceiptView_Load(object sender, EventArgs e) //폼이 시작하는 시점에 열리는것(생성자보다는 느리다)
        {
            CommUtil.colorListViewHeader(ref viewList, Color.Black, Color.White);
            List<ReceiptVO> list = adapter.getReceiptDb(); //initList()에 해도 되는데 
            initList(list);
        }

        private void viewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //샘플코드 쓰면된다 이거는 
           if (viewList.SelectedItems.Count !=0)
            {
                int n = viewList.SelectedItems[0].Index;
                string num = viewList.Items[n].SubItems[0].Text;
                string date = viewList.Items[n].SubItems[1].Text;
                string price = viewList.Items[n].SubItems[2].Text;
                string staff = viewList.Items[n].SubItems[3].Text;
                string cust = viewList.Items[n].SubItems[4].Text;
                Console.WriteLine("번호: " + num);
                Console.WriteLine("접수날짜: " + date);
                Console.WriteLine("총결제금액: " + price);
                Console.WriteLine("담당자: " + staff);
                Console.WriteLine("고객명: " + cust);
            }
        }
    }
}
