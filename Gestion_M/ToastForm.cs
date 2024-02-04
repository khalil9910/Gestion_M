using System;
using System.Windows.Forms;
using System.Drawing;

namespace Gestion_M
{
    public partial class ToastForm : Form
    {
        private int TostX, TostY;
        private Timer Toastimer;
        private Timer TostHide;
        private int y = 100;

        public ToastForm(string type, string message)
        {
            InitializeComponent();

            lbType.Text = type;
            lbMessage.Text = message;

            SetNotificationStyle(type);

            // Initialize timers
            Toastimer = new Timer();
            Toastimer.Interval = 10;
            Toastimer.Tick += Toastimer_Tick;

            TostHide = new Timer();
            TostHide.Interval = 10;
            TostHide.Tick += TostHide_Tick;
        }

        private void SetNotificationStyle(string type)
        {
            switch (type)
            {
                case "Succes":
                    SetNotificationStyle(Color.FromArgb(57, 155, 53), Properties.Resources.checked__1_);
                    break;
                case "Error":
                    SetNotificationStyle(Color.FromArgb(227, 50, 45), Properties.Resources.warning);
                    break;
                case "Warning":
                    SetNotificationStyle(Color.FromArgb(245, 171, 35), Properties.Resources.information);
                    break;
                default:
                    break;
            }
        }

        private void SetNotificationStyle(Color backgroundColor, Image icon)
        {
            panel1.BackColor = backgroundColor;
            picicon.Image = icon;
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            position();
            Toastimer.Start();
        }

        private void Toastimer_Tick(object sender, EventArgs e)
        {
            TostY -= 10;
            this.Location = new Point(TostX, TostY);

            if (TostY <= 750)
            {
                Toastimer.Stop();
                TostHide.Start();
            }
        }

        private void TostHide_Tick(object sender, EventArgs e)
        {
            y--;

            if (y <= 0)
            {
                TostY += 1;
                this.Location = new Point(TostX, TostY);

                if (TostY > 800)
                {
                    TostHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        private void lbType_Click(object sender, EventArgs e)
        {

        }

        private void position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            TostX = ScreenWidth - this.Width - 5;
            TostY = ScreenHeight - this.Height - 70;

            this.Location = new Point(TostX, TostY += 10);

            if (TostY > 800)
            {
                TostHide.Stop();
                y = 100;
            }
        }
    }
}
