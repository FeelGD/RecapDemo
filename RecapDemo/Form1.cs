﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 0;
            int left = 0;

            //GetUpperBound 0= [0,1] 0 dır 1 ise 1 i temsil eder.
            Button[,] buttons = new Button[8, 8];
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Text = i + "," + j;
                    buttons[i, j].Left = left;
                    left = left + 50;
                    buttons[i, j].Top = top;
                    this.Controls.Add(buttons[i, j]);
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;

                    }
                }
                top = top + 50;
                left = 0;
            }
        }
    }
}
