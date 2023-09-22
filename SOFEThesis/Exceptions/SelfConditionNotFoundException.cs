namespace SOFEThesis.Exceptions
{
    public class SelfConditionNotFoundException : Exception
    {
        public SelfConditionNotFoundException() : base("Self Condition Is Not Found!")
        {
        }
    }
    public class CompoundConditionNotFoundException : Exception
    {
        public CompoundConditionNotFoundException() : base("Compound Condition Is Not Found!")
        {
        }
    }
}
