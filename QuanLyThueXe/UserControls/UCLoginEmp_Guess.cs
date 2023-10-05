using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThueXe.UserControls
{
    public partial class UCLoginEmp_Guess : UserControl
    {
        public event EventHandler btnCreateNewAcc_Clicked;

        public UCLoginEmp_Guess()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void cirpicHide_Visible_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                cirpicHide_Visible.Image = Properties.Resources.visible;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                cirpicHide_Visible.Image = Properties.Resources.hide;
            }    
        }

        private void lblForgottenPass_MouseEnter(object sender, EventArgs e)
        {
            Font currentFont = lblForgottenPass.Font;
            Font newFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);
            lblForgottenPass.Font = newFont;
        }

        private void lblForgottenPass_MouseLeave(object sender, EventArgs e)
        {
            Font currentFont = lblForgottenPass.Font;
            Font newFont = new Font(currentFont, currentFont.Style & ~FontStyle.Underline);
            lblForgottenPass.Font = newFont;
        }

        private void btnCreateNewAcc_Click(object sender, EventArgs e)
        {
            btnCreateNewAcc_Clicked?.Invoke(this, EventArgs.Empty);
        }
    }


}
