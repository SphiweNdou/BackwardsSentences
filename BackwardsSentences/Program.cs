/*****************  UI / Program.cs  *****************/
DisplayBanner();

int numOfSentences = CnslReadPositiveInt("How many sentences do you wish to reverse? ");
var sentences = new List<string>(capacity: numOfSentences);

for (int i = 1; i <= numOfSentences; i++)
{
    string sentence = CnslReadNonEmpty($"Sentence {i}/{numOfSentences}: ");
    sentences.Add(sentence);
    Console.WriteLine("Submitted...\n");
}

Console.WriteLine("**************   Output   **************");

for (int i = 0; i < sentences.Count; i++)
{
    string reversed = ReverseSentenceHelper.ReverseSentence(sentences[i]);
    Console.WriteLine($"Case {i + 1}: {reversed}");
}

static void DisplayBanner()
{
    Console.WriteLine(new string('*', 50));
    Console.WriteLine("                Backward Sentences                ");
    Console.WriteLine(new string('*', 50));
    Console.WriteLine();
}

static int CnslReadPositiveInt(string prompt)
{
    while (true)
    {
        Console.Write(prompt);

        if (int.TryParse(Console.ReadLine(), out var n) && n > 0)
            return n;

        Console.WriteLine("Please enter a valid positive number.");
    }
}

static string CnslReadNonEmpty(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? line = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(line))
            return line.Trim();

        Console.WriteLine("The sentence cannot be empty.");
    }
}

public static class ReverseSentenceHelper
{
    public static string ReverseSentence(string sentence)
    {
        var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var reversedWords = words.Reverse();
        return string.Join(' ', reversedWords);
    }
}
