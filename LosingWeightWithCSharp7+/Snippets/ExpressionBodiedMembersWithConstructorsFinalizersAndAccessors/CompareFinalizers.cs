namespace LosingWeightWithCSharp7Plus.Snippets.ExpressionBodiedMembersWithConstructorsFinalizersAndAccessors
{
    public class FinalizerBefore
    {
        ~FinalizerBefore()
        {
            ReleaseUnmanagedResources();
        }

        private void ReleaseUnmanagedResources() { }        
    }

    public class FinalizerAfter
    {
        ~FinalizerAfter() => ReleaseUnmanagedResources();

        private void ReleaseUnmanagedResources() { }
    }
}