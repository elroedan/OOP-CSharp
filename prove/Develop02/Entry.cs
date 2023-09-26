class Entry 
{
    public string _date;
    public string _entryText;
    public string _promptText;

    public void Display()
    {
        System.Console.WriteLine($"Date: {_date} Prompt: {_promptText} \n Entry: {_entryText}");
    }
}