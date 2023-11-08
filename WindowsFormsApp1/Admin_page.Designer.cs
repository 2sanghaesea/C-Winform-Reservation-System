namespace WindowsFormsApp1
{
    partial class Admin_page
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
            this.Member_btn = new System.Windows.Forms.Button();
            this.Schedule_btn = new System.Windows.Forms.Button();
            this.Rsv_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Member_btn
            // 
            this.Member_btn.Font = new System.Drawing.Font("PokemonGSC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Member_btn.Location = new System.Drawing.Point(255, 59);
            this.Member_btn.Name = "Member_btn";
            this.Member_btn.Size = new System.Drawing.Size(161, 50);
            this.Member_btn.TabIndex = 1;
            this.Member_btn.Text = "회원 관리";
            this.Member_btn.UseVisualStyleBackColor = true;
            this.Member_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Schedule_btn
            // 
            this.Schedule_btn.Font = new System.Drawing.Font("PokemonGSC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Schedule_btn.Location = new System.Drawing.Point(255, 170);
            this.Schedule_btn.Name = "Schedule_btn";
            this.Schedule_btn.Size = new System.Drawing.Size(161, 36);
            this.Schedule_btn.TabIndex = 2;
            this.Schedule_btn.Text = "열차 시간표 관리";
            this.Schedule_btn.UseVisualStyleBackColor = true;
            this.Schedule_btn.Click += new System.EventHandler(this.Schedule_btn_Click);
            // 
            // Rsv_Btn
            // 
            this.Rsv_Btn.Font = new System.Drawing.Font("PokemonGSC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rsv_Btn.Location = new System.Drawing.Point(255, 227);
            this.Rsv_Btn.Name = "Rsv_Btn";
            this.Rsv_Btn.Size = new System.Drawing.Size(161, 50);
            this.Rsv_Btn.TabIndex = 3;
            this.Rsv_Btn.Text = "예약현황";
            this.Rsv_Btn.UseVisualStyleBackColor = true;
            this.Rsv_Btn.Click += new System.EventHandler(this.Rsv_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("PokemonGSC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(173, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "관리자";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("PokemonGSC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(255, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "열차 등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.관리자_페이지;
            this.ClientSize = new System.Drawing.Size(458, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rsv_Btn);
            this.Controls.Add(this.Schedule_btn);
            this.Controls.Add(this.Member_btn);
            this.Name = "Admin_page";
            this.Text = "관리자 페이지";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Member_btn;
        private System.Windows.Forms.Button Schedule_btn;
        private System.Windows.Forms.Button Rsv_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}