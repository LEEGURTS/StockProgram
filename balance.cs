using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_test01 {
	public class balance {
        public string 종목코드 { get; set; }
        public string 종목명 { get; set; }
        public double 수량 { get; set; }
        public double 매수금 { get; set; }
        public double 현재가 { get; set; }
        public double 평가손익 { get; set; }
        public double 수익률 { get; set; }

        public balance() { }

        public balance(string code, string name, double num, double buy, double price, double profit, double percentage) {
            this.종목코드 = code;
            this.종목명 = name;
            this.수량 = num;
            this.매수금 = buy;
            this.현재가 = price;
            this.평가손익 = profit;
            this.수익률 = percentage;
        }
    }

    public class unbuy {
        public string 주문번호 { get; set; }
        public string 종목코드 { get; set; }
        public string 종목명 { get; set; }
        public int 수량 { get; set; }
        public int 주문가격 { get; set; }
        public int 미체결수량 { get; set; }
        public string 주문구분 { get; set; }
        public string 시간 { get; set; }
        public int 현재가 { get; set; }

        public unbuy() { }

        public unbuy(string orderNumber, string code, string name, int orderNum, int orderPrice, int unorderNum, string sep, string time, int price) {
            this.주문번호 = orderNumber;
            this.종목코드 = code;
            this.종목명 = name;
            this.수량 = orderNum;
            this.주문가격 = orderPrice;
            this.미체결수량 = unorderNum;
            this.주문구분 = sep;
            this.시간 = time;
            this.현재가 = price;
        }
    }
}
