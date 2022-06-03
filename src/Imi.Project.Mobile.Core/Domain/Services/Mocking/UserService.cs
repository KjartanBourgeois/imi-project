using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class UserService : IUserService
    {
        private static List<User> users = new List<User>
        {
            new User
            {
                UserName = "Admin",
                Email = "Admin@Admin.com",
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
            }
        };

        public async Task<User> GetUser(string name)
        {
            var user = users.FirstOrDefault(e => e.UserName == name);
            return await Task.FromResult(user);
        }

        public async Task<User> UpdateUser(User user)
        {
            var oldUser = users.FirstOrDefault(e => e.UserName == user.UserName);
            users.Remove(oldUser);
            users.Add(user);
            return await Task.FromResult(user);
        }
    }
}
