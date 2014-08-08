using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using user;
using SortSelect;


namespace stockprocess
{
    public class process
    {   
        static double[] ar = new double[5];//A股票卖价
        static double[] br = new double[5];//B股票卖价
        static double[] arl = new double[4];//A股票买价
        static double[] brl = new double[4];//B股票买价
       
        double[] Apsprice = new double[11];//记录A股票出价中可以交易的价格
        double[] Bpsprice = new double[11];//记录B股票出价中可以交易的价格
        double[] stockinfo = new double[2];

        public static int SplusTNum = 0;//A股票的s+t的数量  
        double dealpriceA,dealpriceB;
        int index = 0;//用来记录可交易的价格的数量

        user.user[] finalseller = new user.user[5];//顺序记录随机挑选的卖者编号
        user.user[] finalbuyer = new user.user[4];//顺序记录随机挑选的买者编号

       

        
        

        public double[] stockprocess(user.user[] stock)
        {   
            /*总共有卖者5人 买者4人 随机选择5名卖者4名买者进行后台交易，每五秒钟进行一次
             * 交易，算出一次成交价格共登陆用户购买交易。通过“实验3”中所给的具体算法算
             * 出成交价格*/
            int[] seller = new int[5];
            int[] buller = new int[4];

            /*以下为对A进行交易的机器人变量*/
            double[] Asellprice = new double[5];
            double[] Abullprice = new double[4];
            int[] Asellnum = new int[5];
            int[] Abuynum = new int[4];

            /*以下为对B进行交易的机器人变量*/
            double[] Bsellprice = new double[5];
            double[] Bbullprice = new double[4];
            int[] Bsellnum = new int[5];
            int[] Bbuynum = new int[4];

            /*以下进行随机挑选卖者5名 买者4名 并随机设置买卖价格和买卖数量（分别针对A股票B股票）*/
            seller = getRandomNum(5, 0, 8);
            buller = getRandomNum(5, 0, 8);
            Asellprice = getRandomNumPrice(5, 0, 50);
            Abullprice = getRandomNumPrice(4, 0, 50);
            Asellnum = getRandomNum(5, 1, 500);
            Abuynum = getRandomNum(4, 1, 500);
            Bsellprice = getRandomNumPrice(5, 0, 50);
            Bbullprice = getRandomNumPrice(4, 0, 50);
            Bsellnum = getRandomNum(5, 1, 500);
            Bbuynum = getRandomNum(4, 1, 500);
            

      
            for (int i = 0; i < 5; i++)
            {
                //设置针对AB股票的卖者信息（卖价，卖的数量）
                stock[seller[i]] = new user.user();

                stock[seller[i]].setAsellprice(Asellprice[i]);
                stock[seller[i]].setAsellnum(Asellnum[i]);

                stock[seller[i]].setBsellprice(Bsellprice[i]);
                stock[seller[i]].setBsellnum(Bsellnum[i]);
                
                ar[i] = stock[seller[i]].getAsellprice();
                br[i] = stock[seller[i]].getBsellprice();

                //将随机选择的5名卖家顺序存入一个数组 以便后续顺序的操作
                finalseller[i] = stock[seller[i]];


            }

            for (int i = 0; i < 4; i++)
            {
                //设置针对AB股票的买者信息（买价，买的数量）
                stock[buller[i]] = new user.user();

                stock[buller[i]].setAbuyprice(Abullprice[i]);
                stock[buller[i]].setAbuynum(Abuynum[i]);

                stock[buller[i]].setBbuyprice(Bbullprice[i]);
                stock[buller[i]].setBbuynum(Bbuynum[i]);

                arl[i] = stock[buller[i]].getAbuyprice();
                brl[i] = stock[buller[i]].getBbuyprice();

                //将随机选择的4名买家顺序存入一个数组 以便后续顺序的操作
                finalbuyer[i] = stock[buller[i]];
            }

            ar = SortSelect.ClassSort.BubbleSort(ar, 5);//对A股票的卖家出价进行排序（由小到大）
            br = SortSelect.ClassSort.BubbleSort(br, 5);//对B股票的卖家出价进行排序（由小到大）
            arl = SortSelect.ClassSort.BubbleSort(arl, 4);//对A股票的买家出价进行排序（由小到大）
            brl = SortSelect.ClassSort.BubbleSort(brl, 4);//对B股票的买家出价进行排序（由小到大）

            
            if (judgeRange(ar, arl, Apsprice))
            {
                sortDealprice(Apsprice);
                double[] Astorepricereal = new double[reduceSameprice(Apsprice).Length];
                Astorepricereal = reduceSameprice(Apsprice);
                double adp = sellfunA(stock, Astorepricereal);
                stockinfo[0] = adp-2.08;
               
            }
            else
            {
                stockinfo[0]=-1;
               
            }


            if (judgeRange(br, brl, Bpsprice))
            {
                sortDealprice(Bpsprice);
                double[] Bstorepricereal = new double[reduceSameprice(Bpsprice).Length];
                Bstorepricereal = reduceSameprice(Bpsprice);
                double bdp = sellfunB(stock, Bstorepricereal);
                stockinfo[1] = bdp+2.57;
              
                
            }
            else
            {
                stockinfo[1]= -1;
                
            }
             return stockinfo;
        }


        public  bool judgeRange(double[] seller,double[] buyer,double[] price)
        {
            int st=0;
            if (seller[0] <= buyer[arl.Length - 1])//判断可交易区间
            {
                int i = buyer.Length - 1;
                price[SplusTNum] = buyer[i];
                SplusTNum++;
                i = i - 1;
                int j = 0;
                int m = 1;
              

                while (i >= 0 && seller[0] <= buyer[i])
                {
                    
                    m++;//s
                    price[st] = buyer[i];
                    st++;
                    i--;

                }
                price[st] = seller[0];
                st++;
                while (j < seller.Length-1 && seller[j] < buyer[arl.Length - 1])
                {
                   
                    price[st] = buyer[j];
                    st++;
                    j++;
                }
                SplusTNum = st;
                return true;
            }
            else
            {
                return false;
            }
        }//判断可交易区间


        public void sortDealprice(double[] price) {
            price = SortSelect.ClassSort.BubbleSort(price, SplusTNum );//可交易值排序 
        }//把可交易区的存在的所有价格排序（由低到高）


        public  double[] reduceSameprice(double[] price)
        {
            //消除可交易区间相同价格的数量 使得价格相同的买卖价格只取一个
            int intx = 0;
            double[] a = new double[9];//用于存储不一样的价格数
            int lengthava = 0;
            a[0] = price[0];
            for (index = 0,intx = 0; index < SplusTNum-1; index++)
            {
                if (a[intx] == price[index + 1])
                {
                        
                }
                else
                {
                    a[intx+1] = price[index + 1];
                    intx++;
                }

            }
            intx++;

            for (int i = intx; i < 9; i++)
            {
                a[i] = -1; 
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != -1)
                {   
                    lengthava++;
                }
                else {
                    break;
                }
            }
            double[] storeprice = new double[lengthava];
            for (int i = 0; i < lengthava; i++)
            {
                storeprice[i] = a[i];
            }
            return storeprice;
        }//将可交易区内相同的价格归一



        public  double sellfunA(user.user []stock, double [] storeprice)
        {
            
            double[] sellnumA = new double[5];//用于记录A卖的各个价格的股票数
            double[] buynumA = new double[5];//用于记录A买的各个价格的股票数
   

            for (int i = 0; i < storeprice.Length; i++)
            {
                for (int j = 0; j < arl.Length; j++)
                {
                    if (finalseller[j].getAsellprice() == storeprice[i])
                    {
                        sellnumA[i] = sellnumA[i] + finalseller[j].getAsellnum();

                    }
                }
            }


            for (int i = 0; i < storeprice.Length; i++)
            {
                for (int j = 0; j < arl.Length; j++)
                {
                    if (storeprice[i] == finalbuyer[j].getAbuyprice())
                    {
                        buynumA[i] = buynumA[i] + finalbuyer[j].getAbuynum();

                    }
                }
            }

            double[] finsellnumA = new double[storeprice.Length];
            double[] finbuynumA = new double[storeprice.Length];

            for (int i = 0; i < storeprice.Length; i++)
            {
                if (i == 0)
                {
                    finsellnumA[i] = sellnumA[i];
                }
                else
                {
                    finsellnumA[i] = finsellnumA[i - 1] + sellnumA[i];
                }
            }//Sell

            for (int j = storeprice.Length - 1; j >= 0; j--)
            {
                if (j == storeprice.Length - 1)
                {
                    finbuynumA[storeprice.Length - 1 - j] = buynumA[j];
                }
                else
                {
                    finbuynumA[storeprice.Length - 1 - j] = finbuynumA[j + 1] + buynumA[j];
                }
            }//Buy

            double[] Estore = new double[storeprice.Length];//寻找min（E,S）

            for (int f = 0; f < storeprice.Length; f++)
            {
                if (finbuynumA[f] <= finsellnumA[f])
                {
                    Estore[f] = finbuynumA[f];
                }
                else
                {
                    Estore[f] = finsellnumA[f];
                }
            }

            Estore = SortSelect.ClassSort.BubbleSort(Estore, Estore.Length);

            double findealnum = Estore[Estore.Length - 1];//成交量最大值，以此来判断成交价格

            for (int e = 0; e < storeprice.Length; e++)
            {
                if (findealnum == finsellnumA[e])
                {
                    dealpriceA = storeprice[e];
                }
                else
                {
                    dealpriceA = storeprice[e];

                }
            }//成交量最大值对应的价格
            dealpriceA = Math.Round(dealpriceA, 2);
            return dealpriceA;
            }//算出A股票的成交价格

        public double sellfunB(user.user[] stock, double[] storeprice)
        {
         
            double[] sellnumB = new double[5];//用于记录B卖的各个价格的股票数
            double[] buynumB = new double[5];//用于记录B买的各个价格的股票数

            for (int i = 0; i < storeprice.Length; i++)
            {
                for (int j = 0; j < brl.Length; j++)
                {
                    if (finalseller[j].getBsellprice() == storeprice[i])
                    {
                        sellnumB[i] = sellnumB[i] + finalseller[j].getBsellnum();

                    }
                }
            }


            for (int i = 0; i < storeprice.Length; i++)
            {
                for (int j = 0; j < brl.Length; j++)
                {
                    if (storeprice[i] == finalbuyer[j].getBbuyprice())
                    {
                        buynumB[i] = buynumB[i] + finalbuyer[j].getBbuynum();

                    }
                }
            }

            double[] finsellnumB = new double[storeprice.Length];
            double[] finbuynumB = new double[storeprice.Length];
            for (int i = 0; i < storeprice.Length; i++)
            {
                if (i == 0)
                {
                    finsellnumB[i] = sellnumB[i];
                }
                else
                {
                    finsellnumB[i] = finsellnumB[i - 1] + sellnumB[i];
                }
            }//Sell

            for (int j = storeprice.Length - 1; j >= 0; j--)
            {
                if (j == storeprice.Length - 1)
                {
                    finbuynumB[storeprice.Length - 1 - j] = buynumB[j];
                }
                else
                {
                    finbuynumB[storeprice.Length - 1 - j] = finbuynumB[j + 1] + buynumB[j];
                }
            }//Buy

            
            double[] Estore = new double[storeprice.Length];

            for (int f = 0; f < storeprice.Length; f++)
            {
                if (finbuynumB[f] <= finsellnumB[f])
                {
                    Estore[f] = finbuynumB[f];
                }
                else
                {
                    Estore[f] = finsellnumB[f];
                }
            }

            Estore = SortSelect.ClassSort.BubbleSort(Estore, Estore.Length);
            double findealnum = Estore[Estore.Length - 1];//成交量最大值，以此来判断成交价格

            for (int e = 0; e < storeprice.Length; e++)
            {
                if (findealnum == finsellnumB[e])
                {


                    dealpriceB = storeprice[e];
                }
                else
                {


                    dealpriceB = storeprice[e];

                }
            }//成交量最大值对应的价格
            dealpriceB = Math.Round(dealpriceB, 2);
            return dealpriceB;
        }//算出B股票的成交价格


        public int[] getRandomNum(int num, int minValue, int maxValue)
        {
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int[] arrNum = new int[num];
            int tmp = 0;
            for (int i = 0; i <= num - 1; i++)
            {
                tmp = ra.Next(minValue, maxValue); //随机取数
                arrNum[i] = getNum(arrNum, tmp, minValue, maxValue, ra); //取出值赋到数组中

            }
            return arrNum;
        }//在minValue和maxValue之间取num个不同的随机数

        public int getNum(int[] arrNum, int tmp, int minValue, int maxValue, Random ra)
        {
            int n = 0;
            while (n <= arrNum.Length - 1)
            {
                if (arrNum[n] == tmp) //利用循环判断是否有重复
                {
                    tmp = ra.Next(minValue, maxValue); //重新随机获取。
                    getNum(arrNum, tmp, minValue, maxValue, ra);//递归:如果取出来的数字和已取得的数字有重复就重新随机获取。
                }
                n++;
            }
            return tmp;
        }//保证所取随机数为不同

        public double[] getRandomNumPrice(int num, int minValue, int maxValue)
        {
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            double[] arrNum = new double[num];
            double tmp = 0;
            for (int i = 0; i <= num - 1; i++)
            {
                    tmp = ra.Next(minValue,maxValue) + ra.NextDouble();
                    arrNum[i] = tmp;
            }
            return arrNum;
        }//在minValue和maxValue中取num个不同的随机价格

        public double[] dealSNumber(double[] sell, double dprice)
        {  
            int flag=-1;
            int i = 0;
             while (flag != 0&&i<sell.Length)
             {
                 if (sell[i] <= dprice)
                 {
                     i++;
                 }
                 else 
                 {                  
                     flag = -1;
                     break;
                 }
             }

             double[] psdeal1 = new double[i];
             for (int count = 0; count < i; count++)
             {
                 psdeal1[count] = sell[count];
             }
             return psdeal1;
             
        }

        public double[] dealBNumber(double[] buy, double dprice)
        {
            int flag = -1;
            int j = buy.Length - 1;
            while (flag!=0)
            {  
                if ( j>=0 && buy[j] >= dprice )
                {
                    j--;
                }
                else
                {
                    flag=0;
                    break;
                }

            }
            double[] psdeal2 = new double[buy.Length - j - 1];
            for (int count = 0, count2 = buy.Length - 1; count < buy.Length - j - 1; count++, count2--)
            {
                psdeal2[count] = buy[count2];
            }
            return psdeal2;
        }

        public void finalAstocknum(double[] sellprice, double[] buyprice,user.user[] seller,user.user[] buyer)
        {   double need=0;
            double[] Astock = new double[2];
            for(int sum=0;sum<buyer.Length;sum++)
            {
                need=need+buyer[sum].getAbuynum();
            }
            for (int i = 0; i < finalseller.Length; i++)
            {
                for (int j = i; j < finalbuyer.Length; j++)
                {
                    if (seller[i].getAsellnum() >= buyer[j].getAbuynum())
                    {
                        need = need - buyer[j].getAbuynum();
                        seller[i].setAsellnum(seller[i].getAsellnum() - buyer[j].getAbuynum());
                        buyer[i].setAstock(buyer[i].getAstock()+buyer[i].getAbuynum());
                     
                    }
                    else
                    {
                        need = need - seller[i].getAsellnum();
                        seller[i].setAsellnum(0);
                        seller[i].setAstock(seller[i].getAstock()-seller[i].getAsellnum());
                     
                        break;
                    }
                }
            }
           
        }


        public void finalBstocknum(double[] sellprice, double[] buyprice, user.user[] seller, user.user[] buyer)
        {
            double[] Bstock = new double[2];
            double need = 0;
            for (int sum = 0; sum < buyer.Length; sum++)
            {
                need = need + buyer[sum].getBbuynum();
            }
            for (int i = 0; i < finalseller.Length; i++)
            {
                for (int j = i; j < finalbuyer.Length; j++)
                {
                    if (seller[i].getBsellnum() >= buyer[j].getBbuynum())
                    {
                        need = need - buyer[j].getBbuynum();
                        seller[i].setBsellnum(seller[i].getBsellnum() - buyer[j].getBbuynum());
                        buyer[i].setBstock(buyer[i].getAstock() + buyer[i].getAbuynum());
                               
                    }
                    else
                    {
                        need = need - seller[i].getBsellnum();
                        seller[i].setBsellnum(0);
                        seller[i].setBstock(seller[i].getBstock() - seller[i].getBsellnum());
                    
                        break;
                    }
                }
            }
          
        }
        }

    
    }

