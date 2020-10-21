﻿using System;

namespace GettingCharIndex
{
    public static class DoWhileMethods
    {
        public static int GetIndexOfChar(string str, char value)
        {
            // TODO #5. Analyze the implementation of "GetLastIndexOfChar(string, char)" method to see how "do..while" loop works, and implement the method using the "do..while" loop statement.
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (str.Length == 0)
            {
                return -1;
            }

            int i = 0;
            do
            {
                if (str[i] == value)
                {
                    return i;
                }

                i++;
            } while (i < str.Length);

            return -1;
        }

        public static int GetIndexOfChar(string str, char value, int startIndex, int count)
        {
            // TODO #6. Analyze the implementation of "GetLastIndexOfChar(string, char, startIndex, count)" method to see how "do..while" loop works, and implement the method using the "do..while" loop statement.
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

            if (str.Length == 0)
            {
                return -1;
            }

            int i = startIndex;
            int lastIndex = startIndex + count;
            do
            {
                if (str[i] == value)
                {
                    return i;
                }

                i++;
            } while (i < lastIndex);

            return -1;
        }

        public static int GetLastIndexOfChar(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int currentCharIndex = str.Length - 1;
            if (currentCharIndex < 0)
            {
                return -1;
            }

            do
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }
            while (currentCharIndex >= 0);

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
            if (currentCharIndex < 0)
            {
                return -1;
            }

            do
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }
            while (currentCharIndex >= startIndex);

            return -1;
        }
    }
}
