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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        DataOperator dataoper=new DataOperator();       
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!Check_Remember.Checked)
                Check_Autologin.Checked = false;
        }
        

        private void LoginID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }
        void ValidateID()
        {
            if (Convert.ToInt32(LoginID.Text.Trim()) > 32767 || LoginID.Text.Trim() == "")
            {
                MessageBox.Show("请输入合法的账号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginID.Focus();
            }
            PublicNum.LoginIdnum = int.Parse(LoginID.Text.Trim());
        }
        
        private void LoginID_TextChanged(object sender, EventArgs e)
        {
            ValidateID();
            string sql = "select Pwd,Remember,AutoLogin from UserInfor where ID=" + int.Parse(LoginID.Text.Trim()) + "";
            DataSet ds = dataoper.GetDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1)
                {
                    LoginPassword.Text = ds.Tables[0].Rows[0][0].ToString();
                    Check_Remember.Checked = true;
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)
                    {
                        Check_Autologin.Checked = true;
                        Login_Click(sender,e);
                    }
                }
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Validate();
            string sql = "select Pwd,Remember,AutoLogin from UserInfor where ID=" + int.Parse(LoginID.Text.Trim()) + "";
            DataSet ds = dataoper.GetDataSet(sql);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("请用户不存在", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginPassword.Focus();
                return;
            }
            else if (LoginPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginPassword.Focus();
                return;
            }
            else if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 0)
            {
                if (LoginPassword.Text.Trim() != ds.Tables[0].Rows[0][0].ToString())
                {
                    MessageBox.Show("请输入正确的密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginPassword.Focus();
                    return;
                }               

            }
            string sq = "update UserInfor set Remember=" + (Check_Remember.Checked ? 1 : 0) + "where ID="+ PublicNum.LoginIdnum+"";
            string sl = "update UserInfor set AutoLogin=" + (Check_Autologin.Checked ? 1 : 0) +"where ID=" + PublicNum.LoginIdnum + "";
            string s = "update UserInfor set flag=1 where ID=" + PublicNum.LoginIdnum + "";//.....
            dataoper.ExecuteSql(sq);
            dataoper.ExecuteSql(sl);
            dataoper.ExecuteSql(s);
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Visible = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        
    }
}
