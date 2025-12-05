public class Task2
{
    public void Run()
    {
        string sentence = "apple orange banana apple kiwi banana apple";
        var words = sentence.Split(' ');

        string popularword = words[0];
        int maxCount = 1;

        foreach (var word in words)
        {
            int count = 0;

            foreach (var w in words)
            {
                if (w == word)
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                popularword = word;
            }
        }

        Console.WriteLine(popularword);
    }
}
