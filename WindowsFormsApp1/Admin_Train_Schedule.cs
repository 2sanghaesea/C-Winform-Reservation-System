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
using System.Text.RegularExpressions; //정규식 사용

namespace WindowsFormsApp1
{
    public partial class Admin_Train_Schedule : Form
    {

        OleDbConnection conn;
        string connectionString =  "Provider=MSDAORA;Password=train;User ID=train";

        public Admin_Train_Schedule()
        {
            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e) //시간표 등록
        {

            string s = "서울역";
            string c = "천안역";
            string d = "대전역";
            string dg = "대구역";
            string b = "부산역";

            conn = new OleDbConnection(connectionString);
            
            string ridetime = Regex.Replace(textBox1.Text, @"\D", "");
            int traintime = int.Parse(ridetime);
            try
            {
                
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                if (Start_combo.Text == s && Destination_combo.Text == b) //서울부터
                {
                    int a = 0;
                    int x = 0;
                    for (int i = 0; i < 4; i++)//시작역
                    {
                        for (int j = 4; j >= 1; j--)//도착역
                        {
                            if (i != j && i<j)
                            {
                                /*int timechange = 50 * a;
                                x += 500000;
                                int real = traintime -= timechange;*/


                                /*string realtime = String.Format("{0:0#:##~##:##}",real);
                                MessageBox.Show(realtime);*/
                                //곱하기 써서 시간 줄이기 그리고 commandtext 내용 타임테이블 바꾸기
                                Start_combo.SelectedIndex = i;
                                Destination_combo.SelectedIndex = j;
                                cmd.CommandText = "INSERT INTO 운행시간표 VALUES('" + Start_combo.Text + "','" + Destination_combo.Text + "','" + TrainType_txt.Text + "'," + TrainNum.Text + ",'" + textBox1.Text + "',(select 요금 from 요금표 where 출발역 = '" + Start_combo.Text + "' and 도착역 ='" + Destination_combo.Text + "' and 열차종류 ='" + TrainType_txt.Text + "'))";
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = conn;
                                cmd.ExecuteNonQuery();
                                /*a++;*/
                            }
                        }
                    }
                    a = 0;
                }
                else if(Start_combo.Text == b && Destination_combo.Text == s) //부산부터
                {
                    for(int i =4; i>0; i--)
                    {
                        for(int j=0; j<4; j++)
                        {
                            if(i != j && i > j)
                            {
                                Start_combo.SelectedIndex = i;
                                Destination_combo.SelectedIndex = j;
                                cmd.CommandText = "INSERT INTO 운행시간표 VALUES('" + Start_combo.Text + "','" + Destination_combo.Text + "','" + TrainType_txt.Text + "'," + TrainNum.Text + ",'" + textBox1.Text + "',(select 요금 from 요금표 where 출발역 = '" + Start_combo.Text + "' and 도착역 ='" + Destination_combo.Text + "' and 열차종류 ='" + TrainType_txt.Text + "'))";
                                cmd.CommandType = CommandType.Text;
                                cmd.Connection = conn;
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                
                conn.Close();
                MessageBox.Show("운행시간표 등록이 완료되었습니다.");
                
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

        private void TrainList_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TrainNum.SelectedIndex == 0 || TrainNum.SelectedIndex == 1)
            {
                TrainType_txt.Text = "무궁화호";
            }
            else
            {
                TrainType_txt.Text = "새마을호";
            }
        }

      
    }
}
