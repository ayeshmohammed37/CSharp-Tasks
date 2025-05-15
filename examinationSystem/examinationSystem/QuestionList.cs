using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examinationSystem
{
    public class QuestionList : List<Question>
    {
        private string LogFilePath { get; set; }

        public QuestionList(string logFilePath)
        {
            LogFilePath = logFilePath;

            // Create the log file if it doesn't exist
            if (!File.Exists(LogFilePath))
            {
                using (FileStream fs = File.Create(LogFilePath))
                {
                    // Just creating the file
                }
            }
        }

        public new void Add(Question question)
        {
            // Maintain default behavior
            base.Add(question);

            // Add logging functionality
            LogQuestionToFile(question);
        }

        private void LogQuestionToFile(Question question)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(LogFilePath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] Added: {question}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error logging question: {ex.Message}");
            }
        }

        public List<Question> ReadQuestionsFromFile()
        {
            List<Question> questions = new List<Question>();

            try
            {
                using (TextReader reader = new StreamReader(LogFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine($"Log entry: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading questions: {ex.Message}");
            }

            return questions;
        }
    }
}
