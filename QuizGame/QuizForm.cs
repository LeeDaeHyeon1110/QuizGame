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
    public partial class QuizForm : Form {
        public bool answer = false;
        public QuizForm(string question, bool answer) {
            InitializeComponent();
            this.answer = answer;
            YesNoQuestion.Text = question;
        }

        private void yesBtn_Click(object sender, EventArgs e) {
            if (answer) {
                resultLbl.BackColor = Color.FromArgb(119, 221, 119);
                resultLbl.Text = "정답입니다!";
                resultLbl.Visible = true;
            } else {
                resultLbl.BackColor = Color.FromArgb(255, 105, 97);
                resultLbl.Text = "틀렸습니다!";
                resultLbl.Visible = true;
            }
        }

        private void noBtn_Click(object sender, EventArgs e) {
            if (!answer) {
                resultLbl.BackColor = Color.FromArgb(119, 221, 119);
                resultLbl.Text = "정답입니다!";
                resultLbl.Visible = true;
            } else {
                resultLbl.BackColor = Color.FromArgb(255, 105, 97);
                resultLbl.Text = "틀렸습니다!";
                resultLbl.Visible = true;
            }
        }
    }
}
