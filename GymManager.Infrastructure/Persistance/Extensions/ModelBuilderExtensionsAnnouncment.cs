using GymManager.Domain.Entities;
using GymManager.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Infrastructure.Persistance.Extensions;
static class ModelBuilderExtensionsAnnouncment
{
    public static void SeedAnnouncment(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Announcment>().HasData(
            new Announcment
            {
                Id = 1,
                Date = new DateTime(2022, 1, 12),
                Description = "Kod promocyjny na suplementy - rabat 12%"
            },
            new Announcment
            {
                Id = 2,
                Date = new DateTime(2022, 2, 5),
                Description = "Zapisy na nowy kurs fitness - start w marcu!"
            },
            new Announcment
            {
                Id = 3,
                Date = new DateTime(2022, 3, 15),
                Description = "Nowe godziny otwarcia siłowni - teraz otwarte do 23:00!"
            },
            new Announcment
            {
                Id = 4,
                Date = new DateTime(2022, 4, 8),
                Description = "Zniżka 20% na karnety roczne przez cały miesiąc!"
            },
            new Announcment
            {
                Id = 5,
                Date = new DateTime(2022, 5, 22),
                Description = "Nowe sprzęty na siłowni - sprawdź naszą strefę cardio!"
            },
            new Announcment
            {
                Id = 6,
                Date = new DateTime(2022, 6, 14),
                Description = "Konkurs dla klubowiczów - wygraj darmowy miesiąc treningów!"
            },
            new Announcment
            {
                Id = 7,
                Date = new DateTime(2022, 7, 30),
                Description = "Nowy instruktor personalny w naszym zespole!"
            },
            new Announcment
            {
                Id = 8,
                Date = new DateTime(2022, 8, 10),
                Description = "Darmowe zajęcia próbne z jogi w każdy poniedziałek!"
            },
            new Announcment
            {
                Id = 9,
                Date = new DateTime(2022, 9, 5),
                Description = "Nowa oferta cateringowa dla sportowców - zdrowe posiłki na miejscu!"
            },
            new Announcment
            {
                Id = 10,
                Date = new DateTime(2022, 10, 18),
                Description = "Wspólne wyjście klubowe - zapisujcie się w recepcji!"
            },
            new Announcment
            {
                Id = 11,
                Date = new DateTime(2022, 11, 25),
                Description = "Black Friday - 30% rabatu na karnety tylko dziś!"
            },
            new Announcment
            {
                Id = 12,
                Date = new DateTime(2022, 12, 31),
                Description = "Sylwestrowy trening - zacznij nowy rok z energią!"
            }
        );
    }
}
