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
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Register_page : Form
    {
        public Register_page()
        {
            InitializeComponent();
        }

        bool idcheck = false;
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=train;User ID=train";

        private void label2_Click(object sender, EventArgs e) 
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//phone num text
        {

        }

        private void member_name_Click(object sender, EventArgs e)
        {

        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void idcheck_btn_Click(object sender, EventArgs e) //중복확인
        {
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "select * from 회원 where 회원이름 = '" + name_text.Text + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                if (!(read.Read()))
                {
                    idcheck = true;
                    MessageBox.Show("사용가능한 ID입니다.");
                }
                else
                {
                    MessageBox.Show("해당 ID가 이미 존재합니다.");
                }
                read.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void register_btn_Click(object sender, EventArgs e) //회원가입
        {
            /*if (!idcheck)
            {
                MessageBox.Show("ID 중복확인을 해주세요");
                return;
            }*/
            if (!(phonenum.Text.ToString().Equals("")) && !(name_text.Text.ToString().Equals("")) && !(pw_text.Text.ToString().Equals("")))
            {
                conn = new OleDbConnection(connectionString);

                try
                {
                    string value = pw_text.Text;
                    SHA256 hash = new SHA256Managed();
                    byte[] bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(value));

                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in bytes)
                        sb.AppendFormat("{0:x2}", b);

                    String password = sb.ToString();

                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();

                    Random rand = new Random();
                    int i = rand.Next(2,999);
                    cmd.CommandText = "INSERT INTO 회원 VALUES(" + i + ", '" + name_text.Text + "','" + phonenum.Text + "',DEFAULT,'"+cardnum_text.Text+"','" + password + "')";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("관리자의 승인을 기다리세요");
                    i++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
                Dispose(true);
            }
            else
            {
                MessageBox.Show("누락된 항목이 있습니다. ");
            }
        }
    }
}
