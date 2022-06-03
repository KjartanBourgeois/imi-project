using Imi.Project.Api.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            const string AdminRoleId = "10000000-0000-0000-0000-000000000000";
            const string AdminRoleName = "Admin";
            const string TestPassword = "Test123?";

            const string SuperAdminRoleId = "20000000-0000-0000-0000-000000000000";
            const string SuperAdminRoleName = "SuperAdmin";

            const string AdminUserId = "11000000-0000-0000-0000-0000000000";
            const string AdminUserName = "Admin";
            const string AdminUserEmail = "Admin@user.be";

            const string SuperAdminUserId = "22000000-0000-0000-0000-0000000000";
            const string SuperAdminUserName = "SuperAdmin";
            const string SuperAdminUserEmail = "Super.Admin@user.be";



            List<User> users = new List<User>
            {
                new User { Id = "00000000-0000-0000-0000-000000000001", FirstName = "Jane", LastName = "Doe", Email = "Jane.Doe@user.be", UserName = "JDoe", NormalizedEmail = "Jane.Doe@user.be".ToUpper(), NormalizedUserName = "JDoe".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false,EmailConfirmed = false, ConcurrencyStamp = "c8554266-b401-4519-9aeb-a9283053fc58",DoB =new DateTime(1952,04,17), Gender = Gender.Female, TermsAndConditions = true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/women/10.jpg")},
                new User { Id = "00000000-0000-0000-0000-000000000002", FirstName = "Joe", LastName = "Doe", Email = "Joe.Doe@user.be", UserName = "JoeD", NormalizedEmail = "Joe.Doe@user.be".ToUpper(), NormalizedUserName = "JoeD".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false,EmailConfirmed = true, ConcurrencyStamp = "f3cfafe8-4386-11ec-81d3-0242ac130003",DoB =new DateTime(1967,10,04), Gender = Gender.Male, TermsAndConditions = true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/men/49.jpg")},
                new User { Id = "00000000-0000-0000-0000-000000000003", FirstName = "Cucum",LastName = "Terrarun", Email = "Cucum.Terrarun@user.be", UserName = "CucumT", NormalizedEmail = "Cucum.Terrarun@user.be".ToUpper(), NormalizedUserName = "CucumT".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false, EmailConfirmed = true, ConcurrencyStamp = "f3cfb222-4386-11ec-81d3-0242ac130003",DoB =new DateTime(1950,03,02), Gender = Gender.NonBinary, TermsAndConditions = false, ProfilePicture = new Uri("https://randomuser.me/api/portraits/lego/6.jpg")},
                new User { Id = "00000000-0000-0000-0000-000000000004", FirstName = "Lantain",LastName = "Skybone", Email = "Lantain.Skybone@user.be", UserName = "SkyboneL", NormalizedEmail = "Lantain.Skybone@user.be".ToUpper(), NormalizedUserName = "SkyboneL".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false,EmailConfirmed = true, ConcurrencyStamp = "f3cfb31c-4386-11ec-81d3-0242ac130003",DoB =new DateTime(1990,03,02), Gender = Gender.Female, TermsAndConditions =true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/women/91.jpg") },
                new User { Id = "00000000-0000-0000-0000-000000000005", FirstName = "Peppa", LastName = "Distantshadow",Email = "Peppa.Distantshadow@user.be", UserName = "PeppaD", NormalizedEmail = "Peppa.Distantshadow@user.be".ToUpper(), NormalizedUserName = "PeppaD".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false,EmailConfirmed = true, ConcurrencyStamp = "f3cfb3e4-4386-11ec-81d3-0242ac130003",DoB =new DateTime(1973,02,23), Gender = Gender.Male,TermsAndConditions =true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/men/4.jpg")},
                new User { Id = "00000000-0000-0000-0000-000000000006", FirstName = "Pinach", LastName = "Flatwood",Email = "Pinach.Flatwood@user.be", UserName = "FlatwoodP", NormalizedEmail = "Pinach.Flatwood@user.be".ToUpper(), NormalizedUserName = "FlatwoodP".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false,EmailConfirmed = true, ConcurrencyStamp = "f3cfb4ac-4386-11ec-81d3-0242ac130003",DoB =new DateTime(1989,04,13), Gender = Gender.NonBinary,TermsAndConditions =true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/lego/0.jpg")},
                new User { Id = "00000000-0000-0000-0000-000000000007", FirstName = "Kallabash", LastName = "Titanhand",Email = "Kallabash.Titanhand@user.be", UserName = "KallabashT", NormalizedEmail = "Kallabash.Titanhand@user.be".ToUpper(), NormalizedUserName = "KallabashT".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false,EmailConfirmed = true, ConcurrencyStamp = "f3cfb786-4386-11ec-81d3-0242ac130003",DoB =new DateTime(1982,03,30), Gender = Gender.Female,TermsAndConditions =true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/women/82.jpg")},
                new User { Id = "00000000-0000-0000-0000-000000000008", FirstName = "Gorlick", LastName = "Deathgrove",Email = "Gorlick.Deathgrove@user.be", UserName = "GorlickD", NormalizedEmail = "Gorlick.Deathgrove@user.be".ToUpper(), NormalizedUserName = "GorlickD".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false,EmailConfirmed = true, ConcurrencyStamp = "f3cfb858-4386-11ec-81d3-0242ac130003",DoB = new DateTime(1979,09,10), Gender = Gender.Male,TermsAndConditions =true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/men/64.jpg")},
                new User { Id = "00000000-0000-0000-0000-000000000009", FirstName = "Courge", LastName = "Voidwound",Email = "Courge.Voidwound@user.be", UserName = "CourgeV", NormalizedEmail = "Courge.Voidwound@user.be".ToUpper(), NormalizedUserName = "CourgeV".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false,EmailConfirmed = true, ConcurrencyStamp = "f3cfb902-4386-11ec-81d3-0242ac130003", DoB =new DateTime(1974,09,10), Gender = Gender.NonBinary,TermsAndConditions =true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/lego/3.jpg")},
                new User { Id = "00000000-0000-0000-0000-000000000010", FirstName = "Leeck", LastName = "Switfblood",Email = "Leeck.Swiftblood@user.be", UserName = "LeeckS", NormalizedEmail = "Leeck.Swiftblood@user.be".ToUpper(), NormalizedUserName = "LeeckS".ToUpper(), SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = false, EmailConfirmed = true,ConcurrencyStamp = "f3cfb9b6-4386-11ec-81d3-0242ac130003", DoB =new DateTime(1952,04,17),  Gender = Gender.Male,TermsAndConditions =true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/men/86.jpg")},
                new User { Id = AdminUserId, FirstName = "Admin", LastName = "Admin",Email = AdminUserEmail, UserName = AdminUserName, NormalizedEmail = AdminUserEmail.ToUpper(), NormalizedUserName = AdminUserName.ToUpper(),SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = true,EmailConfirmed = true,ConcurrencyStamp = "f3cfba6a-4386-11ec-81d3-0242ac130003", DoB = new DateTime(0001,01,01), Gender = Gender.Male, TermsAndConditions = true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/men/74.jpg")},
                new User { Id = SuperAdminUserId, FirstName = "Super", LastName = "Admin",Email = SuperAdminUserEmail, UserName = SuperAdminUserName, NormalizedEmail = SuperAdminUserEmail.ToUpper(), NormalizedUserName = SuperAdminUserName.ToUpper(),SecurityStamp = "VVPCRDAS3MJWQD5CSW2GWPRADBXEZINA", IsAdmin = true,EmailConfirmed = true,ConcurrencyStamp = "a3cfba6a-4386-11ec-81d3-0242ac130003", DoB = new DateTime(0001,01,01), Gender = Gender.Male, TermsAndConditions = true, ProfilePicture = new Uri("https://randomuser.me/api/portraits/lego/2.jpg")}
            };

            IPasswordHasher<User> passwordHaser = new PasswordHasher<User>();

            foreach (var user in users)
            {
                user.PasswordHash = passwordHaser.HashPassword(user, TestPassword);
            }

            modelBuilder.Entity<User>().HasData(users);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = AdminRoleId,
                Name = AdminRoleName,
                NormalizedName = AdminRoleName.ToUpper()
            });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = SuperAdminRoleId,
                Name = SuperAdminRoleName,
                NormalizedName = SuperAdminRoleName.ToUpper()
            });


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = AdminRoleId,
                UserId = AdminUserId
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = SuperAdminRoleId,
                UserId = SuperAdminUserId
            });

        }
    }
}
