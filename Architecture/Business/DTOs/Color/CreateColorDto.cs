using Business.DTOs.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Color
{
    public record CreateColorDto
    {

        public string Name { get; set; }
    }
    public class CreateColorDtoValidator : AbstractValidator<CreateColorDto>
    {
        public CreateColorDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Error var");

        }
    }
}
