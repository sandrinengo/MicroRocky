using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRocky.Authentication.Domain.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Pwd { get; set; }
    }
}
