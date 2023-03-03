using HomeTask.Data.Context;
using HomeTask.Data.Entities;
using HomeTask.Repository.Abstarct;
using HomeTask.Repository.Interface;

namespace HomeTask.Repository.Imp
{
    public class PostRepository : EfRepository<Post, int>,IPostRepository
    {
        private readonly AppDbContext _appDbcontext;
        public PostRepository(AppDbContext dbContext) : base(dbContext)
        {
            _appDbcontext = dbContext;
        }
    }
}
