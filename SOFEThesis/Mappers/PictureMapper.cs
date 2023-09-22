using SOFEThesis.Contracts.Picture;
using SOFEThesis.Domain;

namespace SOFEThesis.Mappers
{
    public static class PictureMapper
    {
        public static List<PictrueDto> Map(List<Picture> pictures)
        {
            return pictures.Select(Map).ToList();
        }
        public static PictrueDto Map(Picture picture)
        {
            return new PictrueDto()
            {
                Id = picture.Id,
                AmbiguousSituation = picture.AmbiguousSituation,
                Name = picture.Name,
                Source = picture.Source,
            };
        }
    }
}
