using GymManager.Application.Dictionaries;
using GymManager.Domain.Entities;
using GymManager.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Infrastructure.Persistance.Extensions
{
    public static class ModelBuilderExtensionsAnnouncement
    {
        public static void SeedAnnouncement(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announcement>().HasData(
                new Announcement
                {
                    Id = 1,
                    Date = new DateTime(2022, 1, 12),
                    Description = "Kod promocyjny na suplementy w sklepie abc = rabat 12."
                },
                new Announcement
                {
                    Id = 2,
                    Date = new DateTime(2022, 1, 16),
                    Description = "W najbliższa sobote siłownia jest otwarta w godzinach 16.00 - 24.00"
                },
                new Announcement
                {
                    Id = 3,
                    Date = new DateTime(2022, 1, 21),
                    Description = "Zajęcia crossfit zostały odwołane, Przepraszamy"
                }, new Announcement
                {
                    Id = 4,
                    Date = new DateTime(2022, 1, 22),
                    Description = "Zatrudnimy trenera od siłowych setów"
                },
                new Announcement
                {
                    Id = 5,
                    Date = new DateTime(2022, 1, 23),
                    Description = "Zniżki na suplemnty zakupione na miejscu"
                },
                new Announcement
                {
                    Id = 6,
                    Date = new DateTime(2022, 1, 24),
                    Description = "Od nowego miesiąca podwyżka opłat związanych z karnetem na siłownię"
                },
                new Announcement
                {
                    Id = 7,
                    Date = new DateTime(2022, 1, 25),
                    Description = "W poprzednim miesiącu zrobiłeś 24 treningi"
                },
                new Announcement
                {
                    Id = 8,
                    Date = new DateTime(2022, 1, 26),
                    Description = "Kmasz zniżki formy, powinieneś jeść więcej suplementów"
                },
                new Announcement
                {
                    Id = 9,
                    Date = new DateTime(2022, 1, 2),
                    Description = "Zapraszając do nas na siłownie najomych dostajesz rabat w wysokosci 50%"
                },
                new Announcement
                {
                    Id = 10,
                    Date = new DateTime(2022, 1, 12),
                    Description = "Kod promocyjny na suplementy w sklepie abc = rabat 12."
                },
                new Announcement
                {
                    Id = 11,
                    Date = new DateTime(2022, 1, 9),
                    Description = "Wesołych Świąt Bożego Narodzenia"
                },
                new Announcement
                {
                    Id = 12,
                    Date = new DateTime(2022, 1, 12),
                    Description = "Odbierz swoja możliwość darmowego treningu"
                });
        }

    }
}
