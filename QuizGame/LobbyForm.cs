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
    public partial class LobbyForm : Form {
        private string file;
        private bool isWriteMode;

        public LobbyForm(string file, bool writeMode) {
            InitializeComponent();
            this.file = file;
            this.isWriteMode = writeMode;
            if (writeMode) {
                label13.Text = "수정 모드";
            } else {
                label13.Text = "살려줘요..";
            }
        }

        private void LobbyForm_Load(object sender, EventArgs e) {
            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E' };
            for (int i = 0; i < 5; i++) {
                FlowLayoutPanel panel = (FlowLayoutPanel)MainPanel.Controls[i];
                for (int j = 0; j < 5; j++) {
                    QuizButton btn = new QuizButton(file, isWriteMode);
                    btn.Text = $"문제 {alphabet[i]}{j+1}";
                    panel.Controls.Add(btn);
                }
            }
        }
    }
}
