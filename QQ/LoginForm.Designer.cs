namespace QQ
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.Check_Remember = new System.Windows.Forms.CheckBox();
            this.Check_Autologin = new System.Windows.Forms.CheckBox();
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginID
            // 
            this.LoginID.Location = new System.Drawing.Point(99, 121);
            this.LoginID.Name = "LoginID";
            this.LoginID.Size = new System.Drawing.Size(142, 21);
            this.LoginID.TabIndex = 0;
            this.LoginID.TextChanged += new System.EventHandler(this.LoginID_TextChanged);
            this.LoginID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号:";            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码:";
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(99, 148);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(142, 21);
            this.LoginPassword.TabIndex = 3;            
            // 
            // Check_Remember
            // 
            this.Check_Remember.AutoSize = true;
            this.Check_Remember.Location = new System.Drawing.Point(99, 175);
            this.Check_Remember.Name = "Check_Remember";
            this.Check_Remember.Size = new System.Drawing.Size(72, 16);
            this.Check_Remember.TabIndex = 4;
            this.Check_Remember.Text = "记住密码";
            this.Check_Remember.UseVisualStyleBackColor = true;            
            // 
            // Check_Autologin
            // 
            this.Check_Autologin.AutoSize = true;
            this.Check_Autologin.Location = new System.Drawing.Point(176, 175);
            this.Check_Autologin.Name = "Check_Autologin";
            this.Check_Autologin.Size = new System.Drawing.Size(72, 16);
            this.Check_Autologin.TabIndex = 5;
            this.Check_Autologin.Text = "自动登录";
            this.Check_Autologin.UseVisualStyleBackColor = true;
            this.Check_Autologin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(99, 212);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(142, 25);
            this.Login.TabIndex = 6;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Location = new System.Drawing.Point(247, 139);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(53, 12);
            this.Register.TabIndex = 7;
            this.Register.Text = "申请账号";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Check_Autologin);
            this.Controls.Add(this.Check_Remember);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginID);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.CheckBox Check_Remember;
        private System.Windows.Forms.CheckBox Check_Autologin;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label Register;
    }
}

