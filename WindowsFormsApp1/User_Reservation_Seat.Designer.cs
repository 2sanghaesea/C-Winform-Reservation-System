namespace WindowsFormsApp1
{
    partial class User_Reservation_Seat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TrainNum = new System.Windows.Forms.TextBox();
            this.Train_Type = new System.Windows.Forms.TextBox();
            this.End = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.TextBox();
            this.Timetxt = new System.Windows.Forms.TextBox();
            this.Seat_Num = new System.Windows.Forms.TextBox();
            this.Rsv_Num = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Change_btn = new System.Windows.Forms.Button();
            this.S_6 = new System.Windows.Forms.CheckBox();
            this.S_5 = new System.Windows.Forms.CheckBox();
            this.S_4 = new System.Windows.Forms.CheckBox();
            this.S_3 = new System.Windows.Forms.CheckBox();
            this.S_2 = new System.Windows.Forms.CheckBox();
            this.S_1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Howpay = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("PokemonGSC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(157, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 33);
            this.label11.TabIndex = 1;
            this.label11.Text = "예약 목록";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(409, 449);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "열차번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "열차종류";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "좌석번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(53, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "시간";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(41, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "출발역";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(41, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "도착역";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(29, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "예약번호";
            // 
            // TrainNum
            // 
            this.TrainNum.Location = new System.Drawing.Point(127, 53);
            this.TrainNum.Name = "TrainNum";
            this.TrainNum.Size = new System.Drawing.Size(100, 27);
            this.TrainNum.TabIndex = 9;
            // 
            // Train_Type
            // 
            this.Train_Type.Location = new System.Drawing.Point(127, 87);
            this.Train_Type.Name = "Train_Type";
            this.Train_Type.Size = new System.Drawing.Size(100, 27);
            this.Train_Type.TabIndex = 10;
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(127, 210);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(100, 27);
            this.End.TabIndex = 11;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(127, 177);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 27);
            this.Start.TabIndex = 12;
            // 
            // Timetxt
            // 
            this.Timetxt.Location = new System.Drawing.Point(127, 147);
            this.Timetxt.Name = "Timetxt";
            this.Timetxt.Size = new System.Drawing.Size(100, 27);
            this.Timetxt.TabIndex = 13;
            // 
            // Seat_Num
            // 
            this.Seat_Num.Location = new System.Drawing.Point(127, 118);
            this.Seat_Num.Name = "Seat_Num";
            this.Seat_Num.Size = new System.Drawing.Size(100, 27);
            this.Seat_Num.TabIndex = 14;
            // 
            // Rsv_Num
            // 
            this.Rsv_Num.Location = new System.Drawing.Point(127, 21);
            this.Rsv_Num.Name = "Rsv_Num";
            this.Rsv_Num.Size = new System.Drawing.Size(100, 27);
            this.Rsv_Num.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(483, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "예약 취소";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(599, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "좌석 변경";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Change_btn);
            this.groupBox2.Controls.Add(this.S_6);
            this.groupBox2.Controls.Add(this.S_5);
            this.groupBox2.Controls.Add(this.S_4);
            this.groupBox2.Controls.Add(this.S_3);
            this.groupBox2.Controls.Add(this.S_2);
            this.groupBox2.Controls.Add(this.S_1);
            this.groupBox2.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(461, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 118);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Change_btn
            // 
            this.Change_btn.Location = new System.Drawing.Point(186, 37);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(51, 45);
            this.Change_btn.TabIndex = 6;
            this.Change_btn.Text = "변경";
            this.Change_btn.UseVisualStyleBackColor = true;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // S_6
            // 
            this.S_6.AutoSize = true;
            this.S_6.Font = new System.Drawing.Font("PokemonGSC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_6.Location = new System.Drawing.Point(117, 85);
            this.S_6.Name = "S_6";
            this.S_6.Size = new System.Drawing.Size(48, 19);
            this.S_6.TabIndex = 5;
            this.S_6.Text = "C2";
            this.S_6.UseVisualStyleBackColor = true;
            // 
            // S_5
            // 
            this.S_5.AutoSize = true;
            this.S_5.Font = new System.Drawing.Font("PokemonGSC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_5.Location = new System.Drawing.Point(15, 85);
            this.S_5.Name = "S_5";
            this.S_5.Size = new System.Drawing.Size(47, 19);
            this.S_5.TabIndex = 4;
            this.S_5.Text = "C1";
            this.S_5.UseVisualStyleBackColor = true;
            // 
            // S_4
            // 
            this.S_4.AutoSize = true;
            this.S_4.Font = new System.Drawing.Font("PokemonGSC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_4.Location = new System.Drawing.Point(117, 52);
            this.S_4.Name = "S_4";
            this.S_4.Size = new System.Drawing.Size(48, 19);
            this.S_4.TabIndex = 3;
            this.S_4.Text = "B2";
            this.S_4.UseVisualStyleBackColor = true;
            // 
            // S_3
            // 
            this.S_3.AutoSize = true;
            this.S_3.Font = new System.Drawing.Font("PokemonGSC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_3.Location = new System.Drawing.Point(15, 52);
            this.S_3.Name = "S_3";
            this.S_3.Size = new System.Drawing.Size(47, 19);
            this.S_3.TabIndex = 2;
            this.S_3.Text = "B1";
            this.S_3.UseVisualStyleBackColor = true;
            // 
            // S_2
            // 
            this.S_2.AutoSize = true;
            this.S_2.Font = new System.Drawing.Font("PokemonGSC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_2.Location = new System.Drawing.Point(117, 20);
            this.S_2.Name = "S_2";
            this.S_2.Size = new System.Drawing.Size(48, 19);
            this.S_2.TabIndex = 1;
            this.S_2.Text = "A2";
            this.S_2.UseVisualStyleBackColor = true;
            // 
            // S_1
            // 
            this.S_1.AutoSize = true;
            this.S_1.Font = new System.Drawing.Font("PokemonGSC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_1.Location = new System.Drawing.Point(15, 20);
            this.S_1.Name = "S_1";
            this.S_1.Size = new System.Drawing.Size(47, 19);
            this.S_1.TabIndex = 0;
            this.S_1.Text = "A1";
            this.S_1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "label8";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.Howpay);
            this.groupBox3.Controls.Add(this.Price);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Rsv_Num);
            this.groupBox3.Controls.Add(this.Seat_Num);
            this.groupBox3.Controls.Add(this.Timetxt);
            this.groupBox3.Controls.Add(this.Start);
            this.groupBox3.Controls.Add(this.End);
            this.groupBox3.Controls.Add(this.Train_Type);
            this.groupBox3.Controls.Add(this.TrainNum);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(461, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 317);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // Howpay
            // 
            this.Howpay.Location = new System.Drawing.Point(127, 272);
            this.Howpay.Name = "Howpay";
            this.Howpay.Size = new System.Drawing.Size(100, 27);
            this.Howpay.TabIndex = 19;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(127, 240);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 27);
            this.Price.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Desktop;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(29, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "결제방법";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Desktop;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(53, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "요금";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(116, 510);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(152, 23);
            this.dataGridView2.TabIndex = 22;
            // 
            // User_Reservation_Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.pokemon_desktop_backgrounds_wallpaper_preview;
            this.ClientSize = new System.Drawing.Size(739, 542);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "User_Reservation_Seat";
            this.Text = "Reservation_Seat";
            this.Load += new System.EventHandler(this.Reservation_Seat_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TrainNum;
        private System.Windows.Forms.TextBox Train_Type;
        private System.Windows.Forms.TextBox End;
        private System.Windows.Forms.TextBox Start;
        private System.Windows.Forms.TextBox Timetxt;
        private System.Windows.Forms.TextBox Seat_Num;
        private System.Windows.Forms.TextBox Rsv_Num;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox S_6;
        private System.Windows.Forms.CheckBox S_5;
        private System.Windows.Forms.CheckBox S_4;
        private System.Windows.Forms.CheckBox S_3;
        private System.Windows.Forms.CheckBox S_2;
        private System.Windows.Forms.CheckBox S_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Howpay;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label11;
    }
}