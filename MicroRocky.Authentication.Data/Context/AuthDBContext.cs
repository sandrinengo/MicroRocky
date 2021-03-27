using MicroRocky.Authentication.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Authentication.Data.Context
{
    public class AuthDBContext:DbContext
    {
        public AuthDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
