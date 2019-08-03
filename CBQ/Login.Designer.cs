namespace CBQ
{
    partial class Login
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
            this.picValidCode = new System.Windows.Forms.ImageList(this.components);
            this.pbVerifyCode = new CCWin.SkinControl.SkinPictureBox();
            this.butUpdateVerifyCode = new CCWin.SkinControl.SkinButton();
            this.skbtn_login = new CCWin.SkinControl.SkinButton();
            this.sklb_region = new CCWin.SkinControl.SkinLabel();
            this.sklb_login = new CCWin.SkinControl.SkinLabel();
            this.sklb_agreement = new CCWin.SkinControl.SkinLabel();
            this.sklb_agreements = new CCWin.SkinControl.SkinLabel();
            this.sklb_forgetpwd = new CCWin.SkinControl.SkinLabel();
            this.sktxb_user = new CCWin.SkinControl.SkinTextBox();
            this.sktxb_pwd = new CCWin.SkinControl.SkinTextBox();
            this.sktxb_ValidCode = new CCWin.SkinControl.SkinTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerifyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // picValidCode
            // 
            this.picValidCode.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.picValidCode.ImageSize = new System.Drawing.Size(16, 16);
            this.picValidCode.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbVerifyCode
            // 
            this.pbVerifyCode.BackColor = System.Drawing.Color.Transparent;
            this.pbVerifyCode.Location = new System.Drawing.Point(274, 147);
            this.pbVerifyCode.Name = "pbVerifyCode";
            this.pbVerifyCode.Size = new System.Drawing.Size(127, 46);
            this.pbVerifyCode.TabIndex = 4;
            this.pbVerifyCode.TabStop = false;
            // 
            // butUpdateVerifyCode
            // 
            this.butUpdateVerifyCode.BackColor = System.Drawing.Color.Transparent;
            this.butUpdateVerifyCode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.butUpdateVerifyCode.DownBack = null;
            this.butUpdateVerifyCode.Location = new System.Drawing.Point(407, 147);
            this.butUpdateVerifyCode.MouseBack = null;
            this.butUpdateVerifyCode.Name = "butUpdateVerifyCode";
            this.butUpdateVerifyCode.NormlBack = null;
            this.butUpdateVerifyCode.Size = new System.Drawing.Size(73, 46);
            this.butUpdateVerifyCode.TabIndex = 5;
            this.butUpdateVerifyCode.Text = "看不清楚换一张";
            this.butUpdateVerifyCode.UseVisualStyleBackColor = false;
            this.butUpdateVerifyCode.Visible = false;
            // 
            // skbtn_login
            // 
            this.skbtn_login.BackColor = System.Drawing.Color.Transparent;
            this.skbtn_login.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtn_login.DownBack = null;
            this.skbtn_login.Location = new System.Drawing.Point(20, 242);
            this.skbtn_login.MouseBack = null;
            this.skbtn_login.Name = "skbtn_login";
            this.skbtn_login.NormlBack = null;
            this.skbtn_login.Size = new System.Drawing.Size(449, 23);
            this.skbtn_login.TabIndex = 6;
            this.skbtn_login.Text = "键入";
            this.skbtn_login.UseVisualStyleBackColor = false;
            this.skbtn_login.Click += new System.EventHandler(this.skbtn_login_Click);
            // 
            // sklb_region
            // 
            this.sklb_region.AutoSize = true;
            this.sklb_region.BackColor = System.Drawing.Color.Transparent;
            this.sklb_region.BorderColor = System.Drawing.Color.White;
            this.sklb_region.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sklb_region.Location = new System.Drawing.Point(167, 281);
            this.sklb_region.Name = "sklb_region";
            this.sklb_region.Size = new System.Drawing.Size(128, 17);
            this.sklb_region.TabIndex = 7;
            this.sklb_region.Text = "没有账号？点击去注册";
            this.sklb_region.Click += new System.EventHandler(this.sklb_region_Click);
            // 
            // sklb_login
            // 
            this.sklb_login.AutoSize = true;
            this.sklb_login.BackColor = System.Drawing.Color.Transparent;
            this.sklb_login.BorderColor = System.Drawing.Color.White;
            this.sklb_login.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sklb_login.Location = new System.Drawing.Point(17, 18);
            this.sklb_login.Name = "sklb_login";
            this.sklb_login.Size = new System.Drawing.Size(32, 17);
            this.sklb_login.TabIndex = 8;
            this.sklb_login.Text = "登录";
            // 
            // sklb_agreement
            // 
            this.sklb_agreement.AutoSize = true;
            this.sklb_agreement.BackColor = System.Drawing.Color.Transparent;
            this.sklb_agreement.BorderColor = System.Drawing.Color.White;
            this.sklb_agreement.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sklb_agreement.Location = new System.Drawing.Point(17, 212);
            this.sklb_agreement.Name = "sklb_agreement";
            this.sklb_agreement.Size = new System.Drawing.Size(176, 17);
            this.sklb_agreement.TabIndex = 9;
            this.sklb_agreement.Text = "登录使用即表示您已阅读并接受";
            // 
            // sklb_agreements
            // 
            this.sklb_agreements.AutoSize = true;
            this.sklb_agreements.BackColor = System.Drawing.Color.Transparent;
            this.sklb_agreements.BorderColor = System.Drawing.Color.White;
            this.sklb_agreements.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sklb_agreements.Location = new System.Drawing.Point(191, 212);
            this.sklb_agreements.Name = "sklb_agreements";
            this.sklb_agreements.Size = new System.Drawing.Size(104, 17);
            this.sklb_agreements.TabIndex = 10;
            this.sklb_agreements.Text = "《用户使用协议》";
            this.sklb_agreements.Click += new System.EventHandler(this.sklb_agreements_Click);
            // 
            // sklb_forgetpwd
            // 
            this.sklb_forgetpwd.AutoSize = true;
            this.sklb_forgetpwd.BackColor = System.Drawing.Color.Transparent;
            this.sklb_forgetpwd.BorderColor = System.Drawing.Color.White;
            this.sklb_forgetpwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sklb_forgetpwd.Location = new System.Drawing.Point(199, 309);
            this.sklb_forgetpwd.Name = "sklb_forgetpwd";
            this.sklb_forgetpwd.Size = new System.Drawing.Size(56, 17);
            this.sklb_forgetpwd.TabIndex = 11;
            this.sklb_forgetpwd.Text = "忘记密码";
            // 
            // sktxb_user
            // 
            this.sktxb_user.BackColor = System.Drawing.Color.Transparent;
            this.sktxb_user.DownBack = null;
            this.sktxb_user.Icon = null;
            this.sktxb_user.IconIsButton = false;
            this.sktxb_user.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.sktxb_user.IsPasswordChat = '\0';
            this.sktxb_user.IsSystemPasswordChar = false;
            this.sktxb_user.Lines = new string[0];
            this.sktxb_user.Location = new System.Drawing.Point(20, 55);
            this.sktxb_user.Margin = new System.Windows.Forms.Padding(0);
            this.sktxb_user.MaxLength = 32767;
            this.sktxb_user.MinimumSize = new System.Drawing.Size(28, 28);
            this.sktxb_user.MouseBack = null;
            this.sktxb_user.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.sktxb_user.Multiline = false;
            this.sktxb_user.Name = "sktxb_user";
            this.sktxb_user.NormlBack = null;
            this.sktxb_user.Padding = new System.Windows.Forms.Padding(5);
            this.sktxb_user.ReadOnly = false;
            this.sktxb_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sktxb_user.Size = new System.Drawing.Size(449, 28);
            // 
            // 
            // 
            this.sktxb_user.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sktxb_user.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sktxb_user.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.sktxb_user.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.sktxb_user.SkinTxt.Name = "BaseText";
            this.sktxb_user.SkinTxt.Size = new System.Drawing.Size(439, 18);
            this.sktxb_user.SkinTxt.TabIndex = 0;
            this.sktxb_user.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sktxb_user.SkinTxt.WaterText = "";
            this.sktxb_user.TabIndex = 12;
            this.sktxb_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sktxb_user.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sktxb_user.WaterText = "";
            this.sktxb_user.WordWrap = true;
            this.sktxb_user.MouseEnter += new System.EventHandler(this.sktxb_user_MouseEnter);
            this.sktxb_user.MouseLeave += new System.EventHandler(this.sktxb_user_MouseLeave);
            // 
            // sktxb_pwd
            // 
            this.sktxb_pwd.BackColor = System.Drawing.Color.Transparent;
            this.sktxb_pwd.DownBack = null;
            this.sktxb_pwd.Icon = null;
            this.sktxb_pwd.IconIsButton = false;
            this.sktxb_pwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.sktxb_pwd.IsPasswordChat = '\0';
            this.sktxb_pwd.IsSystemPasswordChar = false;
            this.sktxb_pwd.Lines = new string[0];
            this.sktxb_pwd.Location = new System.Drawing.Point(20, 103);
            this.sktxb_pwd.Margin = new System.Windows.Forms.Padding(0);
            this.sktxb_pwd.MaxLength = 32767;
            this.sktxb_pwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.sktxb_pwd.MouseBack = null;
            this.sktxb_pwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.sktxb_pwd.Multiline = false;
            this.sktxb_pwd.Name = "sktxb_pwd";
            this.sktxb_pwd.NormlBack = null;
            this.sktxb_pwd.Padding = new System.Windows.Forms.Padding(5);
            this.sktxb_pwd.ReadOnly = false;
            this.sktxb_pwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sktxb_pwd.Size = new System.Drawing.Size(449, 28);
            // 
            // 
            // 
            this.sktxb_pwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sktxb_pwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sktxb_pwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.sktxb_pwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.sktxb_pwd.SkinTxt.Name = "BaseText";
            this.sktxb_pwd.SkinTxt.Size = new System.Drawing.Size(439, 18);
            this.sktxb_pwd.SkinTxt.TabIndex = 0;
            this.sktxb_pwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sktxb_pwd.SkinTxt.WaterText = "";
            this.sktxb_pwd.TabIndex = 12;
            this.sktxb_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sktxb_pwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sktxb_pwd.WaterText = "";
            this.sktxb_pwd.WordWrap = true;
            this.sktxb_pwd.MouseEnter += new System.EventHandler(this.sktxb_pwd_MouseEnter);
            this.sktxb_pwd.MouseLeave += new System.EventHandler(this.sktxb_pwd_MouseLeave);
            // 
            // sktxb_ValidCode
            // 
            this.sktxb_ValidCode.BackColor = System.Drawing.Color.Transparent;
            this.sktxb_ValidCode.DownBack = null;
            this.sktxb_ValidCode.Icon = null;
            this.sktxb_ValidCode.IconIsButton = false;
            this.sktxb_ValidCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.sktxb_ValidCode.IsPasswordChat = '\0';
            this.sktxb_ValidCode.IsSystemPasswordChar = false;
            this.sktxb_ValidCode.Lines = new string[0];
            this.sktxb_ValidCode.Location = new System.Drawing.Point(20, 147);
            this.sktxb_ValidCode.Margin = new System.Windows.Forms.Padding(0);
            this.sktxb_ValidCode.MaxLength = 32767;
            this.sktxb_ValidCode.MinimumSize = new System.Drawing.Size(28, 28);
            this.sktxb_ValidCode.MouseBack = null;
            this.sktxb_ValidCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.sktxb_ValidCode.Multiline = false;
            this.sktxb_ValidCode.Name = "sktxb_ValidCode";
            this.sktxb_ValidCode.NormlBack = null;
            this.sktxb_ValidCode.Padding = new System.Windows.Forms.Padding(5);
            this.sktxb_ValidCode.ReadOnly = false;
            this.sktxb_ValidCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sktxb_ValidCode.Size = new System.Drawing.Size(251, 28);
            // 
            // 
            // 
            this.sktxb_ValidCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sktxb_ValidCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sktxb_ValidCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.sktxb_ValidCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.sktxb_ValidCode.SkinTxt.Name = "BaseText";
            this.sktxb_ValidCode.SkinTxt.Size = new System.Drawing.Size(241, 18);
            this.sktxb_ValidCode.SkinTxt.TabIndex = 0;
            this.sktxb_ValidCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sktxb_ValidCode.SkinTxt.WaterText = "";
            this.sktxb_ValidCode.TabIndex = 13;
            this.sktxb_ValidCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sktxb_ValidCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sktxb_ValidCode.WaterText = "";
            this.sktxb_ValidCode.WordWrap = true;
            this.sktxb_ValidCode.MouseEnter += new System.EventHandler(this.sktxt_ValidCode_MouseEnter);
            this.sktxb_ValidCode.MouseLeave += new System.EventHandler(this.sktxt_ValidCode_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 488);
            this.Controls.Add(this.sktxb_ValidCode);
            this.Controls.Add(this.sktxb_pwd);
            this.Controls.Add(this.sktxb_user);
            this.Controls.Add(this.sklb_forgetpwd);
            this.Controls.Add(this.sklb_agreements);
            this.Controls.Add(this.sklb_agreement);
            this.Controls.Add(this.sklb_login);
            this.Controls.Add(this.sklb_region);
            this.Controls.Add(this.skbtn_login);
            this.Controls.Add(this.butUpdateVerifyCode);
            this.Controls.Add(this.pbVerifyCode);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbVerifyCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList picValidCode;
        private CCWin.SkinControl.SkinPictureBox pbVerifyCode;
        private CCWin.SkinControl.SkinButton butUpdateVerifyCode;
        private CCWin.SkinControl.SkinButton skbtn_login;
        private CCWin.SkinControl.SkinLabel sklb_region;
        private CCWin.SkinControl.SkinLabel sklb_login;
        private CCWin.SkinControl.SkinLabel sklb_agreement;
        private CCWin.SkinControl.SkinLabel sklb_agreements;
        private CCWin.SkinControl.SkinLabel sklb_forgetpwd;
        private CCWin.SkinControl.SkinTextBox sktxb_user;
        private CCWin.SkinControl.SkinTextBox sktxb_pwd;
        private CCWin.SkinControl.SkinTextBox sktxb_ValidCode;
    }
}