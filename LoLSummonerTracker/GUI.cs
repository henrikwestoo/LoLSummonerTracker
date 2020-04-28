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

            SpeechListener speechListener = new SpeechListener(this);
            speechListener.StartListening();
        }

        public void setLabel(string text)
        {
            label1.Text = text;
        }


        //buttons
        private void button1_Click(object sender, EventArgs e)
        {new Logic(0, 10, label1).start(); new Logic(0, 15, label1b).start(); }

        private void button2_Click(object sender, EventArgs e)
        {new Logic(0, 10, label2).start();}

        private void button3_Click(object sender, EventArgs e)
        {new Logic(0, 10, label3).start();}
    }
}
