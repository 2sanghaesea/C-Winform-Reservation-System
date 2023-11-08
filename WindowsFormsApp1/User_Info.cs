using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class User_Info : Form
    {
        OleDbConnection conn;
        string connectionString;
        
        public User_Info()
        {
            InitializeComponent();
            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            textBox1.Text = Login.mem_name;
            textBox2.Text = Login.mem_phonenum;
            textBox3.Text = Login.mem_card;
            label5.Text = Login.mem_grade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "UPDATE 회원 SET 회원이름 ='" + textBox1.Text + "',휴대전화 ='" + textBox2.Text + "',카드번호 ='" + textBox3.Text + "' where 회원번호 =" + Login.mem_num;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("정보가 변경되었습니다.");
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from 회원 where 회원번호 =" +Login.mem_num;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("회원 탈퇴가 완료되었습니다.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
