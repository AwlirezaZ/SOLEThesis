namespace SOFEThesis.Domain
{
    public class FacePicture
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public FacePicture(string name,string source)
        {
            Name = name;
            Source = source;
        }
    }
}
