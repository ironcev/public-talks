using System;

namespace LosingWeightWithCSharp7Plus.Snippets.DefaultExpressions
{
    public class DefaultIssue
    {
        public bool IsEqualToDefaultWithT<T>(T value)
        {
            return value.Equals(default(T)) ? true : false;
        }

        public bool IsEqualToDefaultWithoutT<T>(T value)
        {
            return value.Equals(default) ? true : false;
        }

        public static void TestMe()
        {
            var test = new DefaultIssue();

            Console.WriteLine( test.IsEqualToDefaultWithT(0) ); // Prints true.
            Console.WriteLine( test.IsEqualToDefaultWithoutT(0) ); // Prints false!
        }
    }
}