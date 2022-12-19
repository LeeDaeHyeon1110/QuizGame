namespace QuizGame {
    partial class Main {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.writeBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.genQuizBtn = new System.Windows.Forms.Button();
            this.delQuizBtn = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 30F);
            this.label1.Location = new System.Drawing.Point(72, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "퀴즈 게임";
            // 
            // writeBtn
            // 
            this.writeBtn.Enabled = false;
            this.writeBtn.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.writeBtn.Location = new System.Drawing.Point(45, 255);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(257, 61);
            this.writeBtn.TabIndex = 1;
            this.writeBtn.Text = "수정 모드";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Enabled = false;
            this.playBtn.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.playBtn.Location = new System.Drawing.Point(45, 167);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(257, 61);
            this.playBtn.TabIndex = 2;
            this.playBtn.Text = "플레이";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "쌤 1일만에 마감은 너무한거 아니예요? ㅠㅠ";
            // 
            // genQuizBtn
            // 
            this.genQuizBtn.Location = new System.Drawing.Point(339, 347);
            this.genQuizBtn.Name = "genQuizBtn";
            this.genQuizBtn.Size = new System.Drawing.Size(89, 23);
            this.genQuizBtn.TabIndex = 5;
            this.genQuizBtn.Text = "생성";
            this.genQuizBtn.UseVisualStyleBackColor = true;
            this.genQuizBtn.Click += new System.EventHandler(this.genQuizBtn_Click);
            // 
            // delQuizBtn
            // 
            this.delQuizBtn.Enabled = false;
            this.delQuizBtn.Location = new System.Drawing.Point(434, 347);
            this.delQuizBtn.Name = "delQuizBtn";
            this.delQuizBtn.Size = new System.Drawing.Size(95, 23);
            this.delQuizBtn.TabIndex = 7;
            this.delQuizBtn.Text = "삭제";
            this.delQuizBtn.UseVisualStyleBackColor = true;
            this.delQuizBtn.Click += new System.EventHandler(this.delQuizBtn_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.IntegralHeight = false;
            this.fileList.ItemHeight = 15;
            this.fileList.Location = new System.Drawing.Point(339, 12);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(190, 329);
            this.fileList.TabIndex = 8;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 379);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.delQuizBtn);
            this.Controls.Add(this.genQuizBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "퀴즈 게임";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button writeBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button genQuizBtn;
        private System.Windows.Forms.Button delQuizBtn;
        private System.Windows.Forms.ListBox fileList;
    }
}