using FluentValidation;
using FootApi.Application.Clubs.Dtos;

namespace FootApi.Application.Clubs.Validators
{
    internal class ClubCreateDtoValidator : AbstractValidator<ClubCreateDto>
    {
        public ClubCreateDtoValidator()
        {
            RuleFor(dto => dto.ClubName).Length(3, 50);
            RuleFor(dto => dto.FoundedYear.ToString()).Length(4);
        }
    }
}
