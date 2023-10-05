using QuanLyThueXe.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace QuanLyThueXe
{
    public partial class frmUI : Form
    {
        private bool isDragging = false;
        private Point lastCursorPos;
        private Point lastFormPos;


        public frmUI()
        {
            InitializeComponent();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPos = Cursor.Position;
                lastFormPos = this.Location;
            }
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursorPos = Cursor.Position;
                int deltaX = currentCursorPos.X - lastCursorPos.X;
                int deltaY = currentCursorPos.Y - lastCursorPos.Y;

                this.Location = new Point(lastFormPos.X + deltaX, lastFormPos.Y + deltaY);
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void pnlBot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPos = Cursor.Position;
                lastFormPos = this.Location;
            }
        }

        private void pnlBot_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursorPos = Cursor.Position;
                int deltaX = currentCursorPos.X - lastCursorPos.X;
                int deltaY = currentCursorPos.Y - lastCursorPos.Y;

                this.Location = new Point(lastFormPos.X + deltaX, lastFormPos.Y + deltaY);
            }
        }

        private void pnlBot_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void hienThiDateTime()
        {
            int pnlToplWidth = pnlTop.Width;
            int pnlTopHeight = pnlTop.Height;

            int lblDateTimeWidth = lblDateTime.Width;
            int lblDateTimelHeight = lblDateTime.Height;

            int newX = (pnlToplWidth - lblDateTimeWidth) / 2;
            int newY = (pnlTopHeight - lblDateTimelHeight) / 2;

            lblDateTime.Location = new Point(newX, newY);
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy hh:mm:ss");
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            hienThiDateTime();
        }

        private void cirpicMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cirpicClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadUCLoginEmp_Guess()
        {
            UCLoginEmp_Guess ucLoginEmp_Guess = new UCLoginEmp_Guess();
            pnlBot.Controls.Clear();
            pnlBot.Controls.Add(ucLoginEmp_Guess);
            ucLoginEmp_Guess.Dock = DockStyle.Fill;
            ucLoginEmp_Guess.BringToFront();

            // Đặt sự kiện để load lại UC1 từ UC2
            ucLoginEmp_Guess.btnCreateNewAcc_Clicked += (s, args) =>
            {
                loadUCCreateNewAcc();
            };
        }

        private void loadUCCreateNewAcc()
        {
            UCCreateNewAcc ucCreateNewAcc = new UCCreateNewAcc();
            pnlBot.Controls.Clear();
            pnlBot.Controls.Add(ucCreateNewAcc);
            ucCreateNewAcc.Dock = DockStyle.Fill;
            ucCreateNewAcc.BringToFront();

            // Đặt sự kiện để load lại UC1 từ UC2
            ucCreateNewAcc.btnCreateNewAcc_Clicked += (s, args) =>
            {
                loadUCLoginEmp_Guess();
            };
        }

        private void btnSignInGuess_Click(object sender, EventArgs e)
        {
            loadUCLoginEmp_Guess();
        }

        
    }
}
