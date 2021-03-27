using MicroRocky.Authentication.Data.Context;
using MicroRocky.Authentication.Domain.Interfaces;
using MicroRocky.Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Authentication.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private AuthDBContext _authDBContext;
        public UserRepository(AuthDBContext authDBContext)
        {
            _authDBContext = authDBContext;
        }

        public IEnumerable<User> GetUsers()
        {
            return _authDBContext.Users;
        }
    }
}
