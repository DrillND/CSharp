using carFixMgr0611.common;
using carFixMgr0611.handler;
using carFixMgr0611.model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace carFixMgr0611.ui
{
    partial class ReceiptView : MaterialForm //여기서 퍼블릭 뺏다
    {
        ReceiptAdapter adapter;
        List<ReceiptVO> receiptList;
        public ReceiptView()
        {
            InitializeComponent();
            //initList(); //가장빠른 처리,이니셜라이즈 밑에
        }

        public ReceiptView(ReceiptAdapter adapter)
        {
            //생성자
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

        public void initList(List<ReceiptVO> list) //메소드 오버로딩
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
                        list[i].CarNum,
                        list[i].CustName
                    }
                    ));
            }
            CommUtil.setRowColor(viewList, Color.White, Color.LightGray);

            //스크롤을 밑으로 강제로 끌어내리는 것(참고용),삭제기능 넣을때 충돌 일어날 수도 있음.
            int index = viewList.Items.Count - 1;
            viewList.Items[index].Selected = true;
            viewList.Items[index].Focused = true;
            viewList.EnsureVisible(index);
        }

        public void initGrid()
        {
            string strPrice = string.Format("{0:#,0}원",80000);
            string[] data = { "1", "엔진오일 교환", strPrice };
            viewGrid.Rows.Add(data);

            for (int i=0; i<50; i++)
            {
                viewGrid.Rows.Add(new string[]
                    {
                        (i+2).ToString(), "부동액 교환", strPrice
                    });
            }
            int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell = viewGrid.Rows[count - 1].Cells[0];
            //이것들은 옵션
        }

        public void initGrid(List<RepairItem> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string strPrice = 
                string.Format("{0:#,0}원", list[i].Price);
                viewGrid.Rows.Add(new string[]
                    {
                        (i+1).ToString(), list[i].Repair, strPrice
                    });
            }
            /*int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell = viewGrid.Rows[count - 1].Cells[0];*/
            //이것들은 옵션
        }

        public void initList2(List<ReceiptVO> list)
        {
           //이거 내가 한거
        }

        private void ReceiptView_Load(object sender, EventArgs e) //폼이 시작하는 시점에 열리는것(생성자보다는 느리다)
        {
            CommUtil.colorListViewHeader(ref viewList, Color.Black, Color.White);
            receiptList = adapter.getReceiptVoDb(); //initList()에 해도 되는데 
            viewList.Items.Clear();
            initList(receiptList);
            initGrid();
        }

        private void viewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //샘플코드 쓰면된다 이거는 
            if (viewList.SelectedItems.Count != 0)
            {
                int n = viewList.SelectedItems[0].Index;
                string num = viewList.Items[n].SubItems[0].Text;
                string date = viewList.Items[n].SubItems[1].Text;
                string price = viewList.Items[n].SubItems[2].Text;
                string staff = viewList.Items[n].SubItems[3].Text;
                string carNum = viewList.Items[n].SubItems[4].Text;
                string cust = viewList.Items[n].SubItems[5].Text;
                Console.WriteLine("번호: " + num);
                Console.WriteLine("접수날짜: " + date);
                Console.WriteLine("총결제금액: " + price);
                Console.WriteLine("담당자: " + staff);
                Console.WriteLine("차량번호: " + carNum);
                int receipId = receiptList[n].ReceiptId;
                Console.WriteLine("접수ID: " + receipId);
                Console.WriteLine("고객명: " + cust);
                //여기까지

                List<RepairItem> list = adapter.GetRepairItemsDb(receipId);
                viewGrid.ClearRows();//그리드뷰 초기화, 그 다음 데이터를 뿌려줌
                initGrid(list);
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("수리항목: " + list[i].Repair);
                    Console.WriteLine("수리비: " + list[i].Price);
                }
            }

        }

        private void vSearchItem_Click(object sender, EventArgs e)
        {
            if (viewSelect.Text == "고객명")
            {
                viewList.Items.Clear();
                string name = viewSearch.Text;
                receiptList = adapter.getReceiptVoDb2(name);
                initList(receiptList);
                

            }
            else if (viewSelect.Text == "고객차량번호")
            {
                viewList.Items.Clear();
            }
        }
    }
}
