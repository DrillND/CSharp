using carFixMgr0611.model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        OracleCommand cmd;

        public OraHandler()
        {
            Console.WriteLine("객체 생성");
            conn = new OracleConnection(ORADB);
            cmd = new OracleCommand();
            dbConnect();
        }

        // 소멸자
        ~OraHandler()
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
            catch(OracleException e)
            {
                errMsg(e);
            }
        }

        public void errMsg(OracleException e)
        {
            Console.WriteLine("에러내용: " + e.Message);
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
                errMsg(e);
            }
        }

        public void insertDb()
        {
            string model = "그랜저";
            string cc = "2500cc이하";
            string number = "23가2345";
            string caryear = "2020년식";

            string query =
                string.Format("insert into car_t values " +
                "(CAR_T_SEQ.NEXTVAL, '{0}', '{1}', '{2}', '{3}')",
                model, number, cc, caryear);
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public void insertDb(Receipt receipt)
        {
            try
            {
                string query =
                    string.Format("insert all " +
                    "into car_t values (CAR_T_SEQ.NEXTVAL, " +
                    "'{0}', '{1}', '{2}', '{3}')",
                    receipt.Car.Model,
                    receipt.Car.Number,
                    receipt.Car.Cc,
                    receipt.Car.Year);

                query += string.Format("into CUSTOMER_T values " +
                    "(CUSTOMER_T_SEQ.NEXTVAL, '{0}', " +
                    "'{1}', '{2}', " +
                    "CAR_T_SEQ.currval)",
                    receipt.Cust.Name,
                    receipt.Cust.Tel,
                    receipt.Cust.Birth);

                query += "select * from dual";
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                List<RepairItem> itemList = 
                    receipt.ItemList;
                for (int i = 0; i < itemList.Count; i++)
                {
                    RepairItem item = itemList[i];
                    string queryItem =
                        string.Format(
                            "insert into REPAIR_ITEM_T values " +
                            "(REPAIR_ITEM_T_SEQ.NEXTVAL, " +
                            "{0}, '{1}', {2}, " +
                            "CAR_T_SEQ.currval)",
                            item.Idx, item.Repair,
                            item.Price);
                    cmd.CommandText = queryItem;
                    cmd.ExecuteNonQuery();
                }

                string queryReceipt =
                    string.Format("insert into RECEIPT_T values " +
                    "(RECEIPT_T_SEQ.NEXTVAL, " +
                    "CUSTOMER_T_SEQ.currval, CAR_T_SEQ.currval, " +
                    "'{0}', " +
                    "(select staff_t.staff_id from " +
                    "STAFF_T where staff_t.name = '{1}'), {2})",
                    receipt.InDate, receipt.StaffName,
                    receipt.TotalPrice);
                cmd.CommandText = queryReceipt;
                cmd.ExecuteNonQuery();
            }
            catch(OracleException e)
            {
                errMsg(e);
            }
        }
    }
}
