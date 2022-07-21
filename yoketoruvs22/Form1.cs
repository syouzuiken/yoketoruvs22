using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs22
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyrMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyrMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        const int SpeedMax = 20;
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyrMax;
        const int StartTime = 100;

        const string PlayerText = "(>_<)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        static Random rand = new Random();

        enum State
        {
            None = -1,
            Title,
            Game,
            Gameover,
            Clear
        }
        State currentState = State.None;
        State nextState = State.Title;
   
        [DllImport("user32.dll")]

        public static extern short GetAsyncKeyState(int vKey);
        int itemCount = 0;
        int time = 0;

        public Form1()
        {
            InitializeComponent();

            for(int i=0;i<ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i==PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i<ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = tempLabel.Font;
                Controls.Add(chrs[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState!=State.None)
            {
                initProc();
            }

            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O)<0)
                {
                    nextState = State.Gameover;
                }
                else if(GetAsyncKeyState((int)Keys.C)<0)
                {
                    nextState = State.Clear;
                }
            }

            if(currentState==State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            time--;
            timelabel.Text = "Time"+time;
            Point mp = PointToClient(MousePosition);
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;

            for(int i=EnemyIndex;i<ChrMax;i++)
            {
                if (!chrs[i].Visible) continue;

                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];
                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }

                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }

                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }

                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                if ((mp.X >= chrs[i].Left)
                && (mp.X < chrs[i].Right)
                && (mp.Y >= chrs[i].Top)
                && (mp.Y < chrs[i].Bottom)
                )
                {
                    //MessageBox.Show("当たった！");
                    if(i<ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        chrs[i].Visible=false;
                        itemCount--;
                        if(itemCount<=0)
                        {
                            nextState = State.Clear;
                        }
                        label3.Text = $"★:{itemCount:00}";
                        //vx[i] = 0;
                        //vy[i] = 0;
                        //chrs[i].Left = 10000;
                    }
                }
            }
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyLabel.Visible = true;
                    hiLabel.Visible = true;
                    gameoverLabel.Visible = false;
                    titleButton.Visible = false;
                    clearLabel.Visible = false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    copyLabel.Visible = false;
                    hiLabel.Visible = false;
                    for (int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                    }

                    itemCount = ItemMax;
                    time = StartTime+1;
                    break;

                case State.Gameover:
                    gameoverLabel.Visible = true;
                    titleButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titleButton.Visible = true;
                    hiLabel.Visible = true;
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
