var words = new List<string> { "cat", "beautiful", "sky", "mountain", "queue" };

var theloggestword = words[0];
int maxVowels = 0;

foreach (var word in words)
{
    int count = 0;

    foreach (var letter in word)
    {
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            count++;
    }

    if (count > maxVowels)
    {
        maxVowels = count;
        theloggestword = word;
    }
}

Console.WriteLine(theloggestword);