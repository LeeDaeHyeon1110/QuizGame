namespace QuizGame {
    partial class QuizForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.YesNoQuestion = new System.Windows.Forms.Label();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesNoQuestion
            // 
            this.YesNoQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.YesNoQuestion.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesNoQuestion.Location = new System.Drawing.Point(0, 0);
            this.YesNoQuestion.Name = "YesNoQuestion";
            this.YesNoQuestion.Size = new System.Drawing.Size(545, 167);
            this.YesNoQuestion.TabIndex = 0;
            this.YesNoQuestion.Text = "ㄸ";
            this.YesNoQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.yesBtn.FlatAppearance.BorderSize = 0;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.Location = new System.Drawing.Point(-3, 170);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(274, 132);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "YES";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.noBtn.FlatAppearance.BorderSize = 0;
            this.noBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noBtn.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.noBtn.ForeColor = System.Drawing.Color.White;
            this.noBtn.Location = new System.Drawing.Point(272, 170);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(273, 132);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.BackColor = System.Drawing.Color.White;
            this.resultLbl.Font = new System.Drawing.Font("맑은 고딕", 25F);
            this.resultLbl.ForeColor = System.Drawing.Color.White;
            this.resultLbl.Location = new System.Drawing.Point(-3, 170);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(548, 132);
            this.resultLbl.TabIndex = 3;
            this.resultLbl.Text = "정답입니다!";
            this.resultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLbl.Visible = false;
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 302);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.YesNoQuestion);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자 여기서 퀴즈!";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Label YesNoQuestion;
        private System.Windows.Forms.Label resultLbl;
    }
}