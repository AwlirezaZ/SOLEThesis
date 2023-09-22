using SOFEThesis.Contracts.CompoundCondition;
using SOFEThesis.Domain.Conditions;

namespace SOFEThesis.Mappers
{
    public static class CompoundConditionMapper
    {
        public static List<CompoundConditionDto> Map(List<CompoundCondition> list)
        {
            return list.Select(Map).OrderBy(x => x.Order).ToList();
        }
        public static CompoundConditionDto Map(CompoundCondition condition)
        {
            return new CompoundConditionDto
            {
                Id = condition.Id,
                Order = condition.Order,
                Pictrue = PictureMapper.Map(condition.Picture),
                FirstFacePictrue = FacePictureMapper.Map(condition.FirstFacePicture),
                SecondFacePicture = FacePictureMapper.Map(condition.SecondFacePicture)
            };
        }
    }
}
