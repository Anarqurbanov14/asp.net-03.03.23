using HomeTask.Data.Context;
using HomeTask.Data.Entities;
using HomeTask.Repository.Abstarct;
using HomeTask.Repository.Imp;
using HomeTask.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace HomeTask.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Blog, int> blogRepository { get; set ; }
        public IRepository<Post, int> postRepository { get; set; }

        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            blogRepository = new EfRepository<Blog,int>(_appDbContext);
            postRepository = new PostRepository(_appDbContext);
        }
        public async Task Commit()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
