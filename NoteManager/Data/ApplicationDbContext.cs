using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NoteManager.Data.Models;

namespace NoteManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<NavItem>()
                .HasData(new NavItem() {Href = "passwordmanager", SpanClass = "oi oi-key", Title = "Password Manager"});
        }

        public DbSet<NavItem> NavItems { get; set; }
    }
}