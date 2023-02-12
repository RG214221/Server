using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Repository.Entities;
using Server.Repository;
using Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        IDataSource dataSource;
        public UserRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public async Task<ICollection<User>> GetAllAsync ()
        {
            return await dataSource.Users.ToListAsync();
        }
        public  async Task<User> GetByIdNumberAsync(string idNumber)
        {
            return await dataSource.Users.FirstOrDefaultAsync(user => user.UserIDNumber == idNumber);
        }
        public async Task<User> AddAsync(User model)
        {
            EntityEntry<User> userToReturn = dataSource.Users.Add(model);
            await dataSource.SaveChangesAsync();
            return userToReturn.Entity;
        }
        public async Task<User> UpdateAsync(User model)
        {
            var entity= dataSource.Users.Update(model);
            await dataSource.SaveChangesAsync();
            return entity.Entity;
        }
        public async Task DeleteAsync(string idNumber)
        {
            dataSource.Users.Remove(dataSource.Users.FirstOrDefault(p => p.UserIDNumber == idNumber));
            await dataSource.SaveChangesAsync();   
        }
    }
}

