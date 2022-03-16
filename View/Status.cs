public class Status{

    public static int streak = 0;
    public bool asked = false;

    public void printStatus(){
        SaveStreak();
        LoadStreak();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Current Streak: " + streak);
        Console.WriteLine("--------------------------");
    }

    public void askStatus(){
        Console.WriteLine("Have you finished you Task today? (y/n)");
        String input = Console.ReadLine();
        switch(input){
            case("Y"):
            case("y"):
                Console.WriteLine("Great!");
                streak++;
                asked = true;
                printStatus();
                break;
            case("N"):
            case("n"):
                Console.WriteLine("Bad!");
                streak = 0;
                asked = true;
                printStatus();
                break;
        }
    }

    public static async Task SaveStreak()
    {
        await File.WriteAllTextAsync("Streak.txt", streak.ToString());
    }

    public void LoadStreak(){
        string text = System.IO.File.ReadAllText("Streak.txt");
        streak = Int32.Parse(text);
    }
}