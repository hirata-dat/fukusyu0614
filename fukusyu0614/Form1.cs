﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0614
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)//タイム
        {
            label1.Left += vx;
            label1.Top += vy;
            
            if(label1.Left<0)
            {
                vx = Math.Abs(vx);
            }
            if(label1.Top<0)
            {
                vy = -vy;
            }
            if(label1.Right>300)
            {
                vx = -vx;
            }
            if(label1.Bottom>300)
            {
                vy = -vy;
            }
            if (label1.Left > ClientSize.Width - label1.Width)
            {
                vx = -Math.Abs(vx);
            }

        }

        private void label1_Click(object sender, EventArgs e)//ラベル
        {

        }
    }
}
