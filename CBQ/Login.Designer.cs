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
            this.Eamil_Tel = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.Label();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_pwd = new System.Windows.Forms.TextBox();
            this.Captcha = new System.Windows.Forms.Label();
            this.txtValidCode = new System.Windows.Forms.TextBox();
            this.picValidCode = new System.Windows.Forms.ImageList(this.components);
            this.pbVerifyCode = new CCWin.SkinControl.SkinPictureBox();
            this.butUpdateVerifyCode = new CCWin.SkinControl.SkinButton();
            this.skbtn_login = new CCWin.SkinControl.SkinButton();
            this.sklb_region = new CCWin.SkinControl.SkinLabel();
            this.sklb_login = new CCWin.SkinControl.SkinLabel();
            this.sklb_agreement = new CCWin.SkinControl.SkinLabel();
            this.sklb_agreements = new CCWin.SkinControl.SkinLabel();
            this.sklb_forgetpwd = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerifyCode)).BeginInit();
            this.SuspendLayout();
            // 
            // Eamil_Tel
            // 
            this.Eamil_Tel.AutoSize = true;
            this.Eamil_Tel.Location = new System.Drawing.Point(83, 78);
            this.Eamil_Tel.Name = "Eamil_Tel";
            this.Eamil_Tel.Size = new System.Drawing.Size(53, 12);
            this.Eamil_Tel.TabIndex = 0;
            this.Eamil_Tel.Text = "用户名：";
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.Location = new System.Drawing.Point(83, 117);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(41, 12);
            this.Pwd.TabIndex = 0;
            this.Pwd.Text = "密码：";
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(133, 75);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(232, 21);
            this.txb_username.TabIndex = 1;
            // 
            // txb_pwd
            // 
            this.txb_pwd.Location = new System.Drawing.Point(133, 114);
            this.txb_pwd.Name = "txb_pwd";
            this.txb_pwd.Size = new System.Drawing.Size(232, 21);
            this.txb_pwd.TabIndex = 1;
            this.txb_pwd.UseSystemPasswordChar = true;
            // 
            // Captcha
            // 
            this.Captcha.AutoSize = true;
            this.Captcha.Location = new System.Drawing.Point(83, 157);
            this.Captcha.Name = "Captcha";
            this.Captcha.Size = new System.Drawing.Size(77, 12);
            this.Captcha.TabIndex = 0;
            this.Captcha.Text = "输入验证码：";
            // 
            // txtValidCode
            // 
            this.txtValidCode.Location = new System.Drawing.Point(158, 154);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(82, 21);
            this.txtValidCode.TabIndex = 2;
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
            this.pbVerifyCode.Location = new System.Drawing.Point(246, 154);
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
            this.butUpdateVerifyCode.Location = new System.Drawing.Point(379, 140);
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 488);
            this.Controls.Add(this.sklb_forgetpwd);
            this.Controls.Add(this.sklb_agreements);
            this.Controls.Add(this.sklb_agreement);
            this.Controls.Add(this.sklb_login);
            this.Controls.Add(this.sklb_region);
            this.Controls.Add(this.skbtn_login);
            this.Controls.Add(this.butUpdateVerifyCode);
            this.Controls.Add(this.pbVerifyCode);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.txb_pwd);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.Captcha);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.Eamil_Tel);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbVerifyCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Eamil_Tel;
        private System.Windows.Forms.Label Pwd;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_pwd;
        private System.Windows.Forms.Label Captcha;
        private System.Windows.Forms.TextBox txtValidCode;
        private System.Windows.Forms.ImageList picValidCode;
        private CCWin.SkinControl.SkinPictureBox pbVerifyCode;
        private CCWin.SkinControl.SkinButton butUpdateVerifyCode;
        private CCWin.SkinControl.SkinButton skbtn_login;
        private CCWin.SkinControl.SkinLabel sklb_region;
        private CCWin.SkinControl.SkinLabel sklb_login;
        private CCWin.SkinControl.SkinLabel sklb_agreement;
        private CCWin.SkinControl.SkinLabel sklb_agreements;
        private CCWin.SkinControl.SkinLabel sklb_forgetpwd;
    }
}