using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace user
{
    public class user
    {
        private string name;
        private double money;
        private double Astock;
        private double Bstock;
        private string pwd;

        private double Asellprice;
        private double Abuyprice;
        private double  Asellnum;
        private double  Abuynum;

        private double Bsellprice;
        private double Bbuyprice;
        private double  Bsellnum;
        private double  Bbuynum;

        public void setname(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return this.name;
        }

        public void setpwd(string pwd)
        {
            this.pwd = pwd;
        }
        public string getpwd()
        {
            return this.pwd;
        }

        public void setmoney(double money)
        {
            this.money = money;
        }
        public double getmoney()
        {
            return this.money;
        }

        public void setAstock(double Astock)
        {
            this.Astock = Astock;
        }
        public double getAstock()
        {
            return this.Astock;
        }

        public void setBstock(double Bstock)
        {
            this.Bstock = Bstock;
        }
        public double getBstock()
        {
            return this.Bstock;
        }


        public void setAsellprice(double Asellprice)
        {
            this.Asellprice = Asellprice;
        }

        public double getAsellprice()
        {
            return this.Asellprice;
        }

        public void setAsellnum(double Asellnum)
        {
            this.Asellnum = Asellnum;
        }
        public double getAsellnum()
        {
            return this.Asellnum;
        }

        public void setAbuyprice(double Abuyprice)
        {
            this.Abuyprice = Abuyprice;
        }
        public double getAbuyprice()
        {
            return this.Abuyprice;
        }
        public void setAbuynum(double Abuynum)
        {
            this.Abuynum = Abuynum;
        }
        public double getAbuynum()
        {
            return this.Abuynum;
        }


        public void setBsellprice(double Bsellprice)
        {
            this.Bsellprice = Bsellprice;
        }

        public double getBsellprice()
        {
            return this.Bsellprice;
        }

        public void setBsellnum(double Bsellnum)
        {
            this.Bsellnum = Bsellnum;
        }
        public double getBsellnum()
        {
            return this.Bsellnum;
        }

        public void setBbuyprice(double Bbuyprice)
        {
            this.Bbuyprice = Bbuyprice;
        }
        public double getBbuyprice()
        {
            return this.Bbuyprice;
        }
        public void setBbuynum(double Bbuynum)
        {
            this.Bbuynum = Bbuynum;
        }
        public double getBbuynum()
        {
            return this.Bbuynum;
        }

        
        public static double allocateAstock(int n)
        {
            double stockA = 10000 / n;
            return stockA;
        }

        public static double allocateBstock(int n)
        {
            double stockB = 20000 / n;
            return stockB;
        }
      
    }
}

