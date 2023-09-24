namespace SOFEThesis.Contracts.Picture
{
    public class CreatePictureDto
    {
        public string Name { get; set; }
        public string AmbiguousSituation { get; set; }
        public IFormFile File { get; set; }
    }
}
