namespace WindowsFormsApp1
{
    partial class User_PriceChart
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Go_to_Rsv_Btn = new System.Windows.Forms.Button();
            this.Go_Schedule_Btn = new System.Windows.Forms.Button();
            this.PriceChart_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Desti_combo = new System.Windows.Forms.ComboBox();
            this.Source_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceChart_view)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("휴먼모음T", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("PokemonGSC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(315, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "요금표";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Go_to_Rsv_Btn);
            this.groupBox3.Controls.Add(this.Go_Schedule_Btn);
            this.groupBox3.Controls.Add(this.PriceChart_view);
            this.groupBox3.Location = new System.Drawing.Point(39, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 315);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // Go_to_Rsv_Btn
            // 
            this.Go_to_Rsv_Btn.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Go_to_Rsv_Btn.Location = new System.Drawing.Point(517, 179);
            this.Go_to_Rsv_Btn.Name = "Go_to_Rsv_Btn";
            this.Go_to_Rsv_Btn.Size = new System.Drawing.Size(163, 42);
            this.Go_to_Rsv_Btn.TabIndex = 2;
            this.Go_to_Rsv_Btn.Text = "예매 하러 가기";
            this.Go_to_Rsv_Btn.UseVisualStyleBackColor = true;
            this.Go_to_Rsv_Btn.Click += new System.EventHandler(this.Go_to_Rsv_Btn_Click);
            // 
            // Go_Schedule_Btn
            // 
            this.Go_Schedule_Btn.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Go_Schedule_Btn.Location = new System.Drawing.Point(517, 61);
            this.Go_Schedule_Btn.Name = "Go_Schedule_Btn";
            this.Go_Schedule_Btn.Size = new System.Drawing.Size(163, 42);
            this.Go_Schedule_Btn.TabIndex = 1;
            this.Go_Schedule_Btn.Text = "운행 시간표 보기";
            this.Go_Schedule_Btn.UseVisualStyleBackColor = true;
            this.Go_Schedule_Btn.Click += new System.EventHandler(this.Go_Schedule_Btn_Click);
            // 
            // PriceChart_view
            // 
            this.PriceChart_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PriceChart_view.Location = new System.Drawing.Point(19, 34);
            this.PriceChart_view.Name = "PriceChart_view";
            this.PriceChart_view.RowTemplate.Height = 23;
            this.PriceChart_view.Size = new System.Drawing.Size(473, 264);
            this.PriceChart_view.TabIndex = 0;
            this.PriceChart_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PriceChart_view_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(122, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "출발역 : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Desti_combo);
            this.groupBox2.Controls.Add(this.Source_combo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(102, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 68);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(529, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Desti_combo
            // 
            this.Desti_combo.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Desti_combo.FormattingEnabled = true;
            this.Desti_combo.Items.AddRange(new object[] {
            "서울역",
            "천안역",
            "대전역",
            "대구역",
            "부산역"});
            this.Desti_combo.Location = new System.Drawing.Point(362, 26);
            this.Desti_combo.Name = "Desti_combo";
            this.Desti_combo.Size = new System.Drawing.Size(155, 29);
            this.Desti_combo.TabIndex = 3;
            // 
            // Source_combo
            // 
            this.Source_combo.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Source_combo.FormattingEnabled = true;
            this.Source_combo.Items.AddRange(new object[] {
            "서울역",
            "천안역",
            "대전역",
            "대구역",
            "부산역"});
            this.Source_combo.Location = new System.Drawing.Point(109, 26);
            this.Source_combo.Name = "Source_combo";
            this.Source_combo.Size = new System.Drawing.Size(155, 29);
            this.Source_combo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(283, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착역 :";
            // 
            // User_PriceChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.이상했1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "User_PriceChart";
            this.Text = "User_PriceChart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PriceChart_view)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Desti_combo;
        private System.Windows.Forms.ComboBox Source_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView PriceChart_view;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Go_to_Rsv_Btn;
        private System.Windows.Forms.Button Go_Schedule_Btn;
    }
}