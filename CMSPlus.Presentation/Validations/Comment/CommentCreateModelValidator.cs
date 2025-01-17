using CMSPlus.Domain.Models.CommentModels;
using FluentValidation;

namespace CMSPlus.Presentation.Validations.Comment;

    public class CommentCreateModelValidator : AbstractValidator<CommentCreateModel>
    {
        public CommentCreateModelValidator()
        {
            RuleFor(x => x.Author)
                .NotEmpty().WithMessage("Full Name is required")
                .Matches(@"^[A-Za-z\s]*$").WithMessage("Full Name should only contain letters or spaces.")
                .Length(3, 30).WithMessage("Full Name must be between 3 and 30 characters");
            RuleFor(comment => comment.Body)
                .NotEmpty().WithMessage("Body is required");
        }
    }
