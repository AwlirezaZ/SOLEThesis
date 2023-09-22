namespace SOFEThesis.Contracts.CompoundCondition
{
    public class CreateCompoundConditionDto
    {
        public long PictureId { get; set; }
        public long FirstFacePictureId { get; set; }
        public long SecondFacePictureId { get; set; }

        public long Order { get; set; }
    }
}
