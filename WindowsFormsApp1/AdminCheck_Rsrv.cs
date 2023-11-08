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
using System.Text.RegularExpressions;
namespace WindowsFormsApp1
{
    public partial class AdminCheck_Rsrv : Form
    {
        OleDbConnection conn;
        string connectionString;

        public AdminCheck_Rsrv()
        {
            InitializeComponent();
            connectionString = "Provider=MSDAORA;Password=train;User ID=train";
            conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 예약현황";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;


                OleDbDataReader read = cmd.ExecuteReader();
                dataGridView1.ColumnCount = 8;

                /* string ridetime = Regex.Replace(textBox1.Text, @"\D", "");
                 int traintime = int.Parse(ridetime);*/
                int summary = 0;
                for (int i=0; i<8; i++)
                {
                    dataGridView1.Columns[i].Name = read.GetName(i);
                }

                while (read.Read())
                {
                    object[] obj1 = new object[8];

                    for (int i = 0; i < 8; i++)
                    {
                        obj1[i] = new object();
                        obj1[i] = read.GetValue(i);
                    }

                    dataGridView1.Rows.Add(obj1);
                    string money = Regex.Replace(obj1[6].ToString(), @"\D", "");
                    int allmoney = int.Parse(money);
                    summary += allmoney;
                    label9.Text = String.Format("{0:#,0}", summary);
                }
                read.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void AdminCheck_Rsrv_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Rsv_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            MemNum_text.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Start.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Dest.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Date.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Howpay.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            
        }

        private void Rsv_text_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
