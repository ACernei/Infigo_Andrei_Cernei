using CMSPlus.Domain.Models.TopicModels;
using FluentValidation;

namespace CMSPlus.Presentation.Validations;

public class TopicEditModelValidator : AbstractValidator<TopicEditModel>
{
    private readonly TopicValidatorHelpers _topicValidatorHelpers;

    public TopicEditModelValidator(TopicValidatorHelpers topicValidatorHelpers)
    {
        _topicValidatorHelpers = topicValidatorHelpers;
        RuleFor(topic => topic)
            .MustAsync(_topicValidatorHelpers.IsSystemNameUniqueEdit).WithMessage("System name must be unique");
        RuleFor(topic => topic.SystemName)
            .Must(_topicValidatorHelpers.IsUrl).WithMessage("The system name is not an URL");
    }
}
