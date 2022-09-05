/* Write a program and ask the user to enter an English word.  Count the number of vowels (a, e, i, o, u) in the word.
 * So if the user enters "inadequate", the program should display 6 on the console.*/

Console.WriteLine("Please enter an English word: ");
string input = Console.ReadLine().ToLower();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Invalid entry");
    return;
}

char[] characters = input.ToCharArray();

int vowelsCount = 0;

for (int i = 0; i < characters.Length; i++)
{
    switch (characters[i])
    {
        case 'a':
            vowelsCount++;
            break;
        case 'e':
            vowelsCount++;
            break;
        case 'i':
            vowelsCount++;
            break;
        case 'o':
            vowelsCount++;
            break;
        case 'u':
            vowelsCount++;
            break;
    }
}

Console.WriteLine(@"The number of vowels in your word was: {0}!", vowelsCount);