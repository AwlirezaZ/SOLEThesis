namespace SOFEThesis.Domain
{
    public class User
    {
        public long Id { get; set; }
        public long Age { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
    }
}
