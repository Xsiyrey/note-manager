using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace NoteManager.Data.Models
{
    public class BaseModel : BaseModel<string>
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

    public class BaseModel<TKey> where TKey: IEquatable<TKey>
    {
        [Key]
        [PersonalData]
        public virtual TKey Id { get; set; }
    }
}