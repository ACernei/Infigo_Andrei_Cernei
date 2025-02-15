namespace CMSPlus.Domain.Entities;

public class CommentEntity : BaseEntity
{
    public string Author { get; set; } = null!;
    public string Body { get; set; } = null!;

    public int TopicId { get; set; }
    public TopicEntity Topic { get; set; } = null!;
}
