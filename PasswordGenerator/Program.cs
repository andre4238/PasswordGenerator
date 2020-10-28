using System;

namespace PasswordGenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            generateRandomPassword();
        }

        public static void generateRandomPassword()
        {
            Random random = new Random();
            int length = 16;
            var rString = "";
            for (var i = 0; i < length; i++)
            {
                rString += ((char)(random.Next(1, 26) + 64)).ToString().ToLower();
            }
            Console.WriteLine(rString);
        }

    }
}
