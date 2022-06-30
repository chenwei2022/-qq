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
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }
        public int fid = 0;
        public string nickname;
        public int fhid;    
        DataOperator dataoper = new DataOperator();

        private void ChatForm_Load(object sender, EventArgs e)
        {
            this.Text = "与\"" + nickname + "\"聊天中";
            FriendHead.Image = imageList.Images[fhid];
            NickAndID.Text = string.Format("{0}({1})", nickname, fid);
            ChatText.ScrollToCaret();//滑轮到最底端
        }

        private void MessageLog_MouseClick(object sender, MouseEventArgs e)
        {
            ChatText.Clear();
            /*string messageID = "";*/
            string message;
            string messageTime;            
            string sql = "select Message.ID,Message,MessageTime,NickName from Message,UserInfor" +
                " where (FromUserID=" + fid + " and ToUserID=" + PublicNum.LoginIdnum + "and FromUserID=UserInfor.ID)" +
                " or (FromUserID=" + PublicNum.LoginIdnum + " and ToUserID=" + fid + "and FromUserID=UserInfor.ID ) " +
                "order by MessageTime asc ";//需要联合UserInfor表查出NickName
            SqlDataReader dr = dataoper.GetDataReader(sql);            
            while (dr.Read())
            {
                /*messageID += dr["ID"] + "_";*/
                message = dr["Message"].ToString();
                messageTime = Convert.ToDateTime(dr["MessageTime"]).ToString();                
                ChatText.Text += "\n" + dr["NickName"] + "  " + messageTime + "\n  " + message + "";
            }
            dr.Close();
            DataOperator.conn.Close();
        }

        private void timer_GetMessage_Tick(object sender, EventArgs e)
        {
            string messageID = "";
            string message;
            string messageTime;           
            string sql = "select ID,Message,MessageTime from Message where FromUserID=" + fid + " and ToUserID=" + PublicNum.LoginIdnum + " and MessageTypeID=1 and MessageState=0";
            SqlDataReader dr = dataoper.GetDataReader(sql);            
            while (dr.Read())
            {
                messageID += dr["ID"] + "_";
                message = dr["Message"].ToString();
                messageTime = Convert.ToDateTime(dr["MessageTime"]).ToString();                
                ChatText.Text += "\n" + nickname + "  " + messageTime + "\n  " + message + "";
            }
            DataOperator.conn.Close();
            dr.Close();
            if (messageID.Length > 1)
            {
                messageID.Remove(messageID.Length - 1);//去掉最后的连接符
                SetMessage(messageID);
            }

        }

        private void SetMessage(string messageID)
        {
            string[] messageIDs = messageID.Split('_');
            string sql = "update Message set MessageState=1 where ID="; 
            foreach (string id in messageIDs)
            {
                if (id != "")
                {                    
                    int result = dataoper.ExecuteSql(sql+id);
                }
            }
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            if (TobeSent.Text.Trim() == "") 
            {
                MessageBox.Show("不能发送空消息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {                
                string sql = string.Format(
                    "insert into Message (FromUserID, ToUserID, Message, MessageTypeID, MessageState) values ({0},{1},'{2}',{3},{4})",
                    PublicNum.LoginIdnum, fid, TobeSent.Text, 1, 0);
                int result = dataoper.ExecuteSqlResult(sql);
                ChatText.Text += "\n" + MainForm.nickname + "  " + DateTime.Now + "\n  " + TobeSent.Text + "";
                if (result != 1)
                {
                    MessageBox.Show("消息发送失败，请重新发送！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TobeSent.Text = "";  
                TobeSent.Focus();
            }
        }

        private void TobeSent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 13)
            {
                e.Handled = true;
                SendMessage_Click(this, null);
            }
        }
    }
}
