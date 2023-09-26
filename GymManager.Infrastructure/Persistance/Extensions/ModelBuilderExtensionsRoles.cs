using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistance.Extensions
{
    public static class ModelBuilderExtensionsRoles
    {
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "62FD9D71-3104-406F-97F0-0BFC0DE4CB21",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = "A32752AF-C53C-4178-A52B-3EEA7224C1DC"
                },
                new IdentityRole
                {
                    Id = "5A7D9370-C37A-4790-B6AA-E8E390F6786D",
                    Name = "Klient",
                    NormalizedName = "KLIENT",
                    ConcurrencyStamp = "7112EDD5-EAC4-46C0-BCD5-B987E9DB4D92"
                },
                new IdentityRole
                {
                    Id = "81F09BDC-7DE0-4B6B-8CE9-6269CD3D04D1",
                    Name = "Pracownik",
                    NormalizedName = "PRACOWNIK",
                    ConcurrencyStamp = "7EC72C51-7B61-41FB-B991-204956012AAB"
                });
        }

    }
}
