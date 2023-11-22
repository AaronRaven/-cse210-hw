public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected Animation _animation;
    protected Countdown _countdown;

    private static Dictionary<string, int> _activationCount =
        new Dictionary<string, int>(){
            {"Breathing", 0},
            {"Reflection", 0},
            {"Listing", 0}
        };
    private static Dictionary<string, int> _totalDuration =
        new Dictionary<string, int>(){
            {"Breathing", 0},
            {"Reflection", 0},
            {"Listing", 0}
        };
    public Activity()
    {
        _animation = new Animation();
        _countdown = new Countdown();
    }
    public void RunStartingSequence()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        _animation.Display(5);
        
        _activationCount[_name]++;
        _totalDuration[_name] += _duration;
    }

    public void RunEndingSequence()
    {
        Console.WriteLine("\nWell done!!");
        _animation.Display(5);
       Console.WriteLine($"You have completed another {_duration} " +
            $"seconds of the {_name} Activity.");
        _animation.Display(5);
    }
}