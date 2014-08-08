using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stock;
using user;
using stockprocess;
using System.Data.OleDb;
using System.Timers;   

namespace StockSystem
{
    public partial class login : Form
    {
        public static Boolean signala = false;
        public static Boolean signalb = false;
        public login()
        {   
            InitializeComponent();
            
         }
        


        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


       


        private void a股票行情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (signala == false)
            { signala = true;
            signalb = false;
            }
            else
            { signala = false; }

            
        }
    
        private void b股票行情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (signalb == false)
            { signalb = true;
            signala = false;
            }
            else
            { signalb = false; }

        }

        private void 个人资金ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您现有现金为："+StockSystem.Spebra.otheruser[9].getmoney().ToString());
        }

        private void a股票ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            astockbuy  buy = new astockbuy();
            buy.Show();
            
        }

        private void b股票ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bstockbuy buy = new bstockbuy();
            buy.Show();
           
        }

        private void 个人设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void a股票ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            astocksell sell = new astocksell();
            sell.Show();
            
        }

        private void b股票ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bstocksell sell = new bstocksell();
            sell.Show();
         
        }

        private void 所持股票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("所持A股票数："+StockSystem.Spebra.otheruser[9].getAstock().ToString()+"\n"+"所持B股票数："+
                StockSystem.Spebra.otheruser[9].getBstock().ToString());
        }

        private void 邮箱变更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altinfo alt = new altinfo();
            alt.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (signala == true)
            {
                string temp;
                int j = 0;
                string[] price = new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
               
                float[] stock = new float[12];
                oleDbConnection1.Open();
                oleDbCommand1.CommandText = @"select dealprice from stockA order by ID desc";

                OleDbDataReader dr = oleDbCommand1.ExecuteReader();
                while (dr.Read() && j < 12)
                {
                    temp = dr.GetString(0);
                    stock[j] = Convert.ToSingle(temp);
                    j++;
                }
                oleDbConnection1.Close();
                float[] d = stock;

                //画图初始化
                Bitmap bmap = new Bitmap(500, 500);
                Graphics gph = Graphics.FromImage(bmap);
                gph.Clear(Color.Black);
                PointF cpt = new PointF(40, 420);//中心点
                PointF[] xpt = new PointF[3] { new PointF(cpt.Y + 15, cpt.Y), new PointF(cpt.Y, cpt.Y - 8), new PointF(cpt.Y, cpt.Y + 8) };//x轴三角形
                PointF[] ypt = new PointF[3] { new PointF(cpt.X, cpt.X - 15), new PointF(cpt.X - 8, cpt.X), new PointF(cpt.X + 8, cpt.X) };//y轴三角形
                gph.DrawString("A股票当前行情（每5秒钟一刷新）", new Font("宋体", 14), Brushes.Turquoise, new PointF(cpt.X + 60, cpt.X));//图表标题
                //画x轴
                gph.DrawLine(Pens.YellowGreen, cpt.X, cpt.Y, cpt.Y, cpt.Y);
                gph.DrawPolygon(Pens.White, xpt);
                gph.FillPolygon(new SolidBrush(Color.Blue), xpt);
                gph.DrawString("最近交易", new Font("宋体", 12), Brushes.Wheat, new PointF(cpt.Y + 10, cpt.Y + 10));
                //画y轴
                gph.DrawLine(Pens.YellowGreen, cpt.X, cpt.Y, cpt.X, cpt.X);
                gph.DrawPolygon(Pens.White, ypt);
                gph.FillPolygon(new SolidBrush(Color.Blue), ypt);
                gph.DrawString("价格", new Font("宋体", 12), Brushes.White, new PointF(0, 7));
                for (int i = 1; i <= 12; i++)
                {
                    //画y轴刻度
                    if (i < 11)
                    {
                        gph.DrawString((i * 10).ToString(), new Font("宋体", 11), Brushes.White, new PointF(cpt.X - 30, cpt.Y - i * 30 - 6));
                        gph.DrawLine(Pens.White, cpt.X - 3, cpt.Y - i * 30, cpt.X, cpt.Y - i * 30);
                    }
                    //画x轴项目
                    gph.DrawString(price[i - 1].Substring(0), new Font("宋体", 11), Brushes.White, new PointF(cpt.X + i * 30 - 5, cpt.Y + 5));
                    //gph.DrawString(month[i - 1].Substring(1), new Font("宋体", 11), Brushes.White, new PointF(cpt.X + i * 30 - 5, cpt.Y + 20));
                    if (price[i - 1].Length > 2) gph.DrawString(price[i - 1].Substring(2, 1), new Font("宋体", 11), Brushes.White, new PointF(cpt.X + i * 30 - 5, cpt.Y + 35));
                    //画点
                    gph.DrawEllipse(Pens.White, cpt.X + i * 30 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);
                    gph.FillEllipse(new SolidBrush(Color.White), cpt.X + i * 30 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);
                    //画数值
                    gph.DrawString(d[i - 1].ToString(), new Font("宋体", 11), Brushes.White, new PointF(cpt.X + i * 30, cpt.Y - d[i - 1] * 3));
                    //画折线
                    if (i > 1) gph.DrawLine(Pens.Red, cpt.X + (i - 1) * 30, cpt.Y - d[i - 2] * 3, cpt.X + i * 30, cpt.Y - d[i - 1] * 3);
                }
                //保存输出图片
                //bmap.Save(Response.OutputStream, ImageFormat.Gif);
                pictureBox1.Image = bmap;
            }

            if (signalb == true)
            {
                
                string temp;
                int j = 0;
                string[] month = new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
               
                float[] stock = new float[12];
                oleDbConnection1.Open();
                oleDbCommand1.CommandText = @"select dealprice from stockB order by ID desc";

                OleDbDataReader dr = oleDbCommand1.ExecuteReader();
                while (dr.Read() && j < 12)
                {
                    temp = dr.GetString(0);
                    stock[j] = Convert.ToSingle(temp);
                    j++;
                }
                oleDbConnection1.Close();
                float[] d = stock;

                //画图初始化
                Bitmap bmap = new Bitmap(500, 500);
                Graphics gph = Graphics.FromImage(bmap);
                gph.Clear(Color.Black);
                PointF cpt = new PointF(40, 420);//中心点
                PointF[] xpt = new PointF[3] { new PointF(cpt.Y + 15, cpt.Y), new PointF(cpt.Y, cpt.Y - 8), new PointF(cpt.Y, cpt.Y + 8) };//x轴三角形
                PointF[] ypt = new PointF[3] { new PointF(cpt.X, cpt.X - 15), new PointF(cpt.X - 8, cpt.X), new PointF(cpt.X + 8, cpt.X) };//y轴三角形
                gph.DrawString("B股票当前行情（每五秒钟一刷新）", new Font("宋体", 14), Brushes.Turquoise, new PointF(cpt.X + 60, cpt.X));//图表标题
                //画x轴
                gph.DrawLine(Pens.YellowGreen, cpt.X, cpt.Y, cpt.Y, cpt.Y);
                gph.DrawPolygon(Pens.White, xpt);
                gph.FillPolygon(new SolidBrush(Color.Blue), xpt);
                gph.DrawString("交易次数", new Font("宋体", 12), Brushes.Wheat, new PointF(cpt.Y + 10, cpt.Y + 10));
                //画y轴
                gph.DrawLine(Pens.YellowGreen, cpt.X, cpt.Y, cpt.X, cpt.X);
                gph.DrawPolygon(Pens.White, ypt);
                gph.FillPolygon(new SolidBrush(Color.Blue), ypt);
                gph.DrawString("价格", new Font("宋体", 12), Brushes.White, new PointF(0, 7));
                for (int i = 1; i <= 12; i++)
                {
                    //画y轴刻度
                    if (i < 11)
                    {
                        gph.DrawString((i * 10).ToString(), new Font("宋体", 11), Brushes.White, new PointF(cpt.X - 30, cpt.Y - i * 30 - 6));
                        gph.DrawLine(Pens.White, cpt.X - 3, cpt.Y - i * 30, cpt.X, cpt.Y - i * 30);
                    }
                    //画x轴项目
                    gph.DrawString(month[i - 1].Substring(0), new Font("宋体", 11), Brushes.White, new PointF(cpt.X + i * 30 - 5, cpt.Y + 5));
                    //gph.DrawString(month[i - 1].Substring(1), new Font("宋体", 11), Brushes.White, new PointF(cpt.X + i * 30 - 5, cpt.Y + 20));
                    if (month[i - 1].Length > 2) gph.DrawString(month[i - 1].Substring(2, 1), new Font("宋体", 11), Brushes.White, new PointF(cpt.X + i * 30 - 5, cpt.Y + 35));
                    //画点
                    gph.DrawEllipse(Pens.White, cpt.X + i * 30 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);
                    gph.FillEllipse(new SolidBrush(Color.White), cpt.X + i * 30 - 1.5f, cpt.Y - d[i - 1] * 3 - 1.5f, 3, 3);
                    //画数值
                    gph.DrawString(d[i - 1].ToString(), new Font("宋体", 11), Brushes.White, new PointF(cpt.X + i * 30, cpt.Y - d[i - 1] * 3));
                    //画折线
                    if (i > 1) gph.DrawLine(Pens.Red, cpt.X + (i - 1) * 30, cpt.Y - d[i - 2] * 3, cpt.X + i * 30, cpt.Y - d[i - 1] * 3);
                }
                //保存输出图片
                //bmap.Save(Response.OutputStream, ImageFormat.Gif);
                pictureBox1.Image = bmap;
            }

        }

    


        

    }
}
