using Microsoft.EntityFrameworkCore;

namespace PureFitnessV2.Models
{
    public class SignUpContent : DbContext
    {
        public SignUpContent(DbContextOptions<SignUpContent> options)
            : base(options)
        { }

        public DbSet<SignUp> SignUp { get; set; }
    }
}
