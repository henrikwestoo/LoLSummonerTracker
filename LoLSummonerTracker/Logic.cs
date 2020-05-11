using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoLSummonerTracker
{
    public class Logic
    {
        private System.Windows.Forms.Timer timer;
        int timeInSeconds = 60; //default
        Label label;
        bool running;

        public Logic(int minutes, int seconds, Label label)
        {
            this.label = label;
            timeInSeconds = minutes * 60 + seconds;
        }

        public void start()
        {
            if (running) { timerEnded(); }

            running = true;
            timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += timerTick;
            timer.Start();
            


        }


        public void timerTick(Object source, EventArgs e)
        {

            timeInSeconds--;
            label.Text = timeInSeconds.ToString();

            if (timeInSeconds == 0)
            {
                timerEnded();
            }

        }

        private void timerEnded()
        {

            timer.Stop(); timer.Dispose();

            label.Text = "Timer ended";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Henrik\Desktop\timerover.wav");
            player.Play();

            running = false;

        }

    }
}
