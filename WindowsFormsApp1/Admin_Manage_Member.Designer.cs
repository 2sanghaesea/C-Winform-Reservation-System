
namespace WindowsFormsApp1
{
    partial class Admin_Manage_Member
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AgreeMem = new System.Windows.Forms.TabPage();
            this.Accept_Mem_Btn = new System.Windows.Forms.Button();
            this.Grade_box = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Card_num = new System.Windows.Forms.TextBox();
            this.Phone_num = new System.Windows.Forms.TextBox();
            this.Mem_name = new System.Windows.Forms.TextBox();
            this.Mem_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgreeMem_list = new System.Windows.Forms.DataGridView();
            this.Change_grade = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.MemberName = new System.Windows.Forms.TextBox();
            this.MemberNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Grade_Change_Btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Old_Grade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.New_Grade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Member_list = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.AgreeMem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgreeMem_list)).BeginInit();
            this.Change_grade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Member_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AgreeMem);
            this.tabControl1.Controls.Add(this.Change_grade);
            this.tabControl1.Font = new System.Drawing.Font("PokemonGSC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // AgreeMem
            // 
            this.AgreeMem.BackColor = System.Drawing.Color.White;
            this.AgreeMem.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.확인;
            this.AgreeMem.Controls.Add(this.Accept_Mem_Btn);
            this.AgreeMem.Controls.Add(this.Grade_box);
            this.AgreeMem.Controls.Add(this.label7);
            this.AgreeMem.Controls.Add(this.label6);
            this.AgreeMem.Controls.Add(this.Card_num);
            this.AgreeMem.Controls.Add(this.Phone_num);
            this.AgreeMem.Controls.Add(this.Mem_name);
            this.AgreeMem.Controls.Add(this.Mem_num);
            this.AgreeMem.Controls.Add(this.label5);
            this.AgreeMem.Controls.Add(this.label4);
            this.AgreeMem.Controls.Add(this.label3);
            this.AgreeMem.Controls.Add(this.label2);
            this.AgreeMem.Controls.Add(this.label1);
            this.AgreeMem.Controls.Add(this.AgreeMem_list);
            this.AgreeMem.Location = new System.Drawing.Point(4, 27);
            this.AgreeMem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgreeMem.Name = "AgreeMem";
            this.AgreeMem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgreeMem.Size = new System.Drawing.Size(671, 406);
            this.AgreeMem.TabIndex = 0;
            this.AgreeMem.Text = "회원 승인";
            // 
            // Accept_Mem_Btn
            // 
            this.Accept_Mem_Btn.Location = new System.Drawing.Point(502, 307);
            this.Accept_Mem_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Accept_Mem_Btn.Name = "Accept_Mem_Btn";
            this.Accept_Mem_Btn.Size = new System.Drawing.Size(88, 27);
            this.Accept_Mem_Btn.TabIndex = 13;
            this.Accept_Mem_Btn.Text = "승인";
            this.Accept_Mem_Btn.UseVisualStyleBackColor = true;
            this.Accept_Mem_Btn.Click += new System.EventHandler(this.Accept_Mem_Btn_Click);
            // 
            // Grade_box
            // 
            this.Grade_box.FormattingEnabled = true;
            this.Grade_box.Items.AddRange(new object[] {
            "SILVER",
            "GOLD",
            "VIP"});
            this.Grade_box.Location = new System.Drawing.Point(515, 264);
            this.Grade_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grade_box.Name = "Grade_box";
            this.Grade_box.Size = new System.Drawing.Size(135, 26);
            this.Grade_box.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(456, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "등급 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("PokemonGSC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(424, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "◎ 등급을 결정해 주세요 ◎";
            // 
            // Card_num
            // 
            this.Card_num.Location = new System.Drawing.Point(502, 150);
            this.Card_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Card_num.Name = "Card_num";
            this.Card_num.Size = new System.Drawing.Size(135, 27);
            this.Card_num.TabIndex = 9;
            // 
            // Phone_num
            // 
            this.Phone_num.Location = new System.Drawing.Point(502, 121);
            this.Phone_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phone_num.Name = "Phone_num";
            this.Phone_num.Size = new System.Drawing.Size(135, 27);
            this.Phone_num.TabIndex = 8;
            // 
            // Mem_name
            // 
            this.Mem_name.Location = new System.Drawing.Point(502, 90);
            this.Mem_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mem_name.Name = "Mem_name";
            this.Mem_name.Size = new System.Drawing.Size(135, 27);
            this.Mem_name.TabIndex = 7;
            // 
            // Mem_num
            // 
            this.Mem_num.Location = new System.Drawing.Point(502, 56);
            this.Mem_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mem_num.Name = "Mem_num";
            this.Mem_num.Size = new System.Drawing.Size(135, 27);
            this.Mem_num.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(424, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "카드 번호 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(424, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "휴대 전화 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(424, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "회원 번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(424, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "회원 이름 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("PokemonGSC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "※ 회원 가입 요청 목록 ※";
            // 
            // AgreeMem_list
            // 
            this.AgreeMem_list.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.AgreeMem_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgreeMem_list.Location = new System.Drawing.Point(17, 79);
            this.AgreeMem_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgreeMem_list.Name = "AgreeMem_list";
            this.AgreeMem_list.RowHeadersWidth = 51;
            this.AgreeMem_list.RowTemplate.Height = 27;
            this.AgreeMem_list.Size = new System.Drawing.Size(384, 278);
            this.AgreeMem_list.TabIndex = 0;
            this.AgreeMem_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgreeMem_list_CellContentClick);
            // 
            // Change_grade
            // 
            this.Change_grade.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.확인;
            this.Change_grade.Controls.Add(this.label16);
            this.Change_grade.Controls.Add(this.CardNumber);
            this.Change_grade.Controls.Add(this.PhoneNumber);
            this.Change_grade.Controls.Add(this.label15);
            this.Change_grade.Controls.Add(this.label14);
            this.Change_grade.Controls.Add(this.MemberName);
            this.Change_grade.Controls.Add(this.MemberNumber);
            this.Change_grade.Controls.Add(this.label13);
            this.Change_grade.Controls.Add(this.label12);
            this.Change_grade.Controls.Add(this.Grade_Change_Btn);
            this.Change_grade.Controls.Add(this.label11);
            this.Change_grade.Controls.Add(this.Old_Grade);
            this.Change_grade.Controls.Add(this.label10);
            this.Change_grade.Controls.Add(this.New_Grade);
            this.Change_grade.Controls.Add(this.label9);
            this.Change_grade.Controls.Add(this.label8);
            this.Change_grade.Controls.Add(this.Member_list);
            this.Change_grade.Location = new System.Drawing.Point(4, 27);
            this.Change_grade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change_grade.Name = "Change_grade";
            this.Change_grade.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change_grade.Size = new System.Drawing.Size(671, 406);
            this.Change_grade.TabIndex = 1;
            this.Change_grade.Text = "회원등급변경";
            this.Change_grade.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Silver;
            this.label16.Font = new System.Drawing.Font("PokemonGSC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(478, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 30);
            this.label16.TabIndex = 16;
            this.label16.Text = "[ 회원 정보 ]";
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(537, 194);
            this.CardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(108, 27);
            this.CardNumber.TabIndex = 15;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(537, 165);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(108, 27);
            this.PhoneNumber.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(456, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 18);
            this.label15.TabIndex = 13;
            this.label15.Text = "카드 번호 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(456, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "전화 번호 :";
            // 
            // MemberName
            // 
            this.MemberName.Location = new System.Drawing.Point(537, 136);
            this.MemberName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(108, 27);
            this.MemberName.TabIndex = 11;
            // 
            // MemberNumber
            // 
            this.MemberNumber.Location = new System.Drawing.Point(537, 106);
            this.MemberNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MemberNumber.Name = "MemberNumber";
            this.MemberNumber.Size = new System.Drawing.Size(108, 27);
            this.MemberNumber.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(456, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "회원 이름 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(456, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "회원 번호 : ";
            // 
            // Grade_Change_Btn
            // 
            this.Grade_Change_Btn.Location = new System.Drawing.Point(501, 358);
            this.Grade_Change_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grade_Change_Btn.Name = "Grade_Change_Btn";
            this.Grade_Change_Btn.Size = new System.Drawing.Size(88, 30);
            this.Grade_Change_Btn.TabIndex = 7;
            this.Grade_Change_Btn.Text = "변경";
            this.Grade_Change_Btn.UseVisualStyleBackColor = true;
            this.Grade_Change_Btn.Click += new System.EventHandler(this.Grade_Change_Btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(456, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "변환 등급 : ";
            // 
            // Old_Grade
            // 
            this.Old_Grade.Location = new System.Drawing.Point(537, 286);
            this.Old_Grade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Old_Grade.Name = "Old_Grade";
            this.Old_Grade.Size = new System.Drawing.Size(108, 27);
            this.Old_Grade.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(456, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "기존 등급 : ";
            // 
            // New_Grade
            // 
            this.New_Grade.FormattingEnabled = true;
            this.New_Grade.Items.AddRange(new object[] {
            "SILVER",
            "GOLD",
            "VIP"});
            this.New_Grade.Location = new System.Drawing.Point(537, 311);
            this.New_Grade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.New_Grade.Name = "New_Grade";
            this.New_Grade.Size = new System.Drawing.Size(108, 26);
            this.New_Grade.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("PokemonGSC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(498, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "등급 변경";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("PokemonGSC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(131, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 30);
            this.label8.TabIndex = 1;
            this.label8.Text = "현재 회원 목록";
            // 
            // Member_list
            // 
            this.Member_list.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.Member_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Member_list.Location = new System.Drawing.Point(21, 50);
            this.Member_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Member_list.Name = "Member_list";
            this.Member_list.RowHeadersWidth = 51;
            this.Member_list.RowTemplate.Height = 27;
            this.Member_list.Size = new System.Drawing.Size(399, 338);
            this.Member_list.TabIndex = 0;
            this.Member_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Member_list_CellContentClick);
            // 
            // Admin_Manage_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 456);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Manage_Member";
            this.Text = "회원 관리";
            this.tabControl1.ResumeLayout(false);
            this.AgreeMem.ResumeLayout(false);
            this.AgreeMem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgreeMem_list)).EndInit();
            this.Change_grade.ResumeLayout(false);
            this.Change_grade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Member_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AgreeMem;
        private System.Windows.Forms.TabPage Change_grade;
        private System.Windows.Forms.DataGridView AgreeMem_list;
        private System.Windows.Forms.Button Accept_Mem_Btn;
        private System.Windows.Forms.ComboBox Grade_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Card_num;
        private System.Windows.Forms.TextBox Phone_num;
        private System.Windows.Forms.TextBox Mem_name;
        private System.Windows.Forms.TextBox Mem_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Grade_Change_Btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Old_Grade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox New_Grade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Member_list;
        private System.Windows.Forms.TextBox MemberName;
        private System.Windows.Forms.TextBox MemberNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}