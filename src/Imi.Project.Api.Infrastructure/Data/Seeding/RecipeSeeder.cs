using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class RecipeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Nasi Goreng",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Instructions = "Voeg 1 rode peper en 16 gr geschilde gember toe aan de mengbeker 3 sec/snelheid 8; Schraap naar beneden voeg 2 uien en 2 teentjes knoflook toe 5 sec/snelheid 5",
                    Image = "https://www.alleskunner.be/images/nasigoreng.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/nasigoreng.php"),
                    NumberOfPersons = 6,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "Dumplings",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Instructions = "Maak eerst de dipsaus door 10 gr sojasaus, 10 gr sesamolie, 10 gr honing, ½ eetl sesamzaad, 10 gr sriracha - hot chilisaus, 10 gr mirin aan de mengbeker 10 sec/ snelheid 3; Voeg toe aan een klein dresseerpotje, zet opzij ",
                    Image = "https://www.alleskunner.be/images/dumplings.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/dumplings.php"),
                    NumberOfPersons = 4,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "Aardappelpuree",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Instructions = "Doe de aardappelen in blokjes, water of melk, schepje groentenbouillon voor water = 20 minuten/100 graden/linksomdraai/ snelheid lepeltje roerstand thermomix, voor melk= 20 minuten/98 graden/ linksomdraai/snelheid lepeltje; Doe nu de kruiding zout, peper, nootmuskaat en klein beetje olijfolie of boter linksomdraai/snelheid 4 en door het gaatje bovenaan kan je de structuur van je puree zien en stoppen bij je gewenste structuur. ",
                    Image = "https://www.alleskunner.be/images/aardappelpuree.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/aardappelpuree.php"),
                    NumberOfPersons = 4,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Name = "Bruschetta",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Instructions = "Voeg de tijm, oregano en basilicum toe, 3 seconden /snelheid 8; Haal de kruiden eruit en zet opzij",
                    Image = "https://www.alleskunner.be/images/bruschetta.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/bruschetta.php"),
                    NumberOfPersons = 3,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    Name = "Brussels wafels",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Instructions = "Split de eieren en voeg de eiwitten toe aan de mengbeker, voeg de vlinder toe 2 min/snelheid 4; Haal opgeklopt eiwit eruit en zet opzij",
                    Image = "https://www.alleskunner.be/images/brusselse-wafels.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/brusselse-wafels.php"),
                    NumberOfPersons = 4,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    Name = "Naambroodjes",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Instructions = "Voeg 1 teentje knoflook toe 3 sec/snelheid 8, schraap naar beneden; Voeg 200 gr speltbloem, 2 tl bakpoeder, 150 gr yoghurt, 1 tl five spice, 10 gr olijfolie toe aan de mengbeker 1 min/deegfunctie",
                    Image = "https://www.alleskunner.be/images/naanbrood-janos.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/naanbroodjes.php"),
                    NumberOfPersons = 4,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Name = "Pompoen tomatensoep",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Instructions = "Verwarm de oven voor op 180 graden; Spoel de pompoen af , snij de pompoen in grove stukken verwijder de pitten",
                    Image = "https://www.alleskunner.be/images/pompoen-tomatensoep.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/pompoen-tomatensoep-balletjes.php"),
                    NumberOfPersons = 4,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                    Name = "Long island iced tea",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    Instructions = "Doe 400 gram ijsblokjes in de mengbeker. 2 seconden, snelheid 6; Verdeel ze over 4 longdrinkglazen",
                    Image = "https://www.alleskunner.be/images/longisland-icetea.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/long-island-icedtea.php"),
                    NumberOfPersons = 4,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                    Name = "Groene smoothie",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Instructions = "Doe alle ingrediënten in de mengbeker 30 seconden/snelheid 10; Schenk uit in een glas",
                    Image = "https://www.alleskunner.be/images/groenesmoothie-spinazie-aardbeien.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/groenesmoothie.php"),
                    NumberOfPersons = 1,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
                    Name = "Milkshake met frambozen",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Instructions = "We maken eerst het randje aan het glas, voeg daarvoor de 30 gr witte suiker, 2 bevroren frambozen, 1 galette koekje (in stukjes gebroken) toe aan de mengbeker 1 sec/turbo; Schraap naar beneden",
                    Image = "https://www.alleskunner.be/images/blog-kokenmetkinderen-milkshake.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/milkshake-frambozen.php"),
                    NumberOfPersons = 5,
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
                    Name = "Bechamelsaus",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Instructions = " Breng alle ingrediënten in de kom; 12 min/90 graden/snelheid 4",
                    Image = "https://www.alleskunner.be/images/bechamelsaus.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/bechamelsaus.php"),
                    NumberOfPersons = 4
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Name = "Tzatziki",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000012"),
                    Instructions = "Voeg 1 komkommer ( zonder pitten) in grove stukken 5 sec/snelheid 5 voeg toe aan varomamandje laat uitlekken in mengkom; Voeg teentje knoflook + handvol dille 3 sec/ snelheid 8, schraap naar beneden opnieuw, 3 sec/snelheid 8 schraap naar beneden",
                    Image = "https://www.alleskunner.be/images/tzatziki.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/tzatziki.php"),
                    NumberOfPersons = 1
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Name = "Babyvoeding groenten/fruitpap",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000013"),
                    Instructions = "Voeg de geschilde en zonder klokhuis appel in mengbeker, schil de wortels en snij in twee;  5 sec/snelheid 5, schraap de groentjes naar beneden",
                    Image = "https://www.alleskunner.be/images/babyvoeding_appelwortel.jpg",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/babyvoeding_appelwortel.php"),
                    NumberOfPersons = 1
                },

                new Recipe
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
                    Name = "Vegan Mayonaise",
                    CategoryId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    CreatedOn = DateTime.Now,
                    KitchenId = Guid.Parse("00000000-0000-0000-0000-000000000015"),
                    ThemeId = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    Instructions = "Voeg een maatbekertje op de mengbeker en weeg 300 gr zonnebloemolie af, zet het maatbekertje opzij; Voeg in de mengbeker 150 gr (amandel) melk, snuifje zout en koffielepel mosterd toe",
                    Image = "https://www.alleskunner.be/images/vegan-mayonaise.png",
                    WebsiteLink = new Uri("https://www.alleskunner.be/recepten/vegan-mayonaise.php"),
                    NumberOfPersons = 1
                }

                );
        }
    }
}