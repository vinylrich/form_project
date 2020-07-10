namespace lets_make_a_plaann
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.planner = new System.Windows.Forms.Button();
            this.diary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "년도를 입력하세요";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(373, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "월을 입력하세요";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(563, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 25);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "일을 입력하세요";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(226, 166);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(431, 234);
            this.textBox4.TabIndex = 4;
            // 
            // planner
            // 
            this.planner.Location = new System.Drawing.Point(708, 180);
            this.planner.Name = "planner";
            this.planner.Size = new System.Drawing.Size(103, 36);
            this.planner.TabIndex = 5;
            this.planner.Text = "플래너";
            this.planner.UseVisualStyleBackColor = true;
            this.planner.Click += new System.EventHandler(this.planner_Click);
            // 
            // diary
            // 
            this.diary.Location = new System.Drawing.Point(708, 256);
            this.diary.Name = "diary";
            this.diary.Size = new System.Drawing.Size(103, 34);
            this.diary.TabIndex = 6;
            this.diary.Text = "일기";
            this.diary.UseVisualStyleBackColor = true;
            this.diary.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 533);
            this.Controls.Add(this.diary);
            this.Controls.Add(this.planner);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button planner;
        private System.Windows.Forms.Button diary;
    }
}

