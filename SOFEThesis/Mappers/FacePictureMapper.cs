using SOFEThesis.Contracts.FacePicture;
using SOFEThesis.Domain;

namespace SOFEThesis.Mappers
{
    public static class FacePictureMapper
    {
        public static List<FacePictureDto> Map(List<FacePicture> facePictures)
        {
            return facePictures.Select(Map).ToList();
        }
        public static FacePictureDto Map(FacePicture picture)
        {
            return new FacePictureDto()
            {
                Id = picture.Id,
                Name = picture.Name,
                Source = picture.Source,
            };
        }
    }
}
