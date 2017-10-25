namespace LosingWeightWithCSharp7Plus.Snippets.DefaultExpressions
{
    public class Before
    {
        public T2 CalculateSomething<T1, T2>(T1 first, T2 second = default(T2)) where T2 : new()
        {
            if (first.Equals(default(T1)))
            {
                // Do some complex logic.
                return new T2();
            }

            return default(T2);
        }
    }
}