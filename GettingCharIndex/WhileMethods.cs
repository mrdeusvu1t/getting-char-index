using System;

namespace GettingCharIndex
{
    public static class WhileMethods
    {
        public static int GetIndexOfChar(string str, char value)
        {
            // TODO #3. Analyze the implementation of "GetLastIndexOfChar(string, char)" method to see how "while" loop works, and implement the method using the "while" loop statement.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == value)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        public static int GetIndexOfChar(string str, char value, int startIndex, int count)
        {
            // TODO #4. Analyze the implementation of "GetLastIndexOfChar(string, char, int, int)" method to see how "while" loop works, and implement the method using the "while" loop statement.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            int i = startIndex;
            int lastIndex = startIndex + count;
            while(i < lastIndex)
            {
                if (str[i] == value)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        public static int GetLastIndexOfChar(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int currentCharIndex = str.Length - 1;
            while (currentCharIndex >= 0)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }

            return -1;
        }

        public static int GetLastIndexOfChar(string str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            int currentCharIndex = startIndex + count - 1;
            while (currentCharIndex >= startIndex)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }

            return -1;
        }
    }
}
