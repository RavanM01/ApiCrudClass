using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Model
{
    public record CreateModelDto
    {

        public string Name { get; set; }
    }
    public class CreateModelDtoValidator : AbstractValidator<CreateModelDto>
    {
        public CreateModelDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Error var");
                
        }
    }
}
