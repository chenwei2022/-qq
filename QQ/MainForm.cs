using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace QQ
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        DataOperator dataoper = new DataOperator();
        int messageindex = 0;
        int fid = 0;
        public static int fid2 = 0;//addremind中用到
        int messagetype = 1;
        public static int Hid = 0;
        public static int Fhid = 0;
        public static string strflag = "[离线]";
        public static string nickname = "";//ChatForm中用到
        //public static int messageID = 0;
        ChatForm chatform;


        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowInfor();
            ShowFriendList();
            ShowHorn();
        }

        public void ShowHorn()
        {
            ts_Message.Image = image_Message.Images[0];
        }

        public void ShowInfor()//另一个窗体用到
        {
            string sql = "select * from UserInfor where ID=" + PublicNum.LoginIdnum;
            SqlDataReader da = dataoper.GetDataReader(sql);
            if (da.Read())
            {
                NickName.Text = nickname = da["NickName"].ToString();
                Sign.Text = da["Sign"].ToString();
                Hid = int.Parse(da["HeadID"].ToString());//
                 HeadPx.Image = imageHead.Images[Hid];
            }
            DataOperator.conn.Close();
            da.Close();
        }

        public void ShowFriendList()//remind窗体用到
        {
            lvShowFriend.Items.Clear();
            string sql = "select FriendID,NickName,Flag,HeadID from UserInfor,Friend where Friend.HostID=" + PublicNum.LoginIdnum + "and Friend.FriendID=UserInfor.ID";
            SqlDataReader da = dataoper.GetDataReader(sql);
            int index = 0;
            while (da.Read())
            {
                if (da["Flag"].ToString() == "0")
                    strflag = "[离线]";
                else
                    strflag = "[在线]";
                lvShowFriend.Items.Add(da["FriendID"].ToString(), da["NickName"].ToString() + strflag, (int)da["HeadID"]);
                lvShowFriend.Items[index++].Group = lvShowFriend.Groups[0];
            }
            DataOperator.conn.Close();
            da.Close();
        }

        private void timer_Getmessage_Tick(object sender, EventArgs e)
        {
            string sql = "select Top 1 FromUserID,Message,MessageTypeID,MessageState from Message where ToUserID=" + PublicNum.LoginIdnum + "and MessageState=0";
            SqlDataReader dr = dataoper.GetDataReader(sql);
            if (dr.Read())
            {
                if (lvShowFriend.SelectedItems.Count > 0)
                {
                    if (lvShowFriend.SelectedItems[0].Group == lvShowFriend.Groups[0])
                    {
                        ts_Delete.Visible = true;
                        ts_AddFriend.Visible = false;
                    }
                    else if (lvShowFriend.SelectedItems[0].Group == lvShowFriend.Groups[1])
                    {
                        ts_Delete.Visible = false;
                        ts_AddFriend.Visible = true;
                    }
                }
                fid = (int)dr["FromUserID"];
                messagetype = (int)dr["MessageTypeID"];
                DataOperator.conn.Close();
                dr.Close();
                if (messagetype == 2)
                {

                    SoundPlayer player = new SoundPlayer("system.wav");
                    player.Play();
                    timer_AddFriend_Remind.Start();
                    fid2 = fid;
                    //MessageBox.Show("测试");
                }
                else if (messagetype == 1)
                {
                    if (!HasShowUser(fid))
                    {
                        UpdateStranger(fid);
                    }

                    string s = "select HeadID from UserInfor where ID=" + fid;
                    Fhid = dataoper.ExecuteSql(s);
                    SoundPlayer player = new SoundPlayer("msg.wav");
                    player.Play();
                    timer_HeadTwinkle.Start();
                }
            }
            else
                dr.Close();//
        }

        private void UpdateStranger(int fid)
        {
            //lvShowFriend.Groups[1].Items.Clear();//清空原来的列表
            string sql = "select NickName, HeadID from UserInfor where ID=" + fid;
            SqlDataReader dataReader = dataoper.GetDataReader(sql);
            int i = lvShowFriend.Items.Count;//从原始列表上添加            
            dataReader.Read();            
            lvShowFriend.Items.Add(fid.ToString(), dataReader["NickName"].ToString(), (int)dataReader["HeadID"]);
            lvShowFriend.Items[i++].Group = lvShowFriend.Groups[1];//设置项的分组为陌生人               
            
            dataReader.Close();
            DataOperator.conn.Close();

        }

        private bool HasShowUser(int fid)
        {
            //for (int i = 0; i < 2; i++)仅有一个列表
                for (int j = 0; j < lvShowFriend.Items.Count; j++)
                {
                    if (Convert.ToInt32(lvShowFriend.Items[j].Name) == fid)
                        return true;
                }
            return false;
        }

        private void timer_HeadTwinkle_Tick(object sender, EventArgs e)//不需要限制成groups[0]
        {
            for (int index = 0; index < lvShowFriend.Items.Count; index++)
            {
                if (fid.ToString() == lvShowFriend.Items[index].Name)
                {
                    if (chatform != null /*&& chatform.chat_fid != 0*/)
                        lvShowFriend.Items[index].ImageIndex = Fhid;
                    else
                    {
                        if (lvShowFriend.Items[index].ImageIndex < 4)

                            lvShowFriend.Items[index].ImageIndex = 4;

                        else
                            lvShowFriend.Items[index].ImageIndex = Fhid;
                    }
                }
            }
        }

       

       

        

        public void timer_AddFriend_Remind_Tick(object sender, EventArgs e)
        {

            ts_Message.Image = image_Message.Images[messageindex = (messageindex == 1 ? 0 : 1)];
            //MessageBox.Show("测试");
        }

       

       

        private void lvShowFriend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvShowFriend.SelectedItems.Count > 0)
            {

                if (chatform == null)
                {
                    chatform = new ChatForm();
                    chatform.fid = Convert.ToInt32(lvShowFriend.SelectedItems[0].Name);                    
                    chatform.nickname = dataoper.GetDataSet(
                        "select NickName from UserInfor where ID=" + chatform.fid).Tables[0].Rows[0][0].ToString();                    
                    chatform.fhid = Convert.ToInt32(dataoper.GetDataSet(
                        "select HeadID from UserInfor where ID=" + chatform.fid).Tables[0].Rows[0][0]);//需要重新获取fhid,定时器的fhid一直在变
                    chatform.ShowDialog();//
                    chatform = null;//
                }
                if (timer_HeadTwinkle.Enabled == true)
                {
                    timer_HeadTwinkle.Stop();                    
                    lvShowFriend.SelectedItems[0].ImageIndex = dataoper.ExecuteSql(
                        "select HeadID from UserInfor where ID=" + Convert.ToInt32(lvShowFriend.SelectedItems[0].Name));
                }

            }
        }

        private void ts_Infor_Click(object sender, EventArgs e)
        {
            EditInforForm editInfo = new EditInforForm();
            editInfo.mainform = this;  //将当前窗体对象传给个人信息窗体,修改信息的时候用到
            editInfo.Show();
        }

        private void ts_Update_Click(object sender, EventArgs e)
        {
            ShowFriendList();
        }

        private void ts_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确实要退出吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void ts_AddFriend_Click(object sender, EventArgs e)
        {
            if (lvShowFriend.SelectedItems.Count > 0)
            {      
                int limit = dataoper.ExecuteSql("select FriendLimitID from UserInfor where ID=" + Convert.ToInt32(lvShowFriend.SelectedItems[0].Name));
                if (limit == 2)
                    MessageBox.Show("对方拒绝添加好友", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                else if (limit == 1)
                {
                    DialogResult re = MessageBox.Show("确实要添加为好友吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        string sl = "insert into message (FromUserID,ToUserID,Message,MessageTypeID,MessageState) values (" + PublicNum.LoginIdnum + "," + Convert.ToInt32(lvShowFriend.SelectedItems[0].Name) + ",0,2,0)";
                        int deleteResult = dataoper.ExecuteSqlResult(sl);
                        if (deleteResult == 1)
                            MessageBox.Show("已经发送添加好友请求", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else if (limit == 0)
                {
                    string sql = "insert into Friend (HostID, FriendID) values(" + PublicNum.LoginIdnum + "," + Convert.ToInt32(lvShowFriend.SelectedItems[0].Name) + ")";
                    int result = dataoper.ExecuteSqlResult(sql);
                    if (result == 1)
                    {
                        MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowFriendList();             
                    }                   
                }
                
                
            }
        }

        private void ts_Delete_Click(object sender, EventArgs e)
        {
            if (lvShowFriend.SelectedItems.Count > 0)
            {               
                DialogResult result = MessageBox.Show("确实要删除该好友吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    string sql = "delete from Friend where HostID=" + PublicNum.LoginIdnum + " and FriendID=" + Convert.ToInt32(lvShowFriend.SelectedItems[0].Name) + "";
                    int deleteResult = dataoper.ExecuteSqlResult(sql);
                    if (deleteResult == 1)
                    {
                        MessageBox.Show("好友已删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lvShowFriend.Items.Remove(lvShowFriend.SelectedItems[0]);
                    }
                }
            }
        }

        private void ts_Message_Click(object sender, EventArgs e)
        {
            AddRemind addremind = new AddRemind();
            addremind.mainform = this;
            addremind.Show();
        }

        private void ts_Searchfriend_Click(object sender, EventArgs e)
        {
            SearchForm searchform = new SearchForm();
            searchform.mainform = this;
            searchform.Show();
        }
    }
}
