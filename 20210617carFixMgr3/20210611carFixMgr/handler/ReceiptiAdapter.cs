using _20210611carFixMgr.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210611carFixMgr.handler
{
    class ReceiptiAdapter
    {
        private List<Receipt> receiptList = new List<Receipt>();

        public void addReceipt(Receipt receipt)

        {
            receiptList.Add(receipt);
        }

        public void viewReceipt(Receipt receipt)
        {
            Console.WriteLine(receiptList);
        }
    }

    

   
}
