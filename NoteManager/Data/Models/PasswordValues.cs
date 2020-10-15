namespace NoteManager.Data.Models
{
    public class PasswordValue : BaseModel
    {
        public string Value { get; set; }
        public string CreateDate { get; set; }
        
        public Password Password { get; set; }
    }
}