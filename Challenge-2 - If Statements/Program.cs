using System;

class Program
{
    // Global variables for high score and high score holder
    static int highscore = 0;
    static string highscorePlayer = "";

    static void Main()
    {
        CheckHighscore(100, "Alice");
        CheckHighscore(80, "Bob");
        CheckHighscore(120, "Charlie");
    }

    static void CheckHighscore(int score, string playerName)
    {
        // Check if the new score is higher than the current high score
        if (score > highscore)
        {
            // Update the high score and high score player
            highscore = score;
            highscorePlayer = playerName;

            Console.WriteLine("New highscore is " + highscore);
            Console.WriteLine("New highscore holder is " + highscorePlayer);
        }
        else
        {
            Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
        }
    }
}
