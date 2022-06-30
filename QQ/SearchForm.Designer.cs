namespace QQ
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.qqNum = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.headPx = new System.Windows.Forms.PictureBox();
            this.imageHead = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.Label();
            this.addFriend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headPx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要搜索的用户ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // qqNum
            // 
            this.qqNum.Location = new System.Drawing.Point(40, 52);
            this.qqNum.Name = "qqNum";
            this.qqNum.Size = new System.Drawing.Size(135, 21);
            this.qqNum.TabIndex = 1;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(181, 50);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(50, 23);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // headPx
            // 
            this.headPx.Location = new System.Drawing.Point(40, 90);
            this.headPx.Name = "headPx";
            this.headPx.Size = new System.Drawing.Size(60, 61);
            this.headPx.TabIndex = 3;
            this.headPx.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "昵称：";
            // 
            // nickName
            // 
            this.nickName.AutoSize = true;
            this.nickName.Location = new System.Drawing.Point(43, 161);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(65, 12);
            this.nickName.TabIndex = 5;
            this.nickName.Text = "loading...";
            // 
            // addFriend
            // 
            this.addFriend.Location = new System.Drawing.Point(125, 128);
            this.addFriend.Name = "addFriend";
            this.addFriend.Size = new System.Drawing.Size(50, 23);
            this.addFriend.TabIndex = 6;
            this.addFriend.Text = "添加";
            this.addFriend.UseVisualStyleBackColor = true;
            this.addFriend.Click += new System.EventHandler(this.addFriend_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 204);
            this.Controls.Add(this.addFriend);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headPx);
            this.Controls.Add(this.search);
            this.Controls.Add(this.qqNum);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.headPx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qqNum;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.PictureBox headPx;
        private System.Windows.Forms.ImageList imageHead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nickName;
        private System.Windows.Forms.Button addFriend;
    }
}