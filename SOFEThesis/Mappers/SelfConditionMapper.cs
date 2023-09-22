using SOFEThesis.Contracts.SelfCondition;
using SOFEThesis.Domain.Conditions;

namespace SOFEThesis.Mappers
{
    public static class SelfConditionMapper
    {
        public static List<SelfConditionDto> Map(List<SelfCondition> list)
        {
            return list.Select(Map).OrderBy(x => x.Order).ToList();
        }
        public static SelfConditionDto Map(SelfCondition condition)
        {
            return new SelfConditionDto
            {
                Id = condition.Id,
                Order = condition.Order,
                Pictrue = PictureMapper.Map(condition.Picture),
            };
        }
    }
}
