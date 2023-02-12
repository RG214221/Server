using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Models;
namespace Services.Interfaces
{
    public interface IUserService : IService<UserModel>
    {
        Task<ICollection<UserModel>> GetAllAsync();
        Task<UserModel> GetByIdNumberAsync(string idNumber);
        Task<UserModel> AddAsync(UserModel model);
        Task<UserModel> UpdateAsync(UserModel model);
        Task DeleteAsync(string idNumber);
    }
}
