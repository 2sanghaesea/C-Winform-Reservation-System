namespace WindowsFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Register_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_text = new System.Windows.Forms.TextBox();
            this.pw_text = new System.Windows.Forms.TextBox();
            this.showpw_combo = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Error = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Register_btn
            // 
            this.Register_btn.Font = new System.Drawing.Font("PokemonGSC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Register_btn.Location = new System.Drawing.Point(230, 279);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(75, 23);
            this.Register_btn.TabIndex = 0;
            this.Register_btn.Text = "회원가입";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("PokemonGSC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Login_btn.Location = new System.Drawing.Point(193, 250);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(156, 23);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "로그인";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PokemonGSC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(138, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PokemonGSC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(125, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "P/W";
            // 
            // Id_text
            // 
            this.Id_text.Location = new System.Drawing.Point(193, 165);
            this.Id_text.Name = "Id_text";
            this.Id_text.Size = new System.Drawing.Size(156, 21);
            this.Id_text.TabIndex = 6;
            this.Id_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pw_text
            // 
            this.pw_text.Location = new System.Drawing.Point(193, 198);
            this.pw_text.Name = "pw_text";
            this.pw_text.PasswordChar = '*';
            this.pw_text.Size = new System.Drawing.Size(156, 21);
            this.pw_text.TabIndex = 7;
            this.pw_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // showpw_combo
            // 
            this.showpw_combo.AutoSize = true;
            this.showpw_combo.Font = new System.Drawing.Font("PokemonGSC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showpw_combo.Location = new System.Drawing.Point(193, 226);
            this.showpw_combo.Name = "showpw_combo";
            this.showpw_combo.Size = new System.Drawing.Size(92, 18);
            this.showpw_combo.TabIndex = 9;
            this.showpw_combo.Text = "비밀번호 보이게";
            this.showpw_combo.UseVisualStyleBackColor = true;
            this.showpw_combo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 308);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // Label_Error
            // 
            this.Label_Error.AutoSize = true;
            this.Label_Error.Font = new System.Drawing.Font("맑은 고딕 Semilight", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Label_Error.Location = new System.Drawing.Point(73, 333);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(0, 30);
            this.Label_Error.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.dd;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 150);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.adxcv;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 201);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 352);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label_Error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.showpw_combo);
            this.Controls.Add(this.pw_text);
            this.Controls.Add(this.Id_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Register_btn; //회원가입
        private System.Windows.Forms.Button Login_btn; //로그인
        private System.Windows.Forms.Label label1; 
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_text; //아이디 텍스트박스
        private System.Windows.Forms.TextBox pw_text; //비밀번호 텍스트박스
        private System.Windows.Forms.CheckBox showpw_combo; //비밀번호 보이게
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

