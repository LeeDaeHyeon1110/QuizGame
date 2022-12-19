using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace QuizGame {
    public class QuizConfigs {
        public string content;
        public bool answer;

        public QuizConfigs(string content, bool answer) {
            this.content = content;
            this.answer = answer;
        }

        public static void CreateQuiz() {
            XmlDocument doc = new XmlDocument();
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));
            XmlNode quiz = doc.CreateElement("quiz");
            for (int i = 0; i < 5; i++) {
                XmlNode category = doc.CreateElement("category");
                for (int j = 0; j < 5; j++) {
                    XmlNode question = doc.CreateElement("question");
                    XmlAttribute content = doc.CreateAttribute("content");
                    content.Value = "";
                    
                    XmlAttribute answer = doc.CreateAttribute("answer");
                    answer.Value = "true";
                    
                    question.Attributes.Append(content);
                    question.Attributes.Append(answer);
                    category.AppendChild(question);
                }
                quiz.AppendChild(category);
            }
            doc.AppendChild(quiz);

            int n = 1;
            while(true) {
                string path = Path.Combine(Main.quizDir, $"Quiz{n++}.xml");
                if (!File.Exists(path)) {
                    doc.Save(path);
                    break;
                }
            }
        }

        public static QuizConfigs GetQuizConfig(string file, int category, int question) {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlNodeList categories = doc.GetElementsByTagName("category");
            XmlNode node = categories[category].ChildNodes[question];

            return new QuizConfigs(
                node.Attributes["content"].InnerText, 
                Boolean.Parse(node.Attributes["answer"].InnerText)
            );
        }

        public static void SaveQuizConfig(QuizConfigs config, string file, int category, int question) {
            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            XmlNodeList categories = doc.GetElementsByTagName("category");
            XmlNode node = categories[category].ChildNodes[question];
            node.Attributes["content"].InnerText = config.content;
            node.Attributes["answer"].InnerText = config.answer.ToString();
            doc.Save(file);
        }
    }
}
