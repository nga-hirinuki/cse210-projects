public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
   
    { //initialize _name, _description, _duration
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage() 
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine(_description +"\n");
    
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready... ");
        ShowSpinner(3);
        Console.WriteLine();
        
    }
    public void DisplayEndingMessage() // fix this and see if this works for others 
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}" );
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
            //Datetime Animation for duration of program
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            
            int i = 0;

            while (DateTime.Now < endTime)
            {
                string s = animationStrings[i];
                Console.Write(s);
                Thread.Sleep(500);
                Console.Write("\b \b");
                i++;

                if (i >= animationStrings.Count)
                {
                    i = 0;
                }
            }
            
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }       
    }
}