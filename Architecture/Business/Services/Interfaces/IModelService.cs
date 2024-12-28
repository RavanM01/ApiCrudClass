using Business.DTOs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface IModelService
    {
        Task<GetModelDto> CreateAsync(CreateModelDto dto);
        Task<GetModelDto> GetById(int id);
        Task Update(UpdateModelDto dto);
        Task Delete(int id);
       
    }
}
