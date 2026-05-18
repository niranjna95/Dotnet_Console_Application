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

    public static void SomeUseFullMethodOfStringClass()
    {
        string stringValue = " FullStack Development ";

        //1. Get length of the string
        Console.WriteLine(stringValue.Length);//Output:23

        //2. Get index of specific character
        Console.WriteLine(stringValue[5]);//Output: S

        //3. Get sub-string based on index
        string subString = stringValue.Substring(5, 5);// Output: Stack
        Console.WriteLine(subString);

        //4. Get index of a character
        int index = stringValue.IndexOf("D");//Output: 11
        Console.WriteLine(index);

        //5. Remove the white spaces from start and end
        string trimmedValue = stringValue.Trim();
        Console.WriteLine(trimmedValue);// Output: FullStack Development

        //6. Replace a part of old string with some new string
        string replacedValue = stringValue.Trim().Replace("Development", ".Net Development");
        Console.WriteLine(replacedValue);//Output: FullStack .Net Development

        //7. Split the string in parts based on delimeters
        string[] parts = stringValue.Split(' ');
        foreach (var part in parts)
        {
            Console.WriteLine(part);
            /*Output:
             FullStack
             Development
            */
        }

        //8. Convert the string to character array
        char[] charArray = stringValue.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            Console.WriteLine(charArray[i]);
            /* Output: 
                F
                u
                l
                l
                S
                t
                a
                c
                k

                D
                e
                v
                e
                l
                o
                p
                m
                e
                n
                t
            */
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
}