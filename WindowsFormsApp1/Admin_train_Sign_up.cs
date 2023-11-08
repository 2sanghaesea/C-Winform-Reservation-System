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
    public partial class Admin_train_Sign_up : Form
    {
        OleDbConnection conn;
        string connectionString;
        public Admin_train_Sign_up()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            conn = new OleDbConnection(connectionString);
            conn.Open();
            updatedb();
        }
        private void updatedb()
        {
            try
            {
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.CommandText = "select * from 열차";
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = conn;

                OleDbDataReader read1 = cmd1.ExecuteReader();
                dataGridView1.ColumnCount = 2;

                for (int i = 0; i < 4; i++)
                {
                    dataGridView1.Columns[i].Name = read1.GetName(i);
                }

                while (read1.Read())
                {
                    object[] obj1 = new object[2];

                    for (int i = 0; i < 2; i++)
                    {
                        obj1[i] = new object();
                        obj1[i] = read1.GetValue(i);
                    }

                    dataGridView1.Rows.Add(obj1);
                }
                read1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//등록
        {
            dataGridView1.Rows.Clear();
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT 열차 VALUES(" + textBox1.Text + ",'" + comboBox1.Text + "')";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                updatedb();
                MessageBox.Show("등록되었습니다.");
            }catch(Exception ex)
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from 열차 where 열차번호 = "+textBox1.Text;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                updatedb();
                MessageBox.Show(textBox1.Text + "번 열차가 삭제되었습니다.");
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
