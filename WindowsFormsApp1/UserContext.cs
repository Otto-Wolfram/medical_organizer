using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace WindowsFormsApp1
{
    class UserContext : DbContext
    {
        public UserContext() : base("DbConnection")
        { }

        public DbSet<Human> Users { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
