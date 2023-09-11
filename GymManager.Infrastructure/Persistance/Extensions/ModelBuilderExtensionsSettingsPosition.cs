using GymManager.Application.Dictionaries;
using GymManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManager.Infrastructure.Persistance.Extensions
{
    public static class ModelBuilderExtensionsSettingsPosition
    {
        public static void SeedSettingsPosition(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SettingsPosition>().HasData(
                new SettingsPosition
                {
                    Id = 1,
                    Key = SettingsDict.HostSmtp,
                    Value = "smtp.gmail.com",
                    Description = "Host",
                    Type = Domain.Enums.SettingsType.Text,
                    SettingsId = 1,
                    Order = 1
                },
                new SettingsPosition
                {
                    Id = 2,
                    Key = SettingsDict.Port,
                    Value = "587",
                    Description = "Host",
                    Type = Domain.Enums.SettingsType.Integer,
                    SettingsId = 1,
                    Order = 2
                },
                new SettingsPosition
                {
                    Id = 3,
                    Key = SettingsDict.SenderEmail,
                    Value = "",
                    Description = "Adres e-mail nadawcy",
                    Type = Domain.Enums.SettingsType.Text,
                    SettingsId = 1,
                    Order = 3
                },
                new SettingsPosition
                {
                    Id = 4,
                    Key = SettingsDict.SenderEmailPassword,
                    Value = "",
                    Description = "Hasło",
                    Type = Domain.Enums.SettingsType.Password,
                    SettingsId = 1,
                    Order = 4
                },
                new SettingsPosition
                {
                    Id = 5,
                    Key = SettingsDict.SenderName,
                    Value = "Paweł Nowicki",
                    Description = "Nazwa nadawcy",
                    Type = Domain.Enums.SettingsType.Text,
                    SettingsId = 1,
                    Order = 5
                },
                new SettingsPosition
                {
                    Id = 6,
                    Key = SettingsDict.SenderLogin,
                    Value = "",
                    Description = "Login nadawcy",
                    Type = Domain.Enums.SettingsType.Text,
                    SettingsId = 1,
                    Order = 6
                },
                new SettingsPosition
                {
                    Id = 7,
                    Key = SettingsDict.BannerVisible,
                    Value = "True",
                    Description = "Czy wyświetlać banner na stronie głównej?",
                    Type = Domain.Enums.SettingsType.Bool,
                    SettingsId = 2,
                    Order = 1
                },
                new SettingsPosition
                {
                    Id = 8,
                    Key = SettingsDict.FooterColor,
                    Value = "#dc3545",
                    Description = "Kolor footera strony głównej",
                    Type = Domain.Enums.SettingsType.Color,
                    SettingsId = 2,
                    Order = 2
                },
                new SettingsPosition
                {
                    Id = 9,
                    Key = SettingsDict.AdminEmail,
                    Value = "pawel.nowicki87@o2.pl",
                    Description = "Główny adress e-mail administratora",
                    Type = Domain.Enums.SettingsType.Text,
                    SettingsId = 2,
                    Order = 3
                });
        }
    }
}
