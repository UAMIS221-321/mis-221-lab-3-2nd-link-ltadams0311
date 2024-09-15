using System;

class CollegeFootballIntro
{
    static void Main()
    {
        string enjoymentLevel = GetEnjoymentLevel();
        string stadium = GetStadiumRecommendation(enjoymentLevel);
        string game = GetGameRecommendation(stadium);

        DisplayStadiumDetails(stadium, game);
    }

    static string GetEnjoymentLevel()
    {
        Console.WriteLine("Welcome to the College Football Intro App!");
        Console.WriteLine("Please enter your preferred level of enjoyment (Boring, Average, Fun, Epic):");
        string enjoymentLevel = Console.ReadLine();

        while (!IsValidEnjoymentLevel(enjoymentLevel))
        {
            Console.WriteLine("Invalid input. Please enter one of the following: Boring, Average, Fun, Epic");
            enjoymentLevel = Console.ReadLine();
        }

        return enjoymentLevel;
    }

    static bool IsValidEnjoymentLevel(string level)
    {
        string[] validLevels = { "Boring", "Average", "Fun", "Epic" };
        return Array.Exists(validLevels, l => l.Equals(level, StringComparison.OrdinalIgnoreCase));
    }

    static string GetStadiumRecommendation(string enjoymentLevel)
    {
        switch (enjoymentLevel.ToLower())
        {
            case "boring":
                return "Neyland Stadium";
            case "average":
                return "Jordan-Hare Stadium";
            case "fun":
                return "Tiger Stadium";
            case "epic":
                return "Saban Field at Bryant-Denny Stadium";
            default:
                return string.Empty; 
        }
    }

    static string GetGameRecommendation(string stadium)
    {
        switch (stadium)
        {
            case "Neyland Stadium":
                return "Kent State @ Tennessee";
            case "Jordan-Hare Stadium":
                return "Kentucky @ Auburn";
            case "Tiger Stadium":
                return "Alabama @ LSU";
            case "Saban Field at Bryant-Denny Stadium":
                return "Auburn @ Alabama";
            default:
                return string.Empty; 
        }
    }

    static void DisplayStadiumDetails(string stadium, string game)
    {
        Console.WriteLine();
        Console.WriteLine("College Football Recommendation:");
        Console.WriteLine($"Stadium: {stadium}");
        Console.WriteLine($"Game: {game}");
    }
}

