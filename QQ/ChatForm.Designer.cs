namespace QQ
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.FriendHead = new System.Windows.Forms.PictureBox();
            this.NickAndID = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.timer_GetMessage = new System.Windows.Forms.Timer(this.components);
            this.ChatText = new System.Windows.Forms.RichTextBox();
            this.TobeSent = new System.Windows.Forms.RichTextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.MessageLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FriendHead)).BeginInit();
            this.SuspendLayout();
            // 
            // FriendHead
            // 
            this.FriendHead.Location = new System.Drawing.Point(7, 11);
            this.FriendHead.Name = "FriendHead";
            this.FriendHead.Size = new System.Drawing.Size(35, 31);
            this.FriendHead.TabIndex = 0;
            this.FriendHead.TabStop = false;
            // 
            // NickAndID
            // 
            this.NickAndID.AutoSize = true;
            this.NickAndID.Location = new System.Drawing.Point(48, 30);
            this.NickAndID.Name = "NickAndID";
            this.NickAndID.Size = new System.Drawing.Size(41, 12);
            this.NickAndID.TabIndex = 1;
            this.NickAndID.Text = "label1";
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
            // timer_GetMessage
            // 
            this.timer_GetMessage.Enabled = true;
            this.timer_GetMessage.Interval = 2000;
            this.timer_GetMessage.Tick += new System.EventHandler(this.timer_GetMessage_Tick);
            // 
            // ChatText
            // 
            this.ChatText.Location = new System.Drawing.Point(7, 48);
            this.ChatText.Name = "ChatText";
            this.ChatText.ReadOnly = true;
            this.ChatText.Size = new System.Drawing.Size(459, 260);
            this.ChatText.TabIndex = 2;
            this.ChatText.Text = "";
            // 
            // TobeSent
            // 
            this.TobeSent.Location = new System.Drawing.Point(7, 337);
            this.TobeSent.Name = "TobeSent";
            this.TobeSent.Size = new System.Drawing.Size(459, 65);
            this.TobeSent.TabIndex = 3;
            this.TobeSent.Text = "";
            this.TobeSent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TobeSent_KeyDown);
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(381, 408);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(75, 23);
            this.SendMessage.TabIndex = 5;
            this.SendMessage.Text = "发送";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // MessageLog
            // 
            this.MessageLog.Location = new System.Drawing.Point(381, 308);
            this.MessageLog.Name = "MessageLog";
            this.MessageLog.Size = new System.Drawing.Size(75, 23);
            this.MessageLog.TabIndex = 6;
            this.MessageLog.Text = "消息记录";
            this.MessageLog.UseVisualStyleBackColor = true;
            this.MessageLog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MessageLog_MouseClick);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 439);
            this.Controls.Add(this.MessageLog);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.TobeSent);
            this.Controls.Add(this.ChatText);
            this.Controls.Add(this.NickAndID);
            this.Controls.Add(this.FriendHead);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FriendHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FriendHead;
        private System.Windows.Forms.Label NickAndID;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Timer timer_GetMessage;
        private System.Windows.Forms.RichTextBox ChatText;
        private System.Windows.Forms.RichTextBox TobeSent;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Button MessageLog;
    }
}