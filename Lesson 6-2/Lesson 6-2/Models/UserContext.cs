using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lesson_6_2.Models
{
    public class UsersContext : DbContext

    {
        public UsersContext() : base("DefaultConnection")
        {

        }
        public DbSet<User> Users { get;set; }
    }
}