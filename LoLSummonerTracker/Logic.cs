using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLSummonerTracker
{
    public class Logic
    {
        private System.Windows.Forms.Timer timer;
        int timeInSeconds = 60; //default
        GUI gui;

        public Logic(GUI gui, int minutes, int seconds)
        {
            this.gui = gui;
            timeInSeconds = minutes * 60 + seconds;
        }

        public void start()
        {

            timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += timerTick;
            timer.Start();


        }


        public void timerTick(Object source, EventArgs e)
        {

            timeInSeconds--;
            gui.setLabel(timeInSeconds.ToString());

            if (timeInSeconds == 0)
            {
                timerEnded();
            }

        }

        private void timerEnded()
        {

            timer.Stop(); timer.Dispose();
            gui.setLabel("TIMER ENDED");

        }

    }
}
