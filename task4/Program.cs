public class Task4
{
    public static void Main(string[] args)
    {
        string input = "Hello my little friend !";
        string result = ReverseWords(input);
       
        Console.WriteLine(result);
    }
    public static string ReverseWords(string str)
    {
        string[] words = str.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
