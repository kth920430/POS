using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject0._1
{
    class clsSale
    {
        //상품 번호
        private int proNum;

        public int ProNum
        {
            get { return proNum; }
            set { proNum = value; }
        }

        //상품 이름
        private string proName;

        public string ProName
        {
            get { return proName; }
            set { proName = value; }
        }

        //상품 수량
        private int proCount;

        public int ProCount
        {
            get { return proCount; }
            set { proCount = value; }
        }

        //상품 금액
        private int unitPrice;

        public int UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        //할인 가격
        private int discount;

        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        //이벤트 행사 이름
        private string eventname;

        public string EventName
        {
            get { return eventname; }
            set { eventname = value; }
        }

    }
}
