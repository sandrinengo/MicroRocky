using MicroRocky.Authentication.Application.Interfaces;
using MicroRocky.Authentication.Domain.Interfaces;
using MicroRocky.Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Authentication.Application.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetUsers();
        }
    }
}
