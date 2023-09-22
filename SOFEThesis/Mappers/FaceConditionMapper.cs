using SOFEThesis.Contracts.FaceCondition;
using SOFEThesis.Domain.Conditions;

namespace SOFEThesis.Mappers
{
    public static class FaceConditionMapper
    {
        public static List<FaceConditionDto> Map(List<FaceCondition> list)
        {
            return list.Select(Map).OrderBy(x => x.Order).ToList();
        }
        public static FaceConditionDto Map(FaceCondition condition)
        {
            return new FaceConditionDto
            {
                Id = condition.Id,
                Order = condition.Order,
                FacePictrue = FacePictureMapper.Map(condition.FacePicture),
            };
        }
    }
}
