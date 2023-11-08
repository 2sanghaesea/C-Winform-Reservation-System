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
    public partial class User_PriceChart : Form
    {

        OleDbConnection conn;
        string connectionString;

 
        public User_PriceChart()
        {
            InitializeComponent();

            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            conn = new OleDbConnection(connectionString);

            try{
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 출발역, 도착역, 열차종류, 요금 from 요금표";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader();

                PriceChart_view.Rows.Clear();
                PriceChart_view.ColumnCount = 4;

                for(int i=0; i<4; i++)
                {
                    PriceChart_view.Columns[i].Name = read.GetName(i);
                }
                while (read.Read())
                {
                    object[] obj1 = new object[4];
                    for(int i =0; i<4; i++)
                    {
                        obj1[i] = new object();
                        obj1[i] = read.GetValue(i);

                    }
                    PriceChart_view.Rows.Add(obj1);
                }
                read.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
          
        }

        private void PriceChart_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                if(Source_combo.Text.ToString() == Desti_combo.Text.ToString()) {
                    MessageBox.Show("출발역과 도착역을 서로 다르게 체크하세요 !");
                }
                cmd.CommandText = "select 출발역, 도착역, 열차종류, 요금 from 요금표 where 출발역 = '" + Source_combo.Text + "'AND 도착역 ='" + Desti_combo.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();

                PriceChart_view.Rows.Clear();
                PriceChart_view.ColumnCount = 4;

                for(int i = 0; i<4; i++)
                {
                    PriceChart_view.Columns[i].Name = read.GetName(i);
                }
                while (read.Read())
                {
                    object[] obj1 = new object[4];

                    for (int i = 0; i < 4; i++) 
                    {
                        obj1[i] = new object();
                        obj1[i] = read.GetValue(i); 
                    }
                    PriceChart_view.Rows.Add(obj1);
                }
                read.Close();
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

        private void Go_to_Rsv_Btn_Click(object sender, EventArgs e)
        {
            Reservation frm = new Reservation();
            frm.ShowDialog();
        }

        private void Go_Schedule_Btn_Click(object sender, EventArgs e)
        {
            User_Check_Schedule frm1 = new User_Check_Schedule();
            frm1.ShowDialog();
        }
    }
}
