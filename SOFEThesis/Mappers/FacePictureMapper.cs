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
        public static FacePictureDto Map(FacePicture facePicture)
        {
            if(facePicture == null) return new FacePictureDto();
            return new FacePictureDto()
            {
                Id = facePicture.Id,
                Name = facePicture.Name,
                Source = facePicture.Source,
            };
        }
    }
}
