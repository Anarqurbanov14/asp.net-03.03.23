using FluentValidation;
using HomeTask.Data.Entities;
using HomeTask.Dtos;

namespace HomeTask.Validation
{
    public class BlogValidation : AbstractValidator<BlogDto>
    {
        public BlogValidation()
        {
            RuleFor(x => x.Description).Length(0,25);
        }
    }
}
