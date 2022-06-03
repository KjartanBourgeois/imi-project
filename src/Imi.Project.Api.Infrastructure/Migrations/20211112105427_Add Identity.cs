using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TermsAndConditions = table.Column<bool>(type: "bit", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitchens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Themes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KitchenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThemeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Kitchens_KitchenId",
                        column: x => x.KitchenId,
                        principalTable: "Kitchens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeIngredients",
                columns: table => new
                {
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeIngredients", x => new { x.RecipeId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeIngredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipePhotos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HighlightedImage = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipePhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipePhotos_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecipePhotos_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20000000-0000-0000-0000-000000000000", "8f438d4e-ddb4-4843-a394-c56df33988e7", "SuperAdmin", "SUPERADMIN" },
                    { "10000000-0000-0000-0000-000000000000", "3611ff07-fa44-4059-87df-de9b4d5f1749", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "Gender", "IsAdmin", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TermsAndConditions", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "22000000-0000-0000-0000-0000000000", 0, "a3cfba6a-4386-11ec-81d3-0242ac130003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super.Admin@user.be", true, "Super", 0, true, "Admin", false, null, "SUPER.ADMIN@USER.BE", "SUPERADMIN", "AQAAAAEAACcQAAAAECBZWFa7/n5SF+IB9vPMLhiUnwtZczWCF+Uz5RvhamO5SSx/bsb45CZmbDnwKDXHMw==", null, false, "https://randomuser.me/api/portraits/lego/2.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "SuperAdmin" },
                    { "11000000-0000-0000-0000-0000000000", 0, "f3cfba6a-4386-11ec-81d3-0242ac130003", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@user.be", true, "Admin", 0, true, "Admin", false, null, "ADMIN@USER.BE", "ADMIN", "AQAAAAEAACcQAAAAELdbIfhmltR1jJPfFlffZVe/mMGWYy5nYDSSiYxrizKEMn6FNWTDR9HfuYCct5h1Xg==", null, false, "https://randomuser.me/api/portraits/men/74.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "Admin" },
                    { "00000000-0000-0000-0000-000000000010", 0, "f3cfb9b6-4386-11ec-81d3-0242ac130003", new DateTime(1952, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leeck.Swiftblood@user.be", true, "Leeck", 0, false, "Switfblood", false, null, "LEECK.SWIFTBLOOD@USER.BE", "LEECKS", "AQAAAAEAACcQAAAAELx3WhWjYJUx/Fbj9AyXMqBzINyF/quVSRgQLmor70+q1EZXRKbGNNc0GSLclotjFw==", null, false, "https://randomuser.me/api/portraits/men/86.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "LeeckS" },
                    { "00000000-0000-0000-0000-000000000009", 0, "f3cfb902-4386-11ec-81d3-0242ac130003", new DateTime(1974, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Courge.Voidwound@user.be", true, "Courge", 2, false, "Voidwound", false, null, "COURGE.VOIDWOUND@USER.BE", "COURGEV", "AQAAAAEAACcQAAAAEInY/CtFwQ+m4HLCTpSXotZ5nRjQUTBSgkTpaRLNkZXhnnBM0o7chedGT8CKhXIhJA==", null, false, "https://randomuser.me/api/portraits/lego/3.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "CourgeV" },
                    { "00000000-0000-0000-0000-000000000008", 0, "f3cfb858-4386-11ec-81d3-0242ac130003", new DateTime(1979, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gorlick.Deathgrove@user.be", true, "Gorlick", 0, false, "Deathgrove", false, null, "GORLICK.DEATHGROVE@USER.BE", "GORLICKD", "AQAAAAEAACcQAAAAEEkiigzSghbVyk+Ssx6cLygygOshtlrEQh6gHzYxve4vVbIfktDpn15fkpQrt4iLSg==", null, false, "https://randomuser.me/api/portraits/men/64.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "GorlickD" },
                    { "00000000-0000-0000-0000-000000000007", 0, "f3cfb786-4386-11ec-81d3-0242ac130003", new DateTime(1982, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kallabash.Titanhand@user.be", true, "Kallabash", 1, false, "Titanhand", false, null, "KALLABASH.TITANHAND@USER.BE", "KALLABASHT", "AQAAAAEAACcQAAAAELmPAXm0/BKxB7WAd+SIGcwAEtUztZcn2yNXWumG66zSl7wjS2zf7fiThFeQ95ub0A==", null, false, "https://randomuser.me/api/portraits/women/82.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "KallabashT" },
                    { "00000000-0000-0000-0000-000000000006", 0, "f3cfb4ac-4386-11ec-81d3-0242ac130003", new DateTime(1989, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinach.Flatwood@user.be", true, "Pinach", 2, false, "Flatwood", false, null, "PINACH.FLATWOOD@USER.BE", "FLATWOODP", "AQAAAAEAACcQAAAAENGV7pFRzrv8BnL6APLK+H/3NIXcLe50Qb/q+ZvvtG/EOzGb6oCqyDkOhtof9G3kXw==", null, false, "https://randomuser.me/api/portraits/lego/0.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "FlatwoodP" },
                    { "00000000-0000-0000-0000-000000000005", 0, "f3cfb3e4-4386-11ec-81d3-0242ac130003", new DateTime(1973, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peppa.Distantshadow@user.be", true, "Peppa", 0, false, "Distantshadow", false, null, "PEPPA.DISTANTSHADOW@USER.BE", "PEPPAD", "AQAAAAEAACcQAAAAEHvOm3ct18bAxPqo1XSDoBGsX+L/ZA+I46AAezIplwfk/Iz8lIYHeQkwBasItskcUA==", null, false, "https://randomuser.me/api/portraits/men/4.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "PeppaD" },
                    { "00000000-0000-0000-0000-000000000004", 0, "f3cfb31c-4386-11ec-81d3-0242ac130003", new DateTime(1990, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lantain.Skybone@user.be", true, "Lantain", 1, false, "Skybone", false, null, "LANTAIN.SKYBONE@USER.BE", "SKYBONEL", "AQAAAAEAACcQAAAAEIIJxmC3lEZLcmBUmczWUYpESti40MowyvR9UKzVhPpLO/A62mmcxfpr5d+ndZv3EQ==", null, false, "https://randomuser.me/api/portraits/women/91.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "SkyboneL" },
                    { "00000000-0000-0000-0000-000000000003", 0, "f3cfb222-4386-11ec-81d3-0242ac130003", new DateTime(1950, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cucum.Terrarun@user.be", true, "Cucum", 2, false, "Terrarun", false, null, "CUCUM.TERRARUN@USER.BE", "CUCUMT", "AQAAAAEAACcQAAAAENAYTz4QQAQ5hgbpn7m9U6rdb0Ifz912EcKaYScbreOWdocP1InvqE7MWo3YNIHl4w==", null, false, "https://randomuser.me/api/portraits/lego/6.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", false, false, "CucumT" },
                    { "00000000-0000-0000-0000-000000000002", 0, "f3cfafe8-4386-11ec-81d3-0242ac130003", new DateTime(1967, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joe.Doe@user.be", true, "Joe", 0, false, "Doe", false, null, "JOE.DOE@USER.BE", "JOED", "AQAAAAEAACcQAAAAEC8jZoGQly4r5SN8BMz07bLTkFSqhXYmMeVvMUsWCpvttK27iupeURMnmj10aM7vXQ==", null, false, "https://randomuser.me/api/portraits/men/49.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "JoeD" },
                    { "00000000-0000-0000-0000-000000000001", 0, "c8554266-b401-4519-9aeb-a9283053fc58", new DateTime(1952, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane.Doe@user.be", false, "Jane", 1, false, "Doe", false, null, "JANE.DOE@USER.BE", "JDOE", "AQAAAAEAACcQAAAAEGsPZE9LVyml2jaLa+CZKUL8wfvSRFDDXeQ5t08s8Lsx1FD6VNh1rSpc6HskOAuCkw==", null, false, "https://randomuser.me/api/portraits/women/10.jpg", "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", true, false, "JDoe" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Hoofdgerecht" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Vegan" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Warme sausen" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Milkshakes" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Smoothies" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Aperitief" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Soepen" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Babyvoeding" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Brood" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Dessert" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Snacks" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Hapjes" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Bijgerecht" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Voorgerecht" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Dips" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Zout" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Olijfolie" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Boter" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Melk" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Yoghurt" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Vodka" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Pompoen" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Knoflook" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Ei" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Tomaat" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Aardappel" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Soja Saus" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Wortel" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), "Rode peper" });

            migrationBuilder.InsertData(
                table: "Kitchens",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Amerikaans" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Thuiskeuken" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Indisch" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Chinees" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Frans" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Italiaans" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Belgisch" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Grieks" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Mexicaans" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Japans" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Libanees" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Thais" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Arabisch" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Andere" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Spaans" }
                });

            migrationBuilder.InsertData(
                table: "Themes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Alledaags" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Aziatisch" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Raclette" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Lente" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Winter" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Zomer" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Herfst" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Halloween" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Gezond" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Barbecue" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Kerst" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Babyvoeding" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Pasen" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "10000000-0000-0000-0000-000000000000", "11000000-0000-0000-0000-0000000000" },
                    { "20000000-0000-0000-0000-000000000000", "22000000-0000-0000-0000-0000000000" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedOn", "Instructions", "KitchenId", "Name", "ThemeId", "UserId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(318), null, new Guid("00000000-0000-0000-0000-000000000007"), "Bruschetta", new Guid("00000000-0000-0000-0000-000000000004"), null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(339), null, new Guid("00000000-0000-0000-0000-000000000001"), "Naambroodjes", new Guid("00000000-0000-0000-0000-000000000004"), null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(370), null, new Guid("00000000-0000-0000-0000-000000000015"), "Groene smoothie", new Guid("00000000-0000-0000-0000-000000000004"), null },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(421), null, new Guid("00000000-0000-0000-0000-000000000015"), "Vegan Mayonaise", new Guid("00000000-0000-0000-0000-000000000004"), null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(359), null, new Guid("00000000-0000-0000-0000-000000000014"), "Long island iced tea", new Guid("00000000-0000-0000-0000-000000000007"), null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(349), null, new Guid("00000000-0000-0000-0000-000000000013"), "Pompoen tomatensoep", new Guid("00000000-0000-0000-0000-000000000008"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2021, 11, 12, 11, 54, 26, 543, DateTimeKind.Local).AddTicks(4113), null, new Guid("00000000-0000-0000-0000-000000000001"), "Nasi Goreng", new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(271), null, new Guid("00000000-0000-0000-0000-000000000002"), "Dumplings", new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(305), null, new Guid("00000000-0000-0000-0000-000000000003"), "Aardappelpuree", new Guid("00000000-0000-0000-0000-000000000012"), null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(328), null, new Guid("00000000-0000-0000-0000-000000000005"), "Brussels wafels", new Guid("00000000-0000-0000-0000-000000000012"), null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(380), null, new Guid("00000000-0000-0000-0000-000000000015"), "Milkshake met frambozen", new Guid("00000000-0000-0000-0000-000000000012"), null },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(391), null, new Guid("00000000-0000-0000-0000-000000000015"), "Bechamelsaus", new Guid("00000000-0000-0000-0000-000000000012"), null },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(401), null, new Guid("00000000-0000-0000-0000-000000000006"), "Tzatziki", new Guid("00000000-0000-0000-0000-000000000012"), null },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2021, 11, 12, 11, 54, 26, 546, DateTimeKind.Local).AddTicks(411), null, new Guid("00000000-0000-0000-0000-000000000015"), "Babyvoeding groenten/fruitpap", new Guid("00000000-0000-0000-0000-000000000013"), null }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Amount", "Unit" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000004"), 4.0, null },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000012"), 1.5, "centiliter" },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000011"), 80.0, "gram" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000010"), 25.0, "centiliter" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000005"), 2.0, null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000003"), 175.0, "gram" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), 1.0, "centiliter" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000013"), 2.0, null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000007"), 1.0, null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000007"), 150.0, "teentje" },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), 1.0, null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000009"), 200.0, "yoghurt" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000008"), 1.0, "centiliter" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000014"), 1.0, "snuifje" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), 1.0, "teentje" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000007"), 150.0, "gram" }
                });

            migrationBuilder.InsertData(
                table: "RecipePhotos",
                columns: new[] { "Id", "HighlightedImage", "ImageLink", "RecipeId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000012"), true, "https://www.alleskunner.be/recepten/tzatziki.php", new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000004"), true, "https://www.alleskunner.be/images/bruschetta.png", new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000011"), true, "https://www.alleskunner.be/images/bechamelsaus.png", new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000010"), true, "https://www.alleskunner.be/images/blog-kokenmetkinderen-milkshake.png", new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000006"), true, "https://www.alleskunner.be/images/naanbrood-janos.png", new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000008"), true, "https://www.alleskunner.be/images/longisland-icetea.png", new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000003"), true, "https://www.alleskunner.be/images/aardappelpuree.png", new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000009"), true, "https://www.alleskunner.be/images/groenesmoothie-spinazie-aardbeien.png", new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000002"), true, "https://www.alleskunner.be/images/dumplings.png", new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000001"), true, "https://www.alleskunner.be/images/nasigoreng.png", new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000014"), true, "https://www.alleskunner.be/images/vegan-mayonaise.png", new Guid("00000000-0000-0000-0000-000000000014"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000007"), true, "https://www.alleskunner.be/images/pompoen-tomatensoep.png", new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000005"), true, "https://www.alleskunner.be/images/brusselse-wafels.png", new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000011"), null },
                    { new Guid("00000000-0000-0000-0000-000000000013"), true, "https://www.alleskunner.be/images/babyvoeding_appelwortel.jpg", new Guid("00000000-0000-0000-0000-000000000013"), new Guid("00000000-0000-0000-0000-000000000011"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeIngredients_IngredientId",
                table: "RecipeIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipePhotos_RecipeId",
                table: "RecipePhotos",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipePhotos_UserId1",
                table: "RecipePhotos",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_KitchenId",
                table: "Recipes",
                column: "KitchenId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ThemeId",
                table: "Recipes",
                column: "ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "RecipeIngredients");

            migrationBuilder.DropTable(
                name: "RecipePhotos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Kitchens");

            migrationBuilder.DropTable(
                name: "Themes");
        }
    }
}
