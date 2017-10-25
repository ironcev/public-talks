using System;

namespace LosingWeightWithCSharp7Plus.Snippets.PatternMatching
{
    public class ComparePatternMachingForNulls
    {
        public void CompareWithNull(string text)
        {
            if (text == null) return;
        }

        public void MatchWithNull(string text)
        {
            if (text is null) return;
        }
    }

    public class ComparePatternMachingForConstants
    {
        public void CompareWithConstant(string text)
        {
            if (text == "") return;
        }

        public void MatchWithConstant(string text)
        {
            if (text is "") return;
        }
    }

    public class ShowPatternMachingInIfStatement
    {
        public void ShowPatternMaching(object o)
        {
            if (o is string s) return;
        }
    }

    public class ShowPatternMachingInSwitchCaseStatement
    {
        public void ShowPatternMachingWithReturn(object o)
        {
            switch (o)
            {
                case string s:
                    Console.WriteLine(s);
                    return;
                case int i:
                    Console.WriteLine(i);
                    return;
            }
        }

        public void ShowPatternMachingWithBreak(object o)
        {
            switch (o)
            {
                case string s:
                    Console.WriteLine(s);
                    break;
                case int i:
                    Console.WriteLine(i);
                    break;
            }

            Console.WriteLine();
        }
    }
}