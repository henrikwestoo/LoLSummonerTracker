using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Timers;

namespace LoLSummonerTracker
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        int timeInSeconds = 60; //default
        
        public Form1()
        {
            InitializeComponent();

            setTime(0, 10);
            label1.Text = timeInSeconds.ToString();

        }

        private void setTime(int minutes, int seconds) {

            timeInSeconds = minutes * 60 + seconds;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += timerTick;
            timer.Start();
        }

        public void timerTick(Object source, EventArgs e) {

            timeInSeconds--;
            label1.Text = timeInSeconds.ToString();
            
            if (timeInSeconds == 0) {
                timerEnded(); 
            }
        
        }

        private void timerEnded() {

            timer.Stop(); timer.Dispose();
            label1.Text = "TIMER ENDED";
        
        }

 
    }
}
