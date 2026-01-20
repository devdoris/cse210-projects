using System;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Did I exercise today?",
        "What did I have for breakfast?",
        "How can I reach my daily goals?",
        "What am I grateful for today?",
        "Have I been kind to anyone today?",
        "What can I do different today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
