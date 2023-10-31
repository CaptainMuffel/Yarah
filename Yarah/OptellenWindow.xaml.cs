using System;
using System.Windows;

namespace Yarah
{
    public partial class OptellenWindow : Window
    {
        private int koekjesCount = 0;
        private Random random = new Random();
        private int firstNumber;
        private int secondNumber;
        private int correctAnswer;

        private void Button_Rekenen(object sender, RoutedEventArgs e)
        {
            RekenenWindow rekenenWindow = new RekenenWindow();
            rekenenWindow.Show();
            this.Close(); // Close the current MainWindow
        }
        public OptellenWindow()
        {
            InitializeComponent();
            GenerateProblem();
        }

        private void GenerateProblem()
        {
            firstNumber = random.Next(1, 11);
            secondNumber = random.Next(1, 11);
            correctAnswer = firstNumber + secondNumber;

            ProblemText.Text = $"What is {firstNumber} + {secondNumber}?";
        }

        private void CheckAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(AnswerInput.Text, out int userAnswer))
            {
                if (userAnswer == correctAnswer)
                {
                    koekjesCount++;
                    KoekjesCount.Text = "Koekjes: " + koekjesCount;
                    GenerateProblem(); // Generate a new problem
                }
                else
                {
                    MessageBox.Show("Incorrect answer. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
            
        }
    }
}
