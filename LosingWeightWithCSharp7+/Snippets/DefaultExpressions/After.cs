namespace LosingWeightWithCSharp7Plus.Snippets.DefaultExpressions
{
    public class After
    {
        public T2 CalculateSomething<T1, T2>(T1 first, T2 second = default) where T2 : new()
        {
            if (first.Equals(default))
            {
                // Do some complex logic.
                return new T2();
            }

            return default;
        }
    }
}