using StringExtensionsLibrary;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] testStrings = { "Hello", "world", "Testing", "" };

            foreach (var str in testStrings)
            {
                Console.WriteLine($"'{str}' starts with uppercase: {str.StartsWithUpperCase()}");
            }
        }
    }
}
