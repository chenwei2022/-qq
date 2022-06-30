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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            star.SelectedIndex = blood.SelectedIndex = 0;
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (nickName.Text.Trim() == "" || nickName.Text.Length > 20)
            {
                MessageBox.Show("昵称输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nickName.Focus();
                return;
            }
            if (age.Text.Trim() == "")
            {
                MessageBox.Show("请输入年龄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                age.Focus();
                return;
            }
            if (!raMan.Checked && !raWoman.Checked)
            {
                MessageBox.Show("请选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //sex.Focus();
                return;
            }
            if (pwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pwd.Focus();
                return;
            }
            if (confirmPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                confirmPwd.Focus();
                return;
            }
            if (pwd.Text.Trim() != confirmPwd.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一样！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                confirmPwd.Focus();
                return;
            }
            int myQQNum = 0;
            string message;
            string sex = raMan.Checked ? raMan.Text : raWoman.Text; 
            string sql = string.Format("insert into UserInfor (Pwd, NickName, Sex, Age, Name, Star, BloodType,Flag,FriendLimitID,HeadID,Remember,AutoLogin,Sign) " +
                "values ('{0}','{1}','{2}',{3},'{4}','{5}','{6}',0,1,0,0,0,'输入签名');select @@Identity from UserInfor",
                pwd.Text.Trim(), nickName.Text.Trim(), sex, int.Parse(age.Text.Trim()), realName.Text.Trim(), star.Text, blood.Text);
            SqlCommand command = new SqlCommand(sql, DataOperator.conn);
            DataOperator.conn.Open();
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                sql = "select SCOPE_IDENTITY() from UserInfor";//查询新增加的记录的标识号
                command = new SqlCommand(sql, DataOperator.conn);
                myQQNum = Convert.ToInt32(command.ExecuteScalar());//获取最新增加的账号
                message = string.Format("注册成功！你的MyQQ号码是" + myQQNum);
            }
            else
            {
                message = "注册失败，请重试！";
            }
            DataOperator.conn.Close();
            MessageBox.Show(message, "注册结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
