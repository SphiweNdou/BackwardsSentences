Console.WriteLine("**************************************************");
Console.WriteLine("                Backward Sentences               ");
Console.WriteLine("**************************************************\n");

Console.WriteLine("How many sentences do you wish to reverse? Please input the number:");
var input =  Console.ReadLine();
int numOfSentences = 0;

while ( !int.TryParse(input, out numOfSentences)) 
{
    Console.WriteLine("Please enter a valid numerical value:");
    input = Console.ReadLine();
}

Console.WriteLine("Thank you.\n");
List<string> sentences = new();

for (int i = 0; i < numOfSentences; i++)
{
    Console.WriteLine("Please enter the sentence you wish to reverse:");
    var userInput = Console.ReadLine();

    while (string.IsNullOrEmpty(userInput))
    {
        Console.WriteLine("Please enter a valid sentence you wish to reverse:");
        userInput = Console.ReadLine();
    }

    sentences.Add(userInput);
    Console.WriteLine("Submitted...");
}

Console.WriteLine("\nOutput");
int count =0;

foreach (var sentence in sentences)
{
    count++;
    Console.WriteLine(@"Case {0}: {1}", count, ReverseSentenceHelper.ReverseSentence(sentence));
}

Console.ReadLine();

public static class ReverseSentenceHelper
{
    public static string ReverseSentence(string sentence)
    {
        var words = sentence.Split(' ');
        var reversedWords = words.Reverse();
        return string.Join(' ', reversedWords);
    }
}
