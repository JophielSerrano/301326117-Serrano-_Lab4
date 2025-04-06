using StringExtensionsLibrary;




    class Program
    {
        static void Main(string[] args)
        {
            string[] testStrings = { "Hello", "world", "Azure", "devops" };

            foreach (var str in testStrings)
            {
                Console.WriteLine($"'{str}' starts with uppercase: {str.StartsWithUpperCase()}");
            }
        }
    }
