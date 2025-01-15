using CMSPlus.Domain.Entities;

namespace CMSPlus.Domain.Interfaces;

public interface ITopicRepository : IRepository<TopicEntity>
{
    public Task<TopicEntity?> GetBySystemName(string systemName);
}
