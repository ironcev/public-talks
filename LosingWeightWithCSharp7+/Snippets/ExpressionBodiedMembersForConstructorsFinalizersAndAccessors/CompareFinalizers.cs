namespace LosingWeightWithCSharp7Plus.Snippets.ExpressionBodiedMembersForConstructorsFinalizersAndAccessors
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