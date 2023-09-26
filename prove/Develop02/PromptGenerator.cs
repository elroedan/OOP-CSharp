class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What are your plans for this weekend?",
        "Write 5 affirmations for when you are feeling low.                    ",
        "What is the best book you have read recently?",
        "How have you grown this year?",
        "What are the most important life lessons you have learned?",
        "Have trouble sleeping? What’s keeping you up?",
        "What is the last dream you remember?",
        "Name the three biggest priorities in your life right now.",
        "What are your biggest fears?",
        "Do you have a fear that is stopping you from achieving your goals?",
        "Name three challenges…. and three ways to overcome them.",
        "Write down your ultimate way to relax.",
        "What would you do if you were granted three wishes?",
        "How about if you were given five wishes?",
        "Name three bad habits you would like to change."
    };


    public string GetRandomPrompt()
    {
        Random random = new Random ();
        int listIndex = random.Next(0, _prompts.Count);
        return _prompts[listIndex];
    } 
}