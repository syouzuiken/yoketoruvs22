﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoruvs22
{
    public partial class Form1 : Form
    {
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
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState!=State.None)
            {
                initProc();
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
                    break;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }
    }
}
