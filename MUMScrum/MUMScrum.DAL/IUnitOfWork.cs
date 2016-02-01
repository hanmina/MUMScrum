using MUMScrum.Entity;

namespace MUMScrum.DAL
{ 

    public interface IUnitOfWork
    {
        GenericRepository<Employee> EmployeeRepository { get; }
        GenericRepository<ProductBacklog> ProductRepository { get; }
        GenericRepository<Role> RoleRepository { get; }
        GenericRepository<ReleaseBacklog> ReleaseBacklogsRepository { get; }
        GenericRepository<Sprint> SprintRepository { get; }
        GenericRepository<UserStory> UserStoryRepository { get; }
        GenericRepository<UserStoryLog> UserStoryLogRepository { get; }
        //GenericRepository<Employee> ScrumMasterRepository { get; }


        bool SaveChanges();
    }
}
