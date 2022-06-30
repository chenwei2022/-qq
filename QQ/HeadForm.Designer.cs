namespace QQ
{
    partial class HeadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadForm));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lvHead = new System.Windows.Forms.ListView();
            this.confirmHead = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // lvHead
            // 
            this.lvHead.LargeImageList = this.imageList;
            this.lvHead.Location = new System.Drawing.Point(5, 13);
            this.lvHead.Name = "lvHead";
            this.lvHead.Size = new System.Drawing.Size(263, 145);
            this.lvHead.TabIndex = 0;
            this.lvHead.UseCompatibleStateImageBehavior = false;
            // 
            // confirmHead
            // 
            this.confirmHead.Location = new System.Drawing.Point(124, 173);
            this.confirmHead.Name = "confirmHead";
            this.confirmHead.Size = new System.Drawing.Size(75, 23);
            this.confirmHead.TabIndex = 1;
            this.confirmHead.Text = "确定";
            this.confirmHead.UseVisualStyleBackColor = true;
            this.confirmHead.Click += new System.EventHandler(this.confirmHead_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HeadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 219);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confirmHead);
            this.Controls.Add(this.lvHead);
            this.Name = "HeadForm";
            this.Text = "选择头像";
            this.Load += new System.EventHandler(this.HeadForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView lvHead;
        private System.Windows.Forms.Button confirmHead;
        private System.Windows.Forms.Button button2;
    }
}