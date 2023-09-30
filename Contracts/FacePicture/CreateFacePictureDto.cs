namespace SOFEThesis.Contracts.FacePicture
{
    public class CreateFacePictureDto
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }
}
