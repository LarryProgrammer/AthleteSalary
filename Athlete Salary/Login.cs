using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Athlete_Salary
{
    public partial class Login : Form
    {
        StaffManager x = new StaffManager();
        bool tmrPos = true;
        public Login()
        {
            InitializeComponent();
            PasswordTxtBox.PasswordChar = '*';

            x.Show();
            tmrPosition.Start();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
       
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxtBox.Text == "hire" && UserNameTextBox.Text.ToLower() == "Pro Athlete".ToLower())
            {
                x.DesktopLocation = this.DesktopLocation;
                tmrSlide.Start();
                //this.Close();
            }
            else
                MessageBox.Show("Invalid credentials. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrPosition_Tick(object sender, EventArgs e)
        {
            if(tmrPos == false)
            {
                tmrPosition.Stop();
            }
            this.Size = x.Size;
            this.MinimumSize = x.Size;
            this.MaximumSize = x.Size;
            x.DesktopLocation = this.DesktopLocation;
        }
        int tick = 0;
        private void tmrSlide_Tick(object sender, EventArgs e)
        {
            if(tick == 225)
            {
                tmrSlide.Stop();
                tmrPos = false;
                this.Hide();
            }
            int speed = 3;
            pnlTop.Location = new Point(pnlTop.Location.X, pnlTop.Location.Y - speed);
            pnlBottom.Location = new Point(pnlBottom.Location.X, pnlBottom.Location.Y + speed);
            tick += speed;
        }
    }
}