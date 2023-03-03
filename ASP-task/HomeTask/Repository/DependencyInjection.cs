using FluentValidation;
using HomeTask.Dtos;
using HomeTask.Repository.Abstarct;
using HomeTask.UnitOfWork;
using HomeTask.Validation;

namespace HomeTask.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryLazy(this IServiceCollection services) 
        {
            services.AddTransient(typeof(IRepository<,>), typeof(EfRepository<,>));
            services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped<IValidator<PostDto>, PostValidation>();
            services.AddScoped<IValidator<BlogDto>, BlogValidation>();
            return services;
        }
    }
}
