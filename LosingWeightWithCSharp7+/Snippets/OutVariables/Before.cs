using System;

namespace LosingWeightWithCSharp7Plus.Snippets.OutVariables
{
    public class Before
    {
        public bool GetThoseImportantValues(int input, out int first, out int second, out int third)
        {
            // Let's prentend that we have some heavy logic here.
            first = 1;
            second = 2;
            third = 3;
            return true;
        }

        public void UseAllThoseImportantValues()
        {
            int first;
            int second;
            int third;
            if (GetThoseImportantValues(12345, out first, out second, out third))
            {
                Console.WriteLine($"{first}.{second}.{third}");
            }
        }
    }
}