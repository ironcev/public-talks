namespace LosingWeightWithCSharp7Plus.Snippets.OutVariables
{
    public class CompareOutVariables
    {
        public bool GetThoseImportantValues(out int value)
        {
            value = 0;
            return true;
        }

        public void Before()
        {
            int value;
            GetThoseImportantValues(out value);
        }

        public void After()
        {
            GetThoseImportantValues(out int value);
        }

        public void AfterWithTypeInference()
        {
            GetThoseImportantValues(out var value);
        }

        public void AfterWithIgnore()
        {
            GetThoseImportantValues(out _);
        }
    }
}