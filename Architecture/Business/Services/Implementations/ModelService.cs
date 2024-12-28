using AutoMapper;
using Business.DTOs.Model;
using Business.Helpers.Exceptions.Common;
using Business.Helpers.Exceptions.Model;
using Business.Services.Interfaces;
using Core.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Implementations
{
    public class ModelService : IModelService
    {
        readonly IModelRepository _repo;
        readonly IMapper _mapper;

        public ModelService(IModelRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<GetModelDto> CreateAsync(CreateModelDto dto)
        {
            if (await _repo.IsExsist(x => x.Name == dto.Name))
            {
                throw new ModelNameExsistException();
            }
            var model=_mapper.Map<Model>(dto);
            var newModel=await _repo.Create(model);
            await _repo.SaveChangesAsync();
            return _mapper.Map<GetModelDto>(newModel);
        }

        public async Task Delete(int id)
        {
            var model = await GetById(id);
            _repo.Delete(_mapper.Map<Model>(model));
            await _repo.SaveChangesAsync();
        }

        public async Task<GetModelDto> GetById(int id)
        {
            if (id <= 0)
            {
                throw new NegativeIdException();
            }
            GetModelDto dto = _mapper.Map<GetModelDto>(await _repo.GetbyId(id));
            return dto!=null?dto:throw new ModelNullException();
        }

        public async Task Update(UpdateModelDto dto)
        {
            var oldModel= await GetById(dto.Id);
            if(await _repo.IsExsist(c => c.Name == dto.Name))
            {
                throw new ModelNameExsistException();
            }
            oldModel = _mapper.Map<GetModelDto>(dto);
            _repo.Update(_mapper.Map<Model>(oldModel));
            await _repo.SaveChangesAsync();
        }
       
    }
}
