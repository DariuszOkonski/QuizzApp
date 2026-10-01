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

            if (GetUserChoice() == question.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }

        private int GetUserChoice()
        {
            Console.WriteLine("Your answer (number): ");
            string input = Console.ReadLine();

            int choice = 0;

            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
                input = Console.ReadLine();
            }

            return choice - 1;
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
