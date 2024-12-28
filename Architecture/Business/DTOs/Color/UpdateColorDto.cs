using Business.DTOs.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Color
{
    public record UpdateColorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UpdateColorDtoValidator : AbstractValidator<UpdateColorDto>
    {
        public UpdateColorDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Id).NotEmpty().NotNull();
        }
    }
}
