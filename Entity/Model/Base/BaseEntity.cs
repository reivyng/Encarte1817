namespace Entity.Model.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime DeleteAt { get; set; }
    }
}
