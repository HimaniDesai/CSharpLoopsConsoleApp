using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            Console.WriteLine("Write a program that reverses a given string.");
            Console.WriteLine("Reverse of '" + s +"'':" + reverseString("hello"));
            Console.WriteLine("Check if a given string is a palindrome.");
            s = "madam";
            Console.WriteLine("Check if '"+ s +"' is palindrome: " + checkPalindrome(s, 0, s.Length-1));
            s = "hello";
            Console.WriteLine("Check if '" + s + "' is palindrome: " + checkPalindrome(s, 0, s.Length - 1));
            Console.WriteLine("Count the number of vowels and consonants in a string.");
            s = "apple";
            int[] count = countVowelsAndConsonants(s, 0, 0, 0);
            Console.WriteLine("'" + s + "'" + ": Vowels = " + count[0] + ", Consonants = " + count[1]);
            Console.WriteLine("Remove duplicate characters from a string");
            s = "programming";
            Console.WriteLine("String '" + s + "'after removing duplicates is " + removeDuplicates(s, 0, ""));
            Console.WriteLine("Identify the first non - repeating character in a string.");
            s = "swiss";
            char result = getFirstNonRepeatingChar(s, 0, "", "");
            Console.WriteLine("First non- repeating character in '" + s + "' is: " + ('\0' != result ? result.ToString() : "No non-repeating character"));
            Console.WriteLine("Check if two strings are anagrams of each other.");
            string s1 = "listen"; string s2 = "silent";
            Console.WriteLine("Are '" + s1 + "' and '" + s2 + "' anagrams: " + checkAnagram(s1, s2, s1.Length -1).ToString());
            s1 = "hello"; s2 = "world";
            Console.WriteLine("Are '" + s1 + "' and '" + s2 + "' anagrams: " + checkAnagram(s1, s2, s1.Length -1).ToString());
            Console.WriteLine("Count the number of words in a given string.");
            s = "C# is awesome";
            Console.WriteLine("Words in the statement " + "'" + "C# is awesome" + "'" + " are: " + countWords(s).ToString());
            Console.WriteLine("Replace a specific word in a string with another word.");
            string input = "I love C#"; string word = "C#"; string replacement = "Java";
            Console.WriteLine("Replace '" + word + "' with '" + replacement + "' in the statement '" + input + "' : " + input.Replace(word, replacement));
            Console.WriteLine("Convert a string so that each word starts with an uppercase letter.");
            s = "hello world";
            Console.WriteLine("Statement '" + s + "' gets transformed into: " + capatilizeEachWord(s));
            Console.WriteLine("Find the most frequently occurring character in a string.");
            s = "success";
            Console.WriteLine("The most frequent character in string '" + s + "' is: " + mostFrequentCharacter(s));
            Console.ReadLine();
        }

        public static string reverseString(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            char[] chars = s.ToCharArray();
            return new string(reverse(chars, 0, s.Length - 1));
        }
        private static char[] reverse(char[] s, int p1, int p2)
        {
            if (p1>=p2)
            {
                return s;
            }
            char swap = s[p1];
            s[p1] = s[p2];
            s[p2] = swap;
            return reverse(s, p1+1, p2-1);
        }

        public static bool checkPalindrome(string s, int i, int j)
        {
            if (j==i || j<i || s.Length == 1 || s.Length == 0) return true;            
            return s[i] == s[j] && checkPalindrome(s, i+1, j-1);
        }

        public static int[] countVowelsAndConsonants(string s, int i, int vowels, int consonants)
        {
            if (s.Length - 1 == i)
            {
                if ("aeiou".Contains(s[i]))
                {
                    return new int[] { vowels + 1, consonants };
                }
                else { return new int[] { vowels, consonants + 1 }; }
            }

            return "aeiou".Contains(s[i]) ? countVowelsAndConsonants(s, i + 1, vowels + 1, consonants) : countVowelsAndConsonants(s, i + 1, vowels, consonants + 1);
        }

        public static string removeDuplicates(string s, int i, string result)
        {
            if (i == s.Length)
            {
                return result;
            }
            if (!result.Contains(s[i]))
            {
                result += s[i];
            }
            return removeDuplicates(s, i + 1, result);
        }

        public static char getFirstNonRepeatingChar(string s, int i, string duplicates, string result)
        {
            if (i == s.Length)
            {
                return result.Length > 0 ? result[0] : '\0';
            }
            else if (!duplicates.Contains(s[i]))
            {
                if (result.Contains(s[i]))
                {
                    duplicates += s[i];
                    result = result.Remove(result.IndexOf(s[i]), 1);
                }
                else
                {
                    result += s[i];
                }
            }
            return getFirstNonRepeatingChar(s, i+1, duplicates, result);
        }

        //Check if two strings are anagrams of each other.
        public static bool checkAnagram(string s1, string s2, int i)
        {
            if (s1.Length == s2.Length && s1.Length == 0)
            {
                return true;
            }
            else if ((s1.Length == 0 && s2.Length !=0 ) || (s1.Length !=0 && s2.Length == 0) || (s1.Length <= i) || ( s2.Length <= i))
            {
                return false;
            }
            else if (s1.Contains(s2[i]))
            {
                s1 = s1.Remove(s1.IndexOf(s2[i]), 1);
                s2 = s2.Remove(i, 1);
                return true && checkAnagram(s1, s2, i - 1);
            }
            return false;

        }

        //Count the number of words in a given string.
        public static int countWords(string s)
        {
            return s.Trim().Count(char.IsWhiteSpace) + 1;
        }

        //Convert a string so that each word starts with an uppercase letter.
        public static string capatilizeEachWord(string s)
        {
            string result = "";
            foreach (string word in s.Split(' '))
            {
                string capitalLetter = word[0].ToString().ToUpper();
                capitalLetter += word.Substring(1);
                capitalLetter += ' ';
                result += capitalLetter;
            }
            return result.Trim();
        }

        //Find the most frequently occurring character in a string.
        public static char mostFrequentCharacter(string s)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (chars.ContainsKey(c)) chars[c]++;
                else chars.Add(c, 1);
            }
            int max = chars.Values.Max();
            return chars.FirstOrDefault(x => x.Value == max).Key;
        }

    }
}
