using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random(); //新增亂數物件
        List<int> number = new List<int>(); //新增按鈕數值串列
        Button FirstClickButton = null;  //暫存第一次按的button
        int Ranks;  //難度變數
        int Clicktimes;  //紀錄按第幾次,按完兩次要歸零
        int WinJudge;  //紀錄有沒有全對
        int StepCount; //紀錄步數
        
        private void Start_Click(object sender, EventArgs e) //開始遊戲
        {   //判斷radiobutton並設定難度為幾成幾
            //設定完開始遊戲布局
            Clicktimes = 0;
            WinJudge = 0;
            StepCount = 0;
            if (Easy.Checked)
            {
                Ranks = 4;
                NewGame(Ranks);
            }
            if (normal.Checked)
            {
                Ranks = 6;
                NewGame(Ranks);
            }
            if (hard.Checked)
            {
                Ranks = 8;
                NewGame(Ranks);
            }
            if (God.Checked)
            {
                Ranks = 10;
                NewGame(Ranks);
            }
        }
        private void NewGame(int Ranks)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            number.Clear();
            for (int i = 1; i <= Ranks * Ranks / 2; i++)
            {
                number.Add(i);
                number.Add(i);
                //如果4*4代表串列要放兩組(1~8)...以此類推
            }
            //開始新增按鈕並設定
            for (int i = 0; i < Ranks; i++)
            {
                for (int j = 0; j < Ranks; j++)
                {
                    int rd = r.Next(0, number.Count);//隨機串列中的個數
                    Button button = new Button()
                    {
                        Text = number[rd].ToString(),//取出串列中的值轉成字串,設定成button的text
                        Size = new Size(40, 40),//設定大小
                        Location = new Point(50 * i, 50 * j),//設定擺放位置
                        BackColor = Color.Black //用顏色設定為隱藏
                    };
                    button.Click += new EventHandler(button_Click);//設定按鈕共用一個click事件
                    number.RemoveAt(rd);//設定完一個button就從串列中移除該值
                    this.splitContainer1.Panel2.Controls.Add(button);//把做好的按鈕加進Panel2
                }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Clicktimes += 1;//每次按都先+1
            if (Clicktimes == 1)//如果是第一次翻牌
            {
                btn.BackColor = Color.White;//顯示
                btn.Enabled = false;//不可再選
                FirstClickButton = btn;//把第一次按鈕暫存
                StepCount += 1;//步數+1
            }
            else if (Clicktimes == 2)//如果是第二次翻牌
            {
                Clicktimes = 0;//重設點擊次數
                if (FirstClickButton.Text == btn.Text)//如果翻到一樣的
                {
                    WinJudge += 2;//勝利判斷值+2
                    btn.BackColor = Color.White;//顯示
                    btn.Enabled = false;//不可再選
                    FirstClickButton = null;//重設暫存按鈕
                    if (WinJudge == Ranks * Ranks)
                    {
                        MessageBox.Show("全對!總共點擊了" + StepCount + "次,您真牛逼");
                    }
                }
                else//如果翻到不一樣的
                {
                    btn.BackColor = Color.White;//顯示
                    btn.Enabled = false;//不可選
                    this.Refresh();//更新畫面
                    Thread.Sleep(500);//暫停0.5秒
                    btn.BackColor = Color.Black;//隱藏
                    btn.Enabled = true;//可選
                    FirstClickButton.BackColor = Color.Black;//將第一次按的也隱藏
                    FirstClickButton.Enabled = true;//可選
                    FirstClickButton = null;//重設暫存按鈕
                }
            }
        }
    }
}

