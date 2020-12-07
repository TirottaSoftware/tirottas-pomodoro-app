using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Settings : Form
    {
        private Pomodoro pomodoroApp;

        //Fields and Properties for the time values
        private int taskMinutes;
        private int breakMinutes;

        private  int BreakMinutes
        {
            get { return breakMinutes; }
            set { breakMinutes = value; }
        }
        private int TaskMinutes
        {
            get { return taskMinutes; }
            set { taskMinutes = value; }
        }

        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Initalize a new instance of the Pomodoro app
            pomodoroApp = new Pomodoro();
            //Set Properties to the values set in the label
            this.TaskMinutes = Convert.ToInt32(lblTaskNumber.Text);
            this.BreakMinutes = Convert.ToInt32(lblBreakTime.Text);

            this.Hide();

            //Set PomodoroApp values 
            pomodoroApp.TASK_MIN = this.TaskMinutes;
            pomodoroApp.BREAK_MIN = this.BreakMinutes;
            //Open Main window
            pomodoroApp.ShowDialog();
        }

        //Increment and Decrement Button functions and EventHandlers
        private void btnTaskDecrement_Click(object sender, EventArgs e)
        {
            int taskTime = int.Parse(lblTaskNumber.Text);
            if (taskTime <= 0)
            {
                return;
            }
            else
            {
                taskTime--;
                lblTaskNumber.Text = taskTime.ToString();
            }
        }

        private void btnTaskIncrement_Click(object sender, EventArgs e)
        {
            int taskTime = int.Parse(lblTaskNumber.Text); 
            if (taskTime >= 60)
            {
                return;
            }
            else
            {
                taskTime++;
                lblTaskNumber.Text = taskTime.ToString();
            }
        }

        private void btnBreakIncrement_Click(object sender, EventArgs e)
        {
            int breakTime = int.Parse(lblBreakTime.Text);
            if (breakTime >= 60)
            {
                return;
            }
            else
            {
                breakTime++;
                lblBreakTime.Text = breakTime.ToString();
            }
        }

        private void btnBreakDecrement_Click(object sender, EventArgs e)
        {
            int breakTime = int.Parse(lblBreakTime.Text);
            if (breakTime <= 0)
            {
                return;
            }
            else
            {
                breakTime--;
                lblBreakTime.Text = breakTime.ToString();
            }
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Making sure the window  is closed and absent from the Task Manager
            Application.Exit();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
