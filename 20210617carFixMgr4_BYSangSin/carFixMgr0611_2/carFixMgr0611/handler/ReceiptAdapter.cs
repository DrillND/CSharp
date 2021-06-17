using carFixMgr0611.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.handler
{
    class ReceiptAdapter
    {
        private List<Receipt> receiptList =
            new List<Receipt>();

        public void addReceipt(Receipt receipt)
        {
            receiptList.Add(receipt);
        }

        public void viewReceipt()
        {

        }
    }
}
