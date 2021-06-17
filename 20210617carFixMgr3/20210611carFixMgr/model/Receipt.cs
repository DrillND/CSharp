﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210611carFixMgr.model
{
    class Receipt
    {
        private Customer cust;
        private Car car;
        private string inDate;
        private string staffName;
        private List<RepairItem> itemList; //고객이 여러 부분 고치길 원할 수 있기 때문에

        public Receipt(Customer cust, Car car, string inDate, string staffName, List<RepairItem> itemList)
        {
            this.cust = cust;
            this.car = car;
            this.inDate = inDate;
            this.staffName = staffName;
            this.itemList = itemList;
        }

        public string InDate { get => inDate; set => inDate = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        internal Customer Cust { get => cust; set => cust = value; }
        internal Car Car { get => car; set => car = value; }
        internal List<RepairItem> ItemList { get => itemList; set => itemList = value; }
    }
}
