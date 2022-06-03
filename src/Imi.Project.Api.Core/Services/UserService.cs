using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Helpers.Mappers;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<UserResponseDto>> ListAllAsync()
        {
            var result = await _userRepository.ListAllAsync();
            var dto = result.MapToDto();

            return dto;
        }

        public async Task<UserResponseDto> GetByIdAsync(Guid id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return null;
            }

            var dto = user.MapToDto();

            return dto;
        }

        public async Task<UserResponseDto> AddAsync(UserRequestDto userRequestDto)
        {
            var user = new User
            {
                UserName = userRequestDto.UserName,
                Email = userRequestDto.Email,
                FirstName = userRequestDto.FirstName,
                LastName = userRequestDto.LastName,
                Gender = userRequestDto.Gender,
            };

            if (user.ProfilePicture == null)
            {
                user.ProfilePicture = new Uri("https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=20&m=1223671392&s=612x612&w=0&h=lGpj2vWAI3WUT1JeJWm1PRoHT3V15_1pdcTn2szdwQ0=");
            }

            var result = await _userRepository.AddAsync(user);

            var dto = result.MapToDto();
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<UserResponseDto> UpdateAsync(UserRequestDto userRequestDto)
        {
            var user = new User
            {
                UserName = userRequestDto.UserName,
                Email = userRequestDto.Email,
                FirstName = userRequestDto.FirstName,
                LastName = userRequestDto.LastName,
            };

            if (user.ProfilePicture == null)
            {
                user.ProfilePicture = new Uri("https://media.istockphoto.com/vectors/default-profile-picture-avatar-photo-placeholder-vector-illustration-vector-id1223671392?k=20&m=1223671392&s=612x612&w=0&h=lGpj2vWAI3WUT1JeJWm1PRoHT3V15_1pdcTn2szdwQ0=");
            }

            var result = await _userRepository.UpdateAsync(user);

            var dto = result.MapToDto();
            return dto;
        }
    }
}
