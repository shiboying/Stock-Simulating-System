using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockSystem
{
    public partial class altinfo : Form
    {
        public altinfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //对数据库中个人资料内容进行更新操作
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = @"update userinfo set email= ? where(userID = ?) ";
            this.oleDbCommand1.Parameters[0].Value = textBox1.Text;
            this.oleDbCommand1.Parameters[1].Value = StockSystem.Spebra.username;
            int j = oleDbCommand1.ExecuteNonQuery();
            oleDbConnection1.Close();

            oleDbConnection1.Open();
            oleDbCommand1.CommandText = @"update userinfo set phonenum = ? where (userID = ?)";
            this.oleDbCommand1.Parameters[0].Value = textBox2.Text;
            this.oleDbCommand1.Parameters[1].Value = StockSystem.Spebra.username;
            int i = oleDbCommand1.ExecuteNonQuery();
            oleDbConnection1.Close();
            MessageBox.Show("更新成功！");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
