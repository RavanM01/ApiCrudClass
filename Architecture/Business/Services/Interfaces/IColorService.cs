using Business.DTOs.Color;
using Business.DTOs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface IColorService
    {
        Task<GetColorDto> CreateAsync(CreateColorDto dto);
        Task<GetColorDto> GetById(int id);
        Task Update(UpdateColorDto dto);
        Task Delete(int id);
     
    }
}
