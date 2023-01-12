using System.Text;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Palindrome Detection

// ignore case and punctuation
static (bool, int) isPalindrome(string testString)
{

    bool isPal = true;

    // strip spaces and Punc
    var sb = new StringBuilder();

    foreach (char c in testString)
    {
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
            sb.Append(c);
    }

    testString = sb.ToString();


    if ((testString.Length % 2) != 0)
    {
        return (isPal, isPal ? testString.Length : 0);
    }

    int start = 0, end = testString.Length - 1;

    while (isPal && start < testString.Length) {
        if (testString[start++] != testString[end--]) {
            isPal = false;
        }
    }

    return (isPal, isPal ? testString.Length : 0);
}

Console.WriteLine("\n\n Welcome to the Palindrome Challenge \n");

do
{

    Console.WriteLine("What string would you like to test: ");

    string input = Console.ReadLine();

    input = input.ToLower();

    if (input == "exit") {
        break;
    }

    (bool, int) test = isPalindrome(input);

    Console.WriteLine($"Palidrome: {test.Item1}, Length: {test.Item2}");

}
while (true);