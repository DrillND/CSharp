using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.model
{
    //m대m 관계에서 그 관계를 테이블화 해야 한다.
    //테이블의 정규화, 중복되는 테이블을 없애기 위해서
    class Customer
    {
        private string name;
        private string tel;
        private string birth;

        public Customer(string name, string tel, string birth)
        {
            this.name = name;
            this.tel = tel;
            this.birth = birth;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Birth { get => birth; set => birth = value; }
    }
}
