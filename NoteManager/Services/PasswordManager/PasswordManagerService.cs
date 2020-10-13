using NoteManager.Data;

namespace NoteManager.Services.PasswordManager
{
    public class PasswordManagerService
    {
        public PasswordManagerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private readonly ApplicationDbContext _dbContext;
    }
}