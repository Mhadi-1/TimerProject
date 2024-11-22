
using System;
using System.Windows.Forms;
using System.Media; 

namespace TimerProject
{
    public partial class Form1 : Form
    {
        short PrograssStartPostionValue = 59 ;

        struct stTime
        {
           public byte houre;
           public byte Minute;
           public byte Second; 
        }
        stTime stTimer;
        SoundPlayer TimerSoundEffect;

        void CircularProgress()
        {
          
          circularProgressBar1.Text =
          stTimer.houre.ToString()
           + ":" + stTimer.Minute.ToString()
           + ":" + stTimer.Second.ToString();

            if(PrograssStartPostionValue == 0 )
            {
                PrograssStartPostionValue = 59; 
            }

            circularProgressBar1.Value = PrograssStartPostionValue; 
            circularProgressBar1.AnimationSpeed = PrograssStartPostionValue;
            circularProgressBar1.MarqueeAnimationSpeed = PrograssStartPostionValue; 

        }

        void ResetNumericdropValues(bool Enabled = true ,  byte Hurse = 0, byte Minutes = 0, byte Second = 0)
        {
            numeric_Hurse.Value = Hurse;
            numeric_Minutes.Value = Minutes;
            numeric_Second.Value = Second;

            numeric_Hurse.Enabled = Enabled;
            numeric_Minutes.Enabled = Enabled;
            numeric_Second.Enabled = Enabled; 
        }

        void ResetStrucTimerValues()
        {
            stTimer.houre = 0;
            stTimer.Minute = 0;
            stTimer.Second = 0; 
        }

        bool TimerEnabled(bool Enalbled = false)
        {
            return tmr_Counter.Enabled = Enalbled;
        }

        void ConvertnumericValueTostrucTime()
        {
            stTimer.houre  = Convert.ToByte(numeric_Hurse.Value); 
            stTimer.Minute = Convert.ToByte(numeric_Minutes.Value); 
            stTimer.Second = Convert.ToByte(numeric_Second.Value);
        }

        bool IsTimerValueInvalied()
        {
            if(numeric_Hurse.Value == 0 && numeric_Minutes.Value == 0 && numeric_Second.Value == 0 )
            {
                MessageBox.Show("To Start Timer Please Input Time!", "Configration", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return true; 
            }
            return false; 
        }

        void StartTimer()
        {

            if(!IsTimerValueInvalied())
            {
              ConvertnumericValueTostrucTime();
              ResetNumericdropValues(false);
              TimerEnabled(true);
              CircularProgress();

            }
            return;
        }

        void ResetTimer()
        {

            PrograssStartPostionValue = 59;
            TimerEnabled(false);
            ResetNumericdropValues();
            ResetStrucTimerValues();
            CircularProgress();
        }

        bool DisplayTimer()
        {

            if (stTimer.houre == 0 && stTimer.Minute == 0 && stTimer.Second == 0)
            {
                return false;
            }

            if (stTimer.houre > 0 && stTimer.Minute == 0 && stTimer.Second == 0)
            {
                stTimer.houre -= 1;
                stTimer.Minute = 59;
                stTimer.Second = 59;
            }

            if (stTimer.Second > 0)
            {
                stTimer.Second -= 1;

            }

            // Check If Minutes
            if (stTimer.Second == 0 && stTimer.Minute > 0)
            {
                stTimer.Second = 59;
                stTimer.Minute -= 1;

            }

            return true;
        }

        bool DesapliedNotifycation()
        {

            notify_Timer.Icon = this.Icon;
            notify_Timer.ShowBalloonTip(1000 , "Reminder ", "Time Has Been Finshed!" , ToolTipIcon.None);
            DispalyAramSoundEffect(true);
            return true; 
        }

        bool DispalyAramSoundEffect(bool DispalySound = false)
        {
            TimerSoundEffect = new SoundPlayer(@"C:\Users\chmik\Desktop\SoundsEffect\TimerAramSoundEffect.wav");
            if(DispalySound == true )
            {
                TimerSoundEffect.Play();
                return DispalySound; 
            } 
            
            if(DispalySound == false)
            {
                TimerSoundEffect.Stop();
                return DispalySound;
            }
            return DispalySound;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            timer.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            TimerEnabled(false);
            ResetNumericdropValues(true, stTimer.houre, stTimer.Minute, stTimer.Second); 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            time.ToLocalTime();
            lbl_Date.Text = time.ToString ("hh :mm:ss : tt");
        }

        private void tmrcircualrPrograss_Tick(object sender, EventArgs e)
        {

            PrograssStartPostionValue -= 1;

            if (DisplayTimer())
            {
                CircularProgress();

            }
            else
            {
                TimerEnabled(false); 
                DesapliedNotifycation();
            }


        }

        private void notify_Timer_BalloonTipClosed(object sender, EventArgs e)
        {
            DispalyAramSoundEffect(false);
            ResetTimer();
            return;
        }
    }
}
