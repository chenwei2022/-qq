namespace QQ
{
    partial class MainForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("好友列表", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("陌生人", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeadPx = new System.Windows.Forms.PictureBox();
            this.NickName = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.Label();
            this.lvShowFriend = new System.Windows.Forms.ListView();
            this.cms_FriendList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ts_AddFriend = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.imageHead = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_Infor = new System.Windows.Forms.ToolStripButton();
            this.ts_Searchfriend = new System.Windows.Forms.ToolStripButton();
            this.ts_Update = new System.Windows.Forms.ToolStripButton();
            this.ts_Message = new System.Windows.Forms.ToolStripButton();
            this.ts_Exit = new System.Windows.Forms.ToolStripButton();
            this.timer_Getmessage = new System.Windows.Forms.Timer(this.components);
            this.timer_HeadTwinkle = new System.Windows.Forms.Timer(this.components);
            this.timer_AddFriend_Remind = new System.Windows.Forms.Timer(this.components);
            this.imageSmallHead = new System.Windows.Forms.ImageList(this.components);
            this.image_Message = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HeadPx)).BeginInit();
            this.cms_FriendList.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadPx
            // 
            this.HeadPx.Location = new System.Drawing.Point(2, 6);
            this.HeadPx.Name = "HeadPx";
            this.HeadPx.Size = new System.Drawing.Size(55, 50);
            this.HeadPx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeadPx.TabIndex = 0;
            this.HeadPx.TabStop = false;
            // 
            // NickName
            // 
            this.NickName.AutoSize = true;
            this.NickName.Location = new System.Drawing.Point(77, 12);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(41, 12);
            this.NickName.TabIndex = 2;
            this.NickName.Text = "label1";
            // 
            // Sign
            // 
            this.Sign.AutoSize = true;
            this.Sign.Location = new System.Drawing.Point(77, 47);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(29, 12);
            this.Sign.TabIndex = 3;
            this.Sign.Text = "Sign";
            // 
            // lvShowFriend
            // 
            this.lvShowFriend.ContextMenuStrip = this.cms_FriendList;
            listViewGroup1.Header = "好友列表";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "陌生人";
            listViewGroup2.Name = "listViewGroup2";
            this.lvShowFriend.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvShowFriend.LargeImageList = this.imageHead;
            this.lvShowFriend.Location = new System.Drawing.Point(2, 62);
            this.lvShowFriend.MultiSelect = false;
            this.lvShowFriend.Name = "lvShowFriend";
            this.lvShowFriend.Size = new System.Drawing.Size(282, 372);
            this.lvShowFriend.SmallImageList = this.imageHead;
            this.lvShowFriend.TabIndex = 4;
            this.lvShowFriend.UseCompatibleStateImageBehavior = false;
            this.lvShowFriend.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvShowFriend_MouseDoubleClick);
            // 
            // cms_FriendList
            // 
            this.cms_FriendList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_AddFriend,
            this.ts_Delete});
            this.cms_FriendList.Name = "cms_FriendList";
            this.cms_FriendList.Size = new System.Drawing.Size(125, 48);
            // 
            // ts_AddFriend
            // 
            this.ts_AddFriend.Name = "ts_AddFriend";
            this.ts_AddFriend.Size = new System.Drawing.Size(124, 22);
            this.ts_AddFriend.Text = "添加好友";
            this.ts_AddFriend.Visible = false;
            this.ts_AddFriend.Click += new System.EventHandler(this.ts_AddFriend_Click);
            // 
            // ts_Delete
            // 
            this.ts_Delete.Name = "ts_Delete";
            this.ts_Delete.Size = new System.Drawing.Size(124, 22);
            this.ts_Delete.Text = "删除";
            this.ts_Delete.Visible = false;
            this.ts_Delete.Click += new System.EventHandler(this.ts_Delete_Click);
            // 
            // imageHead
            // 
            this.imageHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageHead.ImageStream")));
            this.imageHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imageHead.Images.SetKeyName(0, "1.bmp");
            this.imageHead.Images.SetKeyName(1, "2.bmp");
            this.imageHead.Images.SetKeyName(2, "3.bmp");
            this.imageHead.Images.SetKeyName(3, "4.bmp");
            this.imageHead.Images.SetKeyName(4, "back.bmp");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Infor,
            this.ts_Searchfriend,
            this.ts_Update,
            this.ts_Message,
            this.ts_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 437);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_Infor
            // 
            this.ts_Infor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_Infor.Image = ((System.Drawing.Image)(resources.GetObject("ts_Infor.Image")));
            this.ts_Infor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Infor.Name = "ts_Infor";
            this.ts_Infor.Size = new System.Drawing.Size(23, 22);
            this.ts_Infor.Text = "toolStripButton1";
            this.ts_Infor.Click += new System.EventHandler(this.ts_Infor_Click);
            // 
            // ts_Searchfriend
            // 
            this.ts_Searchfriend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_Searchfriend.Image = ((System.Drawing.Image)(resources.GetObject("ts_Searchfriend.Image")));
            this.ts_Searchfriend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Searchfriend.Name = "ts_Searchfriend";
            this.ts_Searchfriend.Size = new System.Drawing.Size(23, 22);
            this.ts_Searchfriend.Text = "toolStripButton2";
            this.ts_Searchfriend.Click += new System.EventHandler(this.ts_Searchfriend_Click);
            // 
            // ts_Update
            // 
            this.ts_Update.Image = ((System.Drawing.Image)(resources.GetObject("ts_Update.Image")));
            this.ts_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Update.Name = "ts_Update";
            this.ts_Update.Size = new System.Drawing.Size(76, 22);
            this.ts_Update.Text = "更新好友";
            this.ts_Update.Click += new System.EventHandler(this.ts_Update_Click);
            // 
            // ts_Message
            // 
            this.ts_Message.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_Message.Image = ((System.Drawing.Image)(resources.GetObject("ts_Message.Image")));
            this.ts_Message.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Message.Name = "ts_Message";
            this.ts_Message.Size = new System.Drawing.Size(23, 22);
            this.ts_Message.Text = "toolStripButton4";
            this.ts_Message.Click += new System.EventHandler(this.ts_Message_Click);
            // 
            // ts_Exit
            // 
            this.ts_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ts_Exit.Image")));
            this.ts_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Exit.Name = "ts_Exit";
            this.ts_Exit.Size = new System.Drawing.Size(23, 22);
            this.ts_Exit.Text = "toolStripButton1";
            this.ts_Exit.Click += new System.EventHandler(this.ts_Exit_Click);
            // 
            // timer_Getmessage
            // 
            this.timer_Getmessage.Enabled = true;
            this.timer_Getmessage.Interval = 1000;
            this.timer_Getmessage.Tick += new System.EventHandler(this.timer_Getmessage_Tick);
            // 
            // timer_HeadTwinkle
            // 
            this.timer_HeadTwinkle.Interval = 1000;
            this.timer_HeadTwinkle.Tick += new System.EventHandler(this.timer_HeadTwinkle_Tick);
            // 
            // timer_AddFriend_Remind
            // 
            this.timer_AddFriend_Remind.Interval = 1000;
            this.timer_AddFriend_Remind.Tick += new System.EventHandler(this.timer_AddFriend_Remind_Tick);
            // 
            // imageSmallHead
            // 
            this.imageSmallHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSmallHead.ImageStream")));
            this.imageSmallHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSmallHead.Images.SetKeyName(0, "1-1.bmp");
            this.imageSmallHead.Images.SetKeyName(1, "2-1.bmp");
            this.imageSmallHead.Images.SetKeyName(2, "3-1.bmp");
            this.imageSmallHead.Images.SetKeyName(3, "4-1.bmp");
            // 
            // image_Message
            // 
            this.image_Message.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_Message.ImageStream")));
            this.image_Message.TransparentColor = System.Drawing.Color.Transparent;
            this.image_Message.Images.SetKeyName(0, "info.png");
            this.image_Message.Images.SetKeyName(1, "Message.gif");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvShowFriend);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.NickName);
            this.Controls.Add(this.HeadPx);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeadPx)).EndInit();
            this.cms_FriendList.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HeadPx;        
        private System.Windows.Forms.Label NickName;
        private System.Windows.Forms.Label Sign;
        private System.Windows.Forms.ListView lvShowFriend;
        private System.Windows.Forms.ImageList imageHead;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_Infor;
        private System.Windows.Forms.ToolStripButton ts_Searchfriend;
        private System.Windows.Forms.Timer timer_Getmessage;
        private System.Windows.Forms.Timer timer_HeadTwinkle;
        private System.Windows.Forms.ToolStripButton ts_Update;
        private System.Windows.Forms.ToolStripButton ts_Exit;
        private System.Windows.Forms.ContextMenuStrip cms_FriendList;
        private System.Windows.Forms.ToolStripMenuItem ts_AddFriend;
        private System.Windows.Forms.ToolStripMenuItem ts_Delete;
        private System.Windows.Forms.ImageList imageSmallHead;
        private System.Windows.Forms.ImageList image_Message;
        public System.Windows.Forms.Timer timer_AddFriend_Remind;
        public System.Windows.Forms.ToolStripButton ts_Message;
    }
}