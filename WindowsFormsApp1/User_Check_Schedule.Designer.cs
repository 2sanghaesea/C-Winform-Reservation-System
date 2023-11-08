namespace WindowsFormsApp1
{
    partial class User_Check_Schedule
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Price_text = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Rsv_button = new System.Windows.Forms.Button();
            this.Time_text = new System.Windows.Forms.TextBox();
            this.TrainNum_text = new System.Windows.Forms.TextBox();
            this.Grade_text = new System.Windows.Forms.TextBox();
            this.End_text = new System.Windows.Forms.TextBox();
            this.Start_text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Train_Type_Combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.DestStation_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceStation_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("PokemonGSC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.Price_text);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Rsv_button);
            this.groupBox4.Controls.Add(this.Time_text);
            this.groupBox4.Controls.Add(this.TrainNum_text);
            this.groupBox4.Controls.Add(this.Grade_text);
            this.groupBox4.Controls.Add(this.End_text);
            this.groupBox4.Controls.Add(this.Start_text);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(484, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 212);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // Price_text
            // 
            this.Price_text.Location = new System.Drawing.Point(80, 180);
            this.Price_text.Name = "Price_text";
            this.Price_text.Size = new System.Drawing.Size(118, 27);
            this.Price_text.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(29, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "요금 :";
            // 
            // Rsv_button
            // 
            this.Rsv_button.BackColor = System.Drawing.Color.Transparent;
            this.Rsv_button.Location = new System.Drawing.Point(217, 91);
            this.Rsv_button.Name = "Rsv_button";
            this.Rsv_button.Size = new System.Drawing.Size(101, 34);
            this.Rsv_button.TabIndex = 13;
            this.Rsv_button.Text = "예약하러가기";
            this.Rsv_button.UseVisualStyleBackColor = false;
            this.Rsv_button.Click += new System.EventHandler(this.Rsv_button_Click);
            // 
            // Time_text
            // 
            this.Time_text.Location = new System.Drawing.Point(80, 150);
            this.Time_text.Name = "Time_text";
            this.Time_text.Size = new System.Drawing.Size(118, 27);
            this.Time_text.TabIndex = 16;
            // 
            // TrainNum_text
            // 
            this.TrainNum_text.Location = new System.Drawing.Point(80, 82);
            this.TrainNum_text.Name = "TrainNum_text";
            this.TrainNum_text.Size = new System.Drawing.Size(118, 27);
            this.TrainNum_text.TabIndex = 15;
            // 
            // Grade_text
            // 
            this.Grade_text.Location = new System.Drawing.Point(80, 115);
            this.Grade_text.Name = "Grade_text";
            this.Grade_text.Size = new System.Drawing.Size(118, 27);
            this.Grade_text.TabIndex = 14;
            this.Grade_text.TextChanged += new System.EventHandler(this.Grade_text_TextChanged);
            // 
            // End_text
            // 
            this.End_text.Location = new System.Drawing.Point(80, 46);
            this.End_text.Name = "End_text";
            this.End_text.Size = new System.Drawing.Size(118, 27);
            this.End_text.TabIndex = 13;
            // 
            // Start_text
            // 
            this.Start_text.Location = new System.Drawing.Point(80, 16);
            this.Start_text.Name = "Start_text";
            this.Start_text.Size = new System.Drawing.Size(118, 27);
            this.Start_text.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(6, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "운행 시간:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(6, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "열차 등급:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(21, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "출발역:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(21, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "도착역:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(7, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "열차 번호:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("PokemonGSC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(484, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 84);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PokemonGSC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "현재 시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("PokemonGSC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(154, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "운행 시간표";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Train_Type_Combo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Search_btn);
            this.groupBox2.Controls.Add(this.DestStation_combo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SourceStation_combo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(35, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 78);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Train_Type_Combo
            // 
            this.Train_Type_Combo.FormattingEnabled = true;
            this.Train_Type_Combo.Items.AddRange(new object[] {
            "무궁화호",
            "새마을호"});
            this.Train_Type_Combo.Location = new System.Drawing.Point(508, 31);
            this.Train_Type_Combo.Name = "Train_Type_Combo";
            this.Train_Type_Combo.Size = new System.Drawing.Size(121, 26);
            this.Train_Type_Combo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(437, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "열차 종류 :";
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.Transparent;
            this.Search_btn.Location = new System.Drawing.Point(666, 29);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 28);
            this.Search_btn.TabIndex = 5;
            this.Search_btn.Text = "검색";
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // DestStation_combo
            // 
            this.DestStation_combo.FormattingEnabled = true;
            this.DestStation_combo.Items.AddRange(new object[] {
            "서울역",
            "천안역",
            "대전역",
            "대구역",
            "부산역"});
            this.DestStation_combo.Location = new System.Drawing.Point(281, 31);
            this.DestStation_combo.Name = "DestStation_combo";
            this.DestStation_combo.Size = new System.Drawing.Size(121, 26);
            this.DestStation_combo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(222, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "도착역 : ";
            // 
            // SourceStation_combo
            // 
            this.SourceStation_combo.FormattingEnabled = true;
            this.SourceStation_combo.Items.AddRange(new object[] {
            "서울역",
            "천안역",
            "대전역",
            "대구역",
            "부산역"});
            this.SourceStation_combo.Location = new System.Drawing.Point(75, 31);
            this.SourceStation_combo.Name = "SourceStation_combo";
            this.SourceStation_combo.Size = new System.Drawing.Size(121, 26);
            this.SourceStation_combo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "출발역 :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(425, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // User_Check_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.확인;
            this.ClientSize = new System.Drawing.Size(870, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "User_Check_Schedule";
            this.Text = "User_Check_Schedule";
            this.Load += new System.EventHandler(this.User_Check_Schedule_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.ComboBox DestStation_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SourceStation_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Rsv_button;
        private System.Windows.Forms.TextBox Time_text;
        private System.Windows.Forms.TextBox TrainNum_text;
        private System.Windows.Forms.TextBox Grade_text;
        private System.Windows.Forms.TextBox End_text;
        private System.Windows.Forms.TextBox Start_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Train_Type_Combo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price_text;
        private System.Windows.Forms.Label label12;
    }
}