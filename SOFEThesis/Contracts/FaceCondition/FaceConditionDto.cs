using SOFEThesis.Contracts.FacePicture;

namespace SOFEThesis.Contracts.FaceCondition
{
    public class FaceConditionDto
    {
        public long Id { get; set; }
        public long Order { get; set; }
        public FacePictureDto FacePictrue { get; set; }
    }
}
