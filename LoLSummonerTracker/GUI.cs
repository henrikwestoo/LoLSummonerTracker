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
        Logic logic;

        public GUI()
        {
            InitializeComponent();
            label1.Text = "10";
            logic = new Logic(this, 0, 10);
        }

        public void setLabel(string text)
        {
            label1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechListener speechListener = new SpeechListener(this);
            speechListener.StartListening();
            //logic.start();
        }


    }
}
