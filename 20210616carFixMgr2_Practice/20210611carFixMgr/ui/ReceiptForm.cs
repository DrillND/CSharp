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
            string number = carNum.Text;
            string cc = carCC.SelectedText;
            string caryear = carYear.SelectedText;

            string staffname = staffName.SelectedText;

            if (name.Equals(""))
            {
                MessageBox.Show("이름이 누락되었습니다.", "항목 오류");
                custName.Focus();
            }
            else if (telh.Equals(""))
            {
                MessageBox.Show("전화번호가 누락되었습니다.", "항목 오류");
                custTelH.Focus();
            }
            else if (telb.Equals(""))
            {
                MessageBox.Show("전화번호가 누락되었습니다.", "항목 오류");
                custTelB.Focus();
            }
            else if (year.Equals(""))
            {
                MessageBox.Show("생년이 누락되었습니다.", "항목 오류");
                custYear.Focus();
            }
            else if (month.Equals(""))
            {
                MessageBox.Show("생월이 누락되었습니다.", "항목 오류");
                custMonth.Focus();
            }
            else if (day.Equals(""))
            {
                MessageBox.Show("생일이 누락되었습니다.", "항목 오류");
                custDay.Focus();
            }
            else if (model.Equals(""))
            {
                MessageBox.Show("차량모델이 누락되었습니다.", "항목 오류");
                carModel.Focus();
            }
            else if (number.Equals(""))
            {
                MessageBox.Show("차량번호가 누락되었습니다.", "항목 오류");
                carNum.Focus();
            }
            else if (cc.Equals(""))
            {
                MessageBox.Show("배기량이 누락되었습니다.", "항목 오류");
                carCC.Focus();
            }
            else if (caryear.Equals(""))
            {
                MessageBox.Show("연식정보가 누락되었습니다.", "항목 오류");
                carYear.Focus();
            }
            else if (staffname.Equals(""))
            {
                MessageBox.Show("담당자 정보가 누락되었습니다.", "항목 오류");
                staffName.Focus();
            }
            else
            {
                Console.WriteLine("고객명: " + name);
                Console.WriteLine("전화: " + (telh + telb));
                Console.WriteLine("생년월일: " + (year + month + day));
                Console.WriteLine("차량모델: " + model);
                Console.WriteLine("차량번호: " + number);
                Console.WriteLine("배기량: " + cc);
                Console.WriteLine("차량연식: " + caryear);
                Console.WriteLine("담당자: " + staffname);
            }

            // 예외처리, 체크박스 어떻게 받는지, 모든 정보(Receipt 객체 생성,RepairItem = list담는다 >>>>DB)

        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
