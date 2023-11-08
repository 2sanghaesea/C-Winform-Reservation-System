using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin_page : Form
    {
        public Admin_page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//회원관리
        {
            Admin_Manage_Member frm = new Admin_Manage_Member();
            frm.ShowDialog();
        }

        private void Schedule_btn_Click(object sender, EventArgs e)
        {
            Admin_Train_Schedule frm = new Admin_Train_Schedule();
            frm.ShowDialog();
        }

        private void Rsv_Btn_Click(object sender, EventArgs e)
        {
            AdminCheck_Rsrv frm = new AdminCheck_Rsrv();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin_train_Sign_up frm2 = new Admin_train_Sign_up();
            frm2.ShowDialog();
        }
    }
}
