using MicroRocky.Authentication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Authentication.Domain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}
