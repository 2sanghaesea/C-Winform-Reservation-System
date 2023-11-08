namespace WindowsFormsApp1
{
    partial class Reservation
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
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Price_text = new System.Windows.Forms.TextBox();
            this.Time_text = new System.Windows.Forms.TextBox();
            this.Grade_text = new System.Windows.Forms.TextBox();
            this.TrainNum_text = new System.Windows.Forms.TextBox();
            this.End_text = new System.Windows.Forms.TextBox();
            this.Start_text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Train_Type_Combo = new System.Windows.Forms.ComboBox();
            this.SourceStation_combo = new System.Windows.Forms.ComboBox();
            this.DestStation_combo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.S_6 = new System.Windows.Forms.CheckBox();
            this.S_1 = new System.Windows.Forms.CheckBox();
            this.S_5 = new System.Windows.Forms.CheckBox();
            this.S_2 = new System.Windows.Forms.CheckBox();
            this.S_4 = new System.Windows.Forms.CheckBox();
            this.S_3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.등록;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("PokemonGSC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(613, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 28);
            this.button3.TabIndex = 22;
            this.button3.Text = "좌석조회";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Price_text);
            this.groupBox5.Controls.Add(this.Time_text);
            this.groupBox5.Controls.Add(this.Grade_text);
            this.groupBox5.Controls.Add(this.TrainNum_text);
            this.groupBox5.Controls.Add(this.End_text);
            this.groupBox5.Controls.Add(this.Start_text);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(425, 135);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 228);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // Price_text
            // 
            this.Price_text.Location = new System.Drawing.Point(73, 193);
            this.Price_text.Name = "Price_text";
            this.Price_text.Size = new System.Drawing.Size(92, 27);
            this.Price_text.TabIndex = 26;
            // 
            // Time_text
            // 
            this.Time_text.Location = new System.Drawing.Point(73, 162);
            this.Time_text.Name = "Time_text";
            this.Time_text.Size = new System.Drawing.Size(92, 27);
            this.Time_text.TabIndex = 25;
            // 
            // Grade_text
            // 
            this.Grade_text.Location = new System.Drawing.Point(73, 130);
            this.Grade_text.Name = "Grade_text";
            this.Grade_text.Size = new System.Drawing.Size(92, 27);
            this.Grade_text.TabIndex = 24;
            this.Grade_text.TextChanged += new System.EventHandler(this.Grade_text_TextChanged);
            // 
            // TrainNum_text
            // 
            this.TrainNum_text.Location = new System.Drawing.Point(73, 97);
            this.TrainNum_text.Name = "TrainNum_text";
            this.TrainNum_text.Size = new System.Drawing.Size(92, 27);
            this.TrainNum_text.TabIndex = 23;
            // 
            // End_text
            // 
            this.End_text.Location = new System.Drawing.Point(73, 63);
            this.End_text.Name = "End_text";
            this.End_text.Size = new System.Drawing.Size(92, 27);
            this.End_text.TabIndex = 22;
            // 
            // Start_text
            // 
            this.Start_text.Location = new System.Drawing.Point(73, 28);
            this.Start_text.Name = "Start_text";
            this.Start_text.Size = new System.Drawing.Size(92, 27);
            this.Start_text.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "요금";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "운행 시간";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "열차 등급";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "열차 번호";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "도착역";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "출발역";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Train_Type_Combo);
            this.groupBox4.Controls.Add(this.SourceStation_combo);
            this.groupBox4.Controls.Add(this.DestStation_combo);
            this.groupBox4.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(60, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(623, 66);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "검색";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "열차 종류";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "도착역";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "출발역";
            // 
            // Train_Type_Combo
            // 
            this.Train_Type_Combo.FormattingEnabled = true;
            this.Train_Type_Combo.Items.AddRange(new object[] {
            "무궁화호",
            "새마을호"});
            this.Train_Type_Combo.Location = new System.Drawing.Point(414, 33);
            this.Train_Type_Combo.Name = "Train_Type_Combo";
            this.Train_Type_Combo.Size = new System.Drawing.Size(91, 26);
            this.Train_Type_Combo.TabIndex = 2;
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
            this.SourceStation_combo.Location = new System.Drawing.Point(65, 33);
            this.SourceStation_combo.Name = "SourceStation_combo";
            this.SourceStation_combo.Size = new System.Drawing.Size(91, 26);
            this.SourceStation_combo.TabIndex = 0;
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
            this.DestStation_combo.Location = new System.Drawing.Point(242, 33);
            this.DestStation_combo.Name = "DestStation_combo";
            this.DestStation_combo.Size = new System.Drawing.Size(91, 26);
            this.DestStation_combo.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(613, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 68);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "현금",
            "카드"});
            this.comboBox4.Location = new System.Drawing.Point(57, 23);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(83, 26);
            this.comboBox4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "결제방법";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.S_6);
            this.groupBox2.Controls.Add(this.S_1);
            this.groupBox2.Controls.Add(this.S_5);
            this.groupBox2.Controls.Add(this.S_2);
            this.groupBox2.Controls.Add(this.S_4);
            this.groupBox2.Controls.Add(this.S_3);
            this.groupBox2.Location = new System.Drawing.Point(613, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 122);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "잔여좌석";
            // 
            // S_6
            // 
            this.S_6.AutoSize = true;
            this.S_6.Location = new System.Drawing.Point(101, 91);
            this.S_6.Name = "S_6";
            this.S_6.Size = new System.Drawing.Size(48, 19);
            this.S_6.TabIndex = 11;
            this.S_6.Text = "C2";
            this.S_6.UseVisualStyleBackColor = true;
            // 
            // S_1
            // 
            this.S_1.AutoSize = true;
            this.S_1.Location = new System.Drawing.Point(12, 23);
            this.S_1.Name = "S_1";
            this.S_1.Size = new System.Drawing.Size(47, 19);
            this.S_1.TabIndex = 6;
            this.S_1.Text = "A1";
            this.S_1.UseVisualStyleBackColor = true;
            // 
            // S_5
            // 
            this.S_5.AutoSize = true;
            this.S_5.Location = new System.Drawing.Point(12, 91);
            this.S_5.Name = "S_5";
            this.S_5.Size = new System.Drawing.Size(47, 19);
            this.S_5.TabIndex = 10;
            this.S_5.Text = "C1";
            this.S_5.UseVisualStyleBackColor = true;
            // 
            // S_2
            // 
            this.S_2.AutoSize = true;
            this.S_2.Location = new System.Drawing.Point(102, 23);
            this.S_2.Name = "S_2";
            this.S_2.Size = new System.Drawing.Size(48, 19);
            this.S_2.TabIndex = 7;
            this.S_2.Text = "A2";
            this.S_2.UseVisualStyleBackColor = true;
            // 
            // S_4
            // 
            this.S_4.AutoSize = true;
            this.S_4.Location = new System.Drawing.Point(102, 57);
            this.S_4.Name = "S_4";
            this.S_4.Size = new System.Drawing.Size(48, 19);
            this.S_4.TabIndex = 9;
            this.S_4.Text = "B2";
            this.S_4.UseVisualStyleBackColor = true;
            // 
            // S_3
            // 
            this.S_3.AutoSize = true;
            this.S_3.Location = new System.Drawing.Point(12, 57);
            this.S_3.Name = "S_3";
            this.S_3.Size = new System.Drawing.Size(47, 19);
            this.S_3.TabIndex = 8;
            this.S_3.Text = "B1";
            this.S_3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(689, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "예약";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PokemonGSC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(165, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "운행시간표";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(367, 252);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(375, 418);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "label13";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 417);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(522, 417);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(86, 20);
            this.dataGridView2.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(285, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "label14";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reservation";
            this.Text = "예약창";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DestStation_combo;
        private System.Windows.Forms.ComboBox SourceStation_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Train_Type_Combo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox S_6;
        private System.Windows.Forms.CheckBox S_1;
        private System.Windows.Forms.CheckBox S_5;
        private System.Windows.Forms.CheckBox S_2;
        private System.Windows.Forms.CheckBox S_4;
        private System.Windows.Forms.CheckBox S_3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price_text;
        private System.Windows.Forms.TextBox Time_text;
        private System.Windows.Forms.TextBox Grade_text;
        private System.Windows.Forms.TextBox TrainNum_text;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox End_text;
        private System.Windows.Forms.TextBox Start_text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label14;
    }
}