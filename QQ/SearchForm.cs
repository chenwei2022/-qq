using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QQ
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        DataOperator dataoper = new DataOperator();
        public MainForm mainform;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            string sql = "select NickName,HeadID from UserInfor where ID=" +int.Parse(qqNum.Text.Trim());
            SqlDataReader dr = dataoper.GetDataReader(sql);
            if (dr.Read())
            {
                headPx.Image = imageHead.Images[(int)dr["HeadID"]];
                nickName.Text = dr["NickName"].ToString();
            }
            else
                MessageBox.Show("不存在此账号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            dr.Close();
            DataOperator.conn.Close();
        }

        private void addFriend_Click(object sender, EventArgs e)
        {
            string sql = "select ID from Friend where (HostID=" + PublicNum.LoginIdnum + "and FriendID=" + int.Parse(qqNum.Text.Trim()) + ") or(HostID=" + int.Parse(qqNum.Text.Trim()) + "and FriendID=" + PublicNum.LoginIdnum+")";
            SqlDataReader dr = dataoper.GetDataReader(sql);
            if (!dr.Read())
            {
                dr.Close();
                DataOperator.conn.Close();
                int limit = dataoper.ExecuteSql("select FriendLimitID from UserInfor where ID=" + int.Parse(qqNum.Text.Trim()));
                if (limit == 2)
                    MessageBox.Show("对方拒绝添加好友", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else if (limit == 1)
                {
                    DialogResult re = MessageBox.Show("确实要添加为好友吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        string sl = "insert into message (FromUserID,ToUserID,Message,MessageTypeID,MessageState) values (" + PublicNum.LoginIdnum + "," + int.Parse(qqNum.Text.Trim()) + ",0,2,0)";
                        int deleteResult = dataoper.ExecuteSqlResult(sl);
                        if (deleteResult == 1)
                            MessageBox.Show("已经发送添加好友请求", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else if (limit == 0)
                {
                    string sl = "insert into Friend (HostID, FriendID) values(" + PublicNum.LoginIdnum + "," + int.Parse(qqNum.Text.Trim()) + ")";
                    int result = dataoper.ExecuteSqlResult(sl);
                    if (result == 1)
                    {
                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mainform.ShowFriendList();
                    }
                }
            }
            else
            {
                dr.Close();
                DataOperator.conn.Close();
                MessageBox.Show("已经是好友", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
                
            


        }
    }
}
