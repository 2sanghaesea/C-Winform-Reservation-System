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
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;

namespace WindowsFormsApp1
{
  
    public partial class Login : Form
    {
        public static string mem_num;
        public static string mem_name;
        public static string mem_grade;
        public static string mem_card;
        public static string mem_phonenum;

        //이번에 데이터 보내깃!
       
       

        public Login()
        {
            InitializeComponent();
            label3.Hide();
            textBox1.Hide();

        }

        

        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=train;User ID=train"; //oracle 서버 연결

        private void button4_Click(object sender, EventArgs e)//로그인
        {
           
            conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                
                cmd.CommandText = "select * from 회원 where 회원이름 = '"+Id_text.Text+"'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                

                if (!(read.Read()))
                    Label_Error.Text = "존재하지 않는 아이디입니다.";
                else//보안
                {

                    string value = pw_text.Text;

                    SHA256 hash = new SHA256Managed();
                    byte[] bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(value));

                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in bytes)
                        sb.AppendFormat("{0:x2}", b);

                    String pw = sb.ToString();

                    textBox1.Text = read.GetValue(0).ToString();

                    if (read.GetValue(5).ToString() != pw)
                    {
                        Label_Error.Text = "비밀번호가 일치하지 않습니다.";
                    }

                    else if (read.GetValue(3).ToString() == "")
                    {
                        Label_Error.Text = "관리자의 승인이 아직 안된 계정 입니다.";
                    }
                    else
                    {


                        
                        mem_num = read.GetValue(0).ToString();
                        mem_card = read.GetValue(4).ToString();
                        mem_grade = read.GetValue(3).ToString();
                        mem_name = read.GetValue(1).ToString();
                        mem_phonenum = read.GetValue(2).ToString();

                        if (Id_text.Text == "admin1")
                        {
                            MessageBox.Show("관리자 계정입니다.");
                            this.Visible = false;
                            Admin_page frm1 = new Admin_page();
                            frm1.ShowDialog();
                        }
                        else
                        {
                            
                            
                            MessageBox.Show(Id_text.Text + "님 환영합니다.");
                            this.Visible = false;
/*
                            DataPassEvent(textBox1.Text);*/
                            User_Main frm1 = new User_Main();

                            frm1.ShowDialog();
                        }

                    }



                }
                

                read.Close();
             
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(showpw_combo.Checked == true)
            {
                pw_text.PasswordChar = default(char); //콤보박스 체크시 비밀번호 보이게
            }
            else
            {
                pw_text.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//회원가입
        {
            Register_page frm = new Register_page();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
   
        }

        private void Id_btn_Click(object sender, EventArgs e)
        {/*
            ID_CHECK f = new ID_CHECK();
            f.ShowDialog();*/
        }

        private void pw_btn_Click(object sender, EventArgs e)
        {
            /*PW_CHECK f = new PW_CHECK();
            f.ShowDialog();*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
