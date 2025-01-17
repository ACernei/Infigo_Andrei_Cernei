using AutoMapper;
using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Models.CommentModels;
using CMSPlus.Domain.Models.TopicModels;
using CMSPlus.Services.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace CMSPlus.Presentation.Controllers;

public class CommentController : Controller
{
    private readonly ICommentService _commentService;
    private readonly IValidator<CommentCreateModel> _createModelValidator;
    private readonly IMapper _mapper;
    private readonly ITopicService _topicService;

    public CommentController(ITopicService topicService, ICommentService commentService, IMapper mapper, IValidator<CommentCreateModel> createModelValidator)
    {
        _topicService = topicService;
        _commentService = commentService;
        _mapper = mapper;
        _createModelValidator = createModelValidator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CommentCreateModel comment)
    {
        var topic = await _topicService.GetById(comment.TopicId);

        var validationResult = await _createModelValidator.ValidateAsync(comment);
        if (!validationResult.IsValid)
        {
            validationResult.AddToModelState(ModelState);

            var topicDto = _mapper.Map<TopicDetailsModel>(topic);

            return View("../Topic/Details", topicDto);
        }

        var commentEntity = _mapper.Map<CommentEntity>(comment);
        await _commentService.Create(commentEntity);

        return RedirectToAction("Details", "Topic", new { systemName = topic.SystemName });
    }
}
