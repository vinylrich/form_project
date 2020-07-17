namespace lets_make_a_plaann
{
    partial class PlannerForm
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
            this.year_box = new System.Windows.Forms.TextBox();
            this.month_box = new System.Windows.Forms.TextBox();
            this.day_box = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.planner = new System.Windows.Forms.Button();
            this.diary = new System.Windows.Forms.Button();
            this.year_label = new System.Windows.Forms.Label();
            this.month_label = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.check_plan = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.text_ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // year_box
            // 
            this.year_box.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.year_box.Location = new System.Drawing.Point(220, 76);
            this.year_box.Name = "year_box";
            this.year_box.Size = new System.Drawing.Size(165, 25);
            this.year_box.TabIndex = 1;
            // 
            // month_box
            // 
            this.month_box.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.month_box.Location = new System.Drawing.Point(420, 76);
            this.month_box.Name = "month_box";
            this.month_box.Size = new System.Drawing.Size(165, 25);
            this.month_box.TabIndex = 2;
            // 
            // day_box
            // 
            this.day_box.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.day_box.Location = new System.Drawing.Point(633, 76);
            this.day_box.Name = "day_box";
            this.day_box.Size = new System.Drawing.Size(165, 25);
            this.day_box.TabIndex = 3;
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.text.Location = new System.Drawing.Point(254, 188);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(484, 265);
            this.text.TabIndex = 4;
            // 
            // planner
            // 
            this.planner.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.planner.Location = new System.Drawing.Point(796, 204);
            this.planner.Name = "planner";
            this.planner.Size = new System.Drawing.Size(116, 41);
            this.planner.TabIndex = 5;
            this.planner.Text = "플래너";
            this.planner.UseVisualStyleBackColor = true;
            this.planner.Click += new System.EventHandler(this.planner_Click);
            // 
            // diary
            // 
            this.diary.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.diary.Location = new System.Drawing.Point(796, 290);
            this.diary.Name = "diary";
            this.diary.Size = new System.Drawing.Size(116, 39);
            this.diary.TabIndex = 6;
            this.diary.Text = "일기";
            this.diary.UseVisualStyleBackColor = true;
            this.diary.Click += new System.EventHandler(this.diary_Click);
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.year_label.Location = new System.Drawing.Point(227, 51);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(124, 17);
            this.year_label.TabIndex = 7;
            this.year_label.Text = "년도를 입력하세요";
            // 
            // month_label
            // 
            this.month_label.AutoSize = true;
            this.month_label.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.month_label.Location = new System.Drawing.Point(433, 51);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(110, 17);
            this.month_label.TabIndex = 8;
            this.month_label.Text = "월을 입력하세요";
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.day_label.Location = new System.Drawing.Point(634, 51);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(110, 17);
            this.day_label.TabIndex = 9;
            this.day_label.Text = "일을 입력하세요";
            // 
            // check_plan
            // 
            this.check_plan.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.check_plan.Location = new System.Drawing.Point(796, 516);
            this.check_plan.Name = "check_plan";
            this.check_plan.Size = new System.Drawing.Size(136, 39);
            this.check_plan.TabIndex = 10;
            this.check_plan.Text = "쓴 내용 보기";
            this.check_plan.UseVisualStyleBackColor = true;
            this.check_plan.Click += new System.EventHandler(this.check_plan_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F);
            this.save.Location = new System.Drawing.Point(377, 490);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(256, 65);
            this.save.TabIndex = 11;
            this.save.Text = "저장";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // text_
            // 
            this.text_.AutoSize = true;
            this.text_.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F);
            this.text_.Location = new System.Drawing.Point(254, 164);
            this.text_.Name = "text_";
            this.text_.Size = new System.Drawing.Size(124, 17);
            this.text_.TabIndex = 12;
            this.text_.Text = "내용을 입력하세요";
            // 
            // PlannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(971, 616);
            this.Controls.Add(this.text_);
            this.Controls.Add(this.save);
            this.Controls.Add(this.check_plan);
            this.Controls.Add(this.day_label);
            this.Controls.Add(this.month_label);
            this.Controls.Add(this.year_label);
            this.Controls.Add(this.diary);
            this.Controls.Add(this.planner);
            this.Controls.Add(this.text);
            this.Controls.Add(this.day_box);
            this.Controls.Add(this.month_box);
            this.Controls.Add(this.year_box);
            this.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "PlannerForm";
            this.Padding = new System.Windows.Forms.Padding(22, 68, 22, 23);
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "planner";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox year_box;
        private System.Windows.Forms.TextBox month_box;
        private System.Windows.Forms.TextBox day_box;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button planner;
        private System.Windows.Forms.Button diary;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label month_label;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Button check_plan;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label text_;
    }
}

