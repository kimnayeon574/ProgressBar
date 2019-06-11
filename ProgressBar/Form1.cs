using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        int Num = 0; // 진행 숫자
        string OrgStr = ""; // 상태 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblStatus.Text;

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Num++;
            if(this.Num > 100)
            {
                this.Timer.Enabled = false;
                return;
            }
            this.pbStatus.Value = this.Num;
            this.lblStatus.Text = this.OrgStr + this.Num + "%";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Num = 0;
            this.pbStatus.Value = this.Num;
            this.lblStatus.Text = this.OrgStr;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;
        }
    }
}
