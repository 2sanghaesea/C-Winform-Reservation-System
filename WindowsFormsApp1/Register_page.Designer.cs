
namespace WindowsFormsApp1
{
    partial class Register_page
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
            this.member_name = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.cardnum_text = new System.Windows.Forms.TextBox();
            this.pw_text = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.idcheck_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // member_name
            // 
            this.member_name.AutoSize = true;
            this.member_name.Location = new System.Drawing.Point(71, 25);
            this.member_name.Name = "member_name";
            this.member_name.Size = new System.Drawing.Size(40, 17);
            this.member_name.TabIndex = 0;
            this.member_name.Text = "* ID";
            this.member_name.Click += new System.EventHandler(this.member_name_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(51, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(61, 17);
            this.label.TabIndex = 1;
            this.label.Text = "* 휴대전화";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "* 카드번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "* 비밀번호";
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(118, 20);
            this.name_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(206, 26);
            this.name_text.TabIndex = 6;
            this.name_text.TextChanged += new System.EventHandler(this.name_text_TextChanged);
            // 
            // phonenum
            // 
            this.phonenum.Location = new System.Drawing.Point(117, 51);
            this.phonenum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(206, 26);
            this.phonenum.TabIndex = 7;
            this.phonenum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cardnum_text
            // 
            this.cardnum_text.Location = new System.Drawing.Point(118, 86);
            this.cardnum_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardnum_text.Name = "cardnum_text";
            this.cardnum_text.Size = new System.Drawing.Size(206, 26);
            this.cardnum_text.TabIndex = 8;
            // 
            // pw_text
            // 
            this.pw_text.Location = new System.Drawing.Point(118, 121);
            this.pw_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_text.Name = "pw_text";
            this.pw_text.Size = new System.Drawing.Size(206, 26);
            this.pw_text.TabIndex = 9;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(334, 104);
            this.register_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(83, 26);
            this.register_btn.TabIndex = 10;
            this.register_btn.Text = "회원가입";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // idcheck_btn
            // 
            this.idcheck_btn.Location = new System.Drawing.Point(334, 22);
            this.idcheck_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idcheck_btn.Name = "idcheck_btn";
            this.idcheck_btn.Size = new System.Drawing.Size(83, 26);
            this.idcheck_btn.TabIndex = 11;
            this.idcheck_btn.Text = "중복확인";
            this.idcheck_btn.UseVisualStyleBackColor = true;
            this.idcheck_btn.Click += new System.EventHandler(this.idcheck_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.register_btn);
            this.groupBox1.Controls.Add(this.idcheck_btn);
            this.groupBox1.Controls.Add(this.name_text);
            this.groupBox1.Controls.Add(this.member_name);
            this.groupBox1.Controls.Add(this.pw_text);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.cardnum_text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.phonenum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("PokemonGSC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(28, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 164);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.회원가입;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 308);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Register_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register_page";
            this.Text = "회원가입";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label member_name;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.TextBox cardnum_text;
        private System.Windows.Forms.TextBox pw_text;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button idcheck_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}