public static class StringCodingProblems
{

    public static void CountNumberOfCharInString()
    {
        string strChar = "C# Programing";
        var charArray = strChar.ToCharArray();
        int numberOfChar = 0;

        for (int i = 0; i < charArray.Length; i++)
        {
            numberOfChar = i + 1;
        }
        Console.WriteLine(numberOfChar);
        //Output: 13
    }
    public static void ReverseString()
    {
        string strChar = "Niranjan";
        var charArray = strChar.ToCharArray();
        string reversedString = "";

        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reversedString += charArray[i].ToString();
        }
        Console.WriteLine(reversedString);
        //Output: najnariN
    }
    public static void CheckPalindrome()
    {
        string strChar = "level";
        var charArray = strChar.ToCharArray();
        string reversedString = "";

        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reversedString += charArray[i].ToString();
        }
        Console.WriteLine(strChar.Equals(reversedString));
        //Output: True
    }

    public static void SomeUsefulMethodsOfStringClass()
    {
        string stringValue = " FullStack Development ";

        //1. Get length of the string
        Console.WriteLine(stringValue.Length); // Output: 23

        //2. Get character at specific index
        Console.WriteLine(stringValue[5]); // Output: S

        //3. Get substring based on index
        string subString = stringValue.Substring(5, 5);
        Console.WriteLine(subString); // Output: Stack

        //4. Get index of a character
        int index = stringValue.IndexOf("D");
        Console.WriteLine(index); // Output: 11

        //5. Remove white spaces from start and end
        string trimmedValue = stringValue.Trim();
        Console.WriteLine(trimmedValue); // Output: FullStack Development

        //6. Replace old string with new string
        string replacedValue = stringValue.Trim()
                                          .Replace("Development", ".Net Development");
        Console.WriteLine(replacedValue);
        // Output: FullStack .Net Development

        //7. Split string based on delimiter
        string[] parts = stringValue.Trim().Split(' ');
        foreach (var part in parts)
        {
            Console.WriteLine(part);
        }

        //8. Convert string to character array
        char[] charArray = stringValue.Trim().ToCharArray();
        foreach (char ch in charArray)
        {
            Console.WriteLine(ch);
        }
    }

    public static void FindLongestWordInSentence()
    {
        string testSentence = "Do more practices for best result";
        string[] words = testSentence.Split(' ');
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine(longestWord);//Output: practices

    }

    public static void CountVowels()
    {
        string inputString = "Niranjan";
        string vowels = "aeiouAEIOU";
        int vowelsCount = 0;

        foreach (char ch in inputString)
        {
            if (vowels.IndexOf(ch) != -1)
            {
                vowelsCount++;
            }
        }

        Console.WriteLine(vowelsCount);
    }

    public static void AraAnagrems()
    {
        string inputTextOne = "listen";
        string inputTextTwo = "silent";
        //Convert both the strings to charatcter arrays
        char[] charArray1 = inputTextOne.ToCharArray();
        char[] charArray2 = inputTextTwo.ToCharArray();

        Array.Sort(charArray1);
        Array.Sort(charArray2);

        for (int i = 0; i < charArray1.Length; i++)
        {
            if (charArray1[i] != charArray2[i])
            {
                Console.WriteLine(false);
            }
        }
        Console.WriteLine(true);
    }
}