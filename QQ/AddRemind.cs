using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QQ
{
    public partial class AddRemind : Form
    {
        public AddRemind()
        {
            InitializeComponent();
        }
        public MainForm mainform;
        DataOperator dataoper = new DataOperator();

        private void AddRemind_Load(object sender, EventArgs e)
        {
            if (MainForm.fid2 == 0)
            {
                addfriendMessage.Text = string.Format(" 暂无添加好友的消息", MainForm.fid2);
                confirmAdd.Visible = false;
                refuseAdd.Visible = false;
            }
            else
            {
                addfriendMessage.Text = string.Format(" 用户:{0} 请求添加你为好友", MainForm.fid2);
                confirmAdd.Visible = true;
                refuseAdd.Visible = true;
            }            
        }

        private void confirmAdd_Click(object sender, EventArgs e)
        {            

            string sql = "insert into Friend (HostID, FriendID) values(" + PublicNum.LoginIdnum + "," + MainForm.fid2 + ")";
            int result = dataoper.ExecuteSqlResult(sql);
            dataoper.ExecuteSqlResult("update Message set MessageState = 1 where FromUserID = "+ MainForm.fid2+"and ToUserID = "+PublicNum.LoginIdnum + "and MessageTypeID = 2");
            if (result == 1)
            {
                MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainform.ShowFriendList();
                MainForm.fid2 = 0;
                mainform.timer_AddFriend_Remind.Stop();
                mainform.ShowHorn();

            }
        }

        private void refuseAdd_Click(object sender, EventArgs e)
        {
            string sql = "update Message set MessageState=1 where FromUserID="+ MainForm.fid2+"and ToUserID="+PublicNum.LoginIdnum + "and MessageTypeID=2";
            int result = dataoper.ExecuteSqlResult(sql);
            if (result == 1)
            {
                MessageBox.Show("已经拒绝添加", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                MainForm.fid2 = 0;
                mainform.timer_AddFriend_Remind.Stop();
                mainform.ShowHorn();
            }
        }
    }
}
