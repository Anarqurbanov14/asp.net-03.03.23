using FluentValidation;
using HomeTask.Data.Entities;
using HomeTask.Dtos;

namespace HomeTask.Validation
{
    public class PostValidation : AbstractValidator<PostDto>
    {
        public PostValidation()
        {
            RuleFor(x => x.Title).Length(0, 30);
            RuleFor(x => x.Subtitle).Length(0, 30);
            RuleFor(x => x.Content).Length(0, 30);
            RuleFor(x => x.Desc).Length(0, 30);
        }
    }
}
