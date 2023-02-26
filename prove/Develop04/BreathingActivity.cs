
public class BreathingActivity : Activity {

    // I need the msg store in variables to be able to use the overwrite line.
    private string _msgIn = "Breathe in...";
    private string _msgOut = "Breathe out...";

    public BreathingActivity(int timeActivity) : base(timeActivity) 
    { // always calling the contructos 
    }

    public void ActivityPrompt()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void BreathingExercise(int seconds)
    {
        int timer = 0;

        while (timer < seconds)
        {
            for (int i = 4; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"{_msgIn}{i}");
                Thread.Sleep(1000); // wait for 1 second
                timer += 1;
            }

            for (int i = 4; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"{_msgOut}{i}");
                Thread.Sleep(1000); // wait for 1 second
                timer += 1;
            }
        }
    }
}