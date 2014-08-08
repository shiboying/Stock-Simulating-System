using System.Data.OleDb;
namespace StockSystem
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.购买ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a股票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a股票ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.b股票ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.b股票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a股票ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.b股票ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a股票行情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b股票行情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人资金ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所持股票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.现有策略ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.邮箱变更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.策略设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.购买ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.个人情况ToolStripMenuItem,
            this.个人设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 购买ToolStripMenuItem
            // 
            this.购买ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a股票ToolStripMenuItem,
            this.b股票ToolStripMenuItem});
            this.购买ToolStripMenuItem.Name = "购买ToolStripMenuItem";
            this.购买ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.购买ToolStripMenuItem.Text = "交易";
            // 
            // a股票ToolStripMenuItem
            // 
            this.a股票ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a股票ToolStripMenuItem1,
            this.b股票ToolStripMenuItem1});
            this.a股票ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("a股票ToolStripMenuItem.Image")));
            this.a股票ToolStripMenuItem.Name = "a股票ToolStripMenuItem";
            this.a股票ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.a股票ToolStripMenuItem.Text = "买";
            // 
            // a股票ToolStripMenuItem1
            // 
            this.a股票ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("a股票ToolStripMenuItem1.Image")));
            this.a股票ToolStripMenuItem1.Name = "a股票ToolStripMenuItem1";
            this.a股票ToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.a股票ToolStripMenuItem1.Text = "A股票";
            this.a股票ToolStripMenuItem1.Click += new System.EventHandler(this.a股票ToolStripMenuItem1_Click);
            // 
            // b股票ToolStripMenuItem1
            // 
            this.b股票ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("b股票ToolStripMenuItem1.Image")));
            this.b股票ToolStripMenuItem1.Name = "b股票ToolStripMenuItem1";
            this.b股票ToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.b股票ToolStripMenuItem1.Text = "B股票";
            this.b股票ToolStripMenuItem1.Click += new System.EventHandler(this.b股票ToolStripMenuItem1_Click);
            // 
            // b股票ToolStripMenuItem
            // 
            this.b股票ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a股票ToolStripMenuItem2,
            this.b股票ToolStripMenuItem2});
            this.b股票ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("b股票ToolStripMenuItem.Image")));
            this.b股票ToolStripMenuItem.Name = "b股票ToolStripMenuItem";
            this.b股票ToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.b股票ToolStripMenuItem.Text = "卖";
            // 
            // a股票ToolStripMenuItem2
            // 
            this.a股票ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("a股票ToolStripMenuItem2.Image")));
            this.a股票ToolStripMenuItem2.Name = "a股票ToolStripMenuItem2";
            this.a股票ToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.a股票ToolStripMenuItem2.Text = "A股票";
            this.a股票ToolStripMenuItem2.Click += new System.EventHandler(this.a股票ToolStripMenuItem2_Click);
            // 
            // b股票ToolStripMenuItem2
            // 
            this.b股票ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("b股票ToolStripMenuItem2.Image")));
            this.b股票ToolStripMenuItem2.Name = "b股票ToolStripMenuItem2";
            this.b股票ToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.b股票ToolStripMenuItem2.Text = "B股票";
            this.b股票ToolStripMenuItem2.Click += new System.EventHandler(this.b股票ToolStripMenuItem2_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a股票行情ToolStripMenuItem,
            this.b股票行情ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // a股票行情ToolStripMenuItem
            // 
            this.a股票行情ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("a股票行情ToolStripMenuItem.Image")));
            this.a股票行情ToolStripMenuItem.Name = "a股票行情ToolStripMenuItem";
            this.a股票行情ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.a股票行情ToolStripMenuItem.Text = "A股票行情";
            this.a股票行情ToolStripMenuItem.Click += new System.EventHandler(this.a股票行情ToolStripMenuItem_Click);
            // 
            // b股票行情ToolStripMenuItem
            // 
            this.b股票行情ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("b股票行情ToolStripMenuItem.Image")));
            this.b股票行情ToolStripMenuItem.Name = "b股票行情ToolStripMenuItem";
            this.b股票行情ToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.b股票行情ToolStripMenuItem.Text = "B股票行情";
            this.b股票行情ToolStripMenuItem.Click += new System.EventHandler(this.b股票行情ToolStripMenuItem_Click);
            // 
            // 个人情况ToolStripMenuItem
            // 
            this.个人情况ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人资金ToolStripMenuItem,
            this.所持股票ToolStripMenuItem,
            this.现有策略ToolStripMenuItem});
            this.个人情况ToolStripMenuItem.Name = "个人情况ToolStripMenuItem";
            this.个人情况ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.个人情况ToolStripMenuItem.Text = "个人情况";
            // 
            // 个人资金ToolStripMenuItem
            // 
            this.个人资金ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("个人资金ToolStripMenuItem.Image")));
            this.个人资金ToolStripMenuItem.Name = "个人资金ToolStripMenuItem";
            this.个人资金ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.个人资金ToolStripMenuItem.Text = "个人资金";
            this.个人资金ToolStripMenuItem.Click += new System.EventHandler(this.个人资金ToolStripMenuItem_Click);
            // 
            // 所持股票ToolStripMenuItem
            // 
            this.所持股票ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("所持股票ToolStripMenuItem.Image")));
            this.所持股票ToolStripMenuItem.Name = "所持股票ToolStripMenuItem";
            this.所持股票ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.所持股票ToolStripMenuItem.Text = "所持股票";
            this.所持股票ToolStripMenuItem.Click += new System.EventHandler(this.所持股票ToolStripMenuItem_Click);
            // 
            // 现有策略ToolStripMenuItem
            // 
            this.现有策略ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("现有策略ToolStripMenuItem.Image")));
            this.现有策略ToolStripMenuItem.Name = "现有策略ToolStripMenuItem";
            this.现有策略ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.现有策略ToolStripMenuItem.Text = "现有策略";
            // 
            // 个人设置ToolStripMenuItem
            // 
            this.个人设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.邮箱变更ToolStripMenuItem,
            this.策略设置ToolStripMenuItem});
            this.个人设置ToolStripMenuItem.Name = "个人设置ToolStripMenuItem";
            this.个人设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.个人设置ToolStripMenuItem.Text = "个人设置";
            this.个人设置ToolStripMenuItem.Click += new System.EventHandler(this.个人设置ToolStripMenuItem_Click);
            // 
            // 邮箱变更ToolStripMenuItem
            // 
            this.邮箱变更ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("邮箱变更ToolStripMenuItem.Image")));
            this.邮箱变更ToolStripMenuItem.Name = "邮箱变更ToolStripMenuItem";
            this.邮箱变更ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.邮箱变更ToolStripMenuItem.Text = "个人资料变更";
            this.邮箱变更ToolStripMenuItem.Click += new System.EventHandler(this.邮箱变更ToolStripMenuItem_Click);
            // 
            // 策略设置ToolStripMenuItem
            // 
            this.策略设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("策略设置ToolStripMenuItem.Image")));
            this.策略设置ToolStripMenuItem.Name = "策略设置ToolStripMenuItem";
            this.策略设置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.策略设置ToolStripMenuItem.Text = "策略设置";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出系统ToolStripMenuItem});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出系统ToolStripMenuItem.Image")));
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\大三上\\c#(O)\\最后大实验\\StockSystem折线图\\S" +
    "tockSystem\\StockSystem\\stock.accdb";
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.CommandText = "SELECT userID FROM userinfo ";
            this.oleDbCommand1.Connection = this.oleDbConnection1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 55);
            this.panel1.TabIndex = 12;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(272, 6);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(155, 12);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "bluezebra.zhang@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "石博莹 09212109 张昊旻 09212050";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(112, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 12);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "huhulaee8@gmail.com";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "联系我们：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(504, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 506);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(232)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(504, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "login";
            this.Text = "欢迎您使用Spebra股票系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 购买ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem a股票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b股票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem a股票行情ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem b股票行情ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人资金ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所持股票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 现有策略ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 邮箱变更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 策略设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private OleDbConnection oleDbConnection1;
        private OleDbCommand oleDbCommand1;
        private System.Windows.Forms.ToolStripMenuItem a股票ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem b股票ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem a股票ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem b股票ToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;

    }
}