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
    public delegate void Move_Data3(string data1, string data2, string data3, string data4, string data5, string data6, string data7);
    public partial class User_Reservation_Seat : Form
    {
      
        OleDbConnection conn;
        string connectionString;

      
        public User_Reservation_Seat()
        {
            InitializeComponent();
            groupBox2.Hide();
            dataGridView2.Hide();
            label8.Text = Login.mem_num;

            connectionString = "Provider=MSDAORA;Password=train;User ID=train"; //oracle 서버 연결
            conn = new OleDbConnection(connectionString);

            
            try
            {

                conn.Open();
                OleDbCommand cmd6 = new OleDbCommand();
                cmd6.CommandText = "select a.예약번호, b.열차번호, b.열차종류,  b.좌석번호, b.시간, a.출발역, a.도착역, a.요금, a.결제방법 from 예약현황 a, 예약좌석 b where a.예약번호 = b.예약번호 and a.회원번호 =" + label8.Text +"and a.요금 = b.요금";
                cmd6.CommandType = CommandType.Text;
                cmd6.Connection = conn;

                OleDbDataReader read = cmd6.ExecuteReader();
                dataGridView1.ColumnCount = 9;

                for (int i = 0; i < 9; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                while (read.Read())
                {
                    object[] obj1 = new object[9];

                    for (int i = 0; i < 9; i++)
                    {
                        obj1[i] = new object();
                        obj1[i] = read.GetValue(i);
                    }

                    dataGridView1.Rows.Add(obj1);
                }
                read.Close();

            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            conn.Close();
        }
     

        private void Reservation_Seat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    conn.Open();
                    OleDbCommand cmd2 = new OleDbCommand();

                    cmd2.CommandText = "delete from 예약좌석 where 예약번호 =" + Rsv_Num.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Connection = conn;
                    cmd2.ExecuteNonQuery();
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
                MessageBox.Show("예약이 취소되었습니다.");
            
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            groupBox2.Show();
            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd6 = new OleDbCommand();
                cmd6.CommandText = "select * from 예약좌석 where 열차번호 =" + TrainNum.Text + " and 출발역='" + Start.Text + "' and 도착역 ='" + End.Text + "'and 시간='" + Timetxt.Text + "'";
                cmd6.Connection = conn;

                OleDbDataReader read = cmd6.ExecuteReader();
                dataGridView2.ColumnCount = 9;

                for (int i = 0; i < 9; i++)
                {
                    dataGridView2.Columns[i].Name = read.GetName(i);
                }

                while (read.Read())
                {
                    object[] obj1 = new object[9];

                    for (int i = 0; i < 9; i++)
                    {
                        obj1[i] = new object();
                        obj1[i] = read.GetValue(i);
                    }

                    dataGridView2.Rows.Add(obj1);
                }

                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {
                    if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "1")
                    {
                        S_1.Hide();

                    }
                    else if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "2")
                    {
                        S_2.Hide();

                    }
                    else if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "3")
                    {
                        S_3.Hide();

                    }
                    else if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "4")
                    {
                        S_4.Hide();

                    }
                    else if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "5")
                    {
                        S_5.Hide();
                    }
                    else if (dataGridView2.Rows[i].Cells[1].Value.ToString() == "6")
                    {
                        S_6.Hide();
                    }
                    else
                    {

                    }
                }

                read.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rsv_Num.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TrainNum.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Train_Type.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Seat_Num.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Timetxt.Text=dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Start.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            End.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Price.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Howpay.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 좌석을 변경하시겠습니까?", "변경 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd2 = new OleDbCommand();

                    cmd2.CommandText = "update set 좌석번호 =" + "from 예약좌석 where 예약번호 =" + Rsv_Num.Text +"and 좌석번호 = " + Seat_Num.Text;
                    cmd2.CommandType = CommandType.Text;
                    cmd2.Connection = conn;
                    cmd2.ExecuteNonQuery();
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
                MessageBox.Show("좌석이 변경되었습니다.");
            }
        }

       
    }
}
