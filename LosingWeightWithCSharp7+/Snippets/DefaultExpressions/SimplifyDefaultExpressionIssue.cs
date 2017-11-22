using System;

namespace LosingWeightWithCSharp7Plus.Snippets.DefaultExpressions
{
    public class SimplifyDefaultExpressionIssue
    {
        public bool IsEqualToDefaultWithT<T>(T value)
        {
            return value.Equals(default(T));
        }

        public bool IsEqualToDefaultWithoutT<T>(T value)
        {
            return value.Equals(default);
        }

        public static void TestMe()
        {
            var test = new SimplifyDefaultExpressionIssue();

            Console.WriteLine( test.IsEqualToDefaultWithT(0) ); // Prints true.
            Console.WriteLine( test.IsEqualToDefaultWithoutT(0) ); // Prints false!
        }
    }
}