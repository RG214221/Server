using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces;
using Services.Models;
using Repository.Interfaces;
using Server.Repository.Entities;

namespace Services.ServiceClasses
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;
        private readonly IMapper mapper;
        public UserService(IUserRepository _rep, IMapper _mapper)
        {
            repository = _rep;
            mapper = _mapper;
        }
        public async Task<UserModel> AddAsync(UserModel model)
        {
            User userToAdd = mapper.Map<User>(model);
            return mapper.Map<UserModel>(await repository.AddAsync(userToAdd));
        }

        public async Task DeleteAsync(string idNumber)
        {
            await repository.DeleteAsync(idNumber);
        }

        public async Task<UserModel> GetByIdNumberAsync(string idNumber)
        {
            return mapper.Map<UserModel>(await repository.GetByIdNumberAsync(idNumber));
        }

        public async Task<ICollection<UserModel>> GetAllAsync()
        {
            ICollection<User> list = await repository.GetAllAsync();
            ICollection<UserModel> listToReturn = new List<UserModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<UserModel>(item));
            }
            return listToReturn;
        }

        public async Task<UserModel> UpdateAsync(UserModel model)
        {

            User userToUpdate = mapper.Map<User>(model);
            return mapper.Map<UserModel>(await repository.UpdateAsync(userToUpdate));

        }
    }
}

