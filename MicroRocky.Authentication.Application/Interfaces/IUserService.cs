using MicroRocky.Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Authentication.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
    }
}
