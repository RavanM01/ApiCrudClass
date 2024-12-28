using Business.DTOs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Color
{
    public record GetAllColorDto
    {
        public IQueryable<GetColorDto> colors { get; set; }
    }
}
