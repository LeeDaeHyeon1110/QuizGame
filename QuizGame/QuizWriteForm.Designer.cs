namespace QuizGame {
    partial class QuizWriteForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizWriteForm));
            this.questionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.RadioButton();
            this.NoBtn = new System.Windows.Forms.RadioButton();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionBox
            // 
            this.questionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionBox.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.questionBox.Location = new System.Drawing.Point(0, 0);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(545, 167);
            this.questionBox.TabIndex = 4;
            this.questionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 16F);
            this.label1.Location = new System.Drawing.Point(180, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "정답은 무엇이죠?";
            // 
            // YesBtn
            // 
            this.YesBtn.AutoSize = true;
            this.YesBtn.Checked = true;
            this.YesBtn.Font = new System.Drawing.Font("맑은 고딕", 40F);
            this.YesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.YesBtn.Location = new System.Drawing.Point(12, 173);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(135, 76);
            this.YesBtn.TabIndex = 5;
            this.YesBtn.TabStop = true;
            this.YesBtn.Text = "YES";
            this.YesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YesBtn.UseVisualStyleBackColor = true;
            // 
            // NoBtn
            // 
            this.NoBtn.AutoSize = true;
            this.NoBtn.Font = new System.Drawing.Font("맑은 고딕", 40F);
            this.NoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(97)))));
            this.NoBtn.Location = new System.Drawing.Point(402, 173);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(131, 76);
            this.NoBtn.TabIndex = 6;
            this.NoBtn.Text = "NO";
            this.NoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveBtn.Location = new System.Drawing.Point(0, 268);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(545, 34);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "저장";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // QuizWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 302);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "QuizWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "퀴즈 수정 창";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.RadioButton NoBtn;
        private System.Windows.Forms.RadioButton YesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
    }
}