using carFixMgr0611.model;
using carFixMgr0611.ui;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace carFixMgr0611.handler
{
    class OraHandler
    {
        const string ORADB =
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
            "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
            "(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)" +
            "(SERVICE_NAME=XE)));" +
            "User Id=sqlDB;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd; //참조, 참조 추가, Oracle.ManagedDataAccess (없으면)
        // Nuget패키지 관리 - ODP.NetCore

        //c# 자바 공통 방식
        public OraHandler()
        {
            Console.WriteLine("객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        ~OraHandler() // ~소멸자, 객체가 소멸할 때 호출
        {
            Console.WriteLine("객체 소멸");
            dbClose();
        }

        public void dbConnect()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e)
            {
                errMsg(e);
            }
        }

        public void errMsg(OracleException e)
        {
            //Console.WriteLine("오라클 접속 에러!");
            //Console.WriteLine("에러번호:" + e.Number);
            Console.WriteLine("에러내용:" + e.Message);
            Console.WriteLine(e.StackTrace);
        }

        public void dbClose()
        {
            try
            {
                conn.Close();
                Console.WriteLine("오라클 접속 해제!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("오라클 접속 해제 에러!");
                errMsg(e);
            }
        }
        public void insertdb()
        {

            string model = "그랜저";
            string cc = "2500cc이하";
            string number = "23가2345";
            string caryear = "2020년식";

            string query = string.Format("insert into car_t values " + "(CAR_T_SEQ.NEXTVAL,'{0}','{1}','{2}','{3}')",
                model, number, cc, caryear);

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery(); //insert drop 뭐든 실행한다는 의미
        }
        public void insertdb(Receipt receipt)
        {
            try
            {
                string query = string.Format("insert all " +
                "into car_t values(car_t_seq.nextval, " +
                "'{0}', '{1}', '{2}','{3}')",
                receipt.Car.Model,
                receipt.Car.Number,
                receipt.Car.Cc,
                receipt.Car.Year);


                query += string.Format("into customer_t values " + "(customer_t_seq.nextval, " +
                    "'{0}','{1}','{2}', " + "car_t_seq.currval)",
                    receipt.Cust.Name,
                    receipt.Cust.Tel,
                    receipt.Cust.Birth);


                query += "select*from dual";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //여기까지 한 트렌젝션

                List<RepairItem> itemList = receipt.ItemList;
                //리스트는 가변적 숫자를 모를 때

                for (int i = 0; i < itemList.Count; i++)
                {
                    RepairItem item = itemList[i];
                    string queryItem = string.Format("insert into repair_item_t values " +
                        "(repair_item_t_seq.nextval, " +
                        "{0},'{1}',{2}, " +
                        "car_t_seq.currval)",
                        item.Idx, item.Repair, item.Price);
                    cmd.CommandText = queryItem;
                    cmd.ExecuteNonQuery();

                }
                // 띄어쓰기,괄호,세미콜론 등 항상 주의
                string queryReceipt = string.Format("insert into receipt_t values " +
                    "(receipt_t_seq.nextval, " +
                    "customer_t_seq.currval, '{0}', " +
                    "(select staff_t.staff_id from " +
                    "staff_t where staff_t.name = '{1}'), car_t_seq.currval, {2})",
                    receipt.InDate, receipt.StaffName, receipt.TotalPrice);
                //{} 양옆에 ''가있으면 문자열 없으면 숫자형
                cmd.CommandText = queryReceipt;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                errMsg(e);

            }
        }

        public void showDb()
        {
            string query = "select indate as 접수일, " +
                "total_price as 총결제금액, " +
                "(select customer_t.name from CUSTOMER_T where " +
                "customer_t.cust_ID = RECEIPT_T.cust_ID) as 고객명, " +
                "(select staff_t.name from staff_t where " +
                "staff_t.staff_ID = RECEIPT_T.staff_ID) as 담당자 " +
                "from receipt_t ";

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text; //셀렉트문은 이렇게 실행
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            //

            if (dr.HasRows)
            {
                while (dr.Read()) //데이터를 읽을 수 있으면
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("접수날짜: " + dr["접수일"]); //접수일에 필드명이나 알리아스 명 적으면 된다.
                    Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    Console.WriteLine("고객명: " + dr["고객명"]);
                    Console.WriteLine("담당자: " + dr["담당자"]);
                    Console.WriteLine("---------------------------");
                    count++;
                }
            }

            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }

            string query2 = "select repair as 수리항목, " +
                            "price as 수리비 from repair_item_t " +
                            "where car_id = " +
                            "(select customer_t.cust_id from customer_t where customer_t.name = '가나다')";

            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            dr = cmd.ExecuteReader();
            count = 1;

            if (dr.HasRows)
            {
                while (dr.Read()) //데이터를 읽을 수 있으면
                {
                    Console.WriteLine("번호: " + count);
                    Console.WriteLine("수리항목: " + dr["수리항목"]);
                    Console.WriteLine("수리비: " + dr["수리비"]);
                    Console.WriteLine("---------------------------");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
        }

        public List<ReceiptVO> getReceipt()
        {
            string query = "select indate as 접수일, " +
                "total_price as 총결제금액, " +
                "(select customer_t.name from CUSTOMER_T where " +
                "customer_t.cust_ID = RECEIPT_T.cust_ID) as 고객명, " +
                "(select staff_t.name from staff_t where " +
                "staff_t.staff_ID = RECEIPT_T.staff_ID) as 담당자 " +
                "from receipt_t ";

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text; //셀렉트문은 이렇게 실행
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            //
            List<ReceiptVO> list = new List<ReceiptVO>();

            if (dr.HasRows)
            {
                while (dr.Read()) //데이터를 읽을 수 있으면
                {
                    //Console.WriteLine("번호: " + count);
                    //Console.WriteLine("접수날짜: " + dr["접수일"]); //접수일에 필드명이나 알리아스 명 적으면 된다.
                    //Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    //Console.WriteLine("고객명: " + dr["고객명"]);
                    //Console.WriteLine("담당자: " + dr["담당자"]);
                    //Console.WriteLine("---------------------------");
                    ReceiptVO receiptvo = new ReceiptVO(dr["접수일"].ToString(), Convert.ToInt32(dr["총결제금액"]),
                        dr["고객명"].ToString(), dr["담당자"].ToString());

                    list.Add(receiptvo);
                    count++;
                   
                }
            }

            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
           
            dr.Close();
            return list;
        }

        public List<ReceiptVO> getReceiptVO()
        {
            //view 가상테이블 사용
            string query =
               "create or REPLACE view receipt_view as " +
               "select receipt_id as 접수ID, " +
               "indate as 접수일, " +
               "total_price as 총결제금액, " +
               "(select customer_t.name from CUSTOMER_T WHERE " +
               "CUSTOMER_T.CUST_ID = receipt_t.CUST_ID) as 고객명, " +
               "(select staff_t.name from staff_T WHERE " +
               "staff_T.STAFF_ID = receipt_t.STAFF_ID) as 담당자, " +
               "(select car_t.num from car_t WHERE " +
               "car_t.car_id = receipt_t.cust_id) as 차량번호 " +
               "from receipt_t";

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string query2 =
                "select * from receipt_view " +
                "order by 접수ID desc";
            
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text; //셀렉트문은 이렇게 실행
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            //
            List<ReceiptVO> list = new List<ReceiptVO>();

            if (dr.HasRows)
            {
                while (dr.Read()) //데이터를 읽을 수 있으면
                {
                    //Console.WriteLine("번호: " + count);
                    //Console.WriteLine("접수날짜: " + dr["접수일"]); //접수일에 필드명이나 알리아스 명 적으면 된다.
                    //Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    //Console.WriteLine("고객명: " + dr["고객명"]);
                    //Console.WriteLine("담당자: " + dr["담당자"]);
                    //Console.WriteLine("---------------------------");
                    ReceiptVO receiptvo = new ReceiptVO(dr["접수일"].ToString(), Convert.ToInt32(dr["총결제금액"]),
                        dr["고객명"].ToString(), dr["담당자"].ToString(),
                        Convert.ToInt32(
                            dr["접수ID"].ToString()),
                        dr["차량번호"].ToString()
                        );

                    list.Add(receiptvo);
                    count++;

                }
            }

            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }

            dr.Close();
            return list;
        }

        public List<ReceiptVO> getReceiptVO2(string name)
        {
            //view 가상테이블 사용
            string query =
               "create or REPLACE view receipt_view as " +
               "select receipt_id as 접수ID, " +
               "indate as 접수일, " +
               "total_price as 총결제금액, " +
               "(select customer_t.name from CUSTOMER_T WHERE " +
               "CUSTOMER_T.CUST_ID = receipt_t.CUST_ID) as 고객명, " +
               "(select staff_t.name from staff_T WHERE " +
               "staff_T.STAFF_ID = receipt_t.STAFF_ID) as 담당자, " +
               "(select car_t.num from car_t WHERE " +
               "car_t.car_id = receipt_t.cust_id) as 차량번호 " +
               "from receipt_t";

            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            string query2 =
               "select * from receipt_view where '" + name + "' = 고객명 order by 접수ID desc";

            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text; //셀렉트문은 이렇게 실행
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            //
            List<ReceiptVO> list = new List<ReceiptVO>();

            if (dr.HasRows)
            {
                while (dr.Read()) //데이터를 읽을 수 있으면
                {
                    //Console.WriteLine("번호: " + count);
                    //Console.WriteLine("접수날짜: " + dr["접수일"]); //접수일에 필드명이나 알리아스 명 적으면 된다.
                    //Console.WriteLine("결제금액: " + dr["총결제금액"]);
                    //Console.WriteLine("고객명: " + dr["고객명"]);
                    //Console.WriteLine("담당자: " + dr["담당자"]);
                    //Console.WriteLine("---------------------------");
                    ReceiptVO receiptvo = new ReceiptVO(dr["접수일"].ToString(), Convert.ToInt32(dr["총결제금액"]),
                        dr["고객명"].ToString(), dr["담당자"].ToString(),
                        Convert.ToInt32(
                            dr["접수ID"].ToString()),
                        dr["차량번호"].ToString()
                        );

                    list.Add(receiptvo);
                    count++;

                }
            }

            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }

            dr.Close();
            return list;
        }

        public List<RepairItem> getRepairItem(string name)
        {
            string query2 = string.Format("select repair as 수리항목, " +
                "price as 수리비 from REPAIR_ITEM_T " +
                "where car_id = " +
                "(select customer_t.cust_id " +
                "from customer_t " +
                "where customer_t.NAME='{0}')", name);
            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            List<RepairItem> list = new List<RepairItem>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //Console.WriteLine("번호: " + count);
                    //Console.WriteLine("수리항목: " + dr["수리항목"]);
                    //Console.WriteLine("수리비: " + dr["수리비"]);
                    //Console.WriteLine("----------------------");
                    list.Add(new RepairItem(
                        0,
                        dr["수리항목"].ToString(),
                        Convert.ToInt32(dr["수리비"].ToString())));
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }
        public List<RepairItem> getRepairItem(int receiptId)
        {


            string query2 = string.Format("select repair as 수리항목, " +
                "price as 수리비 from REPAIR_ITEM_T " +
                "where car_id = {0}", receiptId); 
                

            cmd.CommandText = query2;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            int count = 1;
            List<RepairItem> list = new List<RepairItem>();
            //자바에서는 array list

            if (dr.HasRows)
            {
                while (dr.Read()) //데이터를 읽을 수 있으면
                {
                    //Console.WriteLine("번호: " + count);
                    //Console.WriteLine("수리항목: " + dr["수리항목"]);
                    //Console.WriteLine("수리비: " + dr["수리비"]);
                    //Console.WriteLine("---------------------------");
                    list.Add(new RepairItem(
                        0, dr["수리항목"].ToString(),
                        Convert.ToInt32(dr["수리비"].ToString())));
                    count++;
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return list;
        }
    }
}
