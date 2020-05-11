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
    public partial class GUI : Form
    {
        
        public GUI()
        {
            InitializeComponent();

            //pictureBox1.Image = Image.FromFile(@"C:\Users\Henrik\Desktop\SummonerTrackerImages\Lucian.png");
            //pictureBox2.Image = Image.FromFile(@"C:\Users\Henrik\Desktop\SummonerTrackerImages\Lucian.png");
            //pictureBox3.Image = Image.FromFile(@"C:\Users\Henrik\Desktop\SummonerTrackerImages\Lucian.png");
            //pictureBox4.Image = Image.FromFile(@"C:\Users\Henrik\Desktop\SummonerTrackerImages\Lucian.png");
           // pictureBox5.Image = Image.FromFile(@"C:\Users\Henrik\Desktop\SummonerTrackerImages\Lucian.png");

            SpeechListener speechListener = new SpeechListener(this);
            speechListener.StartListening();

           // var gameInfo = new GameInfoGetter();
        }

        public void setLabel(string text)
        {
            label6.Text = text;
        }

        public void SummonerUsed(String position) {

            switch (position) {

                case "top":
                    new Logic(0, 10, label1).start(); new Logic(0, 15, label1b).start();
                    break;

                case "jungle":
                    new Logic(0, 10, label2).start(); new Logic(0, 15, label2b).start();
                    break;

                case "middle":
                    new Logic(0, 10, label3).start(); new Logic(0, 15, label3b).start();
                    break;

                case "bottom":
                    new Logic(0, 10, label4).start(); new Logic(0, 15, label4b).start();
                    break;

                case "support":
                    new Logic(0, 10, label5).start(); new Logic(0, 15, label5b).start();
                    break;
          
            
            }
        
        }


        //buttons
        private void button1_Click(object sender, EventArgs e)
        {new Logic(0, 10, label1).start(); new Logic(0, 15, label1b).start(); }

        private void button2_Click(object sender, EventArgs e)
        { new Logic(0, 10, label2).start(); new Logic(0, 15, label2b).start(); }

        private void button3_Click(object sender, EventArgs e)
        { new Logic(0, 10, label3).start(); new Logic(0, 15, label3b).start(); }

        private void button4_Click(object sender, EventArgs e)
        {new Logic(0, 10, label4).start(); new Logic(0, 15, label4b).start(); }

        private void button5_Click(object sender, EventArgs e)
        {new Logic(0, 10, label5).start(); new Logic(0, 15, label5b).start(); }
    }
}
