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
    public partial class User_Check_Schedule : Form
    {
        public static string Start_station;
        public static string End_station;
        public static string Train_number;
        public static string Train_time;
        public static string Train_type;
        public static string Train_Price;
        OleDbConnection conn;
        string connectionString;

        public User_Check_Schedule()
        {
            InitializeComponent();
            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            conn = new OleDbConnection(connectionString);

            try { 
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 운행시간표";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();
                dataGridView1.ColumnCount = 6;

                for(int i =0; i<6; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                while (read.Read())
                {
                    object[] obj1 = new object[6];

                    for(int i = 0; i < 6; i++)
                    {
                        obj1[i] = new object();
                        obj1[i] = read.GetValue(i);
                    }

                    dataGridView1.Rows.Add(obj1);
                }
                read.Close();

               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void User_Check_Schedule_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //타이머 간격 100ms
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("F");
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                if (SourceStation_combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차종류, 열차번호, 운행시간 ,요금 from 운행시간표 where 도착역 ='" + DestStation_combo.Text + "' and 열차종류 ='" + Train_Type_Combo.Text + "'";
                }
                else if (DestStation_combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차종류, 열차번호, 운행시간 ,요금 from 운행시간표 where 출발역 ='" + SourceStation_combo.Text + "' and 열차종류 ='" + Train_Type_Combo.Text + "'";
                }
                else if (Train_Type_Combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차종류, 열차번호, 운행시간 ,요금 from 운행시간표 where 출발역 ='" + SourceStation_combo.Text + "' and 도착역 ='" + DestStation_combo.Text + "'";
                }
                else if (SourceStation_combo.Text == "" && DestStation_combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차종류, 열차번호, 운행시간 ,요금 from 운행시간표 where 열차종류 ='" + Train_Type_Combo.Text + "'";
                }
                else if (DestStation_combo.Text == "" && Train_Type_Combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차종류, 열차번호, 운행시간 ,요금 from 운행시간표 where 출발역 ='" + SourceStation_combo.Text + "'";
                }
                else if(Train_Type_Combo.Text == "" && SourceStation_combo.Text == "")
                {
                    cmd.CommandText = "select 출발역, 도착역, 열차종류, 열차번호, 운행시간 ,요금 from 운행시간표 where 도착역 ='" + DestStation_combo.Text + "'";
                }
                else if(Train_Type_Combo.Text == "" && SourceStation_combo.Text == "" && SourceStation_combo.Text == "")
                {
                    MessageBox.Show("검색하시려면 항목을 하나라도 기입하세요");
                }
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = 6;

                for(int i =0; i<6; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }
                while (read.Read())
                {
                    object[] obj1 = new object[6];
                    for(int i =0; i<6; i++)
                    {
                        obj1[i] = new object();
                        obj1[i] = read.GetValue(i);
                        
                    }
                    dataGridView1.Rows.Add(obj1);
                }
                read.Close();
                
            }
            catch(Exception ex)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Start_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Start_station = Start_text.Text;
            End_text.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            End_station = End_text.Text;
            TrainNum_text.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Train_number = TrainNum_text.Text;
            Grade_text.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Train_type = Grade_text.Text;
            Time_text.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Train_time = Time_text.Text;
            Price_text.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Train_Price = Price_text.Text;
        }

        private void Rsv_button_Click(object sender, EventArgs e)
        {
            Reservation frm = new Reservation();
            frm.ShowDialog();
        }

        private void Grade_text_TextChanged(object sender, EventArgs e)
        {

        }
    }

     
    }

