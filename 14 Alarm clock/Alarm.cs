using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Alarm_clock
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            DateTime.Now.ToString();
        }

        private const string V = "knocking_an_iron_door1.mp3";
        int Hrs, MM, SS, NowHour,NowMinute,NowSecond;

        private void timer1_Tick(object sender, EventArgs e)
        {


            while (Setted.Checked)
            {
                if (Hrs == NowHour && MM == NowMinute && SS == NowSecond)
                {
                    SoundPlayer sp = new SoundPlayer();
                    sp.SoundLocation = "knocking_an_iron_door1.mp3";
                    sp.Play();
                }

            }

        }

        private void Hour_ValueChanged(object sender, EventArgs e)
        {
            Hrs=int.Parse(Hour.Value.ToString());
        }

        private void Min_ValueChanged(object sender, EventArgs e)
        {
            MM=int.Parse(Min.Value.ToString());
        }

        private void Sec_ValueChanged(object sender, EventArgs e)
        {
            SS=int.Parse(Sec.Value.ToString());
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            LabTime.Text = DateTime.Now.ToString("HH:mm:ss");
            NowHour = DateTime.Now.Hour;
            NowMinute = DateTime.Now.Minute;
            NowSecond = DateTime.Now.Second;
        }

        private void Setted_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
