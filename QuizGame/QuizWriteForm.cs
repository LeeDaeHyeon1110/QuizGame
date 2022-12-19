using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame {
    public partial class QuizWriteForm : Form {
        public bool answer = false;
        public string file;
        public int i;
        public int j;
        public QuizWriteForm(string question, bool answer, string file, int i, int j)
        {
            InitializeComponent();
            this.answer = answer;
            questionBox.Text = question;
            this.i = i;
            this.j = j;
            this.file = file;
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            QuizConfigs.SaveQuizConfig(
                new QuizConfigs(questionBox.Text, YesBtn.Checked),
                file, i, j
            );
            this.Close();
        }
    }
}
