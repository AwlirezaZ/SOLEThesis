namespace SOFEThesis.Domain.Conditions
{
    public class FaceCondition
    {
        public long Id { get; set; }
        public FacePicture FacePicture { get; set; }
        public long Order { get; set; }
        public long FacePictureId { get; set; }
        public FaceCondition(long facePictureId, long order)
        {
            FacePictureId = facePictureId;
            Order = order;
        }
    }
}
