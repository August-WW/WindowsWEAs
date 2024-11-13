using System;
using System.Media;
using System.Windows.Forms;


namespace WindowsWEAs
{
    public partial class Form1 : Form
    {
        private readonly SoundPlayer soundPlayerWEA;

        private NotifyIcon notifyIcon;
        public Form1()
        {
            InitializeComponent();

            notifyIcon = new NotifyIcon();
            notifyIcon.Visible = false;
            notifyIcon.Icon = SystemIcons.Warning;
            notifyIcon.BalloonTipIcon = ToolTipIcon.Warning;

            soundPlayerWEA = new SoundPlayer();
            soundPlayerWEA.Stream = WindowsWEAs.Properties.Resources.AndroidWEA;
        }

        private void button_SendWEA_Click(object sender, EventArgs e)
        {
            if (radioButton_National.Checked)
            {
                notifyIcon.BalloonTipTitle = "National Alert";
            }
            else if (radioButton_Emergency.Checked)
            {
                notifyIcon.BalloonTipTitle = "Emergency Alert";
            }
            else if (radioButton_AMBER.Checked)
            {
                notifyIcon.BalloonTipTitle = "AMBER Alert";
            }
            else if (radioButton_PublicSafety.Checked)
            {
                notifyIcon.BalloonTipTitle = "Public Safety Alert";
            }
            else if (radioButton_Test.Checked)
            {
                notifyIcon.BalloonTipTitle = "Test Alert";
            }
            else
            {
                MessageBox.Show("Please select an alert type");
            }

            string AlertMessage = richTextBox1.Text;

            if (!string.IsNullOrEmpty(AlertMessage))
            {
                notifyIcon.BalloonTipText = AlertMessage;
                notifyIcon.Visible = true;

                notifyIcon.ShowBalloonTip(9000);
                soundPlayerWEA.Play();
            }
            else
            {
                MessageBox.Show("Please enter a message");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
