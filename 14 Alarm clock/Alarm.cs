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
    public partial class frmAlarm : Form
    {
        public frmAlarm()
        {
            InitializeComponent();
            
        }

        
        int HH, MM, SS, NowHour,NowMinute,NowSecond;
        SoundPlayer sp = new SoundPlayer();

        private void Setted_CheckedChanged(object sender, EventArgs e)
        {
            sp.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabTime.Text = DateTime.Now.ToString("HH:mm:ss");
            NowHour = DateTime.Now.Hour;
            NowMinute = DateTime.Now.Minute;
            NowSecond = DateTime.Now.Second;            

           while (Setted.Checked)
            {                  
                if (HH == NowHour && MM == NowMinute && SS == NowSecond)
                {
                    try
                    {
                        sp.SoundLocation = "test.wav";
                        sp.Play();
                        MessageBox.Show("Ring. Wake up.");

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            

        }

        private void Hour_ValueChanged(object sender, EventArgs e)
        {
            HH = int.Parse(Hour.Value.ToString());
        }

        private void Min_ValueChanged(object sender, EventArgs e)
        {
            MM = int.Parse(Min.Value.ToString());
        }

        private void Sec_ValueChanged(object sender, EventArgs e)
        {
            SS = int.Parse(Sec.Value.ToString());
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
            timer1.Start();
        }
    }
}
