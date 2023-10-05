namespace QuanLyThueXe
{
    partial class frmUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.btnSignInGuess = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cirpicMinimize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cirpicClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlTop.SuspendLayout();
            this.pnlBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cirpicMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cirpicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Thuê Xe";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlTop.Controls.Add(this.lblDateTime);
            this.pnlTop.Controls.Add(this.cirpicMinimize);
            this.pnlTop.Controls.Add(this.cirpicClose);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1529, 45);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            this.pnlTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseUp);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(697, 12);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(134, 21);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "Hiển thị ngày giờ";
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.btnSignInGuess);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBot.Location = new System.Drawing.Point(0, 45);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(1529, 794);
            this.pnlBot.TabIndex = 3;
            this.pnlBot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBot_MouseDown);
            this.pnlBot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBot_MouseMove);
            this.pnlBot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBot_MouseUp);
            // 
            // btnSignInGuess
            // 
            this.btnSignInGuess.Animated = true;
            this.btnSignInGuess.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSignInGuess.BorderRadius = 10;
            this.btnSignInGuess.BorderThickness = 1;
            this.btnSignInGuess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignInGuess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignInGuess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignInGuess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignInGuess.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSignInGuess.ForeColor = System.Drawing.Color.White;
            this.btnSignInGuess.Location = new System.Drawing.Point(404, 179);
            this.btnSignInGuess.Name = "btnSignInGuess";
            this.btnSignInGuess.Size = new System.Drawing.Size(180, 45);
            this.btnSignInGuess.TabIndex = 0;
            this.btnSignInGuess.Text = "Khách hàng";
            this.btnSignInGuess.Click += new System.EventHandler(this.btnSignInGuess_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // cirpicMinimize
            // 
            this.cirpicMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cirpicMinimize.Image = global::QuanLyThueXe.Properties.Resources.minus;
            this.cirpicMinimize.ImageRotate = 0F;
            this.cirpicMinimize.Location = new System.Drawing.Point(1451, 7);
            this.cirpicMinimize.Name = "cirpicMinimize";
            this.cirpicMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cirpicMinimize.Size = new System.Drawing.Size(30, 30);
            this.cirpicMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cirpicMinimize.TabIndex = 2;
            this.cirpicMinimize.TabStop = false;
            this.cirpicMinimize.Click += new System.EventHandler(this.cirpicMinimize_Click);
            // 
            // cirpicClose
            // 
            this.cirpicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cirpicClose.Image = global::QuanLyThueXe.Properties.Resources.close;
            this.cirpicClose.ImageRotate = 0F;
            this.cirpicClose.Location = new System.Drawing.Point(1487, 7);
            this.cirpicClose.Name = "cirpicClose";
            this.cirpicClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cirpicClose.Size = new System.Drawing.Size(30, 30);
            this.cirpicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cirpicClose.TabIndex = 0;
            this.cirpicClose.TabStop = false;
            this.cirpicClose.Click += new System.EventHandler(this.cirpicClose_Click);
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1529, 839);
            this.Controls.Add(this.pnlBot);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thuê Xe";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cirpicMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cirpicClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox cirpicClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTop;
        private Guna.UI2.WinForms.Guna2CirclePictureBox cirpicMinimize;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Label lblDateTime;
        private Guna.UI2.WinForms.Guna2Button btnSignInGuess;
        private System.Windows.Forms.Timer timer1;
    }
}

