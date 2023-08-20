using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Hometask9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Task 1
            string word = "word";
            Console.WriteLine(word[2] + "\n");

            // Task 2
            string wort = "wort";
            Console.WriteLine((wort[1] == wort[3]) + "\n");

            // Task 3
            string clubName = "Milan";
            for (int i = 0; i < clubName.Length; i++)
            {
                Console.WriteLine(clubName[i] + "\n");
            }

            // Task 4
            string s1 = "impossible";
            StringBuilder s2 = new StringBuilder();
            for (int i = 0; i < s1.Length; i++)
            {
                if (i%2 == 0) // Odd letters are on even positions!
                {
                    s2.Append(s1[i]);
                }
            }
            Console.WriteLine(s2 + "\n");

            // Task 5
            string text = "2+2*2 = ?";
            int count = text.Count(c => c == '+');
            Console.WriteLine(count);
            count = text.Count(c => c == '*');
            Console.WriteLine(count + "\n");

            // Task 6
            string text2 = "Try to replace all \"e\"\'s in this text.";
            string replacedText = text2.Replace('e', 'i');
            Console.WriteLine(replacedText + "\n");

            // Task 7
            replacedText = text2.Replace(' ', '_');
            Console.WriteLine(replacedText + "\n");

            // Task 8
            string text3 = "3 wishes, 7 deadly sins, 12 apostols";
            string[] words = text3.Split(' ');

            var numbers = words.Where(word => Regex.IsMatch(word, @"^-?\d+(\.\d+)?$"));

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Task 9
            string text4 = "3 wishes, 7 deadly sins, 12 apostols";
            string[] words2 = text3.Split(' ');

            var numbers2 = words.Where(word => Regex.IsMatch(word, @"^-?\d+(\.\d+)?$")).Select(word => Convert.ToDouble(word));

            double sum = 0;
            foreach (double number in numbers2)
            {
                sum += number;
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine(numbers2.Max() + "\n");

            // Task 10
            string text5 = "Apple Bus Bicycle";
            StringBuilder uppercaseLetters = new StringBuilder();
            foreach (char c in text5)
            {
                if (char.IsUpper(c) && uppercaseLetters.ToString().IndexOf(c) == -1)
                {
                    uppercaseLetters.Append(c + " ");
                }
            }
            Console.WriteLine(uppercaseLetters);

            // Task 11
            string[] myWords = new string[10];
            Console.WriteLine("\nEnter 10 words.");

            for (int i = 0; i < myWords.Length; i++)
            {
                Console.Write($"Enter word #{i+1}: ");
                myWords[i] = Console.ReadLine();
            }

            Console.WriteLine("\nYour words:");
            foreach (string s in myWords)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // Task 12
            string text6 = "mama myla ramu";
            string[] text6Words = text6.Split(' ');
            for (int i = text6Words.Length - 1; i >= 0; i--)
            {
                Console.Write(text6Words[i] + " ");
            }

            // Task 13
            string sentence = "Над ринком кобзар надухнався.";

            string[] wordss = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int wordsStarting = wordss.Count(word => word.StartsWith("н", StringComparison.OrdinalIgnoreCase));
            int wordsEnding = wordss.Count(word => word.EndsWith("р", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("\n\n\"" + sentence + "\"");
            Console.WriteLine($"Кількість слів, що починаються з 'н': {wordsStarting}");
            Console.WriteLine($"Кількість слів, які закінчуються на 'р': {wordsEnding}");



        }
    }
}