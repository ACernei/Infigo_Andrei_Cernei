using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CMSPlus.Domain.Repositories;

public class TopicRepository : Repository<TopicEntity>, ITopicRepository
{
    public TopicRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<TopicEntity?> GetBySystemName(string systemName)
    {
        return await _dbSet.Include(t => t.Comments)
            .SingleOrDefaultAsync(t => t.SystemName == systemName);
    }
}
