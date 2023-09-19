namespace SOFEThesis.Domain.Conditions
{
    public class CompoundCondition
    {
        public long Id { get; set; }
        public Picture Picture { get; set; }
        public FacePicture FirstFacePicture { get; set; }
        public FacePicture SecondFacePicture { get; set; }
        public long Order { get; set; }
        public long PictureId { get; set; }
        public long FirstFacePictureId { get; set; }
        public long SecondFacePictureId { get; set; }
    }
}
