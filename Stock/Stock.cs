using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock
{
    public class Stock
    {
        private double price;
        private int number;
        private string name;

        public Stock()
        {
            this.number = 0;
            this.price = 1.0;
            this.name = "股票";
        }

        public Stock(int number, string name)
        {
            this.number = number;
            this.name = name;
            this.price = 1.0;
        }



        public void setprice(double price)
        {
            this.price = price;
        }

        public double getprice()
        {
            return this.price;
        }

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }


        public double nowpricefun()
        {
            this.price = this.price + 1000;
            return this.price;
        }


        public String printinfo()
        {
            return (name + " 价格：" + this.price + " 有:" + number + " 股 ");
        }

    }
}
