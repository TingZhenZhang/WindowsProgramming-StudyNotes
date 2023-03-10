using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomButtonDemo
{
    class PokerModel
    {
        //⿊桃4、愛⼼3、⽅塊2、梅花1
        public int suit;
        //A, 2, 3, … 9, 10, J, Q, K 分別為 1, 2, 3, … 9, 10, 11, 12, 13
        public int face;
        //true 表⽰為背⾯、false 表⽰為正⾯
        public bool isBack;

        public bool isHide;

        public int pokerValue()//要有public才可被主程式讀取
        {
            return suit * 100 + face;
        }
    }
}
