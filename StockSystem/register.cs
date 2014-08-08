using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StockSystem
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string phone = textBox2.Text;
            string user_name = textBox5.Text;
            string pwd = textBox3.Text;
            string pwd_2 = textBox4.Text;

            if (pwd == pwd_2)
            {
                if (user_name == "" || pwd == "")
                {
                    MessageBox.Show("用户名或密码为空，请重新输入");
                }
                else
                {   
                    //Regist.Regist.WriteName(user_name);
                    //Regist.Regist.WritePwd(pwd);
                    //textBox1.Clear();
                    //textBox2.Clear();
                    oleDbConnection1.Open();
                    oleDbCommand1.CommandText = "SELECT userID FROM userinfo where (userID = ?)";
                    oleDbCommand1.Parameters[0].Value = user_name;
                    OleDbDataReader dr = oleDbCommand1.ExecuteReader();
                    if (dr.Read())
                        {
                        if (textBox5.Text == dr.GetString(0))
                        {
                            MessageBox.Show("用户名已存在，请重新输入用户名");
                            textBox5.Clear();
                        }
                        
                    }
                    else
                    {
                        dr.Close();
                        oleDbCommand1.CommandText = @"insert into userinfo(userID,PWD,phonenum,email)values (?,?,?,?)";
                        this.oleDbCommand1.Parameters[0].Value = user_name;
                        this.oleDbCommand1.Parameters[1].Value = pwd;
                        this.oleDbCommand1.Parameters[2].Value = phone;
                        this.oleDbCommand1.Parameters[3].Value = email;
                        int i = oleDbCommand1.ExecuteNonQuery();
                        oleDbConnection1.Close();

                        MessageBox.Show("注册成功！");
                        this.Hide();
                        Spebra sp = new Spebra();
                        sp.Show();
                        this.Hide();
                    }
             }
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                textBox3.Clear();
                textBox4.Clear();
            }
            
        }


    }
}
