using System;

namespace LosingWeightWithCSharp7Plus.Snippets.DefaultExpressions
{
    // Example taken from (and slightly adapted):
    //      https://github.com/dotnet/csharplang/issues/970
    public class CompilerDefaultExpressionIssue
    {
        public void ShowIssue()
        {
            int? x = default; // null
            int y = default; // 0

            Console.WriteLine(x); // null
            Console.WriteLine(y); // 0

            ProblematicMethod(); // 0 !!
            ProblematicMethod(default); // null !!
        }

        static void ProblematicMethod(int? x = default) // 0 !!
        {
            Console.WriteLine(x);
        }

        public static void TestMe()
        {
            var test = new CompilerDefaultExpressionIssue();

            test.ShowIssue();
        }
    }
}