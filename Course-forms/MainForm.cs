using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_forms
{
    public partial class MainForm : Form
    {
        public void CheckColor(CircularProgressBar.CircularProgressBar cpb)
        {
             if (cpb.Value > 90)
                cpb.ProgressColor = Color.FromArgb(255, 0, 0);
            else if (cpb.Value > 80)
                cpb.ProgressColor = Color.FromArgb(255, 75, 0);
            else if (cpb.Value > 70)
                cpb.ProgressColor = Color.FromArgb(255, 160, 0);
            else if(cpb.Value > 60)
                cpb.ProgressColor = Color.FromArgb(255, 240, 0);
            else if (cpb.Value > 50)
                cpb.ProgressColor = Color.FromArgb(200, 255, 0);
            else if (cpb.Value > 40)
                cpb.ProgressColor = Color.FromArgb(140, 255, 0);
            else if (cpb.Value > 30)
                cpb.ProgressColor = Color.FromArgb(0, 255, 0);
            else if (cpb.Value > 20)
                cpb.ProgressColor = Color.FromArgb(0, 255, 60);
            else if (cpb.Value > 10)
                cpb.ProgressColor = Color.FromArgb(0, 255, 110);
            else if (cpb.Value > 0)
                cpb.ProgressColor = Color.FromArgb(0, 255, 200);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
          //  float tcpu = TempCPU.NextValue();
            float dram = RAM.NextValue();
            //float tmb = tempMOBO.NextValue();
            //float voltage = Voltage.NextValue();

            cCPU.Value = (int)fcpu;
            cCPU.Text = string.Format("{0:0.0}%", fcpu);
            CheckColor(cCPU);

            //cTCPU.Value = (int)tcpu;
            //cTCPU.Text = string.Format("{0:0.0}%", tcpu);
            //CheckColor(cTCPU);

            cRAM.Value = (int)dram;
            cRAM.Text = string.Format("{0:0.0}%", dram);
            CheckColor(cRAM);



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cCPU_Click(object sender, EventArgs e)
        {

        }

        private void cRAM_Click(object sender, EventArgs e)
        {

        }

        private void labelHDD_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cTCPU_Click(object sender, EventArgs e)
        {

        }
    }
}
