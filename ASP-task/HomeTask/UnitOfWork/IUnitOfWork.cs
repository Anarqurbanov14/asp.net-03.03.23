using HomeTask.Data.Entities;
using HomeTask.Repository.Abstarct;
using HomeTask.Repository.Abstarct;
using HomeTask.Repository.Interface;

namespace HomeTask.UnitOfWork
{
    public interface IUnitOfWork
    {
         public IRepository<Blog,int> blogRepository { get; set; }
         public IRepository<Post, int> postRepository { get; set; }

        public Task Commit();
    }
}
