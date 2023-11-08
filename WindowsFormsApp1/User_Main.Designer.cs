namespace WindowsFormsApp1
{
    partial class User_Main
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Price_button = new System.Windows.Forms.Button();
            this.Schedule_button = new System.Windows.Forms.Button();
            this.Rsv_seat_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(1001, 559);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(10, 10);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(2, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(2, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Price_button
            // 
            this.Price_button.BackColor = System.Drawing.Color.LightCoral;
            this.Price_button.Location = new System.Drawing.Point(14, 61);
            this.Price_button.Name = "Price_button";
            this.Price_button.Size = new System.Drawing.Size(126, 43);
            this.Price_button.TabIndex = 2;
            this.Price_button.Text = "요금표";
            this.Price_button.UseVisualStyleBackColor = false;
            this.Price_button.Click += new System.EventHandler(this.Price_button_Click);
            // 
            // Schedule_button
            // 
            this.Schedule_button.BackColor = System.Drawing.Color.LightCoral;
            this.Schedule_button.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Schedule_button.Location = new System.Drawing.Point(14, 110);
            this.Schedule_button.Name = "Schedule_button";
            this.Schedule_button.Size = new System.Drawing.Size(126, 57);
            this.Schedule_button.TabIndex = 3;
            this.Schedule_button.Text = "운행 시간표 확인\r\n예약 하러 가기";
            this.Schedule_button.UseVisualStyleBackColor = false;
            this.Schedule_button.Click += new System.EventHandler(this.Schedule_button_Click);
            // 
            // Rsv_seat_button
            // 
            this.Rsv_seat_button.BackColor = System.Drawing.Color.LightCoral;
            this.Rsv_seat_button.Location = new System.Drawing.Point(14, 173);
            this.Rsv_seat_button.Name = "Rsv_seat_button";
            this.Rsv_seat_button.Size = new System.Drawing.Size(126, 45);
            this.Rsv_seat_button.TabIndex = 5;
            this.Rsv_seat_button.Text = "나의 예약좌석";
            this.Rsv_seat_button.UseVisualStyleBackColor = false;
            this.Rsv_seat_button.Click += new System.EventHandler(this.Rsv_seat_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Rsv_seat_button);
            this.groupBox1.Controls.Add(this.Price_button);
            this.groupBox1.Controls.Add(this.Schedule_button);
            this.groupBox1.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(281, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 231);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "내 정보";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.유저메인1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 367);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // User_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl2);
            this.Name = "User_Main";
            this.Text = "사용자 메인";
            this.tabControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Price_button;
        private System.Windows.Forms.Button Schedule_button;
        private System.Windows.Forms.Button Rsv_seat_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}