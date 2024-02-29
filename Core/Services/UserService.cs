using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Repository;
using Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IAdminInterfaces adminInterfaces) : base(adminInterfaces)
        {
        }

        public async Task<bool> Delete(User entity)
        {
            var result = await _adminInterfaces.userRepository.Delete(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }

        public async Task<User> Get(int id)
        {
            return await _adminInterfaces.userRepository.GetById(id);
        }

        public async Task<IEnumerable<User>> Get()
        {
            return await _adminInterfaces.userRepository.GetAll();
        }

        public async Task<User> Post(User entity)
        {
            var result = await _adminInterfaces.userRepository.Add(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }

        public async Task<User> Put(User entity)
        {
            var result = await _adminInterfaces.userRepository.UpdateAsync(entity);
            await _adminInterfaces.saveChangeAsync();
            return result;
        }
    }
}
