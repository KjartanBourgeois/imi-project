using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class Addnewdatatorecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPersons",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WebsiteLink",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10000000-0000-0000-0000-000000000000",
                column: "ConcurrencyStamp",
                value: "42111277-3742-4fdb-ae48-0b62b14ce7fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20000000-0000-0000-0000-000000000000",
                column: "ConcurrencyStamp",
                value: "0a35c01d-6def-4e00-8874-5fc277661dff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENa6kwiApRRyBV/QxvgA2ex4UYsqQTR733D3by9VW2vOjSTaQvZ5wY0SmMg63jZXRA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEFUG3wPgdLq0/S/i7zuOinAiVBLCzcirnoNCspjsFTvD1K8rPu5a4Tnwh1zYhk6N8w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAED71qLuBG3YQHAObCq2+XJ6N4Wkv7x+8TzLtFUBa7LAQRHz5AwSLpISoqHS9A0Gu/A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEF3OuNHwgEFnAZrGv86Lm6j8SE6pusYmk7gGYIzL+URpDSmc8S6VrqLR5WuZGI/Pzw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEImrZjE9XldYAbNXuBzNSfjyUl/ZiG/H+WN4+Ok4JtfYJM6ziWIEtwXN0noYVFlmqA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEKLK1yLqy1yN37nm3mEa/kCVPYyzMQQIrm7g79p8lTH32GWNseAzIJ0qAGU17l/3Rg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEJapiBp7EiJpo4306I9TjWQxwgRBIGXE3TPbDbNIIIjRU+mq3LVg4TfJV8GrKlrDzw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEOVhqzoSs+kxxod7SQ6uSaeUesHxK6zuPKsChqsE33sX0TcUoeH1XIJbsBT5EpZDfw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEPfZiM0xdDVVYWu/oW7g/AQM2LW5YmewlMGEsGQssLorBBHW7VsKaGEPElmrwFEdSQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEAbvdK6COmnnyCG4vsinH2xNk7ii3E5DnqueYMPUmU3pqvUerwzMizbUafFGFKWmnw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11000000-0000-0000-0000-0000000000",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENyUTRl6zt4VtUBQEpQIkvPKnkpPx/YkPcEaE6cwQ8YYUPMSG30wrpdXhKwA+AwDVw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22000000-0000-0000-0000-0000000000",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEkLDEfKPVKj0Ad5Jd8pOJPlGWfodEA/wpfLmCMS4LQLQOuZADS4WY41U8o05EDyZg==");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 483, DateTimeKind.Local).AddTicks(5093), "https://www.alleskunner.be/images/nasigoreng.png", "Voeg 1 rode peper en 16 gr geschilde gember toe aan de mengbeker 3 sec/snelheid 8; Schraap naar beneden voeg 2 uien en 2 teentjes knoflook toe 5 sec/snelheid 5", 6, "https://www.alleskunner.be/recepten/nasigoreng.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4044), "https://www.alleskunner.be/images/dumplings.png", "Maak eerst de dipsaus door 10 gr sojasaus, 10 gr sesamolie, 10 gr honing, ½ eetl sesamzaad, 10 gr sriracha - hot chilisaus, 10 gr mirin aan de mengbeker 10 sec/ snelheid 3; Voeg toe aan een klein dresseerpotje, zet opzij ", 4, "https://www.alleskunner.be/recepten/dumplings.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4131), "https://www.alleskunner.be/images/aardappelpuree.png", "Doe de aardappelen in blokjes, water of melk, schepje groentenbouillon voor water = 20 minuten/100 graden/linksomdraai/ snelheid lepeltje roerstand thermomix, voor melk= 20 minuten/98 graden/ linksomdraai/snelheid lepeltje; Doe nu de kruiding zout, peper, nootmuskaat en klein beetje olijfolie of boter linksomdraai/snelheid 4 en door het gaatje bovenaan kan je de structuur van je puree zien en stoppen bij je gewenste structuur. ", 4, "https://www.alleskunner.be/recepten/aardappelpuree.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4148), "https://www.alleskunner.be/images/bruschetta.png", "Voeg de tijm, oregano en basilicum toe, 3 seconden /snelheid 8; Haal de kruiden eruit en zet opzij", 3, "https://www.alleskunner.be/recepten/bruschetta.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4160), "https://www.alleskunner.be/images/brusselse-wafels.png", "Split de eieren en voeg de eiwitten toe aan de mengbeker, voeg de vlinder toe 2 min/snelheid 4; Haal opgeklopt eiwit eruit en zet opzij", 4, "https://www.alleskunner.be/recepten/brusselse-wafels.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4172), "https://www.alleskunner.be/images/naanbrood-janos.png", "Voeg 1 teentje knoflook toe 3 sec/snelheid 8, schraap naar beneden; Voeg 200 gr speltbloem, 2 tl bakpoeder, 150 gr yoghurt, 1 tl five spice, 10 gr olijfolie toe aan de mengbeker 1 min/deegfunctie", 4, "https://www.alleskunner.be/recepten/naanbroodjes.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4183), "https://www.alleskunner.be/images/pompoen-tomatensoep.png", "Verwarm de oven voor op 180 graden; Spoel de pompoen af , snij de pompoen in grove stukken verwijder de pitten", 4, "https://www.alleskunner.be/recepten/pompoen-tomatensoep-balletjes.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4194), "https://www.alleskunner.be/images/longisland-icetea.png", "Doe 400 gram ijsblokjes in de mengbeker. 2 seconden, snelheid 6; Verdeel ze over 4 longdrinkglazen", 4, "https://www.alleskunner.be/recepten/long-island-icedtea.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4205), "https://www.alleskunner.be/images/groenesmoothie-spinazie-aardbeien.png", "Doe alle ingrediënten in de mengbeker 30 seconden/snelheid 10; Schenk uit in een glas", 1, "https://www.alleskunner.be/recepten/groenesmoothie.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4217), "https://www.alleskunner.be/images/blog-kokenmetkinderen-milkshake.png", "We maken eerst het randje aan het glas, voeg daarvoor de 30 gr witte suiker, 2 bevroren frambozen, 1 galette koekje (in stukjes gebroken) toe aan de mengbeker 1 sec/turbo; Schraap naar beneden", 5, "https://www.alleskunner.be/recepten/milkshake-frambozen.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4229), "https://www.alleskunner.be/images/bechamelsaus.png", " Breng alle ingrediënten in de kom; 12 min/90 graden/snelheid 4", 4, "https://www.alleskunner.be/recepten/bechamelsaus.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4242), "https://www.alleskunner.be/images/tzatziki.png", "Voeg 1 komkommer ( zonder pitten) in grove stukken 5 sec/snelheid 5 voeg toe aan varomamandje laat uitlekken in mengkom; Voeg teentje knoflook + handvol dille 3 sec/ snelheid 8, schraap naar beneden opnieuw, 3 sec/snelheid 8 schraap naar beneden", 1, "https://www.alleskunner.be/recepten/tzatziki.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4254), "https://www.alleskunner.be/images/babyvoeding_appelwortel.jpg", "Voeg de geschilde en zonder klokhuis appel in mengbeker, schil de wortels en snij in twee;  5 sec/snelheid 5, schraap de groentjes naar beneden", 1, "https://www.alleskunner.be/recepten/babyvoeding_appelwortel.php" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "Image", "Instructions", "NumberOfPersons", "WebsiteLink" },
                values: new object[] { new DateTime(2021, 11, 24, 10, 1, 56, 486, DateTimeKind.Local).AddTicks(4267), "https://www.alleskunner.be/images/vegan-mayonaise.png", "Voeg een maatbekertje op de mengbeker en weeg 300 gr zonnebloemolie af, zet het maatbekertje opzij; Voeg in de mengbeker 150 gr (amandel) melk, snuifje zout en koffielepel mosterd toe", 1, "https://www.alleskunner.be/recepten/vegan-mayonaise.php" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "NumberOfPersons",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "WebsiteLink",
                table: "Recipes");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10000000-0000-0000-0000-000000000000",
                column: "ConcurrencyStamp",
                value: "3611ff07-fa44-4059-87df-de9b4d5f1749");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20000000-0000-0000-0000-000000000000",
                column: "ConcurrencyStamp",
                value: "8f438d4e-ddb4-4843-a394-c56df33988e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000001",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEGsPZE9LVyml2jaLa+CZKUL8wfvSRFDDXeQ5t08s8Lsx1FD6VNh1rSpc6HskOAuCkw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000002",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEC8jZoGQly4r5SN8BMz07bLTkFSqhXYmMeVvMUsWCpvttK27iupeURMnmj10aM7vXQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000003",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENAYTz4QQAQ5hgbpn7m9U6rdb0Ifz912EcKaYScbreOWdocP1InvqE7MWo3YNIHl4w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000004",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEIIJxmC3lEZLcmBUmczWUYpESti40MowyvR9UKzVhPpLO/A62mmcxfpr5d+ndZv3EQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000005",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEHvOm3ct18bAxPqo1XSDoBGsX+L/ZA+I46AAezIplwfk/Iz8lIYHeQkwBasItskcUA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000006",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAENGV7pFRzrv8BnL6APLK+H/3NIXcLe50Qb/q+ZvvtG/EOzGb6oCqyDkOhtof9G3kXw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000007",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELmPAXm0/BKxB7WAd+SIGcwAEtUztZcn2yNXWumG66zSl7wjS2zf7fiThFeQ95ub0A==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000008",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEEkiigzSghbVyk+Ssx6cLygygOshtlrEQh6gHzYxve4vVbIfktDpn15fkpQrt4iLSg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000009",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAEInY/CtFwQ+m4HLCTpSXotZ5nRjQUTBSgkTpaRLNkZXhnnBM0o7chedGT8CKhXIhJA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000010",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELx3WhWjYJUx/Fbj9AyXMqBzINyF/quVSRgQLmor70+q1EZXRKbGNNc0GSLclotjFw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11000000-0000-0000-0000-0000000000",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAELdbIfhmltR1jJPfFlffZVe/mMGWYy5nYDSSiYxrizKEMn6FNWTDR9HfuYCct5h1Xg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22000000-0000-0000-0000-0000000000",
                column: "PasswordHash",
                value: "AQAAAAEAACcQAAAAECBZWFa7/n5SF+IB9vPMLhiUnwtZczWCF+Uz5RvhamO5SSx/bsb45CZmbDnwKDXHMw==");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 543, DateTimeKind.Local).AddTicks(4113), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(271), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(305), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(318), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(328), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(339), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(349), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(359), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(370), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(380), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(391), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(401), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(411), null });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"),
                columns: new[] { "CreatedOn", "Instructions" },
                values: new object[] { new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(421), null });
        }
    }
}
