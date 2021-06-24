using carFixMgr0611.model;
using System;
using System.Collections.Generic;

namespace carFixMgr0611.handler
{
    class ReceiptAdapter //클래스 앞에 public 없으면 디폴트 값 private
    {
        private List<Receipt> receiptList =
            new List<Receipt>();

        private OraHandler ora;
        public ReceiptAdapter(OraHandler ora)
        {
            this.ora = ora;
        }

        public void addReceipt(Receipt receipt)
        {
            receiptList.Add(receipt);
        }

        public void addReceiptDb()
        {
            for (int i = 0; i < receiptList.Count; i++)
            {
                ora.insertdb(receiptList[i]);
            }
            receiptList.Clear();
        }

        public void viewReceipt()
        {
            for (int i = 0; i < receiptList.Count; i++)
            {
                Customer cust = receiptList[i].Cust; //고객 객체정보
                Console.WriteLine("고객명 : " + cust.Name); //name C#에서만 쓸 수 있는 특수한 메소드
                Console.WriteLine("고객전화 : " + cust.Tel);
                Console.WriteLine("생년월일 : " + cust.Birth);


                Car car = receiptList[i].Car;
                Console.WriteLine("모델명 : " + car.Model);
                Console.WriteLine("차량번호 : " + car.Number);
                Console.WriteLine("배기량 : " + car.Cc);
                Console.WriteLine("차량연식 : " + car.Year);


                Console.WriteLine("담당자 : " + receiptList[i].StaffName);
                Console.WriteLine("접수날짜 : " + receiptList[i].InDate);


                List<RepairItem> itemList = receiptList[i].ItemList;
                for (int j = 0; j < itemList.Count; j++)
                {
                    Console.WriteLine("수리번호 : " + itemList[j].Idx);
                    Console.WriteLine("수리항목 : " + itemList[j].Repair);
                    Console.WriteLine("수리비용 : " + itemList[j].Price);
                }

                //총 결제 금액 없다. 새로운 클래스 만들어서 생성

            }
        }

        public void viewReceiptDb()
        {
            ora.showDb();
        }
    }
}
