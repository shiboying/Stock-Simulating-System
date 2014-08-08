using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using user;
using stockprocess;
using System.Data.OleDb;

namespace StockSystem
{
    public partial class astockbuy : Form
    {
       

        public astockbuy()
        {
            InitializeComponent();
            label3.Text = "亲爱的" + StockSystem.Spebra.otheruser[9].getname()+"  股票有风险 投资需谨慎";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(textBox1.Text);
            double dealprice;
            string temp;
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = @"select dealprice from stockA order by ID desc";
            OleDbDataReader dr = oleDbCommand1.ExecuteReader();
            if (dr.Read())
            {
                temp=dr.GetString(0);
                dealprice = Convert.ToDouble(temp);
            }
            else 
            {
                dealprice = 0;
            }

            double yue = StockSystem.Spebra.otheruser[9].getmoney() - dealprice * amount;
            if (yue >= 0)
            {
                StockSystem.Spebra.otheruser[9].setmoney(yue);
                StockSystem.Spebra.otheruser[9].setAstock(StockSystem.Spebra.otheruser[9].getAstock() + amount);
                MessageBox.Show("交易成功！交易价格为： " + dealprice + "\n您的账户余额为: " + yue);
                oleDbConnection1.Close();
            }
            else { MessageBox.Show("您的账户余额不足，交易失败！");
            oleDbConnection1.Close();
            }

            
        }

       
    }
}
