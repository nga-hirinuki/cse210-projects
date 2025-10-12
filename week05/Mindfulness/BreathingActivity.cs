

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()  
    {
      _name = "Breathing Activity";
      _description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";

    }
    
    public void Run()
    {
        DisplayStartingMessage();
        

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
               
        do {
            Console.WriteLine();
            Console.Write("Breathe in..."); 
            ShowCountDown(5);
            
            Console.WriteLine();
            Console.Write("Now breathe out..."); 
            ShowCountDown(5);
            Console.WriteLine();
            

            } while (DateTime.Now < stopTime);               

        DisplayEndingMessage();
    }
}

        

       
    
