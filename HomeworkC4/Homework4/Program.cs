using System;

namespace Homework4
{
    class Program
    {
        static void FunWithStrings(string inputString)
        {
            #region revesingString

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                Console.Write(inputString[i]);
            }
            Console.WriteLine();
            Console.WriteLine("================================");
            #endregion
            #region numberOfVowels
            string inputStringtoLowerCase = inputString.ToLower();
            int vowelCounter = 0;
            for (int i = 0; i < inputStringtoLowerCase.Length; i++)
            {
                switch (inputStringtoLowerCase[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCounter++;
                        break;
                    default:
                        continue;

                }
            }
            Console.WriteLine($"There are {vowelCounter} vowels in your string.");
            Console.WriteLine("================================");

            #endregion
            #region checkIfPalindrome    

            string stringReversed = "";
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                stringReversed += inputString[i];
            }            
            string statement = stringReversed == inputString ? "sentence is palindrome" : "sentence is not palindrome";
            Console.WriteLine(statement);
            Console.WriteLine("================================");
            #endregion
            #region largestWord
            string[] ArrayOfSplitedInputStringWords = inputString.Split(' ');
            int wordLength = 0;
            string longestWord = "";
            foreach (string word in ArrayOfSplitedInputStringWords)
            {
                if (word.Length > wordLength)
                {
                    wordLength = word.Length;
                    longestWord = word;
                }
                else continue;
            }
            Console.WriteLine(@$"The longest word is ""{longestWord}"" and is {wordLength} character long");
            Console.WriteLine("================================");

            #endregion
            #region smallestWord
            string[] ArrayOfSplitedInputStringWords2 = inputString.Split(' ');
            int wordLength2 = 1000000;
            string shortestWord = "";
            foreach (string word in ArrayOfSplitedInputStringWords2)
            {
                if (word.Length < wordLength2)
                {
                    wordLength2 = word.Length;
                    shortestWord = word;
                }
                else continue;
            }
            Console.WriteLine(@$"The shortest word is ""{shortestWord}"" and is {wordLength2} character short");
            Console.WriteLine("================================");

            #endregion
            #region countOfWords
            string[] ArrayOfSplitedInputStringWords3 = inputString.Split(' ');
            Console.WriteLine($"The sentence has {ArrayOfSplitedInputStringWords3.Length} words");
            Console.WriteLine("================================");

            #endregion
            #region mostUsedCharacter
            char mostUsedChar = ' ';
            int characterUsedCount = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                int characterUsedCountInThisCycle = 0;
                for (int l = 0; l < inputString.Length; l++)
                {
                    if (inputString[i] == inputString[l]) characterUsedCountInThisCycle++;
                    if (characterUsedCountInThisCycle > characterUsedCount && inputString[i] != ' ')
                    {
                        characterUsedCount = characterUsedCountInThisCycle;
                        mostUsedChar = inputString[i];
                    }
                    else continue;
                }
            }
            Console.WriteLine($"Most used char is '{mostUsedChar}' and is {characterUsedCount} times used.");
            Console.WriteLine("================================");
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Fun With Strings");
            Console.WriteLine("================================");
            FunWithStrings("Jas sum hristijan petreski");

            Console.ReadLine();
        }
        
    }
}
