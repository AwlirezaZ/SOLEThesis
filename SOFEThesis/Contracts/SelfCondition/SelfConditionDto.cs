using Microsoft.AspNetCore.Identity;
using SOFEThesis.Contracts.Picture;

namespace SOFEThesis.Contracts.SelfCondition
{
    public class SelfConditionDto
    {
        public long Id { get; set; }
        public long Order { get; set; }
        public PictrueDto Pictrue { get; set; }
    }
}
