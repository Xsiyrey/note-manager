using System;
using System.Collections.Generic;

namespace NoteManager.Data.Models
{
    public class Password : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        
        public virtual List<PasswordValue> PasswordDValues { get; set; }
    }
}