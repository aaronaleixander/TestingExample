using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingExample
{
    public static class StringHelper
    {
        public static bool IsTextFile(string fileName)
        {
            if(string.IsNullOrWhiteSpace(fileName))
                return false;

            fileName = fileName.Trim().ToLower();

            if (fileName.Length <= 4)
                return false;

            if (!fileName.EndsWith(".txt"))
                return false;

            return true;
        }

        private static bool DoesContainSpecialCharacters(string name)
        {
            // < > $ % ^ & etc.
            if (name.Contains("<") | name.Contains(">") | name.Contains("$"))
                return true;
            return true;
        }
    }
}
