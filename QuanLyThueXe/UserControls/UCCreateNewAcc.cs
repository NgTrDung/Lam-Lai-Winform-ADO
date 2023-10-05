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
    public partial class UCCreateNewAcc : UserControl
    {
        public event EventHandler btnCreateNewAcc_Clicked;

        public UCCreateNewAcc()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtRetypePass.UseSystemPasswordChar = true;
        }

        private void cirpicHide_Visible_1_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                cirpicHide_Visible_1.Image = Properties.Resources.visible;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                cirpicHide_Visible_1.Image = Properties.Resources.hide;
            }
        }

        private void cirpicHide_Visible_2_Click(object sender, EventArgs e)
        {
            if (txtRetypePass.UseSystemPasswordChar)
            {
                txtRetypePass.UseSystemPasswordChar = false;
                cirpicHide_Visible_2.Image = Properties.Resources.visible;
            }
            else
            {
                txtRetypePass.UseSystemPasswordChar = true;
                cirpicHide_Visible_2.Image = Properties.Resources.hide;
            }
        }

        private void btnCreateNewAcc_Click(object sender, EventArgs e)
        {
            btnCreateNewAcc_Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
