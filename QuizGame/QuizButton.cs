using System;
using System.Windows.Forms;
using System.Drawing;

namespace QuizGame {
    public class QuizButton : Button {
        public string file;
        public bool isWriteMode;
        public QuizButton(string file, bool isWriteMode) {
            this.UseVisualStyleBackColor = true;
            this.Size = new Size(130, 87);
            this.Font = new Font("맑은 고딕", 16f);
            this.Click += new EventHandler(Clicked);
            this.file = file;
            this.isWriteMode = isWriteMode;
        }

        private void Clicked(object sender, EventArgs e) {
            FlowLayoutPanel col = (FlowLayoutPanel)this.Parent;
            int j = col.Controls.IndexOf(this);

            FlowLayoutPanel main = (FlowLayoutPanel)col.Parent;
            int i = main.Controls.IndexOf(col);

            QuizConfigs config = QuizConfigs.GetQuizConfig(file, i, j);
            if (isWriteMode) {
                QuizWriteForm form = new QuizWriteForm(config.content, config.answer, file, i, j);
                form.Show();
            } else {
                QuizForm form = new QuizForm(config.content, config.answer);
                form.Show();
            }
        }
    }
}
