﻿using Imi.Project.Common.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IThemeService
    {
        Task<IEnumerable<ThemeResponseDto>> GetAllThemes();
    }
}