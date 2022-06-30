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
    public partial class HeadForm : Form
    {
        public HeadForm()
        {
            InitializeComponent();
        }
        public EditInforForm editInfor;

        private void HeadForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                lvHead.Items.Add(i.ToString());
                lvHead.Items[i].ImageIndex = i;
            }
        }

        private void confirmHead_Click(object sender, EventArgs e)
        {
            if(lvHead.SelectedItems.Count != 0)
            {
                int hid = lvHead.SelectedItems[0].ImageIndex;
                editInfor.ShowHead(hid);
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择一个头像！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
