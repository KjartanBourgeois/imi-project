using Imi.Project.Common.Dto;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core.Services
{
    public interface IAccountService
    {
        Task<LoginUserResponseDto> Login(string login, string password);
    }
}