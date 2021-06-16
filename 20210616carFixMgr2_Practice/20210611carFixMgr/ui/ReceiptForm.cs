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

namespace _20210611carFixMgr.ui
{
    public partial class ReceiptForm : MaterialForm //닷넷에 폼 클래스로부터 상속 받아서 만들어짐
    {
        //디자인 폼에서 Customer Class의 변수들을 만들어준다. 
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void receiptSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telh = custTelH.SelectedText;
            string telb = custTelB.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;

            string model = carModel.SelectedText;
            string number = CarNum.Text;
            string cc = CarCC.SelectedText;
            string caryear = CarYear.SelectedText;

            string staffname = staffName.SelectedText;


            Console.WriteLine("고객명: " +name);
            Console.WriteLine("전화: "+ (telh+telb));
            Console.WriteLine("생년월일: "+ (year+month+day));
            Console.WriteLine("차량모델: " +model);
            Console.WriteLine("차량번호: " +number);
            Console.WriteLine("배기량: " +cc);
            Console.WriteLine("차량연식: " +caryear);
            Console.WriteLine("담당자: " +staffname);

            // 예외처리, 체크박스 어떻게 받는지, 모든 정보(Receipt 객체 생성,RepairItem = list담는다 >>>>DB)

        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
