
using System.Runtime.CompilerServices;

class QuizProgram
{

    static void Main() {
// create questions
string[] questions = 
{
    "For what movie did Steven Spielberg win his first Oscar for Best Director?",
    "In the movie Babe, what is Babe's role on the farm??",
    "What is the movie in which Jim Carrey discovers that his everyday life is really a TV show about him??"
};

string [] answers = 
{
    "A. The hunger Games \nB. Schindler's List  \nC. The hunger Games ",

    "A. The hunger Games \nB. Schindler's List  \nC. Sheep herding",

    "A. The hunger Games \nB. Schindler's List  \nC. The Truman Show",
};

int[] correctAnswers = {1, 2, 2};
int playerScore = 0;

Console.WriteLine("Welecome to the movies quiz");
for(int i = 0; i < questions.Length; i++) {
    Console.WriteLine("Question " + (i + 1));
    Console.WriteLine(questions[i]);
    Console.WriteLine(answers[i]);
    Console.Write("Choose your answer ('A','B','C'): ");
    String playerAnswer = Console.ReadLine();

    if(string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0) {
playerScore++;
    } else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1) {
playerScore ++;
    } else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2) {
playerScore++;
}}
Console.WriteLine("YOUR SCORE IS: " + playerScore + "/" + questions.Length);
    }
}