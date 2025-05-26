namespace Entity.Model.Security
{
    public class ChangeLog
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int IdTable { get; set; }
        public string TableName { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
        public string Action { get; set; }
        public string Active { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
