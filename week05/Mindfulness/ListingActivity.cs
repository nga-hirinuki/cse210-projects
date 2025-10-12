using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    protected int _count;
   protected List<string> _prompts;

    public ListingActivity() : base()
    {
        _count = 0;
        _prompts = new List<string> 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life \nby having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandonPrompt();
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);

        Console.Write("You may begin in: ");
        ShowCountDown(4);
        Console.WriteLine();
        
        
        List<string> thoughts = new List<string>();
            string input;
        do {
            Console.Write("> ");
            input = GetListFromnUser();
            
            List<string> items = input
            .Split(',')
            .Where(item => !string.IsNullOrWhiteSpace(item))
            .ToList();

            thoughts.AddRange(items);  // Add all valid items from 'items' to 'thoughts'

            _count = items.Count;  // Update count of valid items
            
            
            } while (DateTime.Now < stopTime);
            Console.WriteLine($"You Listed {thoughts.Count} item(s).");
            

            DisplayEndingMessage();
            
    }        
            

    public void GetRandonPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");
    }
    public string GetListFromnUser()
    {
        string input = Console.ReadLine();
        
        // List<string> items = input
        //     .Split(',')
        //     .Where(item => !string.IsNullOrWhiteSpace(item))
        //     .ToList();

        // _count = items.Count;

        // Console.WriteLine($"You Listed {_count} item(s).");
        return input;
    }


}