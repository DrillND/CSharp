using _20210611carFixMgr.handler;
using _20210611carFixMgr.model;
using _20210611carFixMgr.util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            string telH = custTelH.SelectedText;
            string telB = custTelB.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;

            string model = carModel.SelectedText;
            string number = CarNum.Text;
            string cc = CarCC.SelectedText;
            string caryear = CarYear.SelectedText;

            string staffname = staffName.SelectedText;

            string[] arrData = new string[]
            {
                name,telH,telB,year,month,day,model,number,cc,caryear,staffname
            };

            object[] arrObj = new object[] //테스트박스 콤보 등 다양한 타입을 통괄해서 쓸 수 있는 오브젝트 형
            {
                custName,custTelH,custTelB,custYear,custMonth,custDay,carModel,CarNum,CarCC,CarCC,staffName
            };

            string[] arrMsg = new string[]
            {
                "이름을 입력하세요",
                "전화번호 앞자리를 선택하세요",
                "전화번호 뒷자리를 입력하세요",
                "년도를 선택하세요",
                "월을 선택하세요",
                "일을 선택하세요",
                "차량모델을 선택하세요",
                "차량번호를 선택하세요",
                "배기량을 선택하세요",
                "챠량 연식을 선택하세요",
                "담당자를 선택하세요",

            };

            for (int i = 0; i < arrData.Length; i++)
            {
                if (arrData[i].Equals("") || arrData[i].Equals("선택"))
                {
                    MessageBox.Show(arrMsg[i]);
                    ActiveControl = arrObj[i] as Control; //(Control)arrObj[i]; 
                    // as, in, out 
                    ActiveControl.Focus(); // 포커스를 맞추어 줌.
                    return;
                }
            }

            UICheckBox[] checkBox = new UICheckBox[] //sunny ui에서만 쓰이는 타입.
            {
                chk1,chk2,chk3,chk4,chk5,chk6,chk7,chk8,chk9,chk10
            };

            List<RepairItem> itemList = new List<RepairItem>();
            Car car = new Car(arrData[6], arrData[7], arrData[8], arrData[9]);
            Customer cust = new Customer(arrData[0], arrData[1] + arrData[2], arrData[3] + arrData[4] + arrData[5]);
            //public Receipt(Customer cust, Car car, string inDate, string staffName, List<RepairItem> itemList)
            Receipt receipt = new Receipt(cust, car, DateTime.Now.ToString("yyyyMMdd"), arrData[10], itemList);

            for (int i = RepairTable.ENGINE_OIL; i < RepairTable.ETC_COST + 1; i++)
            {
                if (checkBox[i].Checked)
                {

                    Console.WriteLine("수리항목: " + checkBox[i].Text);
                    Console.WriteLine("수리비: " + RepairTable.fixMoney[i]);

                    /*
                    List<UIcheckbox> list = new List<UIcheckbox>();
                    list.Add("홍길동"); //순차적으로 들어간다.
                    list.Add("김길동");
                    list.Add("박길동");
                    // Receipt(Customer cust, Car car, string inDate, string staffName, List<RepairItem> itemList)
                    // Customer(string name, string tel, string birth)
                    // public Car(string model, string number, string cc, string year)
                    Receipt re = new Receipt(new Customer(arrData[0], arrData[1] + arrData[2], arrData[3] + arrData[4] + arrData[5]),
                        new Car(arrData[6], arrData[7], arrData[8], arrData[9]), DateTime.Now.ToString("yyyyMMdd"),arrData[10],
                        list.add(new RepairItem(int idx, string repair, int price)));
                    */ //내가 연습해 본 것.



                    itemList.Add(new RepairItem(i, checkBox[i].Text, RepairTable.fixMoney[i]));



                }
            }
            if (itemList.Count == 0)
            {
                MessageBox.Show("수리항목을 체크하세요");
                return;
            }

            

            ReceiptiAdapter receiptiAdapter = new ReceiptiAdapter();
            receiptiAdapter.addReceipt(receipt);
            receiptiAdapter.viewReceipt(receipt);

            //한글 입력 체크
            string chkName = Regex.Replace(name, @"[^가-힣]{2,4}", "");
            Console.WriteLine("정규표현식: " + chkName);
            if(chkName.Length != name.Length)
            {
                setFocus(custName, Properties.Resources.ERR_NAME_WRONG);
                return;
            }

            //자리수 체크
            Regex regex = new Regex(@"[가-힣]{3}");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                MessageBox.Show(Properties.Resources.ERR_NAME_SIZE);
                ActiveControl = custName;
                ActiveControl.Focus();
                custName.Text = "";
                return;
            }

            //전화번호 체크
            string telAll = telH + telB;
            if (telAll.Length == 10 || telAll.Length == 11)
            {
                Regex regex2 = new Regex(@"01{1}[016789]{1}[0-9]{7,8}");

                Match m2 = regex2.Match(telAll); 
                if (m2.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호");
                    return;
                }

            else
                {
                    MessageBox.Show("올바른 전화번호 자리수를 입력하세요");
                        return;
                }


            }

            Console.WriteLine("고객명: " +name);
            Console.WriteLine("전화: "+ (telH+telB));
            Console.WriteLine("생년월일: "+ (year+month+day));
            Console.WriteLine("차량모델: " +model);
            Console.WriteLine("차량번호: " +number);
            Console.WriteLine("배기량: " +cc);
            Console.WriteLine("차량연식: " +caryear);
            Console.WriteLine("담당자: " +staffname);
            

            // 예외처리, 체크박스 어떻게 받는지, 모든 정보(Receipt 객체 생성,RepairItem = list담는다 >>>>DB)

            /*
            if(name.Equals(""))
            {
                MessageBox.Show("이름을 입력하세요");
                ActiveControl = custName; //현재 활성화되어있는 것은 뭐냐?
                custName.Focus(); // 포커스를 맞추어 줌.
                return; // 메서드가 void일때 return == 메서드 종료가 된다.
                //여기서는 메소드 탈출
            }// 이렇게 하지 말고 메서드를 이용한다. 

            if(telH.Equals(""))
            {
                MessageBox.Show("전화번호 앞자리를 선택하세요");
                ActiveControl = custTelH;
                custTelH.Focus();
                return;
            }
            */
            Close();
        }

        private void setFocus(Control cont,string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = cont;
            ActiveControl.Focus();
            cont.Text = "";
        }

        private void Receipt(object p)
        {
            throw new NotImplementedException();
        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
