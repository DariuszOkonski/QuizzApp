namespace QuizzApp
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void DisplayQuestion(Question question)
        {
            DisplayHeader();
            Console.WriteLine(question.QuestionText);

            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("    ");
                Console.Write(i + 1);
                Console.ResetColor();

                Console.WriteLine($". {question.Answers[i]}");
            }
        }

        private void DisplayHeader()
        {
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("==========================================");
            Console.WriteLine("|                 Question               |");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
