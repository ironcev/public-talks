using System;

namespace LosingWeightWithCSharp7Plus.Snippets.OutVariables
{
    public class After
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
            if (GetThoseImportantValues(12345, out int first, out int second, out int third))
            {
                Console.WriteLine($"{first}.{second}.{third}");
            }
        }

        public void UseAllThoseImportantValuesWithTypeInference()
        {
            if (GetThoseImportantValues(12345, out var first, out var second, out var third))
            {
                Console.WriteLine($"{first}.{second}.{third}");
            }
        }

        public void UseOnlySomeImportantValues()
        {
            if (GetThoseImportantValues(12345, out _, out _, out var third))
            {
                Console.WriteLine($"{third}");
            }
        }
    }
}