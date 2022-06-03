using Imi.Project.Common.Dto;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IAccountService
    {
        Task<LoginUserResponseDto> Login(string login, string password);
    }
}