public class ListeningActivity
{
    private int _count;
    private List<string> _prompts;

    public ListeningActivity()
    {

    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        string[] _prompts = File.ReadAllLines("listeningprompts.txt");
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count());
        Console.WriteLine($"{_prompts[index]}");
    }

    public List<string> GetListFromUser()
    {
        List<string> _fromUser = new List<string>();
        return _fromUser;
    }
}