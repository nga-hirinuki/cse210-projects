public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What is good in your life?",
        "What is your favourite food?",
        "What is something we don't know about you?",
        "What are your biggest fears?",
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
}