namespace SOFEThesis.Domain.Conditions
{
    public class SelfCondition
    {
        public long Id { get; set; }
        public Picture Picture { get; set; }
        public long PictureId { get; set; }
        public long Order { get; set; }
        public SelfCondition(long pictureId,long order)
        {
            PictureId = pictureId;
            Order = order;
        }
    }
}
