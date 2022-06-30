namespace QQ
{
    partial class AddRemind
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
            this.addfriendMessage = new System.Windows.Forms.Label();
            this.confirmAdd = new System.Windows.Forms.Button();
            this.refuseAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addfriendMessage
            // 
            this.addfriendMessage.AutoSize = true;
            this.addfriendMessage.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addfriendMessage.Location = new System.Drawing.Point(26, 83);
            this.addfriendMessage.Name = "addfriendMessage";
            this.addfriendMessage.Size = new System.Drawing.Size(69, 19);
            this.addfriendMessage.TabIndex = 0;
            this.addfriendMessage.Text = "label1";
            // 
            // confirmAdd
            // 
            this.confirmAdd.Location = new System.Drawing.Point(100, 151);
            this.confirmAdd.Name = "confirmAdd";
            this.confirmAdd.Size = new System.Drawing.Size(75, 23);
            this.confirmAdd.TabIndex = 1;
            this.confirmAdd.Text = "添加";
            this.confirmAdd.UseVisualStyleBackColor = true;
            this.confirmAdd.Click += new System.EventHandler(this.confirmAdd_Click);
            // 
            // refuseAdd
            // 
            this.refuseAdd.Location = new System.Drawing.Point(181, 151);
            this.refuseAdd.Name = "refuseAdd";
            this.refuseAdd.Size = new System.Drawing.Size(75, 23);
            this.refuseAdd.TabIndex = 2;
            this.refuseAdd.Text = "拒绝";
            this.refuseAdd.UseVisualStyleBackColor = true;
            this.refuseAdd.Click += new System.EventHandler(this.refuseAdd_Click);
            // 
            // AddRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.refuseAdd);
            this.Controls.Add(this.confirmAdd);
            this.Controls.Add(this.addfriendMessage);
            this.Name = "AddRemind";
            this.Text = "AddRemind";
            this.Load += new System.EventHandler(this.AddRemind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addfriendMessage;
        private System.Windows.Forms.Button confirmAdd;
        private System.Windows.Forms.Button refuseAdd;
    }
}