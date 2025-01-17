namespace CMSPlus.Domain.Models.CommentModels;

public class CommentCreateModel
{
    public string Author { get; set; }
    public string Body { get; set; }
    public int TopicId { get; set; }
}
