using FluentValidation;

namespace FootApi.Application.Clubs.Commands.CreateClub
{
    internal class CreateClubCommandValidator : AbstractValidator<CreateClubCommand>
    {
        public CreateClubCommandValidator()
        {
            RuleFor(dto => dto.ClubName).Length(3, 50);
            RuleFor(dto => dto.FoundedYear.ToString()).Length(4);
        }
    }
}
