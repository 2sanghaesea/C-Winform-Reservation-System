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
using System.Collections;
namespace WindowsFormsApp1
{


    public partial class Reservation : Form
    {

        OleDbConnection conn;
        string connectionString;

        public Reservation()
        {

            InitializeComponent();
            groupBox2.Hide();
            label12.Hide();//현재 시각 숨기기
            label13.Hide();//회원 번호 숨기기
            dataGridView2.Hide();
            label14.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Start_text.Text = User_Check_Schedule.Start_station;
            End_text.Text = User_Check_Schedule.End_station;
            TrainNum_text.Text = User_Check_Schedule.Train_number;
            Grade_text.Text = User_Check_Schedule.Train_type;
            Time_text.Text = User_Check_Schedule.Train_time;
            Price_text.Text = User_Check_Schedule.Train_Price;
            label13.Text = Login.mem_num;
            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            conn = new OleDbConnection(connectionString);


            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();

                cmd.CommandText = "select * from 운행시간표";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;


                OleDbDataReader read = cmd.ExecuteReader();
                dataGridView1.ColumnCount = 6;

                for (int i = 0; i < 6; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                while (read.Read())
                {
                    object[] obj1 = new object[6];

                    for (int i = 0; i < 6; i++)
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
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        
        private void button2_Click(object sender, EventArgs e) //검색 키
        {
            MessageBox.Show(S_1.Name);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                if (SourceStation_combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차번호, 열차종류, 운행시간 ,요금 from 운행시간표 where 도착역 ='" + DestStation_combo.Text + "' and 열차종류 ='" + Train_Type_Combo.Text + "'";
                }
                else if (DestStation_combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차번호, 열차종류, 운행시간 ,요금 from 운행시간표 where 출발역 ='" + SourceStation_combo.Text + "' and 열차종류 ='" + Train_Type_Combo.Text + "'";
                }
                else if (Train_Type_Combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차번호, 열차종류, 운행시간 ,요금 from 운행시간표 where 출발역 ='" + SourceStation_combo.Text + "' and 도착역 ='" + DestStation_combo.Text + "'";
                }
                else if (SourceStation_combo.Text == "" && DestStation_combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차번호, 열차종류, 운행시간 ,요금 from 운행시간표 where 열차종류 ='" + Train_Type_Combo.Text + "'";
                }
                else if (DestStation_combo.Text == "" && Train_Type_Combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차번호, 열차종류, 운행시간 ,요금 from 운행시간표 where 출발역 ='" + SourceStation_combo.Text + "'";
                }
                else if (Train_Type_Combo.Text == "" && SourceStation_combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차번호, 열차종류, 운행시간 ,요금 from 운행시간표 where 도착역 ='" + DestStation_combo.Text + "'";
                }
                else if (Train_Type_Combo.Text == "" && SourceStation_combo.Text == "" && SourceStation_combo.Text == "")
                {
                    MessageBox.Show("검색하시려면 항목을 하나라도 기입하세요");
                }
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 6;

                for (int i = 0; i < 6; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }
                while (read.Read())
                {
                    object[] obj1 = new object[6];
                    for (int i = 0; i < 5; i++)
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


        private void Reservation_Load(object sender, EventArgs e)
        {

            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();
            ;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label12.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Start_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            End_text.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TrainNum_text.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Grade_text.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Time_text.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Price_text.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }


        int StartIndex, EndIndex;


        private void button1_Click(object sender, EventArgs e) //예약
        {


            //예약이 되어있는 좌석이면 표시하고 절대 예약 못하게 해야함 ㅇㅋ?
            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            conn = new OleDbConnection(connectionString);


            string rsvtime = DateTime.Now.ToString("yyyy-MM-dd-HH"); //예약시간
            String traingrade = "";
            if (Grade_text.Text == "새마을호")
            {
                traingrade = "SM";
            }
            else
            {
                traingrade = "MG";
            }
            conn.Open();


            try
            {
                OleDbCommand cmd = new OleDbCommand();//예약좌석
                cmd.CommandText = $"SELECT reservation_num.NEXTVAL FROM DUAL";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();
                String sequence = "";
                if (read.Read()) //시퀀스값 뺴오기
                {
                    sequence = read.GetValue(0).ToString();
                }
                conn.Close();
                String rsvnum = traingrade + rsvtime + sequence.ToString();

                conn.Open();
                bool[] check = { S_1.Checked, S_2.Checked, S_3.Checked, S_4.Checked, S_5.Checked, S_6.Checked };
                string[] Station = { "서울역", "천안역", "대전역", "대구역", "부산역" };
                ArrayList seat_checked1 = new ArrayList();

                StartIndex = Array.IndexOf(Station, textBox1.Text);
                EndIndex = Array.IndexOf(Station, textBox2.Text.ToString());

                for (int i = 0; i < 6; i++)
                {
                    if (check[i] == true)
                    {
                        seat_checked1.Add(i + 1);

                    }
                }

                cmd.CommandText = "INSERT INTO 예약현황 VALUES('" + rsvnum + "'," + label13.Text + ",'" + Grade_text.Text + "','" + Start_text.Text + "','" + End_text.Text + "','" + label12.Text + "','" + Price_text.Text + "','" + comboBox4.Text + "')";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                if (StartIndex < EndIndex)
                {
                    for (int j = 0; j < seat_checked1.Count + 1; j++) //선택한 좌석 넣기용~
                    {
                        for (int s = StartIndex; s < EndIndex; s++) //시작역 인덱스 부터 도착역 인덱스까지 반복
                        {
                            for (int m = EndIndex; m > StartIndex; m--)//도착역 인덱스부터 시작역 인덱스 까지 반복
                            {
                                if (s != m && s < m) //시작역/도착역의 인덱스가 같지 않을때
                                {
                                    cmd.CommandText = "INSERT INTO 예약좌석 VALUES(" + TrainNum_text.Text + "," + seat_checked1[j] + ",'" + Station[s] + "','" + Station[m] + "','" + Grade_text.Text + "',(select 요금 from 요금표 where  출발역 ='" + Station[s] + "' and 도착역 ='" + Station[m] + "' and 열차종류 ='" + Grade_text.Text + "'),'" + Time_text.Text + "','" + rsvnum + "'," + label13.Text + ")";
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Connection = conn;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                else if (StartIndex > EndIndex) {
                    for (int j = 0; j < seat_checked1.Count + 1; j++) //선택한 좌석 넣기용~
                    {
                        for (int s = StartIndex; s > EndIndex; s--) //시작역 인덱스 부터 도착역 인덱스까지 반복
                        {
                            for (int m = EndIndex; m < StartIndex; m++)//도착역 인덱스부터 시작역 인덱스 까지 반복
                            {
                                if (s != m && s>m) //시작역/도착역의 인덱스가 같지 않을때
                                {
                                    cmd.CommandText = "INSERT INTO 예약좌석 VALUES(" + TrainNum_text.Text + "," + seat_checked1[j] + ",'" + Station[s] + "','" + Station[m] + "','" + Grade_text.Text + "',(select 요금 from 요금표 where  출발역 ='" + Station[s] + "' and 도착역 ='" + Station[m] + "' and 열차종류 ='" + Grade_text.Text + "'),'" + Time_text.Text + "','" + rsvnum + "'," + label13.Text + ")";
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Connection = conn;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            
                conn.Close();
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
            MessageBox.Show("예약이 완료되었습니다.");
        }

        private void Grade_text_TextChanged(object sender, EventArgs e)
        {
            if (Grade_text.Text == "무궁화호")
            {
                S_5.Hide();
                S_6.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            textBox1.Text = Start_text.Text;
            textBox2.Text = End_text.Text;

            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd6 = new OleDbCommand();
                cmd6.CommandText = "select * from 예약좌석 where 열차번호 =" + TrainNum_text.Text + " and 출발역='" + Start_text.Text + "' and 도착역 ='" + End_text.Text + "'and 시간='" + Time_text.Text + "'";
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
    }
}
