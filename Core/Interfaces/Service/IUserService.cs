using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    public interface IUserService : IBaseService<User>
    {
        Task<bool> Delete(User entity);
        Task<User> Get(int id);
        Task<IEnumerable<User>> Get();
        Task<User> Post(User entity);
        Task<User> Put(User entity);
    }
}
