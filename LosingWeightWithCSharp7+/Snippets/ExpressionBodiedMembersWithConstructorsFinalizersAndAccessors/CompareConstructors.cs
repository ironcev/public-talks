namespace LosingWeightWithCSharp7Plus.Snippets.ExpressionBodiedMembersWithConstructorsFinalizersAndAccessors
{
    public class ConstructorBefore
    {
        public ConstructorBefore(int id)
        {
            Id = id;
        }

        public int Id { get; }        
    }

    public class ConstructorAfter
    {
        public ConstructorAfter(int id) => Id = id;

        public int Id { get; }
    }
}