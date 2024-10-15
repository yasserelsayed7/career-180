using System;

public class HighScoreApp
{
    // Global variables
    private static int highscore = 0;
    private static string highscorePlayer = "No one";

    public static void Main(string[] args)
    {
        while (true)
        {
            // Ask for user inputs
            Console.WriteLine("Enter the player's name:");
            string playerName = Console.ReadLine();

            Console.WriteLine("Enter the player's score:");
            int score = int.Parse(Console.ReadLine());

            CheckHighScore(score, playerName);

            // Ask if the user wants to continue
            Console.WriteLine("Do you want to enter another score? (yes/no)");
            string response = Console.ReadLine();
            if (response.ToLower() != "yes")
            {
                break;
            }
        }
    }

    public static void CheckHighScore(int score, string playerName)
    {
        if (score > highscore)
        {
            highscore = score;
            highscorePlayer = playerName;
            Console.WriteLine("New highscore is " + score);
            Console.WriteLine("New highscore holder is " + playerName);
        }
        else
        {
            Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
        }
    }
}
