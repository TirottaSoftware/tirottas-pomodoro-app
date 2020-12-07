using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    //Tirotta's Pomodoro App 
    //App version:  1.1.0 
    //Version code: A280920.0
    public partial class Pomodoro : Form
    {
        Timer taskTimer = new Timer();
        Timer breakTimer = new Timer();

        Settings settings;
        //Initializing values which the Settings tab is going to use
        internal int BREAK_MIN = 5;
        internal int TASK_MIN = 25;

        //Initializing private values
        private int taskMinutes;
        private int breakMinutes;
        private int taskSeconds;
        private int breakSeconds;

        //Contorls whether the timer is in Break or Task mode
        private bool inBreak = false;

        //Private properties connected to the private fields
        private int BreakSeconds
        {
            get { return breakSeconds; }
            set { breakSeconds = value; }
        }
        private int BreakMinutes
        {
            get { return breakMinutes; }
            set { breakMinutes = value; }
        }
        private int TaskMinutes
        {
            get { return taskMinutes; }
            set { taskMinutes = value; }
        }
        private int TaskSeconds
        {
            get { return taskSeconds; }
            set { taskSeconds = value; }
        }

        //time left in seconds
        //Required for the Tick Event Handler
        private int timeLeft;

        private void Form1_Load(object sender, EventArgs e)
        {
            taskTimer.Enabled = false;
            SetTimeValues();
            //Set initial value to timeLeft
            timeLeft = (this.TaskMinutes * 60) + this.TaskSeconds;
            UpdateLabel();
        }

        private void SetTimeValues()
        {
            //Sets values after the timer successfully finishes 
            settings = new Settings();
            this.TaskMinutes = TASK_MIN;
            this.TaskSeconds = 0;
            this.BreakMinutes = BREAK_MIN;
            this.BreakSeconds = 0;
        }

        public Pomodoro()
        {
            InitializeComponent();

            btnSettings.FlatAppearance.MouseOverBackColor = btnSettings.BackColor;
            btnSettings.BackColorChanged += (s, e) =>
            {
                btnSettings.FlatAppearance.MouseOverBackColor = btnSettings.BackColor;
            };

            //Set Intervals for both timers
            taskTimer.Interval = 1000;
            breakTimer.Interval = 1000;
            //Set the event handler for both timers
            taskTimer.Tick += timerTask_Tick;
            breakTimer.Tick += timerBreak_Tick;
            //Button with rounded corners
            btnStart = new RoundedButton();
            UpdateLabel();
        }

        private void timerBreak_Tick(object sender, EventArgs e)
        {
            //TimerBreak performs these actions on every interval (set in the constructor above)
            this.BreakSeconds--;

            if (timeLeft <= 0)
            {
                //Timer ends
                breakTimer.Stop();
                btnStart.Enabled = true;
                //Set the mode to TaskMode for the upcoming timer
                inBreak = false;
                this.ShowAlert("Break Finished!", "Get back to work", Alert.enmType.BreakFinished);
                SetTimeValues();
            }
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            if (inBreak)
            {
                timeLeft = (this.BreakMinutes * 60) + this.BreakSeconds;
                lblBreakTimer.Location = new Point(107, 110);
                lblBreakTimer.Text = "Take a break";
            }
            else
            {
                timeLeft = (this.TaskMinutes * 60) + this.TaskSeconds;
                lblBreakTimer.Location = new Point(74, 110);
                lblBreakTimer.Text = "Focus on your task!";
            }
            //Calculating minutes & seconds
            int min = timeLeft / 60;
            int sec = timeLeft % 60;

            //Stringify time values
            string displayMin = string.Empty;
            string displaySec = string.Empty;

            //Making sure there's a 0 in front of one-digit numbers
            if (min <= 9)
            {
                displayMin = $"0{min}";
            }
            else
            {
                displayMin = $"{min}";
            }
            if (sec <= 9)
            {
                displaySec = $"0{sec}";
            }
            else
            {
                displaySec = $"{sec}";
            }
            lblCountdown.Text = $"{displayMin} : {displaySec}";
        }

        private void timerTask_Tick(object sender, EventArgs e)
        {
            //TimerTask performs these actions on every interval (set in the constructor above)
            this.TaskSeconds--;

            if (timeLeft <= 0)
            {
                //Timer ends
                taskTimer.Stop();
                btnStart.Enabled = true;
                inBreak = true;
                this.ShowAlert("Task Finished!", " You may take a break now", Alert.enmType.TaskFinished);
                SetTimeValues();
            }
            UpdateLabel();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start the timer and disable the button so there are no time overlaps
            btnStart.Enabled = false;
            UpdateLabel();
            //Enable/Disable timers depending on the mode
            if (inBreak)
            {
                breakTimer.Start();
                taskTimer.Stop();
            }
            else
            {
                taskTimer.Start();
                breakTimer.Stop();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Open Settings Tab
            settings = new Settings();
            this.Hide();
            settings.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Making sure the window is closed and absent from the Task Manager
            Application.Exit();
        }

        //Popup Alert method
        public void ShowAlert(string msg, string subtitle, Alert.enmType type)
        {
           Alert frm = new Alert();
            frm.showAlert(msg, subtitle, type);
        }

               // this.ShowAlert("Warning Alert", Alert.enmType.TaskFinished);

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void Pomodoro_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

    }
}
