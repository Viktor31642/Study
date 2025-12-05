namespace Навчання
{
    internal class Task3
    {

        public int ReturnSqure(int a) {  return a * a; }
        public bool IsPositive(int a) { if (a > 0) { return true; } else { return false; } }

        public int GetMax(int a, int b)
        {
            if (a > b) { return a; }
            else if (a < b) { return b; }
            return a;
        }
  
        public int CountLetters(string text) 
        { 
            int count  = 0;
            foreach (char c in text) 
             { 
                if (char.IsLetter(c)) {  count++; } 
            }
            return count;
        }

        public int GetVowelCount(string text)
        {
            int count = 0;
            foreach (char c in text) 
            {
                char ch = char.ToLower(c);
                if (ch == 'a') { count++; }
                if (ch == 'e') { count++; }
                if (ch == 'i') { count++; }
                if (ch == 'o') { count++; }
                if (ch == 'u') { count++; }

            }

            return count;
        }

        public int GetMaxValue(int[] numbers)
        {
            if (numbers.Length == 0) {  return 0; }
            int maxValue = numbers[0];
            foreach (int number in numbers)
            {   
                if (number > maxValue) { maxValue = number; }
            }
           return maxValue;
        }
    }
}
