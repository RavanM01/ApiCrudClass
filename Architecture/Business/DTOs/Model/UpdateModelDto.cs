using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Model
{
    public record UpdateModelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UpdateModelDtoValidator : AbstractValidator<UpdateModelDto>
    {
        public UpdateModelDtoValidator() { 
            RuleFor(x=>x.Name).NotEmpty().NotNull();
            RuleFor(x=>x.Id).NotEmpty().NotNull();
        }
    }
}
