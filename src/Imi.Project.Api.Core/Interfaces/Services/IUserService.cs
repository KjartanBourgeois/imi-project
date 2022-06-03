using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponseDto>> ListAllAsync();
        Task<UserResponseDto> GetByIdAsync(Guid id);
        Task<UserResponseDto> AddAsync(UserRequestDto userRequestDto);
        Task<UserResponseDto> UpdateAsync(UserRequestDto userRequestDto);
        Task DeleteAsync(Guid id);
    }
}
