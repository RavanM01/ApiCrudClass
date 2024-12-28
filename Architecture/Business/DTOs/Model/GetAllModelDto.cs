using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Model
{
    public record GetAllModelDto
    {
       public IQueryable<GetModelDto> models { get; set; }
    }
}
