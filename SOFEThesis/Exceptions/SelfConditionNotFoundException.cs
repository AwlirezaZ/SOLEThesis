namespace SOFEThesis.Exceptions
{
    public class SelfConditionNotFoundException : Exception
    {
        public SelfConditionNotFoundException() : base("Self Condition Is Not Found!")
        {
        }
    }
}
