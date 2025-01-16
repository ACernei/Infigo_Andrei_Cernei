using CMSPlus.Domain.Entities;
using CMSPlus.Domain.Interfaces;
using CMSPlus.Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CMSPlus.Domain.Repositories;

public class CommentRepository : Repository<CommentEntity>, ICommentRepository
{

    public CommentRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<List<CommentEntity>> GetByTopicId(int topicId)
    {
        return await _dbSet.Where(x => x.TopicId == topicId).ToListAsync();
    }
}
