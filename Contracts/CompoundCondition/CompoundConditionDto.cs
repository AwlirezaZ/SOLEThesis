using SOFEThesis.Contracts.FacePicture;
using SOFEThesis.Contracts.Picture;

namespace SOFEThesis.Contracts.CompoundCondition
{
    public class CompoundConditionDto
    {
        public long Id { get; set; }
        public long Order { get; set; }
        public FacePictureDto FirstFacePictrue { get; set; }
        public FacePictureDto SecondFacePicture { get; set; }
        public PictrueDto Pictrue { get; set; }


    }
}
