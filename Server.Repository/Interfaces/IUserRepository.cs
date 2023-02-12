using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
namespace Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<ICollection<User>> GetAllAsync();
        Task<User> GetByIdNumberAsync(string id);
        Task<User> AddAsync(User model);
        Task<User> UpdateAsync(User model);
        Task DeleteAsync(string idNumber);
    }
}
