namespace NoteManager.Data.Models
{
    public class NavItem : BaseModel
    {
        public virtual string Href { get; set; }
        public virtual string SpanClass { get; set; }
        public virtual string Title { get; set; }
    }
}