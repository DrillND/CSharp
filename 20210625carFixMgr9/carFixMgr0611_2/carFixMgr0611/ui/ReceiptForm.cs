using carFixMgr0611.handler;
using carFixMgr0611.model;
using carFixMgr0611.util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr0611.ui
{
    partial class ReceiptForm : MaterialForm //오버로딩, 앞에 퍼블릭 빼고 정보를 단일화(ReceiptAdapter과)
    {
        ReceiptAdapter adapter; //그냥 변수선언과 같은
        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(ReceiptAdapter adapter) //생성자
        {
            InitializeComponent();
            this.adapter = adapter;
            
        }

        #region 고객 정보 저장 메쏘드
        private void receiptSave_Click(object sender, EventArgs e) 
            //private void 버튼네임_이벤트(버튼 객체 자기 자신 예)특수한 계산기, 이벤트 정보)
        {
            string name = custName.Text;
            string telH = custTelH.SelectedText;
            string telB = custTelB.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;
            string model = carModel.SelectedText;
            string number = carNum.Text;
            string cc = carCC.SelectedText;
            string caryear = carYear.SelectedText;
            string staffname = staffName.SelectedText;

            string[] arrData = new string[]
            {
                name, telH, telB, year, month,
                day, model, number, cc, caryear, 
                staffname
            };

            object[] arrObj = new object[]
            {
                custName, custTelH, custTelB, custYear,
                custMonth, custDay, carModel, carNum,
                carCC, carYear, staffName
            };

            string[] arrMsg = new string[]
            {
                "이름을 입력하세요",
                "전화번호 앞자리를 선택하세요",
                "전화번호 뒷자리를 선택하세요",
                "년도를 선택하세요",
                "월을 선택하세요",
                "일을 선택하세요",
                "차량모델을 선택하세요",
                "차량번호를 입력하세요",
                "배기량을 선택하세요",
                "챠량연식을 선택하세요",
                "담당자를 선택하세요"
            };

            /*
            //배열로 한번에 데이터들을 처리
            for (int i = 0; i < arrData.Length; i++)
            {
                if (arrData[i].Equals("")
                    || arrData[i].Equals("선택"))
                {
                    MessageBox.Show(arrMsg[i]);
                    ActiveControl = arrObj[i] as Control; 
                    //현재 활성화 된 컨트롤 = arrObj[i] as 컨트롤 타입으로
                    //ActiveControl = (Control)arrObj[i]; , C,JAVA 스타일 형을 강제로 변환한다. 변수 파트에서 공부
                    ActiveControl.Focus();
                    return; // 밑으로 진행 되면 안되니까 void에서 메소드를 중단한다. 
                }
            }
            */

            Dictionary<Object, string> dicInput = new Dictionary<Object, string>();
            // Dictionary<키, 벨류>
            for (int i = 0; i<arrData.Length; i++)
            {
                dicInput.Add(arrObj[i], arrData[i]);
            }

            int cnt = 0;
            foreach(KeyValuePair<object,string> item in dicInput)
            {
                if(item.Value.Equals("")|| item.Value.Equals("선택"))
                {
                    setFocus(item.Key as Control, arrMsg[cnt]);
                    return;
                }
                cnt++;
            }

            UICheckBox[] checkBox = new UICheckBox[]
            {
                chk1, chk2, chk3, chk4, chk5,
                chk6, chk7, chk8, chk9, chk10
            };

            int sum = 0;
            List<RepairItem> itemList = new List<RepairItem>(); //수리 항목을 담을 리스트
            //<>제네릭 = 용용 클래스, 어떤 타입도 넣을 수 있다. 그렇지만 중간에 타입이 바뀔 수 없다. 파이썬은 가능
            for (int i=RepairTable.ENGINE_OIL;
                i<RepairTable.ETC_COST+1; i++)
            {
                if (checkBox[i].Checked)
                {
                    //Console.WriteLine("수리항목:"+checkBox[i].Text);
                    //Console.WriteLine("수리비"+RepairTable.fixMoney[i]); 보여주기 위한 코드
                    itemList.Add(new RepairItem(i,
                        checkBox[i].Text, RepairTable.fixMoney[i]));
                    sum += RepairTable.fixMoney[i];
                }
            }

            if (itemList.Count == 0)
            {
                MessageBox.Show("수리항목을 체크하세요");
                return;
            }

            // 한글 입력 체크
            Regex regex = //정규표현식 Regex, 특정문자열 내에서 가공 처리, 모든 프로그램 언어에서 사용된다.
                    new Regex(@"^[가-힣]{2,4}$"); //한글 가에서 힣 까지 두 자리에서 네 자리까지 ^=부정 $=문자열 마지막
            Match m = regex.Match(name); //입력 받은 name과 regex이 매치가 되는지
            if (m.Success == false) //매치가 되지 않는다면
            {
                setFocus(custName,
                    Properties.Resources.ERR_NAME_WRONG);
                return;
            }
            /*
            // 자리수 체크
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
            */

            // 전화번호 체크
            string telAll = telH + telB;
            if (telAll.Length == 10 || telAll.Length == 11)
            {
                Regex regex2 = 
                    new Regex(@"^01{1}[01]{1}[0-9]{8}$");
                //01 [01] 0또는1 [0-9]까지 8자리 숫자
                //꼭 정규식 안써도 된다. 프로그래밍으로 작성해도 된다. 
                Match m2 = regex2.Match(telAll);
                if (m2.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호");
                    return;
                }
            }
            else
            {
                MessageBox.Show("올바른 전화번호 자리수를 입력하세요");
                return;
            }
#if DEBUG_
            Console.WriteLine("고객명: " + name);
            Console.WriteLine("전화: " + (telH + telB));
            Console.WriteLine("생년월일: " + (year+month+day));
            Console.WriteLine("차량모델: " + model);
            Console.WriteLine("차량번호: " + number);
            Console.WriteLine("배기량: " + cc);
            Console.WriteLine("차량연식: " + caryear);
            Console.WriteLine("담당자: " + staffname);
#endif
            adapter.addReceipt(new Receipt(
                new Customer(name, telH+telB, year+month+day),new Car(model,number,cc,year), 
                DateTime.Now.ToString("yyyy년MM월dd일"),staffname,itemList, sum));

            Close();
        }
        #endregion

        private void setFocus(Control cont, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = cont;
            ActiveControl.Focus();
            cont.Text = "";
        }

        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}
