namespace CMSPlus.Domain.Models.CommentModels;

public class CommentModel
{
    public CommentModel()
    {
        UpdatedOnUtc = CreatedOnUtc = DateTime.UtcNow;
    }

    public int Id { get; set; }
    public int TopicId { get; set; }
    public string Author { get; set; }
    public string Body { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public DateTime UpdatedOnUtc { get; set; }
}
