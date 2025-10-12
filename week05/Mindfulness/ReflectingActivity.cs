public class ReflectingActivity : Activity
{
    protected List<string> _prompts;
    protected List<string> _questions;

    public ReflectingActivity() : base()
    {
        _prompts = new List<string> 
        {
            "Think of a time when you faced a fear and overcame it.",
            "Think of a time when you supported someone who was feeling alone.",
            "Think of a time when you made a difference in someone’s life.",
            "Think of a time when you showed kindness without expecting anything in return.",
            "Think of a time when you took responsibility for something important.",
            "Think of a time when you spoke up for what was right.",
            "Think of a time when you persevered through a challenge.",
       };
        _questions = new List<string> 
        { 
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
         };
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Starting in... "); 
        ShowCountDown(5);
        Console.WriteLine();
        
        Console.Clear();
        DisplayPrompt();
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
               
        do {
            DisplayQuestions();

        } while (DateTime.Now < stopTime);               
 
        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following\n");
        Console.WriteLine("--- " + prompt + " ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }
    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine("> " + question);
        ShowSpinner(6);
    }

}
