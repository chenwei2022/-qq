namespace QQ
{
    partial class EditInforForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditInforForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.personalInfor = new System.Windows.Forms.TabPage();
            this.chooseHead = new System.Windows.Forms.Button();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.blood = new System.Windows.Forms.ComboBox();
            this.age = new System.Windows.Forms.TextBox();
            this.star = new System.Windows.Forms.ComboBox();
            this.realName = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.ComboBox();
            this.nickName = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.securitySetting = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNotAllow = new System.Windows.Forms.RadioButton();
            this.rbVerify = new System.Windows.Forms.RadioButton();
            this.rbAllow = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.confirmPwd = new System.Windows.Forms.TextBox();
            this.newPwd = new System.Windows.Forms.TextBox();
            this.originPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.personalInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            this.securitySetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.personalInfor);
            this.tabControl1.Controls.Add(this.securitySetting);
            this.tabControl1.Location = new System.Drawing.Point(7, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(323, 254);
            this.tabControl1.TabIndex = 0;
            // 
            // personalInfor
            // 
            this.personalInfor.Controls.Add(this.chooseHead);
            this.personalInfor.Controls.Add(this.pbHead);
            this.personalInfor.Controls.Add(this.blood);
            this.personalInfor.Controls.Add(this.age);
            this.personalInfor.Controls.Add(this.star);
            this.personalInfor.Controls.Add(this.realName);
            this.personalInfor.Controls.Add(this.sex);
            this.personalInfor.Controls.Add(this.nickName);
            this.personalInfor.Controls.Add(this.UID);
            this.personalInfor.Controls.Add(this.label11);
            this.personalInfor.Controls.Add(this.label10);
            this.personalInfor.Controls.Add(this.label9);
            this.personalInfor.Controls.Add(this.label8);
            this.personalInfor.Controls.Add(this.label7);
            this.personalInfor.Controls.Add(this.label6);
            this.personalInfor.Controls.Add(this.label5);
            this.personalInfor.Location = new System.Drawing.Point(4, 22);
            this.personalInfor.Name = "personalInfor";
            this.personalInfor.Padding = new System.Windows.Forms.Padding(3);
            this.personalInfor.Size = new System.Drawing.Size(315, 228);
            this.personalInfor.TabIndex = 0;
            this.personalInfor.Text = "个人信息";
            this.personalInfor.UseVisualStyleBackColor = true;
            //this.personalInfor.Click += new System.EventHandler(this.个人信息_Click);
            // 
            // chooseHead
            // 
            this.chooseHead.Location = new System.Drawing.Point(184, 75);
            this.chooseHead.Name = "chooseHead";
            this.chooseHead.Size = new System.Drawing.Size(72, 28);
            this.chooseHead.TabIndex = 16;
            this.chooseHead.Text = "选择头像";
            this.chooseHead.UseVisualStyleBackColor = true;
            this.chooseHead.Click += new System.EventHandler(this.chooseHead_Click);
            // 
            // pbHead
            // 
            this.pbHead.Location = new System.Drawing.Point(184, 3);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(68, 66);
            this.pbHead.TabIndex = 15;
            this.pbHead.TabStop = false;
            // 
            // blood
            // 
            this.blood.FormattingEnabled = true;
            this.blood.Items.AddRange(new object[] {
            "A型",
            "B型",
            "AB型",
            "O型"});
            this.blood.Location = new System.Drawing.Point(193, 168);
            this.blood.Name = "blood";
            this.blood.Size = new System.Drawing.Size(103, 20);
            this.blood.TabIndex = 14;
            //this.blood.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(193, 136);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 21);
            this.age.TabIndex = 13;
            // 
            // star
            // 
            this.star.FormattingEnabled = true;
            this.star.Items.AddRange(new object[] {
            "水瓶座",
            "双鱼座",
            "白羊座",
            "金牛座",
            "双子座",
            "巨蟹座",
            "狮子座",
            "处女座",
            "天秤座",
            "天蝎座",
            "射手座",
            "摩羯座"});
            this.star.Location = new System.Drawing.Point(46, 169);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(103, 20);
            this.star.TabIndex = 12;
            // 
            // realName
            // 
            this.realName.Location = new System.Drawing.Point(65, 137);
            this.realName.Name = "realName";
            this.realName.Size = new System.Drawing.Size(84, 21);
            this.realName.TabIndex = 11;
            // 
            // sex
            // 
            this.sex.FormattingEnabled = true;
            this.sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex.Location = new System.Drawing.Point(52, 98);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(40, 20);
            this.sex.TabIndex = 10;
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(52, 60);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(100, 21);
            this.nickName.TabIndex = 9;
            //this.nickName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(53, 23);
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Size = new System.Drawing.Size(96, 21);
            this.UID.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "血型";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 6;
            this.label10.Text = "年龄";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "星座";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "真实姓名";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "性别";
            //this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "昵称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "用户ID";
            // 
            // securitySetting
            // 
            this.securitySetting.Controls.Add(this.groupBox2);
            this.securitySetting.Controls.Add(this.groupBox1);
            this.securitySetting.Location = new System.Drawing.Point(4, 22);
            this.securitySetting.Name = "securitySetting";
            this.securitySetting.Padding = new System.Windows.Forms.Padding(3);
            this.securitySetting.Size = new System.Drawing.Size(315, 228);
            this.securitySetting.TabIndex = 1;
            this.securitySetting.Text = "安全设置";
            this.securitySetting.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNotAllow);
            this.groupBox2.Controls.Add(this.rbVerify);
            this.groupBox2.Controls.Add(this.rbAllow);
            this.groupBox2.Location = new System.Drawing.Point(8, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "身份验证";
            // 
            // rbNotAllow
            // 
            this.rbNotAllow.AutoSize = true;
            this.rbNotAllow.Location = new System.Drawing.Point(17, 68);
            this.rbNotAllow.Name = "rbNotAllow";
            this.rbNotAllow.Size = new System.Drawing.Size(155, 16);
            this.rbNotAllow.TabIndex = 2;
            this.rbNotAllow.TabStop = true;
            this.rbNotAllow.Text = "不允许任何人加我为好友";
            this.rbNotAllow.UseVisualStyleBackColor = true;
            //this.rbNotAllow.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbVerify
            // 
            this.rbVerify.AutoSize = true;
            this.rbVerify.Location = new System.Drawing.Point(17, 47);
            this.rbVerify.Name = "rbVerify";
            this.rbVerify.Size = new System.Drawing.Size(179, 16);
            this.rbVerify.TabIndex = 1;
            this.rbVerify.TabStop = true;
            this.rbVerify.Text = "需要身份验证才能加我为好友";
            this.rbVerify.UseVisualStyleBackColor = true;
            // 
            // rbAllow
            // 
            this.rbAllow.AutoSize = true;
            this.rbAllow.Location = new System.Drawing.Point(17, 25);
            this.rbAllow.Name = "rbAllow";
            this.rbAllow.Size = new System.Drawing.Size(143, 16);
            this.rbAllow.TabIndex = 0;
            this.rbAllow.TabStop = true;
            this.rbAllow.Text = "允许任何人加我为好友";
            this.rbAllow.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirmPwd);
            this.groupBox1.Controls.Add(this.newPwd);
            this.groupBox1.Controls.Add(this.originPwd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // confirmPwd
            // 
            this.confirmPwd.Location = new System.Drawing.Point(57, 75);
            this.confirmPwd.Name = "confirmPwd";
            this.confirmPwd.Size = new System.Drawing.Size(188, 21);
            this.confirmPwd.TabIndex = 5;
            // 
            // newPwd
            // 
            this.newPwd.Location = new System.Drawing.Point(57, 48);
            this.newPwd.Name = "newPwd";
            this.newPwd.Size = new System.Drawing.Size(188, 21);
            this.newPwd.TabIndex = 4;
            // 
            // originPwd
            // 
            this.originPwd.Location = new System.Drawing.Point(57, 23);
            this.originPwd.Name = "originPwd";
            this.originPwd.Size = new System.Drawing.Size(188, 21);
            this.originPwd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码确认";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "1.bmp");
            this.imageList.Images.SetKeyName(1, "2.bmp");
            this.imageList.Images.SetKeyName(2, "3.bmp");
            this.imageList.Images.SetKeyName(3, "4.bmp");
            this.imageList.Images.SetKeyName(4, "back.bmp");
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(163, 276);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 1;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(244, 275);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // EditInforForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 312);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditInforForm";
            this.Text = "EditInforForm";
            this.Load += new System.EventHandler(this.EditInforForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.personalInfor.ResumeLayout(false);
            this.personalInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            this.securitySetting.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage personalInfor;
        private System.Windows.Forms.TabPage securitySetting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nickName;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sex;
        private System.Windows.Forms.ComboBox blood;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.ComboBox star;
        private System.Windows.Forms.TextBox realName;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNotAllow;
        private System.Windows.Forms.RadioButton rbVerify;
        private System.Windows.Forms.RadioButton rbAllow;
        private System.Windows.Forms.TextBox confirmPwd;
        private System.Windows.Forms.TextBox newPwd;
        private System.Windows.Forms.TextBox originPwd;
        private System.Windows.Forms.Button chooseHead;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
    }
}