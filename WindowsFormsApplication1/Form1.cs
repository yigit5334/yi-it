﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int topla = 0;
            for (int say = 0; say < 100;say=say+3)
            {
                topla=topla+say;
                if (topla >=200)
	{
                    MessageBox.Show("limit aşıldı");
                    break;
	}
            }
        }
    }
}
