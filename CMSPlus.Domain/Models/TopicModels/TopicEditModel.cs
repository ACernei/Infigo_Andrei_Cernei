namespace CMSPlus.Domain.Models.TopicModels;

public class TopicEditModel : BaseTopicModel
{
    public int Id { get; set; }
    public string SystemName { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime? CreatedOnUtc { get; set; }
}
