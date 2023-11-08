using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class User_Main : Form
    {
        public User_Main()
        {
            InitializeComponent();
        }

        private void Schedule_button_Click(object sender, EventArgs e)
        {
            User_Check_Schedule frm2 = new User_Check_Schedule();
            frm2.ShowDialog();
        }

        private void Price_button_Click(object sender, EventArgs e)
        {
            User_PriceChart frm1 = new User_PriceChart();
            frm1.ShowDialog();
        }



        private void Rsv_seat_button_Click(object sender, EventArgs e)
        {
            User_Reservation_Seat frm2 = new User_Reservation_Seat();
            frm2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Info frm6 = new User_Info();
            frm6.ShowDialog();
        }
    }
}
