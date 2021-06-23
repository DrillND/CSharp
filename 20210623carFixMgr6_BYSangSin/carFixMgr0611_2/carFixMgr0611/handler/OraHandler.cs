using carFixMgr0611.model;
using Oracle.ManagedDataAccess.Client;
using System;

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
            cmd.ExecuteNonQuery();
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


                query += string.Format("into customer_t values " + "(customer_t_seq.nextval,'홍길동', " +
                    "'01012347890','19820520'," +
                    "car_t_seq.currval)");


                query += "select*from dual";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                //여기까지 한 트렌젝션

                for (int i = 0; i < 3; i++)
                {
                    string queryItem = string.Format("insert into repair_item_t values " +
                        "(repair_item_t_seq.nextval, " +
                        "'4','엔진오일 교환','50000', " +
                        "car_t_seq.currval)");
                    cmd.CommandText = queryItem;
                    cmd.ExecuteNonQuery();

                }
                // 띄어쓰기,괄호,세미콜론 등 항상 주의
                string queryReceipt = string.Format("insert into receipt_t values " +
                    "(receipt_t_seq.nextval, " +
                    "customer_t_seq.currval, '2021년6월23일', " +
                    "(select staff_t.staff_id from " +
                    "staff_t where staff_t.name = '김우치'), car_t_seq.currval, '1500000')");
                cmd.CommandText = queryReceipt;
                cmd.ExecuteNonQuery();

            }
            catch (OracleException e)
            {
                errMsg(e);

            }
        }
    }
}
