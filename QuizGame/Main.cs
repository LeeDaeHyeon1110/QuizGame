using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace QuizGame {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        public static string quizDir = Path.Combine(Directory.GetCurrentDirectory(), "Quizs");

        private void GetQuizs() {
            fileList.Items.Clear();
            if (!Directory.Exists(quizDir)) {
                Directory.CreateDirectory(quizDir);
            }

            string[] quizs = Directory.GetFiles(quizDir);
            foreach (string quiz in quizs) {
                fileList.Items.Add(Path.GetFileNameWithoutExtension(quiz));
            }
            ManageEnable();
        }

        private void ManageEnable() {
            bool isSelected = fileList.SelectedIndex != -1;
            playBtn.Enabled = isSelected;
            writeBtn.Enabled = isSelected;
            delQuizBtn.Enabled = isSelected;
        }

        private void Main_Load(object sender, EventArgs e) {
            GetQuizs();
        }

        private void genQuizBtn_Click(object sender, EventArgs e) {
            QuizConfigs.CreateQuiz();
            GetQuizs();
        }

        private void delQuizBtn_Click(object sender, EventArgs e) {
            string targetFile = Path.Combine(quizDir, $"{fileList.Items[fileList.SelectedIndex]}.xml");
            File.Delete(targetFile);
            GetQuizs();
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e) {
            ManageEnable();
        }

        private void playBtn_Click(object sender, EventArgs e) {
            string targetFile = Path.Combine(quizDir, $"{fileList.Items[fileList.SelectedIndex]}.xml");
            LobbyForm form = new LobbyForm(targetFile, false);
            form.Show();
        }

        private void writeBtn_Click(object sender, EventArgs e) {
            string targetFile = Path.Combine(quizDir, $"{fileList.Items[fileList.SelectedIndex]}.xml");
            LobbyForm form = new LobbyForm(targetFile, true);
            form.Show();
        }
    }
}
