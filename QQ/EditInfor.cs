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
    public partial class EditInforForm : Form
    {
        public EditInforForm()
        {
            InitializeComponent();
        }
        DataOperator dataoper = new DataOperator();
        public MainForm mainform;    
        
        private void EditInforForm_Load(object sender, EventArgs e)
        {
            int hid = 0;
            int friendLimitID = 0;            
            string sql = "select * from UserInfor where ID=" + PublicNum.LoginIdnum + "";
            SqlDataReader datareader = dataoper.GetDataReader(sql);
            if (datareader.Read())
            {
                UID.Text = datareader["ID"].ToString();
                nickName.Text = datareader["NickName"].ToString(); 
                sex.Text = datareader["Sex"].ToString(); 
                if (!(datareader["Name"] is DBNull))
                {
                    realName.Text = datareader["Name"].ToString();
                }
                age.Text = datareader["Age"].ToString();
                originPwd.Text = datareader["Pwd"].ToString();
                if (!(datareader["Star"] is DBNull))
                {
                    star.Text = datareader["Star"].ToString();
                }
                if (!(datareader["BloodType"] is DBNull))
                {
                    blood.Text = datareader["BloodType"].ToString();
                }
                hid = Convert.ToInt32(datareader["HeadID"]) ;
                friendLimitID = Convert.ToInt32(datareader["FriendLimitID"]); 
            }
            DataOperator.conn.Close();
            ShowHead(hid);
            switch (friendLimitID)
            {
                case 1:
                    rbAllow.Checked = true;
                    break;
                case 2:
                    rbVerify.Checked = true;
                    break;
                case 3:
                    rbNotAllow.Checked = true;
                    break;
                default:
                    rbAllow.Checked = true;
                    break;
            }
        }

        public void ShowHead(int hid)//
        {
            pbHead.Image = imageList.Images[hid];
            pbHead.Tag = hid;
        }

        private void chooseHead_Click(object sender, EventArgs e)
        {
            HeadForm headform= new HeadForm();
            headform.editInfor = this;
            headform.Show();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string sql = GetUpdateSQL();//获取更新SQL语句 
                int result = dataoper.ExecuteSqlResult(sql);
                if (result == 1)
                {
                    MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("数据保存失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                mainform.ShowInfor();                
                this.Close();
            }
        }

        private string GetUpdateSQL()
        {
            string sql = string.Format("update UserInfor set NickName='{0}', HeadID={1},Sex='{2}',Age={3}",
               nickName.Text.Trim(), Convert.ToInt32(pbHead.Tag) ,sex.Text, Convert.ToInt32(age.Text.Trim()));
            if (newPwd.Text.Trim() != "")//判断是否修改了密码
            {
                sql = string.Format("{0} ,Pwd='{1}',Remember=0,AutoLogin=0 ", sql, newPwd.Text.Trim());
            }
            int friendLimitID = 0;
            if (rbAllow.Checked)
            {
                friendLimitID = Convert.ToInt32(rbAllow.Tag);
            }
            else if (rbVerify.Checked)
            {
                friendLimitID = Convert.ToInt32(rbVerify.Tag);
            }
            else if (rbNotAllow.Checked)
            {
                friendLimitID = Convert.ToInt32(rbNotAllow.Tag);
            }
            //拼接更新个人信息的SQL语句
            sql = string.Format("{0},FriendLimitID={1},Name='{2}',Star='{3}',BloodType='{4}' where ID={5}",
                sql, friendLimitID, realName.Text.Trim(), star.Text, blood.Text, PublicNum.LoginIdnum);
            return sql;
        }

        private bool ValidateInput()
        {
            if (nickName.Text.Trim() == "" || nickName.Text.Length > 20)
            {
                MessageBox.Show("昵称输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nickName.Focus();
                return false;
            }
            if (age.Text.Trim() == "")
            {
                MessageBox.Show("请输入年龄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                age.Focus();
                return false;
            }
            if (sex.Text.Trim() == "")
            {
                MessageBox.Show("请输入选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sex.Focus();
                return false;
            }
            if (newPwd.Text.Trim() != confirmPwd.Text.Trim())  
            {
                MessageBox.Show("两次输入的密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newPwd.Focus();
                return false;
            }
            return true;
        }
    }
}
