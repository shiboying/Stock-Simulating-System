using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using user;
using stockprocess;

namespace StockSystem
{
    public partial class Spebra : Form
    {
        public static Stock.Stock AStock = new Stock.Stock(10000, "A股票");
        public static Stock.Stock BStock = new Stock.Stock(20000, "B股票");

        public static user.user[] otheruser = new user.user[10];//初始化其他9个机器用户

        public static Boolean flag;
        double m = 10000.0;
        double Aallocate=1000;
        double Ballocate=2000;
        public static string username;



        public Spebra()
        {
            InitializeComponent();

        }

     
        

        

        private void button2_Click(object sender, EventArgs e)
        {
            register form = new register();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            string user_name = textBox1.Text;
            string user_pwd = textBox2.Text;

            oleDbConnection1.Open();
            oleDbCommand1.CommandText = "SELECT PWD FROM userinfo where( userID = ? )";
            this.oleDbCommand1.Parameters[0].Value = user_name;
           
        

            OleDbDataReader dr = oleDbCommand1.ExecuteReader();
            if (user_name == "" || user_pwd == "")
            {
                MessageBox.Show("用户名或密码为空，请重新输入");
                textBox1.Clear();
                textBox2.Clear();
                oleDbConnection1.Close();
            }
            else if (dr.Read())
            {
                if (textBox2.Text == dr.GetString(0)&&textBox1.Text != "spring")
                {
                    dr.Close();
                    oleDbConnection1.Close();
                    username = textBox1.Text;

                    

                    for (int i = 0; i < 10; i++)
                    {
                        if (i == 9)
                        {
                            otheruser[i] = new user.user();
                            otheruser[i].setname(user_name);
                            otheruser[i].setpwd(user_pwd);
                            otheruser[i].setmoney(m);
                            otheruser[i].setAstock(Aallocate);
                            otheruser[i].setBstock(Ballocate);
                            


                        }
                        else
                        {   
                            otheruser[i] = new user.user();
                            otheruser[i].setname("a"+ (i + 1).ToString());
                            otheruser[i].setpwd((i + 1).ToString());
                            otheruser[i].setmoney(m);
                            otheruser[i].setAstock(Aallocate);
                            otheruser[i].setBstock(Ballocate);

                         
                            m = m + 10000.0;
                        }
                    }

                    login lg = new login();
                    lg.Show();
                    this.Hide();
                   

                    Aallocate = user.user.allocateAstock(10);
                    Ballocate = user.user.allocateBstock(10);

                }
                else if (textBox2.Text == "1234567"&&textBox1.Text == "spring")
                {
                    dr.Close();
                    username = textBox1.Text;
                    ManageLogin mlg = new ManageLogin();
                    mlg.Show();
                    this.Hide();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("用户名或密码不正确，请重新输入。");
                    textBox1.Clear();
                    textBox2.Clear();
                    oleDbConnection1.Close();
                }
            }
            else
            {
                oleDbConnection1.Close();
                MessageBox.Show("您还没有注册，请先注册");
                register fm = new register();       //新窗口
                fm.Show();
                this.Hide();
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            forget forg = new forget();
            forg.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
             double []temp = new double [2];
            double Astockinfo,Bstockinfo;
            
             stockprocess.process sp = new stockprocess.process();
            temp= sp.stockprocess(otheruser);

            
            Astockinfo = temp[0];
            Bstockinfo = temp[1];
         
             if (Astockinfo == -1)
             { MessageBox.Show("交易失败！"); }
             else
             {
                 oleDbConnection2.Open();
                 oleDbCommand2.CommandText = @"insert into stockA (dealprice)values (?)";
                 oleDbCommand2.Parameters[0].Value = Astockinfo;                 
                 oleDbCommand2.ExecuteNonQuery();
                 oleDbConnection2.Close();
             }

            if(Bstockinfo == -1)
            {MessageBox.Show("交易失败！");}
            else{
                oleDbConnection2.Open();
                oleDbCommand3.CommandText = @"insert into stockB (dealprice)values (?)";
                oleDbCommand3.Parameters[0].Value = Bstockinfo;
    
                oleDbCommand3.ExecuteNonQuery();
                oleDbConnection2.Close();
            }

        }
       

    }
}
