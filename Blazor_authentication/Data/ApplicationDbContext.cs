using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blazor_authentication.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var user1 = new ApplicationUser
            {
                Id = "user2-id",
                UserName = "Darvyn@Luis.com",
                NormalizedUserName = "DARVYN@LUIS.COM",
                Email = "Darvyn@Luis.com",
                NormalizedEmail = "DARVYN@LUIS.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Password123!")
            };
            var user1Role = new IdentityUserRole<string>
            {
                RoleId = "2a82922b-1c74-4962-a328-5c3ab1e2a8a7", 
                UserId = user1.Id
            };
            modelBuilder.Entity<ApplicationUser>().HasData(user1);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(user1Role);

        }
    }
}
