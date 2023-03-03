using HomeTask.Data.Context;
using HomeTask.Data.Entities;
using HomeTask.Repository.Abstarct;
using HomeTask.Repository.Interface;

namespace HomeTask.Repository.Imp
{
    public class BlogRepository : EfRepository<Blog, int>, IBlogRepository
    {
        private readonly AppDbContext _appDbcontext;
        public BlogRepository(AppDbContext dbContext) : base(dbContext)
        {
            _appDbcontext = dbContext;
        }
    }
}
