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

    
    public partial class Admin_Manage_Member : Form
    {
        OleDbConnection conn;
        string connectionString;


        public Admin_Manage_Member()
        {
           
            InitializeComponent();
            AgreeMem_list.Rows.Clear();
            connectionString = "Provider=MSDAORA;Password=train;User ID=train";

            conn = new OleDbConnection(connectionString);
            conn.Open();
            updatedb();
        }

        private void AgreeMem_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grade_box.Text.ToString().Equals(""))
            {
                Mem_num.Text = AgreeMem_list.Rows[e.RowIndex].Cells[0].Value.ToString();
                Mem_name.Text = AgreeMem_list.Rows[e.RowIndex].Cells[1].Value.ToString();
                Phone_num.Text = AgreeMem_list.Rows[e.RowIndex].Cells[2].Value.ToString();
                Card_num.Text = AgreeMem_list.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void updatedb()
        {
            try
            {
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.CommandText = "select 회원번호, 회원이름, 휴대전화, 카드번호 from 회원 where 등급 IS NULL and 회원이름!='admin1'";
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = conn;

                OleDbDataReader read1 = cmd1.ExecuteReader();
                AgreeMem_list.ColumnCount = 4;

                for (int i =0; i<4; i++)
                {
                    AgreeMem_list.Columns[i].Name = read1.GetName(i);
                }

                while (read1.Read())
                {
                    object[] obj1 = new object[4];

                    for(int i=0; i<4; i++)
                    {
                        obj1[i] = new object();
                        obj1[i] = read1.GetValue(i);
                    }

                    AgreeMem_list.Rows.Add(obj1);
                }
                read1.Close();

                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.CommandText = "select 회원번호,회원이름,휴대전화,등급,카드번호 from 회원 where 등급 IS NOT NULL and 회원이름!='admin1'";
                cmd2.CommandType = CommandType.Text;
                cmd2.Connection = conn;

                OleDbDataReader read2 = cmd2.ExecuteReader();
                Member_list.ColumnCount = 5;
                
                for(int i=0; i<5; i++)
                {
                    Member_list.Columns[i].Name = read2.GetName(i);
                }
                Member_list.Rows.Clear();

                while (read2.Read())
                {
                    object[] obj2 = new object[5];

                    for(int i =0; i<5; i++)
                    {
                        obj2[i] = new object();
                        obj2[i] = read2.GetValue(i);
                    }

                    Member_list.Rows.Add(obj2);
                }

                read2.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void Member_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            MemberNumber.Text = Member_list.Rows[e.RowIndex].Cells[0].Value.ToString();
            MemberName.Text = Member_list.Rows[e.RowIndex].Cells[1].Value.ToString();
            PhoneNumber.Text = Member_list.Rows[e.RowIndex].Cells[2].Value.ToString();
            CardNumber.Text = Member_list.Rows[e.RowIndex].Cells[4].Value.ToString();
            Old_Grade.Text = Member_list.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void Accept_Mem_Btn_Click(object sender, EventArgs e)
        {
            AgreeMem_list.Rows.Clear();

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "UPDATE 회원 SET 등급 = '" + Grade_box.Text + "' where 회원번호 = " + Mem_num.Text;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                updatedb();
                MessageBox.Show("승인되었습니다.");

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

        private void Grade_Change_Btn_Click(object sender, EventArgs e)
        {
            Member_list.Rows.Clear();
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.CommandText = "UPDATE 회원 SET 등급 = '" + New_Grade.Text + "'where 회원번호 =" + MemberNumber.Text;
                cmd2.CommandType = CommandType.Text;
                cmd2.Connection = conn;

                cmd2.ExecuteNonQuery();
                updatedb();
                MessageBox.Show("등급이 변경되었습니다.");
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
    }
}
